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

namespace BogsyVideoStore
{
    public partial class LogIn : Form
    {
        Dashboard dashboard = new Dashboard();

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            CurrentCustomer customer = new CurrentCustomer
            {
                ContactInfo = txtbxContactInfo.Text,
                Password = txtbxPassword.Text
            };

            if (AccountHandler.LogIn(customer))
            {
                MessageBox.Show("Log in successful");

                this.Hide();
                dashboard.Show();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();

            this.Hide();
            registrationForm.Show();
        }
    }
}
