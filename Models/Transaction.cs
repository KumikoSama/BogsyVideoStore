using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class Transaction
    {
        public int RentalID { get; set; }
        public int VideoID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string VideoTitle { get; set; }
        public string Category { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public string ReturnDate { get; set; }
        public DateTime DatePaid { get; } = DateTime.Now;
        public string Status { get; set; }
        public int PenaltyFee { get; set; }
        public int RentFee { get; set; }
    }

    public class GlobalTransaction
    {
        public static List<Transaction> TransactionList = new List<Transaction>();
        public static int RentalID { get; set; }
        public static int VideoID { get; set; }
        public static int TotalAmount { get; set; }
        public static int Change { get; set; }
        public static int Payment { get; set; }
    }
}
