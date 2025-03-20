using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BogsyVideoStore.Classes
{
    public class Validator
    {
        public static bool ValidateCustomerInformation(string name, string number)
        {
            string query = "SELECT COUNT (*) FROM CustomerTable WHERE @CustomerName = CustomerName AND @ContactInfo = ContactInfo";
            
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", name);
                cmd.Parameters.AddWithValue("@ContactInfo", number);

                conn.Open();
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Customer information already exists");
                    return false;
                }
                
                return true;
            }
        }

        public static bool ValidateContactInfo(string contactinfo)
        {
            try
            {
                if (string.IsNullOrEmpty(contactinfo))
                    throw new FormatException();

                string phonenumpattern = @"^\+63\d{10}$";

                if (Regex.IsMatch(contactinfo, phonenumpattern)) return true;
                else throw new Exception("Phone number is in an invalid format");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
