using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using BogsyVideoStore.Forms;
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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var validations = new List<bool>()
            {
                Validator.ValidateName(txtbxFname.Text),
                Validator.ValidateName(txtbxLname.Text),
                Validator.ValidateContactInfo(txtbxContactNum.Text),
                Validator.ValidateAge(int.Parse(txtbxAge.Text)),
                Validator.ValidatePassword(txtbxPass.Text)
            };

            if (validations.Any(result => !result))
                MessageBox.Show("Error in one or more fields");
            else
            {
                Customer customer = new Customer
                {
                    FirstName = txtbxFname.Text,
                    LastName = txtbxLname.Text,
                    ContactInfo = txtbxContactNum.Text,
                    Address = txtbxAddress.Text,
                    Age = int.Parse(txtbxAge.Text),
                    Password = txtbxPass.Text,
                    Role = txtbxRole.Text
                };

                AccountHandler.Registration(customer);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();

            this.Hide();
            logIn.Show();
        }
    }
}
