using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class ReceiptModel
    {
        public string CustomerName { get; set; }
        public string VideoTitle { get; set; }
        public string Category { get; set; }
        public int RentFee { get; set; }
        public int PenaltyFee { get; set; }
        public static int TotalAmount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DatePaid { get; } = DateTime.Now;
    }

    public class ReceiptList
    {
        public static List<ReceiptModel> Receipts = new List<ReceiptModel>();
    }
}
