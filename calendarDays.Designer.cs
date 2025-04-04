namespace BogsyVideoStore
{
    partial class calendarDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDay = new System.Windows.Forms.Panel();
            this.flwpnlCustomerNames = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.chckbxCheckDay = new System.Windows.Forms.CheckBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDay.SuspendLayout();
            this.flwpnlCustomerNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDay
            // 
            this.pnlDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(102)))), ((int)(((byte)(90)))));
            this.pnlDay.Controls.Add(this.flwpnlCustomerNames);
            this.pnlDay.Controls.Add(this.chckbxCheckDay);
            this.pnlDay.Controls.Add(this.lblDay);
            this.pnlDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDay.Location = new System.Drawing.Point(1, 1);
            this.pnlDay.Name = "pnlDay";
            this.pnlDay.Size = new System.Drawing.Size(88, 88);
            this.pnlDay.TabIndex = 0;
            this.pnlDay.Click += new System.EventHandler(this.pnlDay_Click);
            // 
            // flwpnlCustomerNames
            // 
            this.flwpnlCustomerNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwpnlCustomerNames.Controls.Add(this.label2);
            this.flwpnlCustomerNames.Controls.Add(this.label1);
            this.flwpnlCustomerNames.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flwpnlCustomerNames.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.flwpnlCustomerNames.Location = new System.Drawing.Point(0, 36);
            this.flwpnlCustomerNames.Name = "flwpnlCustomerNames";
            this.flwpnlCustomerNames.Size = new System.Drawing.Size(88, 52);
            this.flwpnlCustomerNames.TabIndex = 2;
            this.flwpnlCustomerNames.Click += new System.EventHandler(this.pnlDay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer name";
            // 
            // chckbxCheckDay
            // 
            this.chckbxCheckDay.AutoSize = true;
            this.chckbxCheckDay.Location = new System.Drawing.Point(3, 3);
            this.chckbxCheckDay.Name = "chckbxCheckDay";
            this.chckbxCheckDay.Size = new System.Drawing.Size(15, 14);
            this.chckbxCheckDay.TabIndex = 1;
            this.chckbxCheckDay.UseVisualStyleBackColor = true;
            this.chckbxCheckDay.Visible = false;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDay.Location = new System.Drawing.Point(61, 3);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(27, 19);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name";
            // 
            // calendarDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlDay);
            this.Name = "calendarDays";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(90, 90);
            this.Load += new System.EventHandler(this.calendarDays_Load);
            this.pnlDay.ResumeLayout(false);
            this.pnlDay.PerformLayout();
            this.flwpnlCustomerNames.ResumeLayout(false);
            this.flwpnlCustomerNames.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDay;
        private System.Windows.Forms.CheckBox chckbxCheckDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.FlowLayoutPanel flwpnlCustomerNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
