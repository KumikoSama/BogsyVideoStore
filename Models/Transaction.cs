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
        public string RentDate { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
        public bool IsReturned { get; set; }
        public int PenaltyFee { get; set; }

    }
}
