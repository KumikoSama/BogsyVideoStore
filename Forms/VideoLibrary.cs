using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
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

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            Video video = new Video
            {
                Title = txtbxTitle.Text,
                ProductionStudio = txtbxProductionStudio.Text,
                Runtime = $"{cmbbxHours.Text}:{cmbbxMinutes.Text}:{cmbbxSeconds.Text}",
                ReleaseDate = dateTimeReleaseDate.Value,
                Category = cmbbxCategory.Text,
                Price = int.Parse(txtbxPrice.Text),
                Rating = cmbbxCategory.Text
            };

            Utility.ExecuteQuery("Video added successfully", "AddNewVideo", new SqlParameter("@Title", video.Title), new SqlParameter("@ProductionStudio", video.ProductionStudio), new SqlParameter("@Runtime", video.Runtime),
                new SqlParameter("@Category", video.Category), new SqlParameter("@Rating", video.Rating), new SqlParameter("@ReleaseDate", video.ReleaseDate), new SqlParameter("@Price", video.Price));
            
            datagridVideos.DataSource = Utility.LoadData("LoadAllVideos");
        }

        private void cmbbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxCategory.SelectedItem.ToString() == "DVD")
                txtbxPrice.Text = "50";
            else
                txtbxPrice.Text = "25";
        }
    }
}
