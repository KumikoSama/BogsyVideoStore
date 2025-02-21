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
            this.datagridVideos = new System.Windows.Forms.DataGridView();
            this.btnAllVideos = new System.Windows.Forms.Button();
            this.btnRentedVideos = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnOverdueRents = new System.Windows.Forms.Button();
            this.btnVideoLibrary = new System.Windows.Forms.Button();
            this.btnCustomerLibrary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridVideos
            // 
            this.datagridVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridVideos.Location = new System.Drawing.Point(204, 22);
            this.datagridVideos.Name = "datagridVideos";
            this.datagridVideos.Size = new System.Drawing.Size(718, 398);
            this.datagridVideos.TabIndex = 0;
            // 
            // btnAllVideos
            // 
            this.btnAllVideos.Location = new System.Drawing.Point(27, 60);
            this.btnAllVideos.Name = "btnAllVideos";
            this.btnAllVideos.Size = new System.Drawing.Size(144, 36);
            this.btnAllVideos.TabIndex = 1;
            this.btnAllVideos.Text = "All Videos";
            this.btnAllVideos.UseVisualStyleBackColor = true;
            this.btnAllVideos.Click += new System.EventHandler(this.btnAllVideos_Click);
            // 
            // btnRentedVideos
            // 
            this.btnRentedVideos.Location = new System.Drawing.Point(27, 116);
            this.btnRentedVideos.Name = "btnRentedVideos";
            this.btnRentedVideos.Size = new System.Drawing.Size(144, 36);
            this.btnRentedVideos.TabIndex = 2;
            this.btnRentedVideos.Text = "Rented Videos";
            this.btnRentedVideos.UseVisualStyleBackColor = true;
            this.btnRentedVideos.Click += new System.EventHandler(this.btnRentedVideos_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(27, 173);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(144, 36);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "Closed Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnOverdueRents
            // 
            this.btnOverdueRents.Location = new System.Drawing.Point(27, 231);
            this.btnOverdueRents.Name = "btnOverdueRents";
            this.btnOverdueRents.Size = new System.Drawing.Size(144, 36);
            this.btnOverdueRents.TabIndex = 4;
            this.btnOverdueRents.Text = "Overdue Rents";
            this.btnOverdueRents.UseVisualStyleBackColor = true;
            this.btnOverdueRents.Click += new System.EventHandler(this.btnOverdueRents_Click);
            // 
            // btnVideoLibrary
            // 
            this.btnVideoLibrary.Location = new System.Drawing.Point(27, 291);
            this.btnVideoLibrary.Name = "btnVideoLibrary";
            this.btnVideoLibrary.Size = new System.Drawing.Size(144, 36);
            this.btnVideoLibrary.TabIndex = 5;
            this.btnVideoLibrary.Text = "Video Library";
            this.btnVideoLibrary.UseVisualStyleBackColor = true;
            this.btnVideoLibrary.Click += new System.EventHandler(this.btnVideoLibrary_Click);
            // 
            // btnCustomerLibrary
            // 
            this.btnCustomerLibrary.Location = new System.Drawing.Point(27, 351);
            this.btnCustomerLibrary.Name = "btnCustomerLibrary";
            this.btnCustomerLibrary.Size = new System.Drawing.Size(144, 36);
            this.btnCustomerLibrary.TabIndex = 6;
            this.btnCustomerLibrary.Text = "Customer Library";
            this.btnCustomerLibrary.UseVisualStyleBackColor = true;
            this.btnCustomerLibrary.Click += new System.EventHandler(this.btnCustomerLibrary_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.btnCustomerLibrary);
            this.Controls.Add(this.btnVideoLibrary);
            this.Controls.Add(this.btnOverdueRents);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnRentedVideos);
            this.Controls.Add(this.btnAllVideos);
            this.Controls.Add(this.datagridVideos);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.datagridVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridVideos;
        private System.Windows.Forms.Button btnAllVideos;
        private System.Windows.Forms.Button btnRentedVideos;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnOverdueRents;
        private System.Windows.Forms.Button btnVideoLibrary;
        private System.Windows.Forms.Button btnCustomerLibrary;
    }
}