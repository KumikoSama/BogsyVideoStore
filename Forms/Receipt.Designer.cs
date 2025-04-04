namespace BogsyVideoStore.Forms
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.reportViewerReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSendToEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewerReceipt
            // 
            this.reportViewerReceipt.DocumentMapWidth = 61;
            this.reportViewerReceipt.Location = new System.Drawing.Point(0, 0);
            this.reportViewerReceipt.Name = "reportViewerReceipt";
            this.reportViewerReceipt.ServerReport.BearerToken = null;
            this.reportViewerReceipt.Size = new System.Drawing.Size(373, 404);
            this.reportViewerReceipt.TabIndex = 0;
            // 
            // btnSendToEmail
            // 
            this.btnSendToEmail.Location = new System.Drawing.Point(141, 422);
            this.btnSendToEmail.Name = "btnSendToEmail";
            this.btnSendToEmail.Size = new System.Drawing.Size(90, 23);
            this.btnSendToEmail.TabIndex = 1;
            this.btnSendToEmail.Text = "Send to Email";
            this.btnSendToEmail.UseVisualStyleBackColor = true;
            this.btnSendToEmail.Click += new System.EventHandler(this.btnSendToEmail_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(373, 460);
            this.Controls.Add(this.btnSendToEmail);
            this.Controls.Add(this.reportViewerReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Receipt_FormClosed);
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReceipt;
        private System.Windows.Forms.Button btnSendToEmail;
    }
}