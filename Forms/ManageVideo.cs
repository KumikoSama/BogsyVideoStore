﻿using BogsyVideoStore.Classes;
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
            if (!string.IsNullOrEmpty(txtbxTitle.Text))
            {
                Video video = new Video
                {
                    Title = txtbxTitle.Text,
                    Category = cmbbxCategory.SelectedItem.ToString(),
                    Price = int.Parse(txtbxPrice.Text),
                };

                Utility.ExecuteQuery(Queries.AddNewVideo, false, new SqlParameter("@Title", video.Title), new SqlParameter("@Category", video.Category),
                    new SqlParameter("@Price", video.Price), new SqlParameter("@Copies", video.Copies));

                MessageBox.Show("Video successfully added");
                this.Close();
            }
            else
                MessageBox.Show("One of the fields are empty");
        }

        private void btnEditVideo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you'll edit this video?", "Video Edit Confirmation",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                GlobalVideo.Title = txtbxTitle.Text;
                GlobalVideo.Price = int.Parse(txtbxPrice.Text);
                GlobalVideo.Category = cmbbxCategory.Text;

                Utility.ExecuteQuery(Queries.EditVideo, false, new SqlParameter("@Title", GlobalVideo.Title), new SqlParameter("@Category", GlobalVideo.Category),
                    new SqlParameter("@Price", GlobalVideo.Price), new SqlParameter("@Copies", GlobalVideo.Copies), new SqlParameter("@VideoID", GlobalVideo.VideoID));

                this.Close();
            }
            else return;
        }

        private void cmbbxCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
