namespace BogsyVideoStore.Forms
{
    partial class CustomerLibrary
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
            this.datagridCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridCustomers
            // 
            this.datagridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCustomers.Location = new System.Drawing.Point(44, 31);
            this.datagridCustomers.Name = "datagridCustomers";
            this.datagridCustomers.Size = new System.Drawing.Size(781, 376);
            this.datagridCustomers.TabIndex = 0;
            // 
            // CustomerLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.datagridCustomers);
            this.Name = "CustomerLibrary";
            this.Text = "CustomerLibrary";
            ((System.ComponentModel.ISupportInitialize)(this.datagridCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridCustomers;
    }
}