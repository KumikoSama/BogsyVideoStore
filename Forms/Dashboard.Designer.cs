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
            this.lnklblClearAll = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxContactInfo = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
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
            this.ReportsPage = new System.Windows.Forms.TabPage();
            this.cmbbxCustomerReport = new System.Windows.Forms.ComboBox();
            this.btnGenerateVideoReport = new System.Windows.Forms.Button();
            this.btnGenerateCustomerReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.RentReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTransactions)).BeginInit();
            this.CustomerLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomer)).BeginInit();
            this.VideoLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVidLibrary)).BeginInit();
            this.ReportsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RentReturn);
            this.tabControl1.Controls.Add(this.CustomerLibrary);
            this.tabControl1.Controls.Add(this.VideoLibrary);
            this.tabControl1.Controls.Add(this.ReportsPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 470);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // RentReturn
            // 
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
            this.RentReturn.Location = new System.Drawing.Point(4, 22);
            this.RentReturn.Name = "RentReturn";
            this.RentReturn.Padding = new System.Windows.Forms.Padding(3);
            this.RentReturn.Size = new System.Drawing.Size(949, 444);
            this.RentReturn.TabIndex = 0;
            this.RentReturn.Text = "Rent and Return";
            this.RentReturn.UseVisualStyleBackColor = true;
            // 
            // btnOverdue
            // 
            this.btnOverdue.Location = new System.Drawing.Point(721, 402);
            this.btnOverdue.Name = "btnOverdue";
            this.btnOverdue.Size = new System.Drawing.Size(84, 23);
            this.btnOverdue.TabIndex = 27;
            this.btnOverdue.Text = "Overdue Rent";
            this.btnOverdue.UseVisualStyleBackColor = true;
            this.btnOverdue.Click += new System.EventHandler(this.btnOverdue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(793, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Category:";
            // 
            // cmbbxCategory
            // 
            this.cmbbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCategory.FormattingEnabled = true;
            this.cmbbxCategory.Items.AddRange(new object[] {
            "All",
            "VCD",
            "DVD"});
            this.cmbbxCategory.Location = new System.Drawing.Point(796, 65);
            this.cmbbxCategory.Name = "cmbbxCategory";
            this.cmbbxCategory.Size = new System.Drawing.Size(120, 23);
            this.cmbbxCategory.TabIndex = 25;
            this.cmbbxCategory.Text = "All";
            this.cmbbxCategory.SelectedIndexChanged += new System.EventHandler(this.cmbbxCategory_SelectedIndexChanged);
            this.cmbbxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbxCategory_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rental and Return";
            // 
            // btnAllVideos
            // 
            this.btnAllVideos.Location = new System.Drawing.Point(445, 402);
            this.btnAllVideos.Name = "btnAllVideos";
            this.btnAllVideos.Size = new System.Drawing.Size(74, 23);
            this.btnAllVideos.TabIndex = 23;
            this.btnAllVideos.Text = "All Videos";
            this.btnAllVideos.UseVisualStyleBackColor = true;
            this.btnAllVideos.Click += new System.EventHandler(this.btnAllVideos_Click);
            // 
            // btnAllTransactions
            // 
            this.btnAllTransactions.Location = new System.Drawing.Point(525, 402);
            this.btnAllTransactions.Name = "btnAllTransactions";
            this.btnAllTransactions.Size = new System.Drawing.Size(93, 23);
            this.btnAllTransactions.TabIndex = 20;
            this.btnAllTransactions.Text = "All Transactions";
            this.btnAllTransactions.UseVisualStyleBackColor = true;
            this.btnAllTransactions.Click += new System.EventHandler(this.btnAllReports_Click);
            // 
            // btnOngoingRent
            // 
            this.btnOngoingRent.Location = new System.Drawing.Point(624, 402);
            this.btnOngoingRent.Name = "btnOngoingRent";
            this.btnOngoingRent.Size = new System.Drawing.Size(91, 23);
            this.btnOngoingRent.TabIndex = 16;
            this.btnOngoingRent.Text = "Ongoing Rent";
            this.btnOngoingRent.UseVisualStyleBackColor = true;
            this.btnOngoingRent.Click += new System.EventHandler(this.btnOngoingRent_Click);
            // 
            // btnPastTransactions
            // 
            this.btnPastTransactions.Location = new System.Drawing.Point(811, 402);
            this.btnPastTransactions.Name = "btnPastTransactions";
            this.btnPastTransactions.Size = new System.Drawing.Size(105, 23);
            this.btnPastTransactions.TabIndex = 15;
            this.btnPastTransactions.Text = "Past Transactions";
            this.btnPastTransactions.UseVisualStyleBackColor = true;
            this.btnPastTransactions.Click += new System.EventHandler(this.btnPastTransactions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose a customer:";
            // 
            // cmbbxCustomer
            // 
            this.cmbbxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCustomer.FormattingEnabled = true;
            this.cmbbxCustomer.Items.AddRange(new object[] {
            "All"});
            this.cmbbxCustomer.Location = new System.Drawing.Point(22, 65);
            this.cmbbxCustomer.Name = "cmbbxCustomer";
            this.cmbbxCustomer.Size = new System.Drawing.Size(231, 23);
            this.cmbbxCustomer.TabIndex = 13;
            this.cmbbxCustomer.Text = "All";
            this.cmbbxCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbbxCustomer_SelectedIndexChanged);
            this.cmbbxCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbxCategory_KeyPress);
            // 
            // datagridTransactions
            // 
            this.datagridTransactions.AllowUserToAddRows = false;
            this.datagridTransactions.AllowUserToDeleteRows = false;
            this.datagridTransactions.AllowUserToResizeColumns = false;
            this.datagridTransactions.AllowUserToResizeRows = false;
            this.datagridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTransactions.Location = new System.Drawing.Point(22, 94);
            this.datagridTransactions.MultiSelect = false;
            this.datagridTransactions.Name = "datagridTransactions";
            this.datagridTransactions.ReadOnly = true;
            this.datagridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTransactions.Size = new System.Drawing.Size(894, 302);
            this.datagridTransactions.TabIndex = 10;
            this.datagridTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTransactions_CellClick);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(22, 403);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(74, 25);
            this.btnRent.TabIndex = 21;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(22, 402);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(74, 25);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // CustomerLibrary
            // 
            this.CustomerLibrary.Controls.Add(this.lnklblClearAll);
            this.CustomerLibrary.Controls.Add(this.label6);
            this.CustomerLibrary.Controls.Add(this.txtbxContactInfo);
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
            // lnklblClearAll
            // 
            this.lnklblClearAll.AutoSize = true;
            this.lnklblClearAll.LinkColor = System.Drawing.Color.DimGray;
            this.lnklblClearAll.Location = new System.Drawing.Point(413, 105);
            this.lnklblClearAll.Name = "lnklblClearAll";
            this.lnklblClearAll.Size = new System.Drawing.Size(71, 13);
            this.lnklblClearAll.TabIndex = 24;
            this.lnklblClearAll.TabStop = true;
            this.lnklblClearAll.Text = "Clear all fields";
            this.lnklblClearAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClearAll_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Contact Information:";
            // 
            // txtbxContactInfo
            // 
            this.txtbxContactInfo.Location = new System.Drawing.Point(272, 82);
            this.txtbxContactInfo.Name = "txtbxContactInfo";
            this.txtbxContactInfo.Size = new System.Drawing.Size(212, 20);
            this.txtbxContactInfo.TabIndex = 22;
            this.txtbxContactInfo.TextChanged += new System.EventHandler(this.txtbxCustomerInformation_TextChanged);
            this.txtbxContactInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxContactInfo_KeyPress);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(28, 54);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(107, 16);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Customer Name:";
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.Location = new System.Drawing.Point(30, 82);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(213, 20);
            this.txtbxFullName.TabIndex = 20;
            this.txtbxFullName.TextChanged += new System.EventHandler(this.txtbxCustomerInformation_TextChanged);
            this.txtbxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFullName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Customer Library";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(97, 118);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(60, 23);
            this.btnEditCustomer.TabIndex = 13;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(31, 118);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(60, 23);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // datagridCustomer
            // 
            this.datagridCustomer.AllowUserToAddRows = false;
            this.datagridCustomer.AllowUserToDeleteRows = false;
            this.datagridCustomer.AllowUserToResizeColumns = false;
            this.datagridCustomer.AllowUserToResizeRows = false;
            this.datagridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCustomer.Location = new System.Drawing.Point(31, 160);
            this.datagridCustomer.MultiSelect = false;
            this.datagridCustomer.Name = "datagridCustomer";
            this.datagridCustomer.ReadOnly = true;
            this.datagridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCustomer.Size = new System.Drawing.Size(884, 262);
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
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Video Library";
            // 
            // btnDeleteVideo
            // 
            this.btnDeleteVideo.Enabled = false;
            this.btnDeleteVideo.Location = new System.Drawing.Point(842, 405);
            this.btnDeleteVideo.Name = "btnDeleteVideo";
            this.btnDeleteVideo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteVideo.TabIndex = 17;
            this.btnDeleteVideo.Text = "Delete";
            this.btnDeleteVideo.UseVisualStyleBackColor = true;
            this.btnDeleteVideo.Click += new System.EventHandler(this.btnDeleteVideo_Click);
            // 
            // btnEditVideo
            // 
            this.btnEditVideo.Enabled = false;
            this.btnEditVideo.Location = new System.Drawing.Point(761, 405);
            this.btnEditVideo.Name = "btnEditVideo";
            this.btnEditVideo.Size = new System.Drawing.Size(75, 23);
            this.btnEditVideo.TabIndex = 16;
            this.btnEditVideo.Text = "Edit";
            this.btnEditVideo.UseVisualStyleBackColor = true;
            this.btnEditVideo.Click += new System.EventHandler(this.btnEditVideo_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(680, 405);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAddVideo.TabIndex = 15;
            this.btnAddVideo.Text = "Add";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // datagridVidLibrary
            // 
            this.datagridVidLibrary.AllowUserToAddRows = false;
            this.datagridVidLibrary.AllowUserToDeleteRows = false;
            this.datagridVidLibrary.AllowUserToResizeColumns = false;
            this.datagridVidLibrary.AllowUserToResizeRows = false;
            this.datagridVidLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridVidLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVidLibrary.Location = new System.Drawing.Point(27, 46);
            this.datagridVidLibrary.MultiSelect = false;
            this.datagridVidLibrary.Name = "datagridVidLibrary";
            this.datagridVidLibrary.ReadOnly = true;
            this.datagridVidLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridVidLibrary.Size = new System.Drawing.Size(890, 353);
            this.datagridVidLibrary.TabIndex = 1;
            this.datagridVidLibrary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridVidLibrary_CellClick);
            this.datagridVidLibrary.DoubleClick += new System.EventHandler(this.datagridVidLibrary_DoubleClick);
            // 
            // ReportsPage
            // 
            this.ReportsPage.Controls.Add(this.label7);
            this.ReportsPage.Controls.Add(this.cmbbxCustomerReport);
            this.ReportsPage.Controls.Add(this.btnGenerateVideoReport);
            this.ReportsPage.Controls.Add(this.btnGenerateCustomerReport);
            this.ReportsPage.Controls.Add(this.reportViewer1);
            this.ReportsPage.Location = new System.Drawing.Point(4, 22);
            this.ReportsPage.Name = "ReportsPage";
            this.ReportsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReportsPage.Size = new System.Drawing.Size(949, 444);
            this.ReportsPage.TabIndex = 3;
            this.ReportsPage.Text = "Reports Page";
            this.ReportsPage.UseVisualStyleBackColor = true;
            // 
            // cmbbxCustomerReport
            // 
            this.cmbbxCustomerReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCustomerReport.FormattingEnabled = true;
            this.cmbbxCustomerReport.Items.AddRange(new object[] {
            "All"});
            this.cmbbxCustomerReport.Location = new System.Drawing.Point(710, 27);
            this.cmbbxCustomerReport.Name = "cmbbxCustomerReport";
            this.cmbbxCustomerReport.Size = new System.Drawing.Size(231, 23);
            this.cmbbxCustomerReport.TabIndex = 22;
            this.cmbbxCustomerReport.Text = "All";
            // 
            // btnGenerateVideoReport
            // 
            this.btnGenerateVideoReport.Location = new System.Drawing.Point(163, 403);
            this.btnGenerateVideoReport.Name = "btnGenerateVideoReport";
            this.btnGenerateVideoReport.Size = new System.Drawing.Size(127, 23);
            this.btnGenerateVideoReport.TabIndex = 21;
            this.btnGenerateVideoReport.Text = "Generate Video Report";
            this.btnGenerateVideoReport.UseVisualStyleBackColor = true;
            this.btnGenerateVideoReport.Click += new System.EventHandler(this.btnGenerateVideoReport_Click);
            // 
            // btnGenerateCustomerReport
            // 
            this.btnGenerateCustomerReport.Location = new System.Drawing.Point(8, 403);
            this.btnGenerateCustomerReport.Name = "btnGenerateCustomerReport";
            this.btnGenerateCustomerReport.Size = new System.Drawing.Size(149, 23);
            this.btnGenerateCustomerReport.TabIndex = 20;
            this.btnGenerateCustomerReport.Text = "Generate Customer Report";
            this.btnGenerateCustomerReport.UseVisualStyleBackColor = true;
            this.btnGenerateCustomerReport.Click += new System.EventHandler(this.btnGenerateCustomerReport_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(949, 341);
            this.reportViewer1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Reports";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 470);
            this.Controls.Add(this.tabControl1);
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
            this.ReportsPage.ResumeLayout(false);
            this.ReportsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RentReturn;
        private System.Windows.Forms.Button btnPastTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxCustomer;
        private System.Windows.Forms.DataGridView datagridTransactions;
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
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnAllVideos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxCategory;
        private System.Windows.Forms.Button btnOverdue;
        private System.Windows.Forms.Button btnAllTransactions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxContactInfo;
        private System.Windows.Forms.LinkLabel lnklblClearAll;
        private System.Windows.Forms.TabPage ReportsPage;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGenerateCustomerReport;
        private System.Windows.Forms.ComboBox cmbbxCustomerReport;
        private System.Windows.Forms.Button btnGenerateVideoReport;
        private System.Windows.Forms.Label label7;
    }
}