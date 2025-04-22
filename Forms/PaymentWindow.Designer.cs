namespace BogsyVideoStore.Forms
{
    partial class PaymentWindow
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
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.btnConfirmTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxPayment = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.pnlPayment.Controls.Add(this.btnConfirmTransaction);
            this.pnlPayment.Controls.Add(this.label1);
            this.pnlPayment.Controls.Add(this.txtbxPayment);
            this.pnlPayment.Controls.Add(this.lblTotal);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.lblChange);
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPayment.Location = new System.Drawing.Point(0, 0);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(361, 267);
            this.pnlPayment.TabIndex = 12;
            // 
            // btnConfirmTransaction
            // 
            this.btnConfirmTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.btnConfirmTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmTransaction.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.btnConfirmTransaction.Location = new System.Drawing.Point(115, 194);
            this.btnConfirmTransaction.Name = "btnConfirmTransaction";
            this.btnConfirmTransaction.Size = new System.Drawing.Size(137, 38);
            this.btnConfirmTransaction.TabIndex = 10;
            this.btnConfirmTransaction.Text = "Confirm Transaction";
            this.btnConfirmTransaction.UseVisualStyleBackColor = false;
            this.btnConfirmTransaction.Click += new System.EventHandler(this.btnConfirmTransaction_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxPayment
            // 
            this.txtbxPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtbxPayment.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPayment.Location = new System.Drawing.Point(115, 87);
            this.txtbxPayment.Name = "txtbxPayment";
            this.txtbxPayment.Size = new System.Drawing.Size(137, 24);
            this.txtbxPayment.TabIndex = 3;
            this.txtbxPayment.TextChanged += new System.EventHandler(this.txtbxPayment_TextChanged);
            this.txtbxPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPayment_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lblTotal.Location = new System.Drawing.Point(115, 128);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 18);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total: ₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(112, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter payment:";
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lblChange.Location = new System.Drawing.Point(115, 158);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(101, 18);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "Change: ₱0.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 267);
            this.Controls.Add(this.pnlPayment);
            this.Name = "PaymentWindow";
            this.Text = "Payment Window";
            this.Load += new System.EventHandler(this.PaymentWindow_Load);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Button btnConfirmTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxPayment;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChange;
    }
}