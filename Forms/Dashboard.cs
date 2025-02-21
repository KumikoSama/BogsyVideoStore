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

namespace BogsyVideoStore.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            datagridVideos.DataSource = Utility.LoadData("LoadAllVideos");
        }

        private void btnAllVideos_Click(object sender, EventArgs e)
        {
            datagridVideos.DataSource = Utility.LoadData("LoadAllVideos");
        }

        private void btnRentedVideos_Click(object sender, EventArgs e)
        {
            datagridVideos.DataSource = Utility.LoadData("LoadRentedVideos");
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            datagridVideos.DataSource = Utility.LoadData("LoadClosedTransactions");
        }

        private void btnOverdueRents_Click(object sender, EventArgs e)
        {
            datagridVideos.DataSource = Utility.LoadData("LoadDueRent");
        }

        private void btnVideoLibrary_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormsHandler.VideoLibrary().Show();
        }

        private void btnCustomerLibrary_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormsHandler.CustomerLibrary().Show();
        }
    }
}
