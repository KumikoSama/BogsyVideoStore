using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class CurrentCustomer
    {
        static string role;

        public static int CustomerID { get; set; }
        public string ContactInfo { get; set; }
        public string Password { get; set; }
        public static string Role { get { return role; } set => role = (value == "Customer") ? value : "Admin"; }
    }
}
