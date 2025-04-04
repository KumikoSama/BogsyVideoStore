using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Globalization;
using System.Net.Mail;

namespace BogsyVideoStore.Forms
{
    enum DataDisplayed
    {
        AllVideos,
        AllTransactions,
        PreviousTransactions,
        OngoingRent,
        OverdueRent,
        ItemLedgerEntry
    }

    enum StoredProcedures
    {
        LoadAllVideos,
        LoadAllCustomers,
        LoadOnGoingRent,
        LoadOverdueRent,
        LoadClosedTransactions,
        LoadAllRentalTransactions
    }

    public partial class Dashboard : Form
    {
        DataDisplayed currentDataDisplayed = DataDisplayed.AllVideos;
        AutoCompleteStringCollection videos, customers;
        string selectedCategory, monthName;
        public static int _month, _year;
        bool isTransactionColumnsHidden = false;
        bool isVideoColumnsHiddeon = false;

        public Dashboard()
        {
            InitializeComponent();
            GlobalCustomer.CustomerName = "All";

            Utility.ExecuteQuery(Queries.UpdateRentalTable, false);
            Utility.ExecuteQuery(Queries.UpdatePenaltyFee, false);

            Utility.GetVideosInfo();
            videos = new AutoCompleteStringCollection();

            foreach (var title in GlobalVideo.VideoList)
                videos.Add(title.Title);

            txtbxSearchCustomerTransactions.SelectedIndexChanged -= cmbbxCustomer_SelectedIndexChanged;

            GlobalCustomer.CustomerList.Add(new Customer { CustomerName = "All" });
            Utility.GetCustomersInfo(txtbxSearchCustomerTransactions);
            Utility.GetTransactions();

            txtbxSearchCustomerTransactions.SelectedIndexChanged += cmbbxCustomer_SelectedIndexChanged;

            customers = new AutoCompleteStringCollection();

            foreach (var customer in GlobalCustomer.CustomerList)
                customers.Add(customer.CustomerName);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            datagridTransactions.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
            datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), true);
            datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);

            datagridCustomer.Columns["CustomerID"].Visible = false;
            datagridVidLibrary.Columns["VideoID"].Visible = false;

            Utility.SplitColumnHeaderTexts(datagridVidLibrary);
            Utility.GenerateCustomerReport(reportViewerCustomer);
            Utility.GenerateVideoReport(reportViewerVideo);

            txtbxSearchVideo.AutoCompleteCustomSource = videos;
            txtbxSearchCustomer.AutoCompleteCustomSource = customers;
            txtbxDescription.AutoCompleteCustomSource = videos;

            this.reportViewerCustomer.RefreshReport();
            this.reportViewerVideo.RefreshReport();
        }

        #region RentalAndReturn

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (GlobalVideo.VideoID != 0)
            {
                RentForm rentForm = new RentForm();
                rentForm.ShowDialog(); 
            }
            else
                MessageBox.Show("Choose a video to rent");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return this?", "Return Video", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Utility.ExecuteQuery("ReturnVideo", true, new SqlParameter("@RentalID", GlobalTransaction.RentalID), new SqlParameter("@VideoID", GlobalVideo.VideoID));

                MessageBox.Show("Video returned successfully");

                if (currentDataDisplayed == DataDisplayed.OngoingRent)
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), cmbbxCategory.SelectedItem.ToString(), txtbxSearchCustomerTransactions.Text != "All");
                else if (currentDataDisplayed == DataDisplayed.OverdueRent)
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.SelectedItem.ToString(), txtbxSearchCustomerTransactions.Text != "All");
            }
            else return;
        }

        private void btnPastTransactions_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.PreviousTransactions;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), cmbbxCategory.SelectedItem.ToString(), txtbxSearchCustomerTransactions.Text != "All");

            btnReturn.Visible = false;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = false;
        }

        private void btnOngoingRent_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OngoingRent;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), cmbbxCategory.SelectedItem.ToString(), txtbxSearchCustomerTransactions.Text != "All");

            btnReturn.Visible = true;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = false;
        }

        private void cmbbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtbxSearchCustomerTransactions.Text != "All")
            {
                GlobalCustomer.CustomerName = txtbxSearchCustomerTransactions.Text;
                GlobalCustomer.CustomerID = int.Parse(txtbxSearchCustomerTransactions.SelectedValue.ToString());
            }

            selectedCategory = (string)cmbbxCategory.SelectedItem;

            switch (currentDataDisplayed)
            {
                case DataDisplayed.AllVideos:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllVideos.ToString(), selectedCategory, false);
                    break;
                case DataDisplayed.OngoingRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), selectedCategory, txtbxSearchCustomerTransactions.Text != "All");
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), selectedCategory, txtbxSearchCustomerTransactions.Text != "All");
                    break;
                case DataDisplayed.AllTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), selectedCategory, txtbxSearchCustomerTransactions.Text != "All");
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), selectedCategory, txtbxSearchCustomerTransactions.Text != "All");
                    break;
            }
        }

        private void btnAllReports_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.AllTransactions;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), cmbbxCategory.SelectedItem.ToString(), txtbxSearchCustomerTransactions.Text != "All");

            btnReturn.Visible = false;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = false;
        }

        private void datagridTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = datagridTransactions.SelectedRows[0];

            if (currentDataDisplayed != DataDisplayed.AllVideos)
            {
                GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
                GlobalCustomer.CustomerID = int.Parse(selectedRow.Cells["CustomerID"].Value.ToString());
                GlobalTransaction.RentalID = int.Parse(selectedRow.Cells["RentalID"].Value.ToString());
            }
            else
            {
                GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
                GlobalVideo.Title = selectedRow.Cells["Title"].Value.ToString();
                GlobalVideo.Category = selectedRow.Cells["Category"].Value.ToString();
                GlobalVideo.Price = int.Parse(selectedRow.Cells["Price"].Value.ToString());
            }
        }

        private void btnAllVideos_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.AllVideos;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllVideos.ToString(), cmbbxCategory.SelectedItem.ToString(), false);

            btnReturn.Visible = false;
            btnRent.Visible = true;
            btnSettlePenalty.Visible = false;
        }

        private void cmbbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = (string)cmbbxCategory.SelectedItem;

            switch (currentDataDisplayed)
            {
                case DataDisplayed.AllVideos:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllVideos.ToString(), selectedCategory, false);
                    break;
                case DataDisplayed.OngoingRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), selectedCategory, txtbxSearchCustomerTransactions.Text != "All");
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), selectedCategory, txtbxSearchCustomerTransactions.Text != "All");
                    break;
                case DataDisplayed.AllTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), selectedCategory, txtbxSearchCustomerTransactions.Text != "All");
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), selectedCategory, txtbxSearchCustomerTransactions.Text != "All");
                    break;
            }
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OverdueRent;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.SelectedItem.ToString(), txtbxSearchCustomerTransactions.Text != "All");

            btnReturn.Visible = true;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = true;
        }

        private void cmbbxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSettlePenalty_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm payment for this due transaction?", "Penalty Fee Payment", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int totalPenalty = 0;

                foreach (DataGridViewRow row in datagridTransactions.SelectedRows)
                {
                    int penaltyFees = int.Parse(row.Cells["Penalty Fee"].Value.ToString());
                    totalPenalty += penaltyFees;

                    GlobalTransaction.TransactionList.Add(new Transaction
                    {
                        CustomerName = row.Cells["Customer Name"].Value.ToString(),
                        VideoTitle = row.Cells["Title"].Value.ToString(),
                        Category = row.Cells["Category"].Value.ToString(),
                        PenaltyFee = penaltyFees,
                    });

                    GlobalTransaction.TotalAmount += totalPenalty;
                }

                using (PaymentWindow paymentWindow = new PaymentWindow())
                    paymentWindow.ShowDialog();

                datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.SelectedItem.ToString(), txtbxSearchCustomerTransactions.Text != "All");
            }
        }

        private void datagridTransactions_DataSourceChanged(object sender, EventArgs e)
        {
            if (currentDataDisplayed == DataDisplayed.AllVideos)
            {
                if (!isVideoColumnsHiddeon)
                {
                    Utility.HideColumns(datagridTransactions, "VideoID");
                    isVideoColumnsHiddeon = true; 
                }
            }
            else if (currentDataDisplayed == DataDisplayed.ItemLedgerEntry)
                datagridTransactions.Columns["EntryNo."].Visible = false;
            else
            {
                if (!isTransactionColumnsHidden)
                {
                    Utility.HideColumns(datagridTransactions, "VideoID", "CustomerID", "RentalID");
                    isTransactionColumnsHidden = true;
                }
            }

            Utility.SplitColumnHeaderTexts(datagridTransactions);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if (pnlCalendar.Visible == false)
            {
                pnlCalendar.Show();
                pnlCalendar.Location = new Point(549, 0);

                ShowDays(DateTime.Now.Month, DateTime.Now.Year);
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            if (!pnlCalendar.Bounds.Contains(PointToClient(MousePosition)))
            {
                pnlCalendar.Visible = false;
                flwpnlCalendar.Controls.Clear();
            }
        }

        private void btnItemLedgerEntry_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.ItemLedgerEntry;

            datagridTransactions.DataSource = Utility.LoadData(Queries.LoadItemLedgerEntry, false);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _month -= 1;

            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }

            ShowDays(_month, _year);
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            _month += 1;

            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }

            ShowDays(_month, _year);
        }

        public void Days_Click(object sender, EventArgs e)
        {
            calendarDays clickedControl = sender as calendarDays;
            if (clickedControl != null)
            {
                DateTime selecteddate = new DateTime(_year, _month, int.Parse(clickedControl.SelectedDay));

                datagridTransactions.DataSource = null;
                datagridTransactions.DataSource = GlobalTransaction.TransactionList.Where(transaction => transaction.RentDate == selecteddate).ToList();

                pnlCalendar.Hide();
            }
        }

        private void ShowDays(int month, int year)
        {
            flwpnlCalendar.Controls.Clear();
            DateTime date;
            _month = month;
            _year = year;

            monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startedTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startedTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < week; i++)
            {
                calendarDays days = new calendarDays("");
                flwpnlCalendar.Controls.Add(days);
            }

            for (int i = 1; i <= day; i++)
            {
                calendarDays days = new calendarDays(i + "");
                date = new DateTime(year, month, i);

                if (GlobalTransaction.TransactionList.Any(transaction => transaction.RentDate == date))
                {
                    foreach (var transaction in GlobalTransaction.TransactionList.Where(transaction => transaction.RentDate == date))
                    {
                        string customerName = GlobalCustomer.CustomerList.Where(customer => customer.CustomerID == transaction.CustomerID).Select(customer => customer.CustomerName).FirstOrDefault();
                        days.TransactionsOnDateList.Add(new TransactionsOnDate
                        {
                            CustomerName = customerName,
                            Status = transaction.Status
                        });
                    }
                }

                days.Click += Days_Click;
                flwpnlCalendar.Controls.Add(days);
            }
        }

        #endregion

        #region CustomerLibrary

        private void btnGenerateCustomerReport_Click(object sender, EventArgs e)
        {
            GlobalCustomer.CustomerName = "All";

            Utility.GenerateCustomerReport(reportViewerCustomer);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            GlobalCustomer.CustomerName = "";
            GlobalCustomer.CustomerID = 0;
            GlobalCustomer.ContactInfo = "";

            using (ManageCustomer manageCustomer = new ManageCustomer())
                manageCustomer.ShowDialog();

            datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), false);
            Utility.GetCustomersInfo(txtbxSearchCustomerTransactions);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (GlobalCustomer.CustomerID != 0)
            {
                using (ManageCustomer manageCustomer = new ManageCustomer(true))
                    manageCustomer.ShowDialog();

                datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), false);
                Utility.GetCustomersInfo(txtbxSearchCustomerTransactions);
            }
            else
                MessageBox.Show("Choose a customer first");
        }

        private void datagridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedCustomer = datagridCustomer.SelectedRows[0];

                GlobalCustomer.CustomerName = selectedCustomer.Cells["Customer Name"].Value.ToString();
                GlobalCustomer.ContactInfo = selectedCustomer.Cells["Contact Number"].Value.ToString();

                GlobalCustomer.CustomerID = int.Parse(selectedCustomer.Cells["CustomerID"].Value.ToString());
                Utility.GenerateCustomerReport(reportViewerCustomer);
            }
        }

        private void txtbxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtbxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxSearchCustomer.Text))
                datagridCustomer.DataSource = GlobalCustomer.CustomerList.Where(customer => customer.CustomerName.ToLower().StartsWith(txtbxSearchCustomer.Text.ToLower())).ToList();
            else
                datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), true);
        }

        #endregion

        #region VideoLibrary

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            using (ManageVideo manageVideo = new ManageVideo(false))
                manageVideo.ShowDialog();

            datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
            Utility.GenerateVideoReport(reportViewerVideo);
        }

        private void btnEditVideo_Click(object sender, EventArgs e)
        {
            if (datagridVidLibrary.SelectedRows.Count > 0)
            {
                using (ManageVideo manageVideo = new ManageVideo(true))
                    manageVideo.ShowDialog();

                datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
                Utility.GenerateVideoReport(reportViewerVideo); 
            }
            else
                MessageBox.Show("Select one video");
        }

        private void datagridVidLibrary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridVidLibrary.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridVidLibrary.SelectedRows[0];

                GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
                GlobalVideo.Title = selectedRow.Cells["Title"].Value.ToString();
                GlobalVideo.Category = selectedRow.Cells["Category"].Value.ToString();
                GlobalVideo.Price = int.Parse(selectedRow.Cells["Price"].Value.ToString());
                GlobalVideo.Copies = int.Parse(selectedRow.Cells["Copies"].Value.ToString());
                GlobalVideo.CopiesBorrowed = int.Parse(selectedRow.Cells["CopiesOnRent"].Value.ToString());
                GlobalVideo.Rating = selectedRow.Cells["Rating"].Value.ToString();

                btnEditVideo.Enabled = true;
                btnDeleteVideo.Enabled = true;
            }
        }

        private void btnDeleteVideo_Click(object sender, EventArgs e)
        {
            if (GlobalVideo.CopiesBorrowed > 0)
                MessageBox.Show("You can't delete this yet! There's still copies that are currently on rent.");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you'll delete this video?", "Video Deletion Confirmation",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Utility.ExecuteQuery(Queries.DeleteVideo, false, new SqlParameter("@VideoID", GlobalVideo.VideoID));
                    Utility.GenerateVideoReport(reportViewerVideo);
                    datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
                }
                else return;
            }
        }

        private void datagridVidLibrary_DoubleClick(object sender, EventArgs e)
        {
            using (ManageVideo manageVideo = new ManageVideo(true))
                manageVideo.ShowDialog();

            datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
        }

        private void btnShowUnavailableVideos_Click(object sender, EventArgs e)
        {
            Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true, true);
            btnShowUnavailableVideos.Hide();
        }

        private void btnHideUnavailableVideos_Click(object sender, EventArgs e)
        {
            Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
            btnShowUnavailableVideos.Show();
        }

        private void btnGenerateVideoReport_Click(object sender, EventArgs e)
        {
            Utility.GenerateVideoReport(reportViewerVideo);
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxSearchVideo.Text))
                datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
            else
                datagridVidLibrary.DataSource = GlobalVideo.VideoList.Where(video => video.Title.ToLower().StartsWith(txtbxSearchVideo.Text.ToLower())).ToList();
        }

        private void cmbbxSortByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = cmbbxSortByCategory.Text;

            datagridVidLibrary.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllVideos.ToString(), selectedCategory, false);
        }

        private void cmbbxRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region ItemJournal

        private void txtbxVideoID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxVideoID.Text))
            {
                int videoid = int.Parse(txtbxVideoID.Text);
                string name = GlobalVideo.VideoList.Where(video => video.VideoID == videoid).Select(video => video.Title).FirstOrDefault();

                txtbxDescription.Text = name;
            }
            else
                return;
        }

        private void cmbbxEntryType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalItemJournal.ItemsList.Add(new ItemJournal
            {
                DocumentNo = txtbxDocumentNo.Text,
                VideoID = int.Parse(txtbxVideoID.Text),
                Description = txtbxDescription.Text,
                Quantity = int.Parse(txtbxQuantity.Text),
                SerialNo = txtbxSerialNo.Text,
                EntryType = cmbbxEntryType.Text
            });

            datagridItemJournal.DataSource = GlobalItemJournal.ItemsList;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            foreach (var item in GlobalItemJournal.ItemsList)
            {
                Utility.ExecuteQuery("AddIntoItemLedgerEntry", true, new SqlParameter("@DocumentNo", item.DocumentNo), new SqlParameter("@VideoID", item.VideoID), new SqlParameter("@Description", item.Description),
                    new SqlParameter("@Quantity", item.Quantity), new SqlParameter("@SerialNo", item.SerialNo), new SqlParameter("@Type", item.EntryType));
            }

            MessageBox.Show("Item posted successfully");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int rowIndex = datagridItemJournal.SelectedRows[0].Index;

            if (MessageBox.Show("Remove selected item?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GlobalItemJournal.ItemsList.RemoveAt(rowIndex);

                datagridItemJournal.DataSource = null;
                datagridItemJournal.DataSource = GlobalItemJournal.ItemsList;
            }
        }

        #endregion
    }
}