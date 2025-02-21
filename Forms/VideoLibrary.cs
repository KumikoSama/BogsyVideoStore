using BogsyVideoStore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogsyVideoStore.Forms
{
    public partial class VideoLibrary : Form
    {
        public VideoLibrary()
        {
            InitializeComponent();
            datagridVideos.DataSource = Utility.LoadData("LoadAllVideos");
        }
    }
}
