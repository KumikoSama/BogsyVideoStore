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

namespace BogsyVideoStore
{
    public partial class LogIn : Form
    {
        Forms.Dashboard dashboard = new Forms.Dashboard();

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            CurrentCustomer customer = new CurrentCustomer();
            customer.ContactInfo = txtbxContactInfo.Text;
            customer.Password = txtbxPassword.Text;

            if (Helper.LogIn())
            {
                MessageBox.Show("Log in successful");

                this.Hide();
                dashboard.Show();
            }
        }
    }
}
