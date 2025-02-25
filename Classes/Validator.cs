using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BogsyVideoStore.Classes
{
    public class Validator
    {
        public static bool ValidateName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Invalid input");
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool ValidateContactInfo(string contactinfo)
        {
            try
            {
                if (string.IsNullOrEmpty(contactinfo))
                    throw new FormatException();

                string phonenumpattern = @"^\+63\d{10}$";

                if (Regex.IsMatch(contactinfo, phonenumpattern))
                    return true;
                else 
                    throw new FormatException("Invalid phone number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
