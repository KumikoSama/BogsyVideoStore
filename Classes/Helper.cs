using BogsyVideoStore.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BogsyVideoStore.Classes
{
    public class Helper
    {
        public static bool LogIn()
        {
            try
            {
                CurrentCustomer currentCustomer = new CurrentCustomer();
                string parseContactInfo, parsePass;

                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LogIn", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@ContactInfo", currentCustomer.ContactInfo),
                        new SqlParameter("@Password", currentCustomer.ContactInfo)
                    });

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            parseContactInfo = reader.GetString(1);
                            parsePass = reader.GetString(2);

                            if (parseContactInfo == currentCustomer.ContactInfo)
                            {
                                if (parsePass == currentCustomer.Password)
                                {
                                    currentCustomer.CustomerID = reader.GetInt16(0);
                                    return true;
                                }
                            }
                            else throw new Exception("No accounts found");
                        }
                        else throw new Exception("No accounts found");
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public static void Registration()
        {
            try
            {
                Customer customer = new Customer();

                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Registration", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@FirstName", customer.FirstName),
                        new SqlParameter("@LastName", customer.LastName),
                        new SqlParameter("@Age", customer.Age),
                        new SqlParameter("@ContactInfo", customer.ContactInfo),
                        new SqlParameter("@Address", customer.Address),
                        new SqlParameter("@Password", customer.Password)
                    });

                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
        }
    }
}
