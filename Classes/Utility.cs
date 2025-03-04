using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BogsyVideoStore.Properties;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;
using Microsoft.Reporting.WinForms;

namespace BogsyVideoStore.Classes
{
    public class Utility
    {
        public static DataTable LoadData(string query, bool isCustomer, bool isStoredProcedure)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                if (isStoredProcedure)
                    cmd.CommandType = CommandType.StoredProcedure;

                if (isCustomer)
                    cmd.Parameters.AddWithValue("@CustomerID", GlobalCustomer.CustomerID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public static void ExecuteQuery(string query, bool isStoredProcedure, params SqlParameter[] parameterSets)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (isStoredProcedure)
                        cmd.CommandType = CommandType.StoredProcedure;

                    if (parameterSets != null)
                        cmd.Parameters.AddRange(parameterSets);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadVideosInComboBox(ComboBox comboBox)
        {
            string query = "SELECT VideoID, Title, Category, Price FROM VideoTable WHERE Copies > 0";
            GlobalVideo.VideoList.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GlobalVideo.VideoList.Add(new Video
                        {
                            VideoID = int.Parse(reader["VideoID"].ToString()),
                            Title = reader["Title"].ToString(),
                            Category = reader["Category"].ToString(),
                            Price = int.Parse(reader["Price"].ToString())
                        });
                    }
                }
            }

            comboBox.DataSource = null;
            comboBox.DataSource = GlobalVideo.VideoList;
            comboBox.DisplayMember = "Title";
            comboBox.ValueMember = "VideoID";
        }

        public static DataTable LoadDataByCustomerAndCategory(string query, string category, bool isCustomer)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Category", category != "All" ? category : null);
                if (isCustomer)
                    cmd.Parameters.AddWithValue("@CustomerID", GlobalCustomer.CustomerID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public static void LoadCustomers(ComboBox comboBox)
        {
            string query = "SELECT CustomerID, CustomerName FROM CustomerTable";
            var customers = new List<Customer>
            {
                new Customer { CustomerName = "All", CustomerID = 0 },
            };

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString()
                        });
                    }
                }
            }

            comboBox.DataSource = customers;
            comboBox.DisplayMember = "CustomerName";
            comboBox.ValueMember = "CustomerID";
        }

        public static void GenerateReport(ReportViewer reportViewer)
        {
            string query = "SELECT * FROM RentalTable";

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                reportViewer.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
                reportViewer.LocalReport.ReportPath = "Reports.rdlc";
                reportViewer.LocalReport.DataSources.Add(reportDataSource);

                reportViewer.RefreshReport();
                reportViewer.Refresh();
            }
        }

        public static void GetCategoryAndPrice()
        {
            GlobalVideo.Category = GlobalVideo.VideoList.Where(video => video.VideoID == GlobalVideo.VideoID).Select(video => video.Category).FirstOrDefault();
            GlobalVideo.Price = GlobalVideo.VideoList.Where(video => video.VideoID == GlobalVideo.VideoID).Select(video => video.Price).FirstOrDefault();
        }

        public static void HideColumns(DataGridView dt, params string[] columnNames)
        {
            foreach (string item in columnNames)
                dt.Columns[item].Visible = false; 
        }
    }
}
