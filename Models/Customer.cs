using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ContactInfo { get; set; }
    }

    public class GlobalCustomer
    {
        public static List<Customer> CustomerList = new List<Customer>();
        public static int CustomerID { get; set; }
        public static string CustomerName { get; set; }
        public static string ContactInfo { get; set; }
    }
}
