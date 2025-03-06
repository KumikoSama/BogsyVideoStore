using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using Microsoft.Data.SqlClient;
using System;
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
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            txtbxTitle.Text = GlobalVideo.Title;
            txtbxCategory.Text = GlobalVideo.Category;
            txtbxPrice.Text = GlobalVideo.Price.ToString();

            cmbbxVideos.SelectedIndexChanged -= cmbbxVideos_SelectedIndexChanged;
            Utility.LoadVideosInComboBox(cmbbxVideos);
            cmbbxVideos.SelectedIndexChanged += cmbbxVideos_SelectedIndexChanged;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (datagridList.DataSource != null)
            {
                foreach (var transaction in GlobalTransaction.TransactionList)
                {
                    Utility.ExecuteQuery("InsertToRental", true, new SqlParameter("@VideoID", transaction.VideoID), new SqlParameter("@CustomerID", GlobalCustomer.CustomerID), new SqlParameter("@RentDate", transaction.RentDate),
                            new SqlParameter("@DueDate", transaction.DueDate), new SqlParameter("@RentFee", transaction.RentFee), new SqlParameter("@PenaltyFee", transaction.PenaltyFee), new SqlParameter("@Status", transaction.Status));
                }
            }
            else MessageBox.Show("Add transaction to the list first");

            MessageBox.Show("Video successfully rented");

            this.Close();

            Receipt receipt = new Receipt(GlobalTransaction.TotalAmount);
            receipt.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dueDate = DateTime.Now.AddDays(int.Parse(cmbbxDays.Text));

            GlobalTransaction.TransactionList.Add(new Transaction
            {
                VideoID = GlobalVideo.VideoID,
                Status = "On Rent",
                DueDate = dueDate,
                RentDate = DateTime.Now,
                IsReturned = false,
                PenaltyFee = 0,
                RentFee = GlobalVideo.Price
            });

            datagridList.DataSource = null;
            datagridList.DataSource = GlobalTransaction.TransactionList;

            GlobalTransaction.TotalAmount = calculateTotal(int.Parse(txtbxPrice.Text), previousAmount);
            previousAmount = GlobalTransaction.TotalAmount;
            lblTotalAmount.Text = GlobalTransaction.TotalAmount.ToString();
        }

        private void cmbbxDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbbxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVideo.VideoID = int.Parse(cmbbxVideos.SelectedValue.ToString());
            Utility.GetCategoryAndPrice();

            txtbxTitle.Text = cmbbxVideos.Text;
            txtbxCategory.Text = GlobalVideo.Category;
            txtbxPrice.Text = GlobalVideo.Price.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int rowIndex = datagridList.SelectedRows[0].Index;

            DialogResult result = MessageBox.Show("Are you sure you want to remove this?", "Removing Video", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                GlobalTransaction.TransactionList.RemoveAt(rowIndex);
                datagridList.DataSource = null;
                datagridList.DataSource = GlobalTransaction.TransactionList;
            }
            else return;
        }
    }
}
