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
    public partial class DataDisplay : Form
    {
        public DataDisplay(string dataDisplay)
        {
            InitializeComponent();

            switch (dataDisplay)
            {
                case "Earnings":
                    label1.Text = "Earnings Today";
                    break;
                case "Overdue":
                    label1.Text = "Overdue Rent Today";
                    break;
                case "Rented":
                    label1.Text = "Rented Videos Today";
                    break;
                default:
                    label1.Text = "Returned Videos Today";
                    break;
            }
        }

        private void DataDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
