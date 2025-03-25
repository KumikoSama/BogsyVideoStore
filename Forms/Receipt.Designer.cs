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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxPayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerReceipt
            // 
            this.reportViewerReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerReceipt.DocumentMapWidth = 61;
            this.reportViewerReceipt.Location = new System.Drawing.Point(-3, -3);
            this.reportViewerReceipt.Name = "reportViewerReceipt";
            this.reportViewerReceipt.ServerReport.BearerToken = null;
            this.reportViewerReceipt.Size = new System.Drawing.Size(370, 392);
            this.reportViewerReceipt.TabIndex = 0;
            this.reportViewerReceipt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxPayment
            // 
            this.txtbxPayment.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPayment.Location = new System.Drawing.Point(118, 128);
            this.txtbxPayment.Name = "txtbxPayment";
            this.txtbxPayment.Size = new System.Drawing.Size(137, 21);
            this.txtbxPayment.TabIndex = 3;
            this.txtbxPayment.TextChanged += new System.EventHandler(this.txtbxPayment_TextChanged);
            this.txtbxPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPayment_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(115, 195);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(99, 17);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "Change: ₱0.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(115, 165);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(81, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total: ₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnGenerateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReceipt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnGenerateReceipt.Location = new System.Drawing.Point(118, 246);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(137, 32);
            this.btnGenerateReceipt.TabIndex = 10;
            this.btnGenerateReceipt.Text = "Confirm Transaction";
            this.btnGenerateReceipt.UseVisualStyleBackColor = false;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // pnlPayment
            // 
            this.pnlPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPayment.Controls.Add(this.btnGenerateReceipt);
            this.pnlPayment.Controls.Add(this.label1);
            this.pnlPayment.Controls.Add(this.txtbxPayment);
            this.pnlPayment.Controls.Add(this.lblTotal);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.lblChange);
            this.pnlPayment.Location = new System.Drawing.Point(-3, -3);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(370, 392);
            this.pnlPayment.TabIndex = 11;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(364, 390);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.reportViewerReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Receipt_FormClosed);
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGenerateReceipt;
        private System.Windows.Forms.Panel pnlPayment;
    }
}