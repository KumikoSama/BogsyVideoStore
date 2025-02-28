using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BogsyVideoStore.Forms
{
    public partial class RentForm : Form
    {
        public RentForm(bool isMultiple, params List<Video>[] videos)
        {
            InitializeComponent();

            if (!isMultiple)
            {
                txtbxTitle.Text = GlobalVideo.Title;
                txtbxCategory.Text = GlobalVideo.Category;
                txtbxPrice.Text = GlobalVideo.Price.ToString(); 
            }
            else
            {
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            DateTime dueDate = DateTime.Now.AddDays(int.Parse(cmbbxDays.Text));

            Transaction transaction = new Transaction
            {
                VideoID = GlobalVideo.VideoID,
                Status = "On Rent",
                DueDate = dueDate,
                RentDate = DateTime.Now,
                IsReturned = false,
                PenaltyFee = 0,
                RentFee = GlobalVideo.Price
            };

            Utility.ExecuteQuery("InsertToRental", true, new SqlParameter("@VideoID", transaction.VideoID), new SqlParameter("@CustomerID", GlobalCustomer.CustomerID), new SqlParameter("@RentDate", transaction.RentDate),
                new SqlParameter("@DueDate", transaction.DueDate), new SqlParameter("@RentFee", transaction.RentFee), new SqlParameter("@PenaltyFee", transaction.PenaltyFee), new SqlParameter("@Status", transaction.Status));

            MessageBox.Show("Video successfully rented");
            this.Hide();
        }

        private void cmbbxDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
