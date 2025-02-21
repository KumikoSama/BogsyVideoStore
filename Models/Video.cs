using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class Video
    {
        public int VideoID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Copies { get; set; }
        public int CopiesBorrowed { get; set; }
    }

    public class GlobalVideo
    {
        public static int VideoID { get; set; }
        public static string Title { get; set; }
        public static string Category { get; set; }
        public static int Price { get; set; }
        public static int Copies { get; set; }
        public static int CopiesBorrowed { get; set; }
    }
}
