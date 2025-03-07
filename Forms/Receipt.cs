using BogsyVideoStore.Classes;
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
        int totalAmount;

        public Receipt(int totalAmount)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.BringToFront();
            Utility.GenerateReceipt(reportViewer1, totalAmount);
        }
    }
}
