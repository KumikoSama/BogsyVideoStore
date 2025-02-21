using BogsyVideoStore.Classes;
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
using BogsyVideoStore.Models;

namespace BogsyVideoStore.Forms
{
    public partial class ManageVideo : Form
    {
        bool isEdit;

        public ManageVideo(bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
        }

        private void ManageVideo_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                btnEditVideo.Show();
                txtbxTitle.Text = GlobalVideo.Title;
                txtbxPrice.Text = GlobalVideo.Price.ToString();
                txtbxCopies.Text = GlobalVideo.Copies.ToString();
                cmbbxCategory.Text = GlobalVideo.Category;
            }
        }

        private void cmbbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxCategory.SelectedItem.ToString() == "DVD")
                txtbxPrice.Text = "50";
            else
                txtbxPrice.Text = "25";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Video video = new Video
            {
                Title = txtbxTitle.Text,
                Category = cmbbxCategory.SelectedItem.ToString(),
                Price = int.Parse(txtbxPrice.Text)
            };

            Utility.ExecuteQuery("Video added", Queries.AddNewVideo, false, new SqlParameter("@Title", video.Title), new SqlParameter("@Category", video.Category),
                new SqlParameter("@Price", video.Price));

            this.Close();
        }

        private void btnEditVideo_Click(object sender, EventArgs e)
        {
            Utility.ExecuteQuery("Video edited", Queries.EditVideo, false, new SqlParameter("@Title", GlobalVideo.Title), new SqlParameter("@Category", GlobalVideo.Category),
                new SqlParameter("@Price", GlobalVideo.Price), new SqlParameter("@Copies", GlobalVideo.Copies), new SqlParameter("@VideoID", GlobalVideo.VideoID));
        }
    }
}
