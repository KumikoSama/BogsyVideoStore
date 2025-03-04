namespace BogsyVideoStore.Forms
{
    partial class RentForm
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
            this.components = new System.ComponentModel.Container();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.txtbxCategory = new System.Windows.Forms.TextBox();
            this.cmbbxDays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.datagridList = new System.Windows.Forms.DataGridView();
            this.cmbbxVideos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Location = new System.Drawing.Point(95, 75);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.ReadOnly = true;
            this.txtbxTitle.Size = new System.Drawing.Size(143, 20);
            this.txtbxTitle.TabIndex = 0;
            // 
            // txtbxCategory
            // 
            this.txtbxCategory.Location = new System.Drawing.Point(302, 75);
            this.txtbxCategory.Name = "txtbxCategory";
            this.txtbxCategory.ReadOnly = true;
            this.txtbxCategory.Size = new System.Drawing.Size(160, 20);
            this.txtbxCategory.TabIndex = 1;
            // 
            // cmbbxDays
            // 
            this.cmbbxDays.FormattingEnabled = true;
            this.cmbbxDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbbxDays.Location = new System.Drawing.Point(98, 135);
            this.cmbbxDays.Name = "cmbbxDays";
            this.cmbbxDays.Size = new System.Drawing.Size(160, 21);
            this.cmbbxDays.TabIndex = 2;
            this.cmbbxDays.Text = "1";
            this.cmbbxDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbxDays_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days to rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(305, 135);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.ReadOnly = true;
            this.txtbxPrice.Size = new System.Drawing.Size(160, 20);
            this.txtbxPrice.TabIndex = 6;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(202, 187);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 8;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rent";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // datagridList
            // 
            this.datagridList.AllowUserToAddRows = false;
            this.datagridList.AllowUserToDeleteRows = false;
            this.datagridList.AllowUserToResizeColumns = false;
            this.datagridList.AllowUserToResizeRows = false;
            this.datagridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridList.Location = new System.Drawing.Point(0, 224);
            this.datagridList.Name = "datagridList";
            this.datagridList.ReadOnly = true;
            this.datagridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridList.Size = new System.Drawing.Size(555, 246);
            this.datagridList.TabIndex = 13;
            // 
            // cmbbxVideos
            // 
            this.cmbbxVideos.FormattingEnabled = true;
            this.cmbbxVideos.Location = new System.Drawing.Point(95, 75);
            this.cmbbxVideos.Name = "cmbbxVideos";
            this.cmbbxVideos.Size = new System.Drawing.Size(160, 21);
            this.cmbbxVideos.TabIndex = 14;
            this.cmbbxVideos.SelectedIndexChanged += new System.EventHandler(this.cmbbxVideos_SelectedIndexChanged);
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 470);
            this.Controls.Add(this.datagridList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxDays);
            this.Controls.Add(this.txtbxCategory);
            this.Controls.Add(this.txtbxTitle);
            this.Controls.Add(this.cmbbxVideos);
            this.Name = "RentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentForm_FormClosing);
            this.Load += new System.EventHandler(this.RentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.TextBox txtbxCategory;
        private System.Windows.Forms.ComboBox cmbbxDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView datagridList;
        private System.Windows.Forms.ComboBox cmbbxVideos;
    }
}