using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class Transaction
    {
        public int VideoID { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public bool IsReturned { get; set; }
        public int PenaltyFee { get; set; }
        public int RentFee { get; set; }
    }

    public class GlobalTransaction
    {
        public static List<Transaction> TransactionList = new List<Transaction>();
        public static int RentalID { get; set; }
        public static int VideoID { get; set; }
        public static int CustomerID { get; set; }
        public static DateTime RentDate { get; set; }
        public static DateTime DueDate { get; set; }
        public static string Status { get; set; }
        public static int PenaltyFee { get; set; }
        public static int RentFee { get; set; }
        public static int TotalAmount { get; set; }
    }
}
