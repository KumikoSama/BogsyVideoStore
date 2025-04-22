using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class SerialNo
    {
        public string SerialNoId { get; set; }
        public int VideoId { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
    }

    public static class SerialNoList
    {
        public static List<SerialNo> SerialNos { get; set; } = new List<SerialNo>();
    }
}
