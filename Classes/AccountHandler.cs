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
    public class AccountHandler
    {
        public static bool LogIn(CurrentCustomer currentCustomer)
        {
            try
            {
                string parseContactInfo, parsePass;

                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("LogIn", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@ContactInfo", currentCustomer.ContactInfo),
                        new SqlParameter("@Password", currentCustomer.ContactInfo),
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
                                    CurrentCustomer.Role = reader.GetString(3);
                                    return true;
                                }
                            }
                            else throw new Exception("No accounts found");
                        }
                        else throw new Exception("No accounts found");
                    }
                }
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void Registration(Customer customer)
        {
            try
            {
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
                        new SqlParameter("@Password", customer.Password),
                        new SqlParameter("@Role", customer.Role)
                    });

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
