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
            this.txtbxCategory = new System.Windows.Forms.TextBox();
            this.cmbbxDays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Location = new System.Drawing.Point(122, 91);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.ReadOnly = true;
            this.txtbxTitle.Size = new System.Drawing.Size(160, 20);
            this.txtbxTitle.TabIndex = 0;
            // 
            // txtbxCategory
            // 
            this.txtbxCategory.Location = new System.Drawing.Point(122, 143);
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
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
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
            this.txtbxPrice.ReadOnly = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rent";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
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
            this.Name = "RentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentForm";
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
    }
}