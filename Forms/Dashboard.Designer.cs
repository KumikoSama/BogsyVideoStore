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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RentReturn = new System.Windows.Forms.TabPage();
            this.btnSettlePenalty = new System.Windows.Forms.Button();
            this.btnOverdue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAllTransactions = new System.Windows.Forms.Button();
            this.btnOngoingRent = new System.Windows.Forms.Button();
            this.btnPastTransactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxSearchCustomerTransactions = new System.Windows.Forms.ComboBox();
            this.datagridTransactions = new System.Windows.Forms.DataGridView();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.CustomerLibrary = new System.Windows.Forms.TabPage();
            this.txtbxSearchCustomer = new System.Windows.Forms.TextBox();
            this.reportViewerCustomer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerateCustomerReport = new System.Windows.Forms.Button();
            this.datagridCustomer = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.VideoLibrary = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbbxSortByCategory = new System.Windows.Forms.ComboBox();
            this.txtbxSearchVideo = new System.Windows.Forms.TextBox();
            this.reportViewerVideo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerateVideoReport = new System.Windows.Forms.Button();
            this.datagridVidLibrary = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteVideo = new System.Windows.Forms.Button();
            this.btnEditVideo = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnShowUnavailableVideos = new System.Windows.Forms.Button();
            this.btnHideUnavailableVideos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Calendar = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAllVideos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.RentReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTransactions)).BeginInit();
            this.CustomerLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomer)).BeginInit();
            this.VideoLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVidLibrary)).BeginInit();
            this.Calendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.RentReturn);
            this.tabControl1.Controls.Add(this.CustomerLibrary);
            this.tabControl1.Controls.Add(this.VideoLibrary);
            this.tabControl1.Controls.Add(this.Calendar);
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
            this.RentReturn.Controls.Add(this.panel1);
            this.RentReturn.Controls.Add(this.btnSettlePenalty);
            this.RentReturn.Controls.Add(this.pictureBox1);
            this.RentReturn.Controls.Add(this.btnOverdue);
            this.RentReturn.Controls.Add(this.label5);
            this.RentReturn.Controls.Add(this.cmbbxCategory);
            this.RentReturn.Controls.Add(this.label4);
            this.RentReturn.Controls.Add(this.btnAllVideos);
            this.RentReturn.Controls.Add(this.btnAllTransactions);
            this.RentReturn.Controls.Add(this.btnOngoingRent);
            this.RentReturn.Controls.Add(this.btnPastTransactions);
            this.RentReturn.Controls.Add(this.label1);
            this.RentReturn.Controls.Add(this.txtbxSearchCustomerTransactions);
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
            // txtbxSearchCustomerTransactions
            // 
            this.txtbxSearchCustomerTransactions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbxSearchCustomerTransactions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtbxSearchCustomerTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtbxSearchCustomerTransactions.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearchCustomerTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.txtbxSearchCustomerTransactions.FormattingEnabled = true;
            this.txtbxSearchCustomerTransactions.Items.AddRange(new object[] {
            "All"});
            this.txtbxSearchCustomerTransactions.Location = new System.Drawing.Point(51, 68);
            this.txtbxSearchCustomerTransactions.Name = "txtbxSearchCustomerTransactions";
            this.txtbxSearchCustomerTransactions.Size = new System.Drawing.Size(485, 22);
            this.txtbxSearchCustomerTransactions.TabIndex = 13;
            this.txtbxSearchCustomerTransactions.SelectedIndexChanged += new System.EventHandler(this.cmbbxCustomer_SelectedIndexChanged);
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
            this.CustomerLibrary.Controls.Add(this.txtbxSearchCustomer);
            this.CustomerLibrary.Controls.Add(this.reportViewerCustomer);
            this.CustomerLibrary.Controls.Add(this.btnGenerateCustomerReport);
            this.CustomerLibrary.Controls.Add(this.datagridCustomer);
            this.CustomerLibrary.Controls.Add(this.label3);
            this.CustomerLibrary.Controls.Add(this.btnEditCustomer);
            this.CustomerLibrary.Controls.Add(this.btnAddCustomer);
            this.CustomerLibrary.Controls.Add(this.pictureBox3);
            this.CustomerLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.CustomerLibrary.Location = new System.Drawing.Point(4, 26);
            this.CustomerLibrary.Name = "CustomerLibrary";
            this.CustomerLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerLibrary.Size = new System.Drawing.Size(1025, 471);
            this.CustomerLibrary.TabIndex = 1;
            this.CustomerLibrary.Text = "Customer Library";
            // 
            // txtbxSearchCustomer
            // 
            this.txtbxSearchCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbxSearchCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbxSearchCustomer.Location = new System.Drawing.Point(54, 45);
            this.txtbxSearchCustomer.Name = "txtbxSearchCustomer";
            this.txtbxSearchCustomer.Size = new System.Drawing.Size(338, 22);
            this.txtbxSearchCustomer.TabIndex = 31;
            this.txtbxSearchCustomer.TextChanged += new System.EventHandler(this.txtbxSearchCustomer_TextChanged);
            // 
            // reportViewerCustomer
            // 
            this.reportViewerCustomer.Location = new System.Drawing.Point(572, 44);
            this.reportViewerCustomer.Name = "reportViewerCustomer";
            this.reportViewerCustomer.ServerReport.BearerToken = null;
            this.reportViewerCustomer.Size = new System.Drawing.Size(432, 379);
            this.reportViewerCustomer.TabIndex = 28;
            // 
            // btnGenerateCustomerReport
            // 
            this.btnGenerateCustomerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnGenerateCustomerReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCustomerReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnGenerateCustomerReport.Location = new System.Drawing.Point(820, 426);
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
            this.datagridCustomer.Location = new System.Drawing.Point(27, 73);
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
            this.datagridCustomer.Size = new System.Drawing.Size(539, 350);
            this.datagridCustomer.TabIndex = 25;
            this.datagridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCustomer_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 16);
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
            this.btnEditCustomer.Location = new System.Drawing.Point(83, 426);
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
            this.btnAddCustomer.Location = new System.Drawing.Point(27, 426);
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
            this.VideoLibrary.Controls.Add(this.label7);
            this.VideoLibrary.Controls.Add(this.cmbbxSortByCategory);
            this.VideoLibrary.Controls.Add(this.txtbxSearchVideo);
            this.VideoLibrary.Controls.Add(this.reportViewerVideo);
            this.VideoLibrary.Controls.Add(this.btnGenerateVideoReport);
            this.VideoLibrary.Controls.Add(this.datagridVidLibrary);
            this.VideoLibrary.Controls.Add(this.label2);
            this.VideoLibrary.Controls.Add(this.btnDeleteVideo);
            this.VideoLibrary.Controls.Add(this.btnEditVideo);
            this.VideoLibrary.Controls.Add(this.btnAddVideo);
            this.VideoLibrary.Controls.Add(this.btnShowUnavailableVideos);
            this.VideoLibrary.Controls.Add(this.btnHideUnavailableVideos);
            this.VideoLibrary.Controls.Add(this.pictureBox2);
            this.VideoLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.VideoLibrary.Location = new System.Drawing.Point(4, 26);
            this.VideoLibrary.Name = "VideoLibrary";
            this.VideoLibrary.Size = new System.Drawing.Size(1025, 471);
            this.VideoLibrary.TabIndex = 2;
            this.VideoLibrary.Text = "Video Library";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label7.Location = new System.Drawing.Point(400, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Category:";
            // 
            // cmbbxSortByCategory
            // 
            this.cmbbxSortByCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbxSortByCategory.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSortByCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.cmbbxSortByCategory.FormattingEnabled = true;
            this.cmbbxSortByCategory.Items.AddRange(new object[] {
            "All",
            "VCD",
            "DVD"});
            this.cmbbxSortByCategory.Location = new System.Drawing.Point(465, 47);
            this.cmbbxSortByCategory.Name = "cmbbxSortByCategory";
            this.cmbbxSortByCategory.Size = new System.Drawing.Size(120, 22);
            this.cmbbxSortByCategory.TabIndex = 31;
            this.cmbbxSortByCategory.Text = "All";
            this.cmbbxSortByCategory.SelectedIndexChanged += new System.EventHandler(this.cmbbxSortByCategory_SelectedIndexChanged);
            // 
            // txtbxSearchVideo
            // 
            this.txtbxSearchVideo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbxSearchVideo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbxSearchVideo.Location = new System.Drawing.Point(54, 47);
            this.txtbxSearchVideo.Name = "txtbxSearchVideo";
            this.txtbxSearchVideo.Size = new System.Drawing.Size(338, 22);
            this.txtbxSearchVideo.TabIndex = 25;
            this.txtbxSearchVideo.TextChanged += new System.EventHandler(this.txtbxSearch_TextChanged);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(509, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 23);
            this.panel1.TabIndex = 30;
            // 
            // Calendar
            // 
            this.Calendar.Controls.Add(this.pictureBox5);
            this.Calendar.Controls.Add(this.pictureBox4);
            this.Calendar.Controls.Add(this.label14);
            this.Calendar.Controls.Add(this.label13);
            this.Calendar.Controls.Add(this.label12);
            this.Calendar.Controls.Add(this.label11);
            this.Calendar.Controls.Add(this.label10);
            this.Calendar.Controls.Add(this.label9);
            this.Calendar.Controls.Add(this.label8);
            this.Calendar.Controls.Add(this.label6);
            this.Calendar.Controls.Add(this.flowLayoutPanel1);
            this.Calendar.Location = new System.Drawing.Point(4, 26);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(1025, 471);
            this.Calendar.TabIndex = 3;
            this.Calendar.Text = "Calendar";
            this.Calendar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 367);
            this.flowLayoutPanel1.TabIndex = 0;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(53, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Sunday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label8.Location = new System.Drawing.Point(138, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Monday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label9.Location = new System.Drawing.Point(217, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tuesday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label10.Location = new System.Drawing.Point(290, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Wednesday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label11.Location = new System.Drawing.Point(376, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Thursday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label12.Location = new System.Drawing.Point(469, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Friday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label13.Location = new System.Drawing.Point(542, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Saturday";
            // 
            // label14
            // 
            this.label14.AutoEllipsis = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label14.Location = new System.Drawing.Point(36, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 22);
            this.label14.TabIndex = 34;
            this.label14.Text = "Month";
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BogsyVideoStore.Properties.Resources.magnifying_glass_solid;
            this.pictureBox3.Location = new System.Drawing.Point(27, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
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
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BogsyVideoStore.Properties.Resources.nexticon;
            this.pictureBox5.Location = new System.Drawing.Point(285, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BogsyVideoStore.Properties.Resources.previousicon;
            this.pictureBox4.Location = new System.Drawing.Point(251, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bogsy\'s Video Store";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.RentReturn.ResumeLayout(false);
            this.RentReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTransactions)).EndInit();
            this.CustomerLibrary.ResumeLayout(false);
            this.CustomerLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomer)).EndInit();
            this.VideoLibrary.ResumeLayout(false);
            this.VideoLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVidLibrary)).EndInit();
            this.Calendar.ResumeLayout(false);
            this.Calendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.ComboBox txtbxSearchCustomerTransactions;
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
        private System.Windows.Forms.TextBox txtbxSearchVideo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbxSortByCategory;
        private System.Windows.Forms.TextBox txtbxSearchCustomer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage Calendar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}