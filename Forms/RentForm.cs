using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BogsyVideoStore.Forms
{
    public partial class RentForm : Form
    {
        int previousAmount;
        Func<int, int, int> calculateTotal = (x, y) => x + y;

        public RentForm()
        {
            InitializeComponent();
            GlobalTransaction.TransactionList.Clear();
            GlobalCustomer.CustomerList.Clear();
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            cmbbxVideos.SelectedIndexChanged -= cmbbxVideos_SelectedIndexChanged;
            cmbbxCustomer.SelectedIndexChanged -= cmbbxCustomer_SelectedIndexChanged;
            Utility.GetVideosInfo(cmbbxVideos);
            Utility.GetCustomersInfo(cmbbxCustomer);
            cmbbxCustomer.Text = "";
            cmbbxCustomer.SelectedIndexChanged += cmbbxCustomer_SelectedIndexChanged;
            cmbbxVideos.SelectedIndexChanged += cmbbxVideos_SelectedIndexChanged;

            cmbbxVideos.Text = GlobalVideo.Title;
            txtbxCategory.Text = GlobalVideo.Category;
            txtbxPrice.Text = GlobalVideo.Price.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (GlobalTransaction.TransactionList.Count > 0)
            {
                this.Close();

                PaymentWindow paymentWindow = new PaymentWindow();
                paymentWindow.ShowDialog();
            }
            else
                MessageBox.Show("Add transaction to the list first");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxCustomer.Text))
            {
                MessageBox.Show("Select a customer.");
                return;
            }
            else if (!GlobalCustomer.CustomerList.Select(customer => customer.CustomerName).Contains(cmbbxCustomer.Text))
            {
                MessageBox.Show("This customer doesn't exist in your list of customers");
                return;
            }
            else if (!GlobalVideo.VideoList.Select(video => video.Title).Contains(cmbbxVideos.Text))
            {
                MessageBox.Show("This video doesn't exist in your list of videos");
                return;
            }

            if (datagridList.Rows.Count < 10)
            {
                DateTime dueDate = DateTime.Now.AddDays(int.Parse(cmbbxDays.Text));
                GlobalVideo.Title = cmbbxVideos.Text;

                GlobalTransaction.TransactionList.Add(new Transaction
                {
                    VideoID = GlobalVideo.VideoID,
                    CustomerName = GlobalCustomer.CustomerName,
                    VideoTitle = cmbbxVideos.Text,
                    Category = GlobalVideo.Category,
                    Status = "On Rent",
                    DueDate = dueDate,
                    RentDate = DateTime.Now,
                    PenaltyFee = 0,
                    RentFee = GlobalVideo.Price, 
                    SerialNo = txtbxSerialNo.Text,
                });

                datagridList.DataSource = null;
                datagridList.DataSource = GlobalTransaction.TransactionList;

                GlobalTransaction.TotalAmount = calculateTotal(int.Parse(txtbxPrice.Text), previousAmount);
                previousAmount = GlobalTransaction.TotalAmount;
                lblTotalAmount.Text = $"₱{GlobalTransaction.TotalAmount}.00";
            }
            else MessageBox.Show("Limit of 10 videos reached.");
        }

        private void cmbbxDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbbxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVideo.VideoID = int.Parse(cmbbxVideos.SelectedValue.ToString());

            GlobalVideo.Category = GlobalVideo.VideoList.Where(video => video.VideoID == GlobalVideo.VideoID).Select(video => video.Category).FirstOrDefault();
            GlobalVideo.Price = GlobalVideo.VideoList.Where(video => video.VideoID == GlobalVideo.VideoID).Select(video => video.Price).FirstOrDefault();

            txtbxCategory.Text = GlobalVideo.Category;
            txtbxPrice.Text = GlobalVideo.Price.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int rowIndex = datagridList.SelectedRows[0].Index;

            DialogResult result = MessageBox.Show("Are you sure you want to remove this?", "Removing Video", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                GlobalTransaction.TotalAmount -= int.Parse(datagridList.CurrentRow.Cells["RentFee"].Value.ToString());
                lblTotalAmount.Text = $"₱{GlobalTransaction.TotalAmount.ToString()}.00";
                 
                GlobalTransaction.TransactionList.RemoveAt(rowIndex);
                datagridList.DataSource = null;
                datagridList.DataSource = GlobalTransaction.TransactionList;

                if (GlobalTransaction.TransactionList.Count == 0)
                    cmbbxCustomer.Enabled = true;
            }
            else return;
        }

        private void datagridList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Utility.HideColumns(datagridList, "CustomerName", "VideoID", "CustomerID", "DatePaid", "PenaltyFee");
            Utility.SplitColumnHeaderTexts(datagridList);

            cmbbxCustomer.Enabled = false;
        }

        private void cmbbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbbxCustomer.Text))
            {
                GlobalCustomer.CustomerName = cmbbxCustomer.Text;
                GlobalCustomer.CustomerID = int.Parse(cmbbxCustomer.SelectedValue.ToString());
            }
        }
    }
}
