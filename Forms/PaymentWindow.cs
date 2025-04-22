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
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BogsyVideoStore.Properties;

namespace BogsyVideoStore.Forms
{
    public partial class PaymentWindow : Form
    {
        bool isPenaltyFee;

        public PaymentWindow(bool isPenaltyFee)
        {
            InitializeComponent();
            this.isPenaltyFee = isPenaltyFee;
        }

        private void btnConfirmTransaction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxPayment.Text))
                MessageBox.Show("Enter payment");
            else
            {
                GlobalItemJournal.DocumentNo = Settings.Default.LastReceiptNo + 1;
                Settings.Default.LastReceiptNo = GlobalItemJournal.DocumentNo;
                Settings.Default.Save();

                if (!isPenaltyFee)
                {
                    foreach (var transaction in GlobalTransaction.TransactionList)
                    {
                        Utility.ExecuteQuery("InsertToRental", true,
                            new SqlParameter("@VideoID", transaction.VideoID), 
                            new SqlParameter("@CustomerID", GlobalCustomer.CustomerID), 
                            new SqlParameter("@RentDate", transaction.RentDate),
                            new SqlParameter("@DueDate", transaction.DueDate), 
                            new SqlParameter("@RentFee", transaction.RentFee), 
                            new SqlParameter("@PenaltyFee", transaction.PenaltyFee), 
                            new SqlParameter("@Status", transaction.Status),
                            new SqlParameter("@SerialNo", transaction.SerialNo), 
                            new SqlParameter("@DocumentNo", "BVS" + GlobalItemJournal.DocumentNo));

                        Utility.ExecuteQuery("AddIntoItemLedgerEntry", true, new SqlParameter("@DocumentNo", "BVS" + GlobalItemJournal.DocumentNo), new SqlParameter("@VideoID", transaction.VideoID), new SqlParameter("@Title", transaction.VideoTitle),
                            new SqlParameter("@Quantity", "-1"), new SqlParameter("@SerialNo", transaction.SerialNo), new SqlParameter("@Type", "Sale"));
                    }

                    MessageBox.Show("Video successfully rented");
                    isPenaltyFee = false;
                }
                else
                {
                    Utility.ExecuteQuery("ReturnVideo", true, new SqlParameter("@RentalID", GlobalTransaction.RentalID), new SqlParameter("@VideoID", GlobalVideo.VideoID));

                    Utility.ExecuteQuery("AddIntoItemLedgerEntry", true, new SqlParameter("@DocumentNo", GlobalItemJournal.DocumentNo), new SqlParameter("@VideoID", GlobalVideo.VideoID), new SqlParameter("@Title", GlobalVideo.Title),
                        new SqlParameter("@Quantity", "+1"), new SqlParameter("@SerialNo", GlobalItemJournal.SerialNo), new SqlParameter("@Type", "Return"));

                    MessageBox.Show("Payments settled");
                    isPenaltyFee = true;
                }

                Receipt receipt = new Receipt(isPenaltyFee);
                receipt.Show();

                this.Close();
            }
        }

        private void txtbxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (char.IsDigit(e.KeyChar) && txtbxPayment.TextLength > 6)
                e.Handled = true;
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

        private void PaymentWindow_Load(object sender, EventArgs e)
        {
            lblTotal.Text = $"Total: ₱{GlobalTransaction.TotalAmount}.00";
        }
    }
}
