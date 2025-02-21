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

namespace BogsyVideoStore.Forms
{
    public partial class Dashboard : Form
    {
        ManageVideo manageVideo;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            datagridTransactions.DataSource = Utility.LoadData("LoadAllRentalTransactions", false, true);
            datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, true);
            datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CustomerTable (FullName) VALUES (@FullName)";

            Customer customer = new Customer();
            customer.FullName = txtbxFullName.Text;

            Utility.ExecuteQuery("Member successfully added", query, false, new SqlParameter("@FullName", customer.FullName));
            datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, false);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = datagridTransactions.SelectedRows[0];

            Video video = new Video
            {
                Title = selectedRow.Cells["Title"].Value.ToString(),
                Category = selectedRow.Cells["Category"].Value.ToString(),
                Price = int.Parse(selectedRow.Cells["Price"].Value.ToString()),
            };

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnPastTransactions_Click(object sender, EventArgs e)
        {

        }

        private void btnOngoingRent_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CustomerTable SET FullName = @FullName WHERE CustomerID = @CustomerID";

            Utility.ExecuteQuery("Customer information updated", query, false, new SqlParameter("@FullName", txtbxFullName.Text), new SqlParameter("@CustomerID", GlobalCustomer.CustomerID));
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
            DataGridViewRow selectedRow = datagridTransactions.SelectedRows[0];

            GlobalVideo.VideoID = int.Parse(selectedRow.Cells["VideoID"].Value.ToString());
            GlobalVideo.Title = selectedRow.Cells["Title"].Value.ToString();
            GlobalVideo.Category = selectedRow.Cells["Category"].Value.ToString();
            GlobalVideo.Price = int.Parse(selectedRow.Cells["Price"].Value.ToString());
            GlobalVideo.In = int.Parse(selectedRow.Cells["In"].Value.ToString());
        }

        private void btnDeleteVideo_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM VideoTable WHERE VideoID = @VideoID";

            Utility.ExecuteQuery("Video deleted", query, false, new SqlParameter("@VideoID", GlobalVideo.VideoID));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                datagridTransactions.DataSource = Utility.LoadData("LoadAllRentalTransactions", false, true);
            else if (tabControl1.SelectedIndex == 1)
                datagridCustomer.DataSource = Utility.LoadData("LoadAllCustomers", false, true);
            else
                datagridVidLibrary.DataSource = Utility.LoadData("LoadAllVideos", false, true);
        }
    }
}
