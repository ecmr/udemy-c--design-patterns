namespace Strategy
{
    partial class Form1
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
            this.ckbStudent = new System.Windows.Forms.CheckBox();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.ckbLoyaly = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.nupdtotalSale = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupdtotalSale)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbStudent
            // 
            this.ckbStudent.AutoSize = true;
            this.ckbStudent.Location = new System.Drawing.Point(42, 42);
            this.ckbStudent.Name = "ckbStudent";
            this.ckbStudent.Size = new System.Drawing.Size(108, 17);
            this.ckbStudent.TabIndex = 0;
            this.ckbStudent.Text = "Student Discount";
            this.ckbStudent.UseVisualStyleBackColor = true;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.Location = new System.Drawing.Point(103, 166);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(119, 23);
            this.btnApplyDiscount.TabIndex = 1;
            this.btnApplyDiscount.Text = "Apply Discounts";
            this.btnApplyDiscount.UseVisualStyleBackColor = true;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // ckbLoyaly
            // 
            this.ckbLoyaly.AutoSize = true;
            this.ckbLoyaly.Location = new System.Drawing.Point(42, 75);
            this.ckbLoyaly.Name = "ckbLoyaly";
            this.ckbLoyaly.Size = new System.Drawing.Size(107, 17);
            this.ckbLoyaly.TabIndex = 2;
            this.ckbLoyaly.Text = "Loyally Doscount";
            this.ckbLoyaly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Sale";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(82, 223);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(56, 13);
            this.lblFinalPrice.TabIndex = 4;
            this.lblFinalPrice.Text = "Final Price";
            // 
            // nupdtotalSale
            // 
            this.nupdtotalSale.Location = new System.Drawing.Point(103, 124);
            this.nupdtotalSale.Name = "nupdtotalSale";
            this.nupdtotalSale.Size = new System.Drawing.Size(120, 20);
            this.nupdtotalSale.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 344);
            this.Controls.Add(this.nupdtotalSale);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbLoyaly);
            this.Controls.Add(this.btnApplyDiscount);
            this.Controls.Add(this.ckbStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupdtotalSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbStudent;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.CheckBox ckbLoyaly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.NumericUpDown nupdtotalSale;
    }
}

