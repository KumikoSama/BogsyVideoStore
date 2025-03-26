namespace BogsyVideoStore.Forms
{
    partial class ManageVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageVideo));
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbbxCategory = new System.Windows.Forms.ComboBox();
            this.txtbxCopies = new System.Windows.Forms.TextBox();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxRating = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(173, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Price";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPrice.Location = new System.Drawing.Point(129, 207);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.ReadOnly = true;
            this.txtbxPrice.Size = new System.Drawing.Size(160, 22);
            this.txtbxPrice.TabIndex = 24;
            this.txtbxPrice.Text = "50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "Copies";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(129, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Title";
            // 
            // cmbbxCategory
            // 
            this.cmbbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbxCategory.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCategory.FormattingEnabled = true;
            this.cmbbxCategory.Items.AddRange(new object[] {
            "DVD",
            "VCD"});
            this.cmbbxCategory.Location = new System.Drawing.Point(129, 154);
            this.cmbbxCategory.Name = "cmbbxCategory";
            this.cmbbxCategory.Size = new System.Drawing.Size(160, 22);
            this.cmbbxCategory.TabIndex = 20;
            this.cmbbxCategory.Text = "DVD";
            this.cmbbxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbbxCategory_SelectedIndexChanged);
            this.cmbbxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbxCategory_KeyPress);
            // 
            // txtbxCopies
            // 
            this.txtbxCopies.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCopies.Location = new System.Drawing.Point(129, 264);
            this.txtbxCopies.Name = "txtbxCopies";
            this.txtbxCopies.Size = new System.Drawing.Size(160, 22);
            this.txtbxCopies.TabIndex = 19;
            this.txtbxCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCopies_KeyPress);
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTitle.Location = new System.Drawing.Point(129, 95);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(160, 22);
            this.txtbxTitle.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 40);
            this.label5.TabIndex = 27;
            this.label5.Text = "Manage Video";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditVideo
            // 
            this.btnEditVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnEditVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVideo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnEditVideo.Location = new System.Drawing.Point(173, 386);
            this.btnEditVideo.Name = "btnEditVideo";
            this.btnEditVideo.Size = new System.Drawing.Size(75, 23);
            this.btnEditVideo.TabIndex = 28;
            this.btnEditVideo.Text = "Edit";
            this.btnEditVideo.UseVisualStyleBackColor = false;
            this.btnEditVideo.Visible = false;
            this.btnEditVideo.Click += new System.EventHandler(this.btnEditVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 30;
            this.label1.Text = "Rating";
            // 
            // cmbbxRating
            // 
            this.cmbbxRating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbxRating.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxRating.FormattingEnabled = true;
            this.cmbbxRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"});
            this.cmbbxRating.Location = new System.Drawing.Point(129, 323);
            this.cmbbxRating.Name = "cmbbxRating";
            this.cmbbxRating.Size = new System.Drawing.Size(160, 22);
            this.cmbbxRating.TabIndex = 20;
            this.cmbbxRating.Text = "PG";
            this.cmbbxRating.SelectedIndexChanged += new System.EventHandler(this.cmbbxCategory_SelectedIndexChanged);
            this.cmbbxRating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbxCategory_KeyPress);
            // 
            // ManageVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(422, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbbxRating);
            this.Controls.Add(this.cmbbxCategory);
            this.Controls.Add(this.txtbxCopies);
            this.Controls.Add(this.txtbxTitle);
            this.Controls.Add(this.btnEditVideo);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Video";
            this.Load += new System.EventHandler(this.ManageVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbbxCategory;
        private System.Windows.Forms.TextBox txtbxCopies;
        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxRating;
    }
}