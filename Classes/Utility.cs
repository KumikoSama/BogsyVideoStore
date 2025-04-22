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
using System.Text.RegularExpressions;

namespace BogsyVideoStore.Classes
{
    public class Utility
    {
        public static DataTable LoadData(string query, bool isStoredProcedure, bool ShowUnavailable = false)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                if (isStoredProcedure)
                    cmd.CommandType = CommandType.StoredProcedure;

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

        public static void GetTransactions()
        {
            string query = "SELECT * FROM RentalTable";
            GlobalTransaction.TransactionList.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GlobalTransaction.TransactionList.Add(new Transaction
                        {
                            RentalID = int.Parse(reader["RentalID"].ToString()),
                            VideoID = int.Parse(reader["VideoID"].ToString()),
                            VideoTitle = GlobalVideo.VideoList.FirstOrDefault(v => v.VideoID == int.Parse(reader["VideoID"].ToString())).Title,
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = GlobalCustomer.CustomerList.FirstOrDefault(c => c.CustomerID == int.Parse(reader["CustomerID"].ToString())).CustomerName,
                            RentDate = Convert.ToDateTime(reader["RentDate"].ToString()),
                            DueDate = Convert.ToDateTime(reader["DueDate"].ToString()),
                            ReturnDate = reader["ReturnDate"].ToString() ?? null,
                            RentFee = int.Parse(reader["RentFee"].ToString()),
                            PenaltyFee = int.Parse(reader["PenaltyFee"].ToString()),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
        }

        public static void GetVideosInfo(ComboBox comboBox = null)
        {
            string query = "SELECT * FROM VideoTable";
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
                            Price = int.Parse(reader["Price"].ToString()),
                            Copies = int.Parse(reader["Copies"].ToString()),
                            CopiesOnRent = int.Parse(reader["CopiesOnRent"].ToString())
                        });
                    }
                }
            }

            if (comboBox != null)
            {
                comboBox.DataSource = null;
                comboBox.DataSource = GlobalVideo.VideoList;
                comboBox.DisplayMember = "Title";
                comboBox.ValueMember = "VideoID"; 
            }
        }

        public static void GetItemLedgerEntries()
        {
            GlobalItemJournal.ItemsList.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Queries.LoadItemLedgerEntry, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GlobalItemJournal.ItemsList.Add(new ItemJournal
                        {
                            DocumentNo = reader["DocumentNo."].ToString(),
                            VideoID = int.Parse(reader["VideoID"].ToString()),
                            Title = reader["Title"].ToString(),
                            Quantity = int.Parse(reader["Quantity"].ToString()),
                            SerialNo = reader["SerialNo."].ToString(),
                            EntryType = reader["Type"].ToString()
                        });
                    }
                }
            }
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

        public static void GetCustomersInfo(ComboBox comboBox)
        {
            string query = "SELECT * FROM CustomerTable";

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GlobalCustomer.CustomerList.Add(new Customer
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            ContactInfo = reader["ContactInfo"].ToString()
                        });
                    }
                }
            }

            comboBox.DataSource = GlobalCustomer.CustomerList;
            comboBox.DisplayMember = "CustomerName";
            comboBox.ValueMember = "CustomerID";
        }

        public static void GenerateCustomerReport(ReportViewer reportViewer)
        {
            reportViewer.LocalReport.DataSources.Clear();
            var customerData = GlobalTransaction.TransactionList
                .Where(t => (GlobalCustomer.CustomerID == 0 || t.CustomerID == GlobalCustomer.CustomerID) && t.Status == "On Rent")
                .Select(t => new
                {
                    t.CustomerName,
                    t.VideoID,
                    t.VideoTitle,
                    t.RentDate,
                    t.DueDate,
                    t.ReturnDate,
                    t.RentFee,
                    t.PenaltyFee,
                    t.Status
                }).ToList();

            ReportDataSource reportDataSource = new ReportDataSource("CustomerData", customerData);
            reportViewer.LocalReport.ReportPath = "CustomerReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            ReportParameter[] reportParams = new ReportParameter[]
            {
                new ReportParameter("CustomerID", GlobalCustomer.CustomerID.ToString() ?? null),
                new ReportParameter("CustomerName", GlobalCustomer.CustomerName != null ? "Customer Name: " + GlobalCustomer.CustomerName : "(All Customers)")
            };

            reportViewer.LocalReport.SetParameters(reportParams);

            reportViewer.RefreshReport();
            reportViewer.Refresh();
        }

        public static void GenerateVideoReport(ReportViewer reportViewer)
        {
            reportViewer.LocalReport.DataSources.Clear();

            ReportDataSource reportDataSource = new ReportDataSource("VideoDataSet", GlobalVideo.VideoList);
            reportViewer.LocalReport.ReportPath = "VideosReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(reportDataSource);

            reportViewer.RefreshReport();
            reportViewer.Refresh();
        }

        public static void GenerateReceipt(ReportViewer reportViewerReceipt, bool isPenaltyFee)
        {
            reportViewerReceipt.LocalReport.DataSources.Clear();

            ReportDataSource reportDataSource = new ReportDataSource(isPenaltyFee ? "Receipt" : "NewTransaction", GlobalTransaction.TransactionList);
            reportViewerReceipt.LocalReport.ReportPath = isPenaltyFee ? "PenaltyFeeReceipt.rdlc" : "TransactionReceipt.rdlc";
            reportViewerReceipt.LocalReport.DataSources.Add(reportDataSource);

            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("TotalAmount", GlobalTransaction.TotalAmount.ToString()),
                new ReportParameter("Payment", GlobalTransaction.Payment.ToString()),
                new ReportParameter("Change", GlobalTransaction.Change.ToString()),
                new ReportParameter("DocumentNo", GlobalItemJournal.DocumentNo.ToString()),
            };

            reportViewerReceipt.LocalReport.SetParameters(reportParameters);
            reportViewerReceipt.RefreshReport(); 
            reportViewerReceipt.Refresh();
            GlobalTransaction.TransactionList.Clear();
        }

        public static bool CheckExistingRent(string serialNo)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(Queries.GetExistingRent, conn);

                cmd.Parameters.AddWithValue("@VideoID", GlobalVideo.VideoID);
                cmd.Parameters.AddWithValue("@SerialNo", serialNo);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        return false;
                }
            }
            return true;
        }

        public static void GetSerialNo(ComboBox cmbbxSerialNo)
        {
            SerialNoList.SerialNos.Clear();

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetSerialNo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VideoID", GlobalVideo.VideoID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SerialNoList.SerialNos.Add(new SerialNo
                        {
                            SerialNoId = reader["SerialNoID"].ToString(),
                            VideoId = int.Parse(reader["VideoID"].ToString()),
                            SerialNumber = reader["SerialNo."].ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }
        }


        public static void SplitColumnHeaderTexts(DataGridView dt)
        {
            foreach (DataGridViewColumn column in dt.Columns)
                column.HeaderText = Regex.Replace(column.HeaderText, @"(?<!^)(?=[A-Z])", " ");
        }

        public static void HideColumns(DataGridView dt, params string[] columnNames)
        {
            foreach (string item in columnNames)
                dt.Columns[item].Visible = false; 
        }
    }
}
