using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class Receipt
    {
        public string CustomerName { get; set; }
        public string VideoTitle { get; set; }
        public string Category { get; set; }
        public int RentFee { get; set; }
        public int PenaltyFee { get; set; }
        public int TotalAmount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DatePaid { get; set; }
    }
}
