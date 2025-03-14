using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using Microsoft.Reporting.WinForms;
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
    public partial class Receipt : Form
    {
        bool isPenaltyFee;

        public Receipt(bool isPenaltyFee)
        {
            InitializeComponent();
            this.isPenaltyFee = isPenaltyFee;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.reportViewerReceipt.RefreshReport();
            this.BringToFront();

            lblTotal.Text = $"Total: ₱{GlobalTransaction.TotalAmount}.00";
        }

        private void txtbxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (char.IsDigit(e.KeyChar) && txtbxPayment.TextLength > 6)
                e.Handled = true;
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxPayment.Text))
                MessageBox.Show("Enter payment");
            else
            {
                if (!isPenaltyFee)
                {
                    foreach (var transaction in GlobalTransaction.TransactionList)
                    {
                        Utility.ExecuteQuery("InsertToRental", true, new SqlParameter("@VideoID", transaction.VideoID), new SqlParameter("@CustomerID", GlobalCustomer.CustomerID), new SqlParameter("@RentDate", transaction.RentDate),
                            new SqlParameter("@DueDate", transaction.DueDate), new SqlParameter("@RentFee", transaction.RentFee), new SqlParameter("@PenaltyFee", transaction.PenaltyFee), new SqlParameter("@Status", transaction.Status));
                    }

                    MessageBox.Show("Video successfully rented");
                }
                else
                {
                    Utility.ExecuteQuery("ReturnVideo", true, new SqlParameter("@RentalID", GlobalTransaction.RentalID), new SqlParameter("@VideoID", GlobalTransaction.VideoID));

                    MessageBox.Show("Payments settled");
                }

                Utility.GenerateReceipt(reportViewerReceipt, isPenaltyFee);
            }
        }

        private void txtbxPayment_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxPayment.Text))
                lblChange.Text = $"Change: ₱0.00";
            else
            {
                GlobalTransaction.Payment = Convert.ToInt32(txtbxPayment.Text);
                GlobalTransaction.Change = GlobalTransaction.Payment - GlobalTransaction.TotalAmount;
                lblChange.Text = $"Change: ₱{GlobalTransaction.Change}.00";
            }
        }

        private void Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalTransaction.TotalAmount = 0;
            GlobalTransaction.Payment = 0;
            GlobalTransaction.Change = 0;
        }
    }
}
