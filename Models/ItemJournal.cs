using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class ItemJournal
    {
        public string DocumentNo { get; set; }
        public int VideoID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; } = 1;
        public string SerialNo { get; set; }
        public string EntryType { get; set; }
    }
    
    public class GlobalItemJournal
    {
        public static List<ItemJournal> ItemsList = new List<ItemJournal>();
    }
}
