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
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxPayment.Text))
                MessageBox.Show("Enter payment");
            else
                Utility.GenerateReceipt(reportViewerReceipt, isPenaltyFee);
        }

        private void txtbxPayment_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxPayment.Text))
                lblChange.Text = $"Change: 0.00";

            GlobalTransaction.Payment = Convert.ToInt32(txtbxPayment.Text);
            GlobalTransaction.Change = GlobalTransaction.Payment - GlobalTransaction.TotalAmount;
            lblChange.Text = $"Change: {GlobalTransaction.Change}.00";
        }

        private void Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalTransaction.TotalAmount = 0;
        }

        private void txtbxPayment_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtbxPayment.Text, out decimal amount))
                txtbxPayment.Text = string.Format("{0:N0}", amount);
        }

    }
}
