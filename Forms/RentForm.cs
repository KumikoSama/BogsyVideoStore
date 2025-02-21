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
    public partial class RentForm : Form
    {
        readonly Video video;
        Dashboard dashboard = new Dashboard();

        public RentForm(Video video)
        {
            InitializeComponent();
            this.video = video;

            txtbxTitle.Text = video.Title;
            txtbxCategory.Text = video.Category;
            txtbxPrice.Text = video.Price.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RentalTable (VideoID, CustomerID, RentDate, DueDate, PenaltyFee, Status)" +
                "VALUES (@VideoID, @CustomerID, @RentDate, @DueDate, @PenaltyFee, @Status)";

            DateTime dueDate = DateTime.Now.AddDays(int.Parse(cmbbxDays.Text));

            Transaction transaction = new Transaction
            {
                VideoID = video.VideoID,
                Status = "Rented",
                DueDate = dueDate,
                RentDate = DateTime.Now,
                IsReturned = false,
                PenaltyFee = 0
            };

            Utility.ExecuteQuery("Rent successful", query, false, new SqlParameter("@VideoID", transaction.VideoID), new SqlParameter("@CustomerID", transaction.CustomerID), new SqlParameter("@RentDate", transaction.RentDate),
                new SqlParameter("@DueDate", transaction.DueDate), new SqlParameter("@PenaltyFee", transaction.PenaltyFee), new SqlParameter("@Status", transaction.Status));

            this.Hide();
        }
    }
}
