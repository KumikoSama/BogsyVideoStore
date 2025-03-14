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
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxCategory
            // 
            this.txtbxCategory.Location = new System.Drawing.Point(305, 66);
            this.txtbxCategory.Name = "txtbxCategory";
            this.txtbxCategory.ReadOnly = true;
            this.txtbxCategory.Size = new System.Drawing.Size(160, 20);
            this.txtbxCategory.TabIndex = 1;
            // 
            // cmbbxDays
            // 
            this.cmbbxDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbxDays.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxDays.FormattingEnabled = true;
            this.cmbbxDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbbxDays.Location = new System.Drawing.Point(98, 126);
            this.cmbbxDays.Name = "cmbbxDays";
            this.cmbbxDays.Size = new System.Drawing.Size(160, 22);
            this.cmbbxDays.TabIndex = 2;
            this.cmbbxDays.Text = "1";
            this.cmbbxDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbxDays_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days to rent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPrice.Location = new System.Drawing.Point(305, 126);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.ReadOnly = true;
            this.txtbxPrice.Size = new System.Drawing.Size(160, 22);
            this.txtbxPrice.TabIndex = 6;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnRent.Location = new System.Drawing.Point(468, 466);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 25);
            this.btnRent.TabIndex = 8;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rent";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnAdd.Location = new System.Drawing.Point(288, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
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
            this.datagridList.Location = new System.Drawing.Point(0, 215);
            this.datagridList.Name = "datagridList";
            this.datagridList.ReadOnly = true;
            this.datagridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridList.Size = new System.Drawing.Size(555, 245);
            this.datagridList.TabIndex = 13;
            this.datagridList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagridList_DataBindingComplete);
            // 
            // cmbbxVideos
            // 
            this.cmbbxVideos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbbxVideos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbbxVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbxVideos.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxVideos.FormattingEnabled = true;
            this.cmbbxVideos.Location = new System.Drawing.Point(98, 66);
            this.cmbbxVideos.Name = "cmbbxVideos";
            this.cmbbxVideos.Size = new System.Drawing.Size(160, 22);
            this.cmbbxVideos.TabIndex = 14;
            this.cmbbxVideos.SelectedIndexChanged += new System.EventHandler(this.cmbbxVideos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(53, 474);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(44, 17);
            this.lblTotalAmount.TabIndex = 16;
            this.lblTotalAmount.Text = "₱0.00";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnRemove.Location = new System.Drawing.Point(207, 165);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 27);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(BogsyVideoStore.Models.Transaction);
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(555, 501);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.cmbbxVideos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Form";
            this.Load += new System.EventHandler(this.RentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.BindingSource transactionBindingSource;
    }
}