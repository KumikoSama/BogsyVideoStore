using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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

        public Dashboard()
        {
            InitializeComponent();

            txtbxSearchCustomerTransactions.SelectedIndexChanged -= cmbbxCustomer_SelectedIndexChanged;

            Utility.ExecuteQuery(Queries.UpdateRentalTable, false);
            Utility.GetCustomersInfo(txtbxSearchCustomerTransactions);
            Utility.ExecuteQuery(Queries.UpdatePenaltyFee, false);
            Utility.GetItemLedgerEntries();
            Utility.GetVideosInfo();
            Utility.GetTransactions();
            GetCountTransactions();

            txtbxSearchCustomerTransactions.SelectedIndexChanged += cmbbxCustomer_SelectedIndexChanged;

            videos = new AutoCompleteStringCollection();

            foreach (var title in GlobalVideo.VideoList)
                videos.Add(title.Title);

            customers = new AutoCompleteStringCollection();

            foreach (var customer in GlobalCustomer.CustomerList)
                customers.Add(customer.CustomerName);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            datagridTransactions.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
            datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), true);
            datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);

            GlobalCustomer.CustomerName = null;
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

            txtbxSearchCustomerTransactions.Text = null;
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        #region RentalAndReturn

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (GlobalVideo.Copies == 0)
            {
                MessageBox.Show("No copies available to rent");
                return;
            }
            if (GlobalVideo.VideoID != 0)
            {
                using (RentForm rentForm = new RentForm())
                    rentForm.ShowDialog();

                datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllVideos.ToString(), selectedCategory, false);

                Utility.GetTransactions();
                GetCountTransactions();
            }
            else
                MessageBox.Show("Choose a video to rent");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return this?", "Return Video", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Utility.ExecuteQuery("AddIntoItemLedgerEntry", true, new SqlParameter("@DocumentNo", GlobalTransaction.DocumentNo), new SqlParameter("@VideoID", GlobalVideo.VideoID), new SqlParameter("@Title", GlobalVideo.Title),
                    new SqlParameter("@Quantity", "+1"), new SqlParameter("@SerialNo", GlobalItemJournal.SerialNo), new SqlParameter("@Type", "Return"));

                Utility.ExecuteQuery("ReturnVideo", true, new SqlParameter("@RentalID", GlobalTransaction.RentalID), new SqlParameter("@VideoID", GlobalVideo.VideoID), new SqlParameter("@SerialNo", GlobalItemJournal.SerialNo));

                MessageBox.Show("Video returned successfully");

                if (currentDataDisplayed == DataDisplayed.OngoingRent)
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), cmbbxCategory.SelectedItem.ToString(), !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                else if (currentDataDisplayed == DataDisplayed.OverdueRent)
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.SelectedItem.ToString(), !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));

                Utility.GetTransactions();
                GetCountTransactions();
            }
            else return;
        }

        private void btnPastTransactions_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.PreviousTransactions;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), cmbbxCategory.SelectedItem.ToString(), !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));

            btnReturn.Visible = false;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = false;
        }

        private void btnOngoingRent_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OngoingRent;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), cmbbxCategory.SelectedItem.ToString(), !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));

            btnReturn.Visible = true;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = false;
        }

        private void cmbbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text))
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
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.AllTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
            }
        }

        private void btnAllReports_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.AllTransactions;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), cmbbxCategory.SelectedItem.ToString(), !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));

            btnReturn.Visible = false;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = false;
        }

        private void datagridTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = datagridTransactions.SelectedRows[0];

            if (currentDataDisplayed == DataDisplayed.ItemLedgerEntry)
                return;

            if (currentDataDisplayed != DataDisplayed.AllVideos)
            {
                GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
                GlobalVideo.Title = selectedRow.Cells["Title"].Value.ToString();
                GlobalCustomer.CustomerID = int.Parse(selectedRow.Cells["CustomerID"].Value.ToString());
                GlobalTransaction.RentalID = int.Parse(selectedRow.Cells["RentalID"].Value.ToString());
                GlobalItemJournal.SerialNo = selectedRow.Cells["Serial No."].Value.ToString();
                GlobalTransaction.DocumentNo = selectedRow.Cells["Document No."].Value.ToString();
            }
            else
            {
                GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
                GlobalVideo.Copies = int.Parse(selectedRow.Cells["Copies"].Value.ToString());
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
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.AllTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
            }
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OverdueRent;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.Text, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));

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
                DataGridViewRow row = datagridTransactions.SelectedRows[0];

                int penaltyFees = int.Parse(row.Cells["Penalty Fee"].Value.ToString());

                GlobalTransaction.TotalAmount += penaltyFees;

                using (PaymentWindow paymentWindow = new PaymentWindow(true))
                    paymentWindow.ShowDialog();

                Utility.GetTransactions();
                GetCountTransactions();
                datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.SelectedItem.ToString(), !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
            }
        }

        private void datagridTransactions_DataSourceChanged(object sender, EventArgs e)
        {
            if (currentDataDisplayed == DataDisplayed.AllVideos)
                Utility.HideColumns(datagridTransactions, "VideoID");
            else if (currentDataDisplayed == DataDisplayed.ItemLedgerEntry)
                datagridTransactions.Columns["EntryNo."].Visible = false;
            else
                Utility.HideColumns(datagridTransactions, "VideoID", "CustomerID", "RentalID");
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            //if (pnlCalendar.Visible == false)
            //{
            //    pnlCalendar.Show();
            //    pnlCalendar.Location = new Point(549, 0);

            //}
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
            datagridTransactions.Columns["EntryNo."].Visible = false;

            btnRent.Hide();
            btnReturn.Hide();
            btnSettlePenalty.Hide();
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
            //calendarDays clickedControl = sender as calendarDays;
            //if (clickedControl != null)
            //{
            //    DateTime selecteddate = new DateTime(_year, _month, int.Parse(clickedControl.SelectedDay));

            //    datagridTransactions.DataSource = null;
            //    datagridTransactions.DataSource = GlobalTransaction.TransactionList.Where(transaction => transaction.RentDate == selecteddate).ToList();

            //    pnlCalendar.Hide();
            //}
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

        private void txtbxSearchCustomerTransactions_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text))
            {
                GlobalCustomer.CustomerName = txtbxSearchCustomerTransactions.Text;
            }

            selectedCategory = (string)cmbbxCategory.SelectedItem;

            switch (currentDataDisplayed)
            {
                case DataDisplayed.AllVideos:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllVideos.ToString(), selectedCategory, false);
                    break;
                case DataDisplayed.OngoingRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.AllTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), selectedCategory, !string.IsNullOrEmpty(txtbxSearchCustomerTransactions.Text));
                    break;
            }

        }

        #endregion

        #region CustomerLibrary

        private void btnGenerateCustomerReport_Click(object sender, EventArgs e)
        {
            GlobalCustomer.CustomerName = null;
            GlobalCustomer.CustomerID = 0;

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

            Utility.GetVideosInfo();

            datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
            Utility.GenerateVideoReport(reportViewerVideo);

            videos.Clear();

            foreach (var title in GlobalVideo.VideoList)
                videos.Add(title.Title);

            txtbxDescription.AutoCompleteCustomSource = videos;
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

        #endregion

        #region ItemJournal

        private void txtbxTitle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxDescription.Text))
            {
                string title = txtbxDescription.Text;
                int videoid = GlobalVideo.VideoList.Where(vidtitle => vidtitle.Title == title).Select(vidId => vidId.VideoID).FirstOrDefault();

                txtbxVideoID.Text = videoid.ToString();
            }
            else
            {
                txtbxVideoID.Text = "";
                return;
            }
        }

        private void cmbbxEntryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbbxEntryType.Text)
            {
                case "Sale":
                    txtbxQuantity.Text = "-1";
                    break;
                case "Return":
                    txtbxQuantity.Text = "+1";
                    break;
                default:
                    txtbxQuantity.Text = "1";
                    break;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab != RentReturn)
                panel10.Visible = true;
            else panel10.Visible = false;
        }

        private void picbxCloseCalendar_Click(object sender, EventArgs e)
        {
            pnlCalendar.Visible = false;
        }

        private void datagridTransactions_DoubleClick(object sender, EventArgs e)
        {
            if (currentDataDisplayed == DataDisplayed.AllVideos)
            {
                using (ManageVideo manageVideo = new ManageVideo(true))
                    manageVideo.ShowDialog();

                datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
                datagridTransactions.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
                Utility.GenerateVideoReport(reportViewerVideo);
            }
        }

        private void datagridCustomer_DoubleClick(object sender, EventArgs e)
        {
            using (ManageCustomer manageCustomer = new ManageCustomer(true))
                manageCustomer.ShowDialog();

            datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), false);
            Utility.GetCustomersInfo(txtbxSearchCustomerTransactions);
        }

        private void pnlClick_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            label13.SendToBack();

            switch (panel.Name)
            {
                case "pnlEarnings":
                    datagridDataDisplay.DataSource = null;

                    pnlEarnings.BackColor = Color.FromArgb(24, 28, 20);
                    pnlOverdue.BackColor = Color.FromArgb(105, 117, 101);
                    pnlRented.BackColor = Color.FromArgb(105, 117, 101);
                    pnlReturned.BackColor = Color.FromArgb(105, 117, 101);

                    datagridDataDisplay.DataSource = GlobalTransaction.TransactionList
                        .Where(transaction => (transaction.Status == "On Rent" || transaction.Status == "Closed") && (transaction.RentDate == DateTime.Today || transaction.ReturnDate == DateTime.Today.ToString()))
                        .Select(transaction => new
                        {
                            transaction.VideoID,
                            transaction.VideoTitle,
                            transaction.CustomerName,
                            transaction.RentDate,
                            transaction.ReturnDate,
                            transaction.PenaltyFee,
                            transaction.RentFee,
                            transaction.Status
                        }).ToList();
                    break;
                case "pnlOverdue":
                    datagridDataDisplay.DataSource = null;

                    pnlEarnings.BackColor = Color.FromArgb(105, 117, 101);
                    pnlOverdue.BackColor = Color.FromArgb(24, 28, 20);
                    pnlRented.BackColor = Color.FromArgb(105, 117, 101);
                    pnlReturned.BackColor = Color.FromArgb(105, 117, 101);

                    datagridDataDisplay.DataSource = GlobalTransaction.TransactionList
                        .Where(transaction => transaction.Status == "Overdue")
                        .Select(transaction => new
                        {
                            transaction.VideoID,
                            transaction.VideoTitle,
                            transaction.CustomerName,
                            transaction.RentDate,
                            transaction.PenaltyFee,
                            transaction.RentFee
                        }).ToList();
                    break;
                case "pnlRented":
                    datagridDataDisplay.DataSource = null;

                    pnlEarnings.BackColor = Color.FromArgb(105, 117, 101);
                    pnlOverdue.BackColor = Color.FromArgb(105, 117, 101);
                    pnlRented.BackColor = Color.FromArgb(24, 28, 20);
                    pnlReturned.BackColor = Color.FromArgb(105, 117, 101);

                    datagridDataDisplay.DataSource = GlobalTransaction.TransactionList
                        .Where(transaction => transaction.Status == "On Rent" && transaction.RentDate == DateTime.Today)
                        .Select(transaction => new
                        {
                            transaction.VideoID,
                            transaction.VideoTitle,
                            transaction.CustomerName,
                            transaction.RentDate,
                            transaction.PenaltyFee,
                            transaction.RentFee,
                            transaction.Status,
                        }).ToList();
                    break;
                case "pnlReturned":
                    datagridDataDisplay.DataSource = null;

                    pnlEarnings.BackColor = Color.FromArgb(105, 117, 101);
                    pnlOverdue.BackColor = Color.FromArgb(105, 117, 101);
                    pnlRented.BackColor = Color.FromArgb(105, 117, 101);
                    pnlReturned.BackColor = Color.FromArgb(24, 28, 20);

                    datagridDataDisplay.DataSource = GlobalTransaction.TransactionList
                        .Where(transaction => transaction.Status == "Closed" && transaction.ReturnDate == DateTime.Today.ToString())
                        .Select(transaction => new
                        {
                            transaction.VideoID,
                            transaction.VideoTitle,
                            transaction.CustomerName,
                            transaction.RentDate,
                            transaction.PenaltyFee,
                            transaction.RentFee
                        }).ToList();
                    break;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!GlobalVideo.VideoList.Any(video => video.Title == txtbxDescription.Text))
            {
                MessageBox.Show("This video does not exist.");
                return;
            }
            if (datagridItemJournal.Rows.Cast<DataGridViewRow>().Any(r => !r.IsNewRow && r.Cells["SerialNo"].Value?.ToString() == txtbxSerialNo.Text &&
              r.Cells["VideoID"].Value?.ToString() == txtbxVideoID.Text))
            {
                MessageBox.Show("This item already exists.");
                return;
            }

            ItemJournal item = new ItemJournal
            {
                DocumentNo = txtbxDocumentNo.Text,
                VideoID = int.Parse(txtbxVideoID.Text),
                Title = txtbxDescription.Text,
                Quantity = int.Parse(txtbxQuantity.Text),
                SerialNo = txtbxSerialNo.Text,
                EntryType = cmbbxEntryType.Text
            };

            int rowIndex = datagridItemJournal.Rows.Add();
            DataGridViewRow row = datagridItemJournal.Rows[rowIndex];
            row.Cells["DocumentNo"].Value = item.DocumentNo;
            row.Cells["VideoID"].Value = item.VideoID;
            row.Cells["Title"].Value = item.Title;
            row.Cells["Quantity"].Value = item.Quantity;
            row.Cells["SerialNo"].Value = item.SerialNo;
            row.Cells["EntryType"].Value = item.EntryType;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (datagridItemJournal.Rows.Count != 0)
            {
                foreach (DataGridViewRow item in datagridItemJournal.Rows)
                {
                    Utility.ExecuteQuery("AddIntoItemLedgerEntry", true,
                        new SqlParameter("@DocumentNo", item.Cells["DocumentNo"].Value.ToString()),
                        new SqlParameter("@VideoID", item.Cells["VideoID"].Value.ToString()),
                        new SqlParameter("@Title", item.Cells["Title"].Value.ToString()),
                        new SqlParameter("@Quantity", item.Cells["Quantity"].Value.ToString()),
                        new SqlParameter("@SerialNo", item.Cells["SerialNo"].Value.ToString()),
                        new SqlParameter("@Type", item.Cells["EntryType"].Value.ToString()));
                }

                datagridItemJournal.Rows.Clear();
                MessageBox.Show("Item posted successfully");

                if (currentDataDisplayed == DataDisplayed.ItemLedgerEntry)
                    datagridTransactions.DataSource = Utility.LoadData(Queries.LoadItemLedgerEntry, false);

                datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);

                GlobalItemJournal.ItemsList.Clear();
                Utility.GetItemLedgerEntries();

                txtbxDocumentNo.Text = "";
                txtbxDescription.Text = "";
                txtbxVideoID.Text = "";
                txtbxSerialNo.Text = "";
            }
            else MessageBox.Show("No items to post");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int rowIndex = datagridItemJournal.SelectedRows[0].Index;

            if (MessageBox.Show("Remove selected item?", "Removing Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GlobalItemJournal.ItemsList.RemoveAt(rowIndex);

                datagridItemJournal.DataSource = null;
                datagridItemJournal.DataSource = GlobalItemJournal.ItemsList;
            }
        }

        private void GetCountTransactions()
        {
            var today = DateTime.Today;

            int onRentCount = GlobalTransaction.TransactionList
                .Count(transaction => (transaction.Status == "On Rent" || transaction.Status == "Closed") && transaction.RentDate == today);

            int overdueCount = GlobalTransaction.TransactionList
                .Count(transaction => transaction.Status == "Overdue");

            int returnedCount = GlobalTransaction.TransactionList
                .Count(transaction => transaction.Status == "Closed" && transaction.ReturnDate == today.ToString());

            decimal totalEarnings = GlobalTransaction.TransactionList
                .Where(transaction =>
                    (transaction.Status == "On Rent" || transaction.Status == "Closed") &&
                    (transaction.RentDate == today || transaction.ReturnDate == today.ToString()))
                .Sum(transaction =>
                    transaction.PenaltyFee + (transaction.PenaltyFee == 0 ? transaction.RentFee : 0));

            lblRentedCount.Text = onRentCount.ToString();
            lblOverdueCount.Text = overdueCount.ToString();
            lblReturnedCount.Text = returnedCount.ToString();
            lblEarningCount.Text = totalEarnings.ToString("C");
        }

        #endregion
    }
}