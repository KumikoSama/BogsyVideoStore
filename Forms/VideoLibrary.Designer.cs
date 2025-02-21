namespace BogsyVideoStore.Forms
{
    partial class VideoLibrary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagridVideos = new System.Windows.Forms.DataGridView();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxProductionStudio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbxCategory = new System.Windows.Forms.ComboBox();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxHours = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbbxMinutes = new System.Windows.Forms.ComboBox();
            this.cmbbxSeconds = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbbxRating = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimeReleaseDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridVideos
            // 
            this.datagridVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVideos.Location = new System.Drawing.Point(26, 24);
            this.datagridVideos.Name = "datagridVideos";
            this.datagridVideos.Size = new System.Drawing.Size(414, 409);
            this.datagridVideos.TabIndex = 0;
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Location = new System.Drawing.Point(558, 64);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(182, 20);
            this.txtbxTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // txtbxProductionStudio
            // 
            this.txtbxProductionStudio.Location = new System.Drawing.Point(558, 117);
            this.txtbxProductionStudio.Name = "txtbxProductionStudio";
            this.txtbxProductionStudio.Size = new System.Drawing.Size(182, 20);
            this.txtbxProductionStudio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Production Studio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Runtime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category";
            // 
            // cmbbxCategory
            // 
            this.cmbbxCategory.FormattingEnabled = true;
            this.cmbbxCategory.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.cmbbxCategory.Location = new System.Drawing.Point(558, 296);
            this.cmbbxCategory.Name = "cmbbxCategory";
            this.cmbbxCategory.Size = new System.Drawing.Size(89, 21);
            this.cmbbxCategory.TabIndex = 9;
            this.cmbbxCategory.Text = "DVD";
            this.cmbbxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbbxCategory_SelectedIndexChanged);
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(653, 297);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.ReadOnly = true;
            this.txtbxPrice.Size = new System.Drawing.Size(87, 20);
            this.txtbxPrice.TabIndex = 10;
            this.txtbxPrice.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // cmbbxHours
            // 
            this.cmbbxHours.FormattingEnabled = true;
            this.cmbbxHours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbbxHours.Location = new System.Drawing.Point(558, 240);
            this.cmbbxHours.Name = "cmbbxHours";
            this.cmbbxHours.Size = new System.Drawing.Size(46, 21);
            this.cmbbxHours.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = ":";
            // 
            // cmbbxMinutes
            // 
            this.cmbbxMinutes.FormattingEnabled = true;
            this.cmbbxMinutes.Items.AddRange(new object[] {
            "1",
            "2 ",
            "3 ",
            "4",
            "5 ",
            "6 ",
            "7 ",
            "8 ",
            "9",
            "10",
            "11 ",
            "12 ",
            "13 ",
            "14 ",
            "15 ",
            "16 ",
            "17 ",
            "18",
            "19 ",
            "20 ",
            "21 ",
            "22 ",
            "23 ",
            "24 ",
            "25 ",
            "26 ",
            "27 ",
            "28 ",
            "29 ",
            "30 ",
            "31 ",
            "32 ",
            "33 ",
            "34 ",
            "35 ",
            "36 ",
            "37 ",
            "38 ",
            "39 ",
            "40 ",
            "41 ",
            "42 ",
            "43 ",
            "44 ",
            "45 ",
            "46 ",
            "47 ",
            "48 ",
            "49 ",
            "50 ",
            "51 ",
            "52 ",
            "53 ",
            "54 ",
            "55 ",
            "56 ",
            "57 ",
            "58 ",
            "59 "});
            this.cmbbxMinutes.Location = new System.Drawing.Point(626, 240);
            this.cmbbxMinutes.Name = "cmbbxMinutes";
            this.cmbbxMinutes.Size = new System.Drawing.Size(46, 21);
            this.cmbbxMinutes.TabIndex = 14;
            // 
            // cmbbxSeconds
            // 
            this.cmbbxSeconds.FormattingEnabled = true;
            this.cmbbxSeconds.Items.AddRange(new object[] {
            "1",
            "2 ",
            "3 ",
            "4",
            "5 ",
            "6 ",
            "7 ",
            "8 ",
            "9",
            "10",
            "11 ",
            "12 ",
            "13 ",
            "14 ",
            "15 ",
            "16 ",
            "17 ",
            "18",
            "19 ",
            "20 ",
            "21 ",
            "22 ",
            "23 ",
            "24 ",
            "25 ",
            "26 ",
            "27 ",
            "28 ",
            "29 ",
            "30 ",
            "31 ",
            "32 ",
            "33 ",
            "34 ",
            "35 ",
            "36 ",
            "37 ",
            "38 ",
            "39 ",
            "40 ",
            "41 ",
            "42 ",
            "43 ",
            "44 ",
            "45 ",
            "46 ",
            "47 ",
            "48 ",
            "49 ",
            "50 ",
            "51 ",
            "52 ",
            "53 ",
            "54 ",
            "55 ",
            "56 ",
            "57 ",
            "58 ",
            "59 "});
            this.cmbbxSeconds.Location = new System.Drawing.Point(694, 241);
            this.cmbbxSeconds.Name = "cmbbxSeconds";
            this.cmbbxSeconds.Size = new System.Drawing.Size(46, 21);
            this.cmbbxSeconds.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Minutes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(691, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Seconds";
            // 
            // cmbbxRating
            // 
            this.cmbbxRating.FormattingEnabled = true;
            this.cmbbxRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NR"});
            this.cmbbxRating.Location = new System.Drawing.Point(558, 351);
            this.cmbbxRating.Name = "cmbbxRating";
            this.cmbbxRating.Size = new System.Drawing.Size(182, 21);
            this.cmbbxRating.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Rating";
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(613, 389);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAddVideo.TabIndex = 22;
            this.btnAddVideo.Text = "Add";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(558, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "ReleaseDate";
            // 
            // dateTimeReleaseDate
            // 
            this.dateTimeReleaseDate.Location = new System.Drawing.Point(558, 168);
            this.dateTimeReleaseDate.Name = "dateTimeReleaseDate";
            this.dateTimeReleaseDate.Size = new System.Drawing.Size(182, 20);
            this.dateTimeReleaseDate.TabIndex = 25;
            // 
            // VideoLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.dateTimeReleaseDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAddVideo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbbxRating);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbbxSeconds);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbbxMinutes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbbxHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.cmbbxCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxProductionStudio);
            this.Controls.Add(this.txtbxTitle);
            this.Controls.Add(this.datagridVideos);
            this.Name = "VideoLibrary";
            this.Text = "VideoLibrary";
            ((System.ComponentModel.ISupportInitialize)(this.datagridVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridVideos;
        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxProductionStudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbxCategory;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbxMinutes;
        private System.Windows.Forms.ComboBox cmbbxSeconds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbbxRating;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimeReleaseDate;
    }
}