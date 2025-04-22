using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BogsyVideoStore.Forms;

namespace BogsyVideoStore
{

    public partial class calendarDays: UserControl
    {
        string _day;
        public List<TransactionsOnDate> TransactionsOnDateList = new List<TransactionsOnDate>();
        public string SelectedDay { get { return lblDay.Text; } set { lblDay.Text = value; } }

        //private void pnlDay_Click(object sender, EventArgs e)
        //{
        //    if (chckbxCheckDay.Checked == false && lblDay.Text != "")
        //    {
        //        chckbxCheckDay.Checked = true;
        //        pnlDay.BackColor = Color.WhiteSmoke;
        //        lblDay.ForeColor = Color.FromArgb(60, 61, 55);

        //        foreach (Label label in flwpnlCustomerNames.Controls)
        //            label.ForeColor = Color.FromArgb(60, 61, 55);
        //    }
        //}

        private void AttachClickEvent(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += (s, e) => this.OnClick(e); // Forward click event to ucDays
                AttachClickEvent(c); // Recursively attach to all child controls
            }
        }

        public calendarDays(string day)
        {
            InitializeComponent();
            _day = day;
            lblDay.Text = day;

            AttachClickEvent(this); 
        }

        private void calendarDays_Load(object sender, EventArgs e)
        {
            flwpnlCustomerNames.Controls.Clear();

            if (TransactionsOnDateList.Count > 0)
            {
                foreach (var transaction in TransactionsOnDateList)
                {
                    Label label = new Label();
                    label.Text = transaction.CustomerName;
                    label.BackColor = transaction.Status == "Closed" ? Color.RosyBrown : Color.Goldenrod;

                    flwpnlCustomerNames.Controls.Add(label);
                }
            }
        }
    }   
    
    public class TransactionsOnDate
    {
        public string CustomerName { get; set; }
        public string Status { get; set; }
    }
}
