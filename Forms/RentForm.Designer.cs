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
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.txtbxFormat = new System.Windows.Forms.TextBox();
            this.cmbbxDays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Location = new System.Drawing.Point(122, 91);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(160, 20);
            this.txtbxTitle.TabIndex = 0;
            // 
            // txtbxFormat
            // 
            this.txtbxFormat.Location = new System.Drawing.Point(122, 143);
            this.txtbxFormat.Name = "txtbxFormat";
            this.txtbxFormat.Size = new System.Drawing.Size(160, 20);
            this.txtbxFormat.TabIndex = 1;
            // 
            // cmbbxDays
            // 
            this.cmbbxDays.FormattingEnabled = true;
            this.cmbbxDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbbxDays.Location = new System.Drawing.Point(122, 199);
            this.cmbbxDays.Name = "cmbbxDays";
            this.cmbbxDays.Size = new System.Drawing.Size(160, 21);
            this.cmbbxDays.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days to rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(122, 257);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(160, 20);
            this.txtbxPrice.TabIndex = 6;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(162, 336);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 8;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxDays);
            this.Controls.Add(this.txtbxFormat);
            this.Controls.Add(this.txtbxTitle);
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxTitle;
        private System.Windows.Forms.TextBox txtbxFormat;
        private System.Windows.Forms.ComboBox cmbbxDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Button btnRent;
    }
}