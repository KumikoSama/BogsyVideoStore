using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogsyVideoStore.Models
{
    public class Video
    {
        string rating;

        public int VideoID { get; set; }
        public string Title { get; set; }
        public string ProductionStudio { get; set; }
        public string Runtime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string Rating 
        {
            get { return rating; }
            set => rating = (value == "G" || value == "PG" || value == "PG-13" || value == "R") ? value : "NR";
        }
    }
}
