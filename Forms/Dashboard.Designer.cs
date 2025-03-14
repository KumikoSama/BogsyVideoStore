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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RentReturn = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettlePenalty = new System.Windows.Forms.Button();
            this.btnOverdue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAllVideos = new System.Windows.Forms.Button();
            this.btnAllTransactions = new System.Windows.Forms.Button();
            this.btnOngoingRent = new System.Windows.Forms.Button();
            this.btnPastTransactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxCustomer = new System.Windows.Forms.ComboBox();
            this.datagridTransactions = new System.Windows.Forms.DataGridView();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.CustomerLibrary = new System.Windows.Forms.TabPage();
            this.reportViewerCustomer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerateCustomerReport = new System.Windows.Forms.Button();
            this.datagridCustomer = new System.Windows.Forms.DataGridView();
            this.lnklblClearAll = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxContactInfo = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.VideoLibrary = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.reportViewerVideo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerateVideoReport = new System.Windows.Forms.Button();
            this.datagridVidLibrary = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteVideo = new System.Windows.Forms.Button();
            this.btnEditVideo = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnShowUnavailableVideos = new System.Windows.Forms.Button();
            this.btnHideUnavailableVideos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.RentReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTransactions)).BeginInit();
            this.CustomerLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomer)).BeginInit();
            this.VideoLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVidLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.RentReturn);
            this.tabControl1.Controls.Add(this.CustomerLibrary);
            this.tabControl1.Controls.Add(this.VideoLibrary);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 501);
            this.tabControl1.TabIndex = 10;
            // 
            // RentReturn
            // 
            this.RentReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.RentReturn.Controls.Add(this.pictureBox1);
            this.RentReturn.Controls.Add(this.btnSettlePenalty);
            this.RentReturn.Controls.Add(this.btnOverdue);
            this.RentReturn.Controls.Add(this.label5);
            this.RentReturn.Controls.Add(this.cmbbxCategory);
            this.RentReturn.Controls.Add(this.label4);
            this.RentReturn.Controls.Add(this.btnAllVideos);
            this.RentReturn.Controls.Add(this.btnAllTransactions);
            this.RentReturn.Controls.Add(this.btnOngoingRent);
            this.RentReturn.Controls.Add(this.btnPastTransactions);
            this.RentReturn.Controls.Add(this.label1);
            this.RentReturn.Controls.Add(this.cmbbxCustomer);
            this.RentReturn.Controls.Add(this.datagridTransactions);
            this.RentReturn.Controls.Add(this.btnRent);
            this.RentReturn.Controls.Add(this.btnReturn);
            this.RentReturn.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentReturn.Location = new System.Drawing.Point(4, 26);
            this.RentReturn.Name = "RentReturn";
            this.RentReturn.Padding = new System.Windows.Forms.Padding(3);
            this.RentReturn.Size = new System.Drawing.Size(1025, 471);
            this.RentReturn.TabIndex = 0;
            this.RentReturn.Text = "Rent and Return";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BogsyVideoStore.Properties.Resources.magnifying_glass_solid;
            this.pictureBox1.Location = new System.Drawing.Point(24, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettlePenalty
            // 
            this.btnSettlePenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnSettlePenalty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnSettlePenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePenalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnSettlePenalty.Location = new System.Drawing.Point(24, 425);
            this.btnSettlePenalty.Name = "btnSettlePenalty";
            this.btnSettlePenalty.Size = new System.Drawing.Size(116, 27);
            this.btnSettlePenalty.TabIndex = 28;
            this.btnSettlePenalty.Text = "Settle Penalty Fees";
            this.btnSettlePenalty.UseVisualStyleBackColor = false;
            this.btnSettlePenalty.Visible = false;
            this.btnSettlePenalty.Click += new System.EventHandler(this.btnSettlePenalty_Click);
            // 
            // btnOverdue
            // 
            this.btnOverdue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnOverdue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnOverdue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnOverdue.Location = new System.Drawing.Point(772, 426);
            this.btnOverdue.Name = "btnOverdue";
            this.btnOverdue.Size = new System.Drawing.Size(94, 26);
            this.btnOverdue.TabIndex = 27;
            this.btnOverdue.Text = "Overdue Rent";
            this.btnOverdue.UseVisualStyleBackColor = false;
            this.btnOverdue.Click += new System.EventHandler(this.btnOverdue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(865, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Category:";
            // 
            // cmbbxCategory
            // 
            this.cmbbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbxCategory.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.cmbbxCategory.FormattingEnabled = true;
            this.cmbbxCategory.Items.AddRange(new object[] {
            "All",
            "VCD",
            "DVD"});
            this.cmbbxCategory.Location = new System.Drawing.Point(868, 68);
            this.cmbbxCategory.Name = "cmbbxCategory";
            this.cmbbxCategory.Size = new System.Drawing.Size(120, 22);
            this.cmbbxCategory.TabIndex = 25;
            this.cmbbxCategory.Text = "All";
            this.cmbbxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbbxCategory_SelectedIndexChanged);
            this.cmbbxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbxCategory_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rental and Return";
            // 
            // btnAllVideos
            // 
            this.btnAllVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnAllVideos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnAllVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllVideos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnAllVideos.Location = new System.Drawing.Point(484, 426);
            this.btnAllVideos.Name = "btnAllVideos";
            this.btnAllVideos.Size = new System.Drawing.Size(74, 26);
            this.btnAllVideos.TabIndex = 23;
            this.btnAllVideos.Text = "All Videos";
            this.btnAllVideos.UseVisualStyleBackColor = false;
            this.btnAllVideos.Click += new System.EventHandler(this.btnAllVideos_Click);
            // 
            // btnAllTransactions
            // 
            this.btnAllTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnAllTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnAllTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnAllTransactions.Location = new System.Drawing.Point(564, 426);
            this.btnAllTransactions.Name = "btnAllTransactions";
            this.btnAllTransactions.Size = new System.Drawing.Size(105, 26);
            this.btnAllTransactions.TabIndex = 20;
            this.btnAllTransactions.Text = "All Transactions";
            this.btnAllTransactions.UseVisualStyleBackColor = false;
            this.btnAllTransactions.Click += new System.EventHandler(this.btnAllReports_Click);
            // 
            // btnOngoingRent
            // 
            this.btnOngoingRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnOngoingRent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnOngoingRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOngoingRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnOngoingRent.Location = new System.Drawing.Point(675, 426);
            this.btnOngoingRent.Name = "btnOngoingRent";
            this.btnOngoingRent.Size = new System.Drawing.Size(91, 26);
            this.btnOngoingRent.TabIndex = 16;
            this.btnOngoingRent.Text = "Ongoing Rent";
            this.btnOngoingRent.UseVisualStyleBackColor = false;
            this.btnOngoingRent.Click += new System.EventHandler(this.btnOngoingRent_Click);
            // 
            // btnPastTransactions
            // 
            this.btnPastTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnPastTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnPastTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPastTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnPastTransactions.Location = new System.Drawing.Point(872, 426);
            this.btnPastTransactions.Name = "btnPastTransactions";
            this.btnPastTransactions.Size = new System.Drawing.Size(116, 26);
            this.btnPastTransactions.TabIndex = 15;
            this.btnPastTransactions.Text = "Past Transactions";
            this.btnPastTransactions.UseVisualStyleBackColor = false;
            this.btnPastTransactions.Click += new System.EventHandler(this.btnPastTransactions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose or search for a customer:";
            // 
            // cmbbxCustomer
            // 
            this.cmbbxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbbxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbbxCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbxCustomer.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.cmbbxCustomer.FormattingEnabled = true;
            this.cmbbxCustomer.Items.AddRange(new object[] {
            "All"});
            this.cmbbxCustomer.Location = new System.Drawing.Point(51, 68);
            this.cmbbxCustomer.Name = "cmbbxCustomer";
            this.cmbbxCustomer.Size = new System.Drawing.Size(438, 22);
            this.cmbbxCustomer.TabIndex = 13;
            this.cmbbxCustomer.Text = "All";
            this.cmbbxCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbbxCustomer_SelectedIndexChanged);
            // 
            // datagridTransactions
            // 
            this.datagridTransactions.AllowUserToAddRows = false;
            this.datagridTransactions.AllowUserToDeleteRows = false;
            this.datagridTransactions.AllowUserToResizeColumns = false;
            this.datagridTransactions.AllowUserToResizeRows = false;
            this.datagridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.datagridTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridTransactions.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datagridTransactions.Location = new System.Drawing.Point(24, 97);
            this.datagridTransactions.MultiSelect = false;
            this.datagridTransactions.Name = "datagridTransactions";
            this.datagridTransactions.ReadOnly = true;
            this.datagridTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTransactions.Size = new System.Drawing.Size(964, 322);
            this.datagridTransactions.TabIndex = 10;
            this.datagridTransactions.DataSourceChanged += new System.EventHandler(this.datagridTransactions_DataSourceChanged);
            this.datagridTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTransactions_CellClick);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnRent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnRent.Location = new System.Drawing.Point(24, 426);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(74, 26);
            this.btnRent.TabIndex = 21;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnReturn.Location = new System.Drawing.Point(24, 425);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(74, 26);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // CustomerLibrary
            // 
            this.CustomerLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.CustomerLibrary.Controls.Add(this.reportViewerCustomer);
            this.CustomerLibrary.Controls.Add(this.btnGenerateCustomerReport);
            this.CustomerLibrary.Controls.Add(this.datagridCustomer);
            this.CustomerLibrary.Controls.Add(this.lnklblClearAll);
            this.CustomerLibrary.Controls.Add(this.label6);
            this.CustomerLibrary.Controls.Add(this.txtbxContactInfo);
            this.CustomerLibrary.Controls.Add(this.lbl);
            this.CustomerLibrary.Controls.Add(this.txtbxFullName);
            this.CustomerLibrary.Controls.Add(this.label3);
            this.CustomerLibrary.Controls.Add(this.btnEditCustomer);
            this.CustomerLibrary.Controls.Add(this.btnAddCustomer);
            this.CustomerLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.CustomerLibrary.Location = new System.Drawing.Point(4, 26);
            this.CustomerLibrary.Name = "CustomerLibrary";
            this.CustomerLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerLibrary.Size = new System.Drawing.Size(1025, 471);
            this.CustomerLibrary.TabIndex = 1;
            this.CustomerLibrary.Text = "Customer Library";
            // 
            // reportViewerCustomer
            // 
            this.reportViewerCustomer.Location = new System.Drawing.Point(572, 73);
            this.reportViewerCustomer.Name = "reportViewerCustomer";
            this.reportViewerCustomer.ServerReport.BearerToken = null;
            this.reportViewerCustomer.Size = new System.Drawing.Size(432, 376);
            this.reportViewerCustomer.TabIndex = 28;
            // 
            // btnGenerateCustomerReport
            // 
            this.btnGenerateCustomerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnGenerateCustomerReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCustomerReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnGenerateCustomerReport.Location = new System.Drawing.Point(820, 44);
            this.btnGenerateCustomerReport.Name = "btnGenerateCustomerReport";
            this.btnGenerateCustomerReport.Size = new System.Drawing.Size(184, 23);
            this.btnGenerateCustomerReport.TabIndex = 27;
            this.btnGenerateCustomerReport.Text = "Generate All Customers Report";
            this.btnGenerateCustomerReport.UseVisualStyleBackColor = false;
            this.btnGenerateCustomerReport.Click += new System.EventHandler(this.btnGenerateCustomerReport_Click);
            // 
            // datagridCustomer
            // 
            this.datagridCustomer.AllowUserToAddRows = false;
            this.datagridCustomer.AllowUserToDeleteRows = false;
            this.datagridCustomer.AllowUserToResizeColumns = false;
            this.datagridCustomer.AllowUserToResizeRows = false;
            this.datagridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.datagridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridCustomer.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagridCustomer.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datagridCustomer.Location = new System.Drawing.Point(27, 132);
            this.datagridCustomer.MultiSelect = false;
            this.datagridCustomer.Name = "datagridCustomer";
            this.datagridCustomer.ReadOnly = true;
            this.datagridCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCustomer.Size = new System.Drawing.Size(530, 317);
            this.datagridCustomer.TabIndex = 25;
            this.datagridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCustomer_CellClick);
            // 
            // lnklblClearAll
            // 
            this.lnklblClearAll.AutoSize = true;
            this.lnklblClearAll.LinkColor = System.Drawing.Color.DimGray;
            this.lnklblClearAll.Location = new System.Drawing.Point(423, 102);
            this.lnklblClearAll.Name = "lnklblClearAll";
            this.lnklblClearAll.Size = new System.Drawing.Size(80, 14);
            this.lnklblClearAll.TabIndex = 24;
            this.lnklblClearAll.TabStop = true;
            this.lnklblClearAll.Text = "Clear all fields";
            this.lnklblClearAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClearAll_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Contact Information:";
            // 
            // txtbxContactInfo
            // 
            this.txtbxContactInfo.Location = new System.Drawing.Point(272, 73);
            this.txtbxContactInfo.Name = "txtbxContactInfo";
            this.txtbxContactInfo.Size = new System.Drawing.Size(231, 22);
            this.txtbxContactInfo.TabIndex = 22;
            this.txtbxContactInfo.TextChanged += new System.EventHandler(this.txtbxCustomerInformation_TextChanged);
            this.txtbxContactInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContactInfo_KeyPress);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(28, 52);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 16);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Customer Name:";
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.Location = new System.Drawing.Point(30, 73);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(232, 22);
            this.txtbxFullName.TabIndex = 20;
            this.txtbxFullName.TextChanged += new System.EventHandler(this.txtbxCustomerInformation_TextChanged);
            this.txtbxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFullName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Customer Library";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnEditCustomer.FlatAppearance.BorderSize = 0;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnEditCustomer.Location = new System.Drawing.Point(87, 102);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(53, 23);
            this.btnEditCustomer.TabIndex = 13;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnAddCustomer.Location = new System.Drawing.Point(31, 102);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(50, 23);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // VideoLibrary
            // 
            this.VideoLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.VideoLibrary.Controls.Add(this.pictureBox2);
            this.VideoLibrary.Controls.Add(this.txtbxSearch);
            this.VideoLibrary.Controls.Add(this.reportViewerVideo);
            this.VideoLibrary.Controls.Add(this.btnGenerateVideoReport);
            this.VideoLibrary.Controls.Add(this.datagridVidLibrary);
            this.VideoLibrary.Controls.Add(this.label2);
            this.VideoLibrary.Controls.Add(this.btnDeleteVideo);
            this.VideoLibrary.Controls.Add(this.btnEditVideo);
            this.VideoLibrary.Controls.Add(this.btnAddVideo);
            this.VideoLibrary.Controls.Add(this.btnShowUnavailableVideos);
            this.VideoLibrary.Controls.Add(this.btnHideUnavailableVideos);
            this.VideoLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.VideoLibrary.Location = new System.Drawing.Point(4, 26);
            this.VideoLibrary.Name = "VideoLibrary";
            this.VideoLibrary.Size = new System.Drawing.Size(1025, 471);
            this.VideoLibrary.TabIndex = 2;
            this.VideoLibrary.Text = "Video Library";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BogsyVideoStore.Properties.Resources.magnifying_glass_solid;
            this.pictureBox2.Location = new System.Drawing.Point(27, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbxSearch.Location = new System.Drawing.Point(54, 47);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(289, 22);
            this.txtbxSearch.TabIndex = 25;
            this.txtbxSearch.TextChanged += new System.EventHandler(this.txtbxSearch_TextChanged);
            // 
            // reportViewerVideo
            // 
            this.reportViewerVideo.Location = new System.Drawing.Point(591, 46);
            this.reportViewerVideo.Name = "reportViewerVideo";
            this.reportViewerVideo.ServerReport.BearerToken = null;
            this.reportViewerVideo.Size = new System.Drawing.Size(426, 379);
            this.reportViewerVideo.TabIndex = 24;
            // 
            // btnGenerateVideoReport
            // 
            this.btnGenerateVideoReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnGenerateVideoReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnGenerateVideoReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateVideoReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnGenerateVideoReport.Location = new System.Drawing.Point(862, 431);
            this.btnGenerateVideoReport.Name = "btnGenerateVideoReport";
            this.btnGenerateVideoReport.Size = new System.Drawing.Size(143, 23);
            this.btnGenerateVideoReport.TabIndex = 23;
            this.btnGenerateVideoReport.Text = "Generate Video Report";
            this.btnGenerateVideoReport.UseVisualStyleBackColor = false;
            this.btnGenerateVideoReport.Click += new System.EventHandler(this.btnGenerateVideoReport_Click);
            // 
            // datagridVidLibrary
            // 
            this.datagridVidLibrary.AllowUserToAddRows = false;
            this.datagridVidLibrary.AllowUserToDeleteRows = false;
            this.datagridVidLibrary.AllowUserToResizeColumns = false;
            this.datagridVidLibrary.AllowUserToResizeRows = false;
            this.datagridVidLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridVidLibrary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.datagridVidLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridVidLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.datagridVidLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.Format = "D";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridVidLibrary.DefaultCellStyle = dataGridViewCellStyle8;
            this.datagridVidLibrary.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datagridVidLibrary.Location = new System.Drawing.Point(27, 74);
            this.datagridVidLibrary.MultiSelect = false;
            this.datagridVidLibrary.Name = "datagridVidLibrary";
            this.datagridVidLibrary.ReadOnly = true;
            this.datagridVidLibrary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridVidLibrary.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridVidLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridVidLibrary.Size = new System.Drawing.Size(558, 351);
            this.datagridVidLibrary.TabIndex = 21;
            this.datagridVidLibrary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridVidLibrary_CellClick);
            this.datagridVidLibrary.DoubleClick += new System.EventHandler(this.datagridVidLibrary_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Video Library";
            // 
            // btnDeleteVideo
            // 
            this.btnDeleteVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnDeleteVideo.Enabled = false;
            this.btnDeleteVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnDeleteVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnDeleteVideo.Location = new System.Drawing.Point(510, 431);
            this.btnDeleteVideo.Name = "btnDeleteVideo";
            this.btnDeleteVideo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteVideo.TabIndex = 17;
            this.btnDeleteVideo.Text = "Delete";
            this.btnDeleteVideo.UseVisualStyleBackColor = false;
            this.btnDeleteVideo.Click += new System.EventHandler(this.btnDeleteVideo_Click);
            // 
            // btnEditVideo
            // 
            this.btnEditVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnEditVideo.Enabled = false;
            this.btnEditVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnEditVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnEditVideo.Location = new System.Drawing.Point(429, 431);
            this.btnEditVideo.Name = "btnEditVideo";
            this.btnEditVideo.Size = new System.Drawing.Size(75, 23);
            this.btnEditVideo.TabIndex = 16;
            this.btnEditVideo.Text = "Edit";
            this.btnEditVideo.UseVisualStyleBackColor = false;
            this.btnEditVideo.Click += new System.EventHandler(this.btnEditVideo_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnAddVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnAddVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnAddVideo.Location = new System.Drawing.Point(348, 431);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAddVideo.TabIndex = 15;
            this.btnAddVideo.Text = "Add";
            this.btnAddVideo.UseVisualStyleBackColor = false;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnShowUnavailableVideos
            // 
            this.btnShowUnavailableVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnShowUnavailableVideos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnShowUnavailableVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUnavailableVideos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnShowUnavailableVideos.Location = new System.Drawing.Point(27, 431);
            this.btnShowUnavailableVideos.Name = "btnShowUnavailableVideos";
            this.btnShowUnavailableVideos.Size = new System.Drawing.Size(152, 23);
            this.btnShowUnavailableVideos.TabIndex = 19;
            this.btnShowUnavailableVideos.Text = "Show Unavailable Videos";
            this.btnShowUnavailableVideos.UseVisualStyleBackColor = false;
            this.btnShowUnavailableVideos.Click += new System.EventHandler(this.btnShowUnavailableVideos_Click);
            // 
            // btnHideUnavailableVideos
            // 
            this.btnHideUnavailableVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnHideUnavailableVideos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnHideUnavailableVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideUnavailableVideos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnHideUnavailableVideos.Location = new System.Drawing.Point(27, 431);
            this.btnHideUnavailableVideos.Name = "btnHideUnavailableVideos";
            this.btnHideUnavailableVideos.Size = new System.Drawing.Size(152, 23);
            this.btnHideUnavailableVideos.TabIndex = 20;
            this.btnHideUnavailableVideos.Text = "Hide Unavailable Videos";
            this.btnHideUnavailableVideos.UseVisualStyleBackColor = false;
            this.btnHideUnavailableVideos.Click += new System.EventHandler(this.btnHideUnavailableVideos_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1033, 501);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bogsy\'s Video Store";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.RentReturn.ResumeLayout(false);
            this.RentReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTransactions)).EndInit();
            this.CustomerLibrary.ResumeLayout(false);
            this.CustomerLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomer)).EndInit();
            this.VideoLibrary.ResumeLayout(false);
            this.VideoLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVidLibrary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomerLibrary;
        private System.Windows.Forms.TabPage VideoLibrary;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteVideo;
        private System.Windows.Forms.Button btnEditVideo;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.TextBox txtbxFullName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxContactInfo;
        private System.Windows.Forms.LinkLabel lnklblClearAll;
        private System.Windows.Forms.Button btnShowUnavailableVideos;
        private System.Windows.Forms.Button btnHideUnavailableVideos;
        private System.Windows.Forms.TabPage RentReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettlePenalty;
        private System.Windows.Forms.Button btnOverdue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAllVideos;
        private System.Windows.Forms.Button btnAllTransactions;
        private System.Windows.Forms.Button btnOngoingRent;
        private System.Windows.Forms.Button btnPastTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxCustomer;
        private System.Windows.Forms.DataGridView datagridTransactions;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView datagridCustomer;
        private System.Windows.Forms.DataGridView datagridVidLibrary;
        private System.Windows.Forms.Button btnGenerateVideoReport;
        private System.Windows.Forms.Button btnGenerateCustomerReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCustomer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVideo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtbxSearch;
    }
}