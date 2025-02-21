namespace BogsyVideoStore.Forms
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RentReturn = new System.Windows.Forms.TabPage();
            this.btnPastTransactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxCustomer = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.datagridVideos = new System.Windows.Forms.DataGridView();
            this.CustomerLibrary = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.datagridCustomer = new System.Windows.Forms.DataGridView();
            this.VideoLibrary = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteVideo = new System.Windows.Forms.Button();
            this.btnEditVideo = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.datagridVidLibrary = new System.Windows.Forms.DataGridView();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnOngoingRent = new System.Windows.Forms.Button();
            this.btnAllReports = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.RentReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVideos)).BeginInit();
            this.CustomerLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomer)).BeginInit();
            this.VideoLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVidLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RentReturn);
            this.tabControl1.Controls.Add(this.CustomerLibrary);
            this.tabControl1.Controls.Add(this.VideoLibrary);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 470);
            this.tabControl1.TabIndex = 10;
            // 
            // RentReturn
            // 
            this.RentReturn.Controls.Add(this.btnAllReports);
            this.RentReturn.Controls.Add(this.btnOngoingRent);
            this.RentReturn.Controls.Add(this.btnPastTransactions);
            this.RentReturn.Controls.Add(this.label1);
            this.RentReturn.Controls.Add(this.cmbbxCustomer);
            this.RentReturn.Controls.Add(this.btnReturn);
            this.RentReturn.Controls.Add(this.btnRent);
            this.RentReturn.Controls.Add(this.datagridVideos);
            this.RentReturn.Location = new System.Drawing.Point(4, 22);
            this.RentReturn.Name = "RentReturn";
            this.RentReturn.Padding = new System.Windows.Forms.Padding(3);
            this.RentReturn.Size = new System.Drawing.Size(949, 444);
            this.RentReturn.TabIndex = 0;
            this.RentReturn.Text = "Rent and Return";
            this.RentReturn.UseVisualStyleBackColor = true;
            // 
            // btnPastTransactions
            // 
            this.btnPastTransactions.Location = new System.Drawing.Point(811, 398);
            this.btnPastTransactions.Name = "btnPastTransactions";
            this.btnPastTransactions.Size = new System.Drawing.Size(105, 25);
            this.btnPastTransactions.TabIndex = 15;
            this.btnPastTransactions.Text = "Past Transactions";
            this.btnPastTransactions.UseVisualStyleBackColor = true;
            this.btnPastTransactions.Click += new System.EventHandler(this.btnPastTransactions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose a customer:";
            // 
            // cmbbxCustomer
            // 
            this.cmbbxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCustomer.FormattingEnabled = true;
            this.cmbbxCustomer.Location = new System.Drawing.Point(22, 54);
            this.cmbbxCustomer.Name = "cmbbxCustomer";
            this.cmbbxCustomer.Size = new System.Drawing.Size(220, 26);
            this.cmbbxCustomer.TabIndex = 13;
            this.cmbbxCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbbxCustomer_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(102, 398);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(74, 25);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(22, 398);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(74, 25);
            this.btnRent.TabIndex = 11;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // datagridVideos
            // 
            this.datagridVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVideos.Location = new System.Drawing.Point(22, 97);
            this.datagridVideos.MultiSelect = false;
            this.datagridVideos.Name = "datagridVideos";
            this.datagridVideos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridVideos.Size = new System.Drawing.Size(894, 295);
            this.datagridVideos.TabIndex = 10;
            // 
            // CustomerLibrary
            // 
            this.CustomerLibrary.Controls.Add(this.lbl);
            this.CustomerLibrary.Controls.Add(this.txtbxFullName);
            this.CustomerLibrary.Controls.Add(this.label3);
            this.CustomerLibrary.Controls.Add(this.btnEditCustomer);
            this.CustomerLibrary.Controls.Add(this.btnAddCustomer);
            this.CustomerLibrary.Controls.Add(this.datagridCustomer);
            this.CustomerLibrary.Location = new System.Drawing.Point(4, 22);
            this.CustomerLibrary.Name = "CustomerLibrary";
            this.CustomerLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerLibrary.Size = new System.Drawing.Size(949, 444);
            this.CustomerLibrary.TabIndex = 1;
            this.CustomerLibrary.Text = "Customer Library";
            this.CustomerLibrary.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Customer Library";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(108, 383);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnEditCustomer.TabIndex = 13;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(27, 383);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // datagridCustomer
            // 
            this.datagridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCustomer.Location = new System.Drawing.Point(27, 51);
            this.datagridCustomer.MultiSelect = false;
            this.datagridCustomer.Name = "datagridCustomer";
            this.datagridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCustomer.Size = new System.Drawing.Size(884, 266);
            this.datagridCustomer.TabIndex = 11;
            this.datagridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCustomer_CellClick);
            // 
            // VideoLibrary
            // 
            this.VideoLibrary.Controls.Add(this.label2);
            this.VideoLibrary.Controls.Add(this.btnDeleteVideo);
            this.VideoLibrary.Controls.Add(this.btnEditVideo);
            this.VideoLibrary.Controls.Add(this.btnAddVideo);
            this.VideoLibrary.Controls.Add(this.datagridVidLibrary);
            this.VideoLibrary.Location = new System.Drawing.Point(4, 22);
            this.VideoLibrary.Name = "VideoLibrary";
            this.VideoLibrary.Size = new System.Drawing.Size(949, 444);
            this.VideoLibrary.TabIndex = 2;
            this.VideoLibrary.Text = "Video Library";
            this.VideoLibrary.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Video Library";
            // 
            // btnDeleteVideo
            // 
            this.btnDeleteVideo.Location = new System.Drawing.Point(189, 395);
            this.btnDeleteVideo.Name = "btnDeleteVideo";
            this.btnDeleteVideo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteVideo.TabIndex = 17;
            this.btnDeleteVideo.Text = "Delete";
            this.btnDeleteVideo.UseVisualStyleBackColor = true;
            // 
            // btnEditVideo
            // 
            this.btnEditVideo.Location = new System.Drawing.Point(108, 395);
            this.btnEditVideo.Name = "btnEditVideo";
            this.btnEditVideo.Size = new System.Drawing.Size(75, 23);
            this.btnEditVideo.TabIndex = 16;
            this.btnEditVideo.Text = "Edit";
            this.btnEditVideo.UseVisualStyleBackColor = true;
            this.btnEditVideo.Click += new System.EventHandler(this.btnEditVideo_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(27, 395);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAddVideo.TabIndex = 15;
            this.btnAddVideo.Text = "Add";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // datagridVidLibrary
            // 
            this.datagridVidLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVidLibrary.Location = new System.Drawing.Point(27, 47);
            this.datagridVidLibrary.MultiSelect = false;
            this.datagridVidLibrary.Name = "datagridVidLibrary";
            this.datagridVidLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridVidLibrary.Size = new System.Drawing.Size(890, 342);
            this.datagridVidLibrary.TabIndex = 1;
            this.datagridVidLibrary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridVidLibrary_CellClick);
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.Location = new System.Drawing.Point(28, 352);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(238, 20);
            this.txtbxFullName.TabIndex = 20;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(25, 335);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 13);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Customer Name";
            // 
            // btnOngoingRent
            // 
            this.btnOngoingRent.Location = new System.Drawing.Point(714, 398);
            this.btnOngoingRent.Name = "btnOngoingRent";
            this.btnOngoingRent.Size = new System.Drawing.Size(91, 25);
            this.btnOngoingRent.TabIndex = 16;
            this.btnOngoingRent.Text = "Ongoing Rent";
            this.btnOngoingRent.UseVisualStyleBackColor = true;
            this.btnOngoingRent.Click += new System.EventHandler(this.btnOngoingRent_Click);
            // 
            // btnAllReports
            // 
            this.btnAllReports.Location = new System.Drawing.Point(624, 398);
            this.btnAllReports.Name = "btnAllReports";
            this.btnAllReports.Size = new System.Drawing.Size(84, 23);
            this.btnAllReports.TabIndex = 20;
            this.btnAllReports.Text = "All Reports";
            this.btnAllReports.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 470);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.RentReturn.ResumeLayout(false);
            this.RentReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVideos)).EndInit();
            this.CustomerLibrary.ResumeLayout(false);
            this.CustomerLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomer)).EndInit();
            this.VideoLibrary.ResumeLayout(false);
            this.VideoLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVidLibrary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RentReturn;
        private System.Windows.Forms.Button btnPastTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxCustomer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DataGridView datagridVideos;
        private System.Windows.Forms.TabPage CustomerLibrary;
        private System.Windows.Forms.TabPage VideoLibrary;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView datagridCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteVideo;
        private System.Windows.Forms.Button btnEditVideo;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.DataGridView datagridVidLibrary;
        private System.Windows.Forms.TextBox txtbxFullName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnOngoingRent;
        private System.Windows.Forms.Button btnAllReports;
    }
}