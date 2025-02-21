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
        OngoingRent
    }

    public partial class Dashboard : Form
    {
        ManageVideo manageVideo;
        bool isTransactions = false;
        DataDisplayed currentDataDisplayed = DataDisplayed.AllVideos;

        public Dashboard()
        {
            InitializeComponent();
            _ = Queries.UpdateRentalTable;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            datagridTransactions.DataSource = Utility.LoadData("LoadAllVideos", false, true);
            datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, true);
            datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);

            cmbbxCustomer.DataSource = Utility.LoadCustomers();
            btnReturn.Visible = false;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FullName = txtbxFullName.Text;

            Utility.ExecuteQuery("Member successfully added", Queries.InsertToCustomerTable, false, new SqlParameter("@FullName", customer.FullName));
            datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, false);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (cmbbxCustomer.SelectedItem.ToString() == "All")
                return;
            else
            {
                DataGridViewRow selectedRow = datagridTransactions.SelectedRows[0];

                GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
                GlobalVideo.Title = selectedRow.Cells["Title"].Value.ToString();
                GlobalVideo.Category = selectedRow.Cells["Category"].Value.ToString();
                GlobalVideo.Price = int.Parse(selectedRow.Cells["Price"].Value.ToString());

                RentForm rentForm = new RentForm();
                rentForm.Show();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Utility.ExecuteQuery("Video returned", "ReturnVideo", true, new SqlParameter("@CustomerID", GlobalCustomer.CustomerID), new SqlParameter("@VideoID", GlobalVideo.VideoID));
        }

        private void btnPastTransactions_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.PreviousTransactions;

            isTransactions = true;
            datagridTransactions.DataSource = Utility.LoadData(Queries.LoadClosedTransactions, false, false);

            btnReturn.Visible = false;
            btnRent.Visible = false;
            cmbbxCategory.Enabled = false;
        }

        private void btnOngoingRent_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.OngoingRent;

            isTransactions = true;
            datagridTransactions.DataSource = Utility.LoadData(Queries.LoadOngoingRent, cmbbxCustomer.SelectedItem.ToString() != "All", false);

            btnReturn.Visible = true;
            btnRent.Visible = false;
            cmbbxCategory.Enabled = false;
        }

        private void cmbbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxCustomer.SelectedItem.ToString() != "All")
            {
                GlobalCustomer.FullName = cmbbxCustomer.SelectedItem.ToString();
                Utility.GetCustomerID();
            }

            switch (currentDataDisplayed)
            {
                case DataDisplayed.AllVideos:
                    datagridTransactions.DataSource = Utility.LoadData("LoadAllVideos", false, true);
                    break;
                case DataDisplayed.OngoingRent:
                    datagridTransactions.DataSource = Utility.LoadData(Queries.LoadOngoingRent, cmbbxCustomer.SelectedItem.ToString() != "All", false);
                    break;
                case DataDisplayed.PreviousTransactions:
                    datagridTransactions.DataSource = Utility.LoadData(Queries.LoadOngoingRent, cmbbxCustomer.SelectedItem.ToString() != "All", false);
                    break;
                case DataDisplayed.AllReports:
                    datagridTransactions.DataSource = Utility.LoadData("LoadAllRentalTransactions", cmbbxCustomer.SelectedItem.ToString() != "All", true);
                    break;
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Utility.ExecuteQuery("Customer information updated", Queries.EditCustomerQuery, false, new SqlParameter("@FullName", txtbxFullName.Text), new SqlParameter("@CustomerID", GlobalCustomer.CustomerID));
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            manageVideo = new ManageVideo(false);
            manageVideo.Show();
        }

        private void datagridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedCustomer = datagridCustomer.SelectedRows[0];
            txtbxFullName.Text = selectedCustomer.Cells["FullName"].Value.ToString();
            GlobalCustomer.CustomerID = int.Parse(selectedCustomer.Cells["CustomerID"].Value.ToString());
        }

        private void btnEditVideo_Click(object sender, EventArgs e)
        {
            manageVideo = new ManageVideo(true);
            manageVideo.Show();
        }

        private void datagridVidLibrary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = datagridVidLibrary.SelectedRows[0];

            GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
            GlobalVideo.Title = selectedRow.Cells["Title"].Value.ToString();
            GlobalVideo.Category = selectedRow.Cells["Category"].Value.ToString();
            GlobalVideo.Price = int.Parse(selectedRow.Cells["Price"].Value.ToString());
            GlobalVideo.Copies = int.Parse(selectedRow.Cells["Copies"].Value.ToString());
        }

        private void btnDeleteVideo_Click(object sender, EventArgs e)
        {
            Utility.ExecuteQuery("Video deleted", Queries.DeleteVideo, false, new SqlParameter("@VideoID", GlobalVideo.VideoID));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);
            else if (tabControl1.SelectedIndex == 1)
                datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, true);
            else
                datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);
        }

        private void btnAllReports_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.AllReports;

            isTransactions = true;
            datagridTransactions.DataSource = Utility.LoadData("LoadAllRentalTransactions", cmbbxCustomer.SelectedItem.ToString() != "All", true);

            btnReturn.Visible = false;
            btnRent.Visible = false;
            cmbbxCategory.Enabled = false;
        }

        private void datagridTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isTransactions)
            {
                DataGridViewRow selectedTransaction = datagridTransactions.Rows[0];
                GlobalVideo.VideoID = int.Parse(selectedTransaction.Cells["VideoID"].Value.ToString());
                GlobalCustomer.CustomerID = int.Parse(selectedTransaction.Cells["CustomerID"].Value.ToString());
                GlobalTransaction.RentalID = int.Parse(selectedTransaction.Cells["RentalID"].Value.ToString()); 
            }
        }

        private void btnAllVideos_Click(object sender, EventArgs e)
        {
            currentDataDisplayed = DataDisplayed.AllVideos;

            isTransactions = false;
            datagridTransactions.DataSource = Utility.LoadData("LoadAllVideos", false, true);

            btnReturn.Visible = false;
            btnRent.Visible = true;
            cmbbxCategory.Enabled = true;
        }

        private void cmbbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridTransactions.DataSource = Utility.SortByCategory(cmbbxCategory.SelectedItem.ToString());
        }
    }
}
