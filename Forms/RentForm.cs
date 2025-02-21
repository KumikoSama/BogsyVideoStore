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

        public RentForm(Video video)
        {
            InitializeComponent();
            this.video = video;

            txtbxTitle.Text = video.Title;
            txtbxFormat.Text = video.Category;
            txtbxPrice.Text = video.Price.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction
            {
                CustomerID = CurrentCustomer.CustomerID,
                VideoID = video.VideoID,
                Status = "Pending",
                DueDate = null,
                RentDate = null,
                IsReturned = false,
                PenaltyFee = 0
            };

            Utility.ExecuteQuery("Request successful", "InsertToPendingRequests", new SqlParameter());
        }
    }
}
