using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using Microsoft.Data.SqlClient;
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
    public partial class ManageCustomer: Form
    {
        public ManageCustomer(bool isEdit = false)
        {
            InitializeComponent();

            if (isEdit)
            {
                btnAddCustomer.Hide();

                txtbxContactInfo.Text = GlobalCustomer.ContactInfo;
                txtbxFullName.Text = GlobalCustomer.CustomerName;
            }
        }

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
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateContactInfo(txtbxContactInfo.Text) && !string.IsNullOrEmpty(txtbxFullName.Text))
            {
                if (Validator.ValidateCustomerInformation(txtbxFullName.Text, txtbxContactInfo.Text))
                {
                    MessageBox.Show("Customer information does not exist");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you'll edit this customer information?", "Customer Information",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                    Utility.ExecuteQuery(Queries.EditCustomerQuery, false, new SqlParameter("@CustomerName", txtbxFullName.Text.ToUpper()), new SqlParameter("@ContactInfo", txtbxContactInfo.Text), new SqlParameter("@CustomerID", GlobalCustomer.CustomerID));
                else return;
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

        private void lnklblClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtbxFullName.Clear();
            txtbxContactInfo.Clear();
            GlobalCustomer.CustomerID = 0;
        }
    }
}
