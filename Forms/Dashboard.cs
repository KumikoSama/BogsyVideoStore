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

namespace BogsyVideoStore.Forms
{
    enum DataDisplayed
    {
        AllVideos,
        AllReports,
        PreviousTransactions,
        OngoingRent,
        OverdueRent
    }

    public partial class Dashboard : Form
    {
        DataDisplayed currentDataDisplayed = DataDisplayed.AllVideos;
        string selectedCategory;

        public Dashboard()
        {
            InitializeComponent();
            Utility.ExecuteQuery(Queries.UpdateRentalTable, false);
            Utility.ExecuteQuery(Queries.UpdatePenaltyFee, false);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            datagridTransactions.DataSource = Utility.LoadData("LoadAllVideos", false, true);
            datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, true);
            datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);

            Utility.LoadCustomers(cmbbxCustomer);

            datagridCustomer.Columns["CustomerID"].Visible = false;
            datagridTransactions.Columns["VideoID"].Visible = false;
            datagridVidLibrary.Columns["VideoID"].Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "RentReturn":
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadAllVideos", "All", false);
                    break;
                case "VideoLibrary":
                    datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);
                    break;
                case "CustomerLibrary":
                    datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, true);
                    break;
            }
        }

        #region RentalAndReturn

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (cmbbxCustomer.Text == "All")
                return;
            else
            {
                DataGridViewRow selectedRow;
                var video = new List<Video>();
                bool isMultiple = false;

                if (datagridTransactions.SelectedRows.Count == 1)
                {
                    selectedRow = datagridTransactions.SelectedRows[0];

                    GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
                    GlobalVideo.Title = selectedRow.Cells["Title"].Value.ToString();
                    GlobalVideo.Category = selectedRow.Cells["Category"].Value.ToString();
                    GlobalVideo.Price = int.Parse(selectedRow.Cells["Price"].Value.ToString());

                    isMultiple = false;

                    RentForm rentForm = new RentForm(isMultiple);
                    rentForm.Show();
                }
                else if (datagridTransactions.SelectedRows.Count > 1)
                {
                    for (int i = 0; i < datagridTransactions.SelectedRows.Count; i++)
                    {
                        selectedRow = datagridTransactions.SelectedRows[i];

                        video.Add(new Video
                        {
                            VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString()),
                            Title = selectedRow.Cells["Title"].Value.ToString(),
                            Category = selectedRow.Cells["Category"].Value.ToString(),
                            Price = int.Parse(selectedRow.Cells["Price"].Value.ToString())
                        });
                    }
                    isMultiple = true;

                    RentForm rentForm = new RentForm(isMultiple, video);
                    rentForm.Show();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return this?", "Return Video", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Utility.ExecuteQuery("ReturnVideo", true, new SqlParameter("@CustomerID", GlobalCustomer.CustomerID), new SqlParameter("@VideoID", GlobalVideo.VideoID));

                MessageBox.Show("Video returned successfully");
            }
            else return;
        }

        private void btnPastTransactions_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.PreviousTransactions;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadClosedTransactions", cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");

            btnReturn.Visible = false;
            btnRent.Visible = false;
            Utility.HideColumns(datagridTransactions, "RentalID", "CustomerID", "VideoID");
        }

        private void btnOngoingRent_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OngoingRent;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadOnGoingRent", cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");
            datagridTransactions.MultiSelect = false;

            btnReturn.Visible = true;
            btnRent.Visible = false;

            Utility.HideColumns(datagridTransactions, "RentalID", "CustomerID", "VideoID");
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
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadAllVideos", selectedCategory, false);
                    break;
                case DataDisplayed.OngoingRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadOnGoingRent", selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadClosedTransactions", selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.AllReports:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadAllRentalTransactions", selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadOverdueRent", selectedCategory, cmbbxCustomer.Text != "All");
                    break;
            }
        }

        private void btnAllReports_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.AllReports;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadAllRentalTransactions", cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");

            btnReturn.Visible = false;
            btnRent.Visible = false;
            
            Utility.HideColumns(datagridTransactions,"VideoID", "CustomerID", "RentalID");
        }

        private void datagridTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRows = datagridTransactions.Rows[0];

            if (currentDataDisplayed != DataDisplayed.AllVideos)
            {
                GlobalVideo.VideoID = int.Parse(selectedRows.Cells["VideoID"].Value.ToString());
                GlobalCustomer.CustomerID = int.Parse(selectedRows.Cells["CustomerID"].Value.ToString());
                GlobalTransaction.RentalID = int.Parse(selectedRows.Cells["RentalID"].Value.ToString());
            }
            else
            {
                if (datagridTransactions.SelectedRows.Count == 1)
                {

                }
            }
        }

        private void btnAllVideos_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.AllVideos;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadAllVideos", cmbbxCategory.SelectedItem.ToString(), false);

            btnReturn.Visible = false;
            btnRent.Visible = true;
        }

        private void cmbbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCategory = (string)cmbbxCategory.SelectedItem;

            switch (currentDataDisplayed)
            {
                case DataDisplayed.AllVideos:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadAllVideos", selectedCategory, false);
                    break;
                case DataDisplayed.OngoingRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadOnGoingRent", selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadClosedTransactions", selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.AllReports:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadAllRentalTransactions", selectedCategory, cmbbxCustomer.Text != "All");
                    break;
                case DataDisplayed.OverdueRent:
                    datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadOverdueRent", selectedCategory, cmbbxCustomer.Text != "All");
                    break;
            }
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OverdueRent;

            datagridTransactions.DataSource = Utility.LoadDataByCustomerAndCategory("LoadOverdueRent", cmbbxCategory.SelectedItem.ToString(), cmbbxCustomer.Text != "All");

            btnReturn.Visible = true;
            btnRent.Visible = false;
            Utility.HideColumns(datagridTransactions, "VideoID", "CustomerID", "RentalID");
        }

        private void cmbbxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        #region CustomerLibrary

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            if (!Validator.ValidateCustomerInformation(txtbxFullName.Text, txtbxContactInfo.Text))
                return;

            if (Validator.ValidateContactInfo(txtbxContactInfo.Text) && !string.IsNullOrEmpty(txtbxFullName.Text))
            {
                customer.CustomerName = txtbxFullName.Text.ToUpper();
                customer.ContactInfo = txtbxContactInfo.Text;
            }
            else return;

            Utility.ExecuteQuery(Queries.InsertToCustomerTable, false, new SqlParameter("@CustomerName", customer.CustomerName), new SqlParameter("@ContactInfo", customer.ContactInfo));

            MessageBox.Show("Customer successfully added");
            datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, false);
            Utility.LoadCustomers(cmbbxCustomer);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateContactInfo(txtbxContactInfo.Text) && !string.IsNullOrEmpty(txtbxFullName.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you'll edit this customer information?", "Customer Information",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                    Utility.ExecuteQuery(Queries.EditCustomerQuery, false, new SqlParameter("@CustomerName", txtbxFullName.Text.ToUpper()), new SqlParameter("@ContactInfo", txtbxContactInfo.Text), new SqlParameter("@CustomerID", GlobalCustomer.CustomerID));
                else return;

                datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, true);
            }
            else
                MessageBox.Show("Fields are empty or in an incorrect format");
        }

        private void datagridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedCustomer = datagridCustomer.SelectedRows[0];

                txtbxFullName.Text = selectedCustomer.Cells["CustomerName"].Value.ToString();
                txtbxContactInfo.Text = selectedCustomer.Cells["ContactInfo"].Value.ToString();

                GlobalCustomer.CustomerID = int.Parse(selectedCustomer.Cells["CustomerID"].Value.ToString());
                btnAddCustomer.Enabled = false;
            }
        }

        private void txtbxContactInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+')
                e.Handled = true;
            else if (e.KeyChar == '+' && (txtbxContactInfo.SelectionStart != 0 || txtbxContactInfo.Text.Contains("+")))
                e.Handled = true;
            else if (char.IsDigit(e.KeyChar) && txtbxContactInfo.Text.Length >= 13)
                e.Handled = true;
        }

        private void txtbxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void lnklblClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtbxFullName.Clear();
            txtbxContactInfo.Clear();
            btnAddCustomer.Enabled = true;
        }

        private void txtbxCustomerInformation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxFullName.Text) || string.IsNullOrEmpty(txtbxContactInfo.Text))
                btnAddCustomer.Enabled = true;
        }

        #endregion

        #region VideoLibrary

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            using (ManageVideo manageVideo = new ManageVideo(false))
                manageVideo.ShowDialog();

            datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);
        }

        private void btnEditVideo_Click(object sender, EventArgs e)
        {
            if (datagridVidLibrary.SelectedRows.Count > 0)
            {
                using (ManageVideo manageVideo = new ManageVideo(true))
                    manageVideo.ShowDialog();

                datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);
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
                MessageBox.Show("You can't delete this yet! There's still copies that are being borrowed.");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you'll delete this video?", "Video Deletion Confirmation",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                    Utility.ExecuteQuery(Queries.DeleteVideo, false, new SqlParameter("@VideoID", GlobalVideo.VideoID));
                else return;
            }
        }

        private void datagridVidLibrary_DoubleClick(object sender, EventArgs e)
        {
            using (ManageVideo manageVideo = new ManageVideo(true))
                manageVideo.ShowDialog();

            datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);
        }

        #endregion

    }
}