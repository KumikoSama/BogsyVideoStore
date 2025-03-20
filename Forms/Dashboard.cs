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

namespace BogsyVideoStore.Forms
{
    enum DataDisplayed
    {
        AllVideos,
        AllTransactions,
        PreviousTransactions,
        OngoingRent,
        OverdueRent
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
        string selectedCategory;

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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            datagridTransactions.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);
            datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), true);
            datagridVidLibrary.DataSource = Utility.LoadData(StoredProcedures.LoadAllVideos.ToString(), true);

            datagridCustomer.Columns["CustomerID"].Visible = false;
            datagridVidLibrary.Columns["VideoID"].Visible = false;

            cmbbxCustomer.SelectedIndexChanged -= cmbbxCustomer_SelectedIndexChanged;

            GlobalCustomer.CustomerList.Add(new Customer { CustomerName = "All" });
            Utility.LoadCustomers(cmbbxCustomer);

            cmbbxCustomer.SelectedIndexChanged += cmbbxCustomer_SelectedIndexChanged;

            customers = new AutoCompleteStringCollection();

            foreach (var customer in GlobalCustomer.CustomerList)
                customers.Add(customer.CustomerName);

            Utility.SplitColumnHeaderTexts(datagridVidLibrary);
            Utility.GenerateCustomerReport(reportViewerCustomer);
            Utility.GenerateVideoReport(reportViewerVideo);

            txtbxSearchVideo.AutoCompleteCustomSource = videos;
            txtbxSearchCustomer.AutoCompleteCustomSource = customers;

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
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");
                else if (currentDataDisplayed == DataDisplayed.OverdueRent)
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");
            }
            else return;
        }

        private void btnPastTransactions_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.PreviousTransactions;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");

            btnReturn.Visible = false;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = false;
        }

        private void btnOngoingRent_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OngoingRent;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");
            datagridTransactions.MultiSelect = false;

            btnReturn.Visible = true;
            btnRent.Visible = false;
            btnSettlePenalty.Visible = false;
        }

        private void cmbbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxCustomer.Text != "All")
            {
                GlobalCustomer.CustomerName = cmbbxCustomer.Text;
                GlobalCustomer.CustomerID = int.Parse(cmbbxCustomer.SelectedValue.ToString());
            }

            selectedCategory = (string)cmbbxCategory.SelectedItem;

            switch (currentDataDisplayed)
            {
                case DataDisplayed.AllVideos:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllVideos.ToString(), selectedCategory, false);
                    break;
                case DataDisplayed.OngoingRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.AllTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), selectedCategory, cmbbxCustomer.Text != "All");
                    break;
            }
        }

        private void btnAllReports_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.AllTransactions;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");

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
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOnGoingRent.ToString(), selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadClosedTransactions.ToString(), selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.AllTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllRentalTransactions.ToString(), selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), selectedCategory, cmbbxCustomer.Text != "All");
                    break;
            }
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OverdueRent;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");

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

                using (Receipt receipt = new Receipt(true))
                    receipt.ShowDialog();

                datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadOverdueRent.ToString(), cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");
            }
        }

        private void datagridTransactions_DataSourceChanged(object sender, EventArgs e)
        {
            if (currentDataDisplayed == DataDisplayed.AllVideos)
                Utility.HideColumns(datagridTransactions, "VideoID");
            else
                Utility.HideColumns(datagridTransactions, "VideoID", "CustomerID", "RentalID");

            Utility.SplitColumnHeaderTexts(datagridTransactions);
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
            Utility.LoadCustomers(cmbbxCustomer);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            using (ManageCustomer manageCustomer = new ManageCustomer(true))
                manageCustomer.ShowDialog();

            datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), false);
            Utility.LoadCustomers(cmbbxCustomer);
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

        #endregion

        private void cmbbxSortByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = cmbbxSortByCategory.Text;

            datagridVidLibrary.DataSource = Utility.LoadDataByCustomerAndCategory(StoredProcedures.LoadAllVideos.ToString(), selectedCategory, false);
        }

        private void txtbxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxSearchCustomer.Text))
                datagridCustomer.DataSource = GlobalCustomer.CustomerList.Where(customer => customer.CustomerName.ToLower().StartsWith(txtbxSearchCustomer.Text.ToLower())).ToList();
            else
                datagridCustomer.DataSource = Utility.LoadData(StoredProcedures.LoadAllCustomers.ToString(), true);
        }
    }
}