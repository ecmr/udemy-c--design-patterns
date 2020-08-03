namespace Decorator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo8 = new System.Windows.Forms.RadioButton();
            this.rdo16 = new System.Windows.Forms.RadioButton();
            this.rdo256 = new System.Windows.Forms.RadioButton();
            this.rdo128 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo512 = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ckbDiscount = new System.Windows.Forms.CheckBox();
            this.lblModelRash = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo16);
            this.groupBox1.Controls.Add(this.rdo8);
            this.groupBox1.Location = new System.Drawing.Point(40, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memory";
            // 
            // rdo8
            // 
            this.rdo8.AutoSize = true;
            this.rdo8.Location = new System.Drawing.Point(7, 20);
            this.rdo8.Name = "rdo8";
            this.rdo8.Size = new System.Drawing.Size(95, 17);
            this.rdo8.TabIndex = 0;
            this.rdo8.TabStop = true;
            this.rdo8.Text = "8 GBytes ($70)";
            this.rdo8.UseVisualStyleBackColor = true;
            // 
            // rdo16
            // 
            this.rdo16.AutoSize = true;
            this.rdo16.Location = new System.Drawing.Point(7, 56);
            this.rdo16.Name = "rdo16";
            this.rdo16.Size = new System.Drawing.Size(107, 17);
            this.rdo16.TabIndex = 1;
            this.rdo16.TabStop = true;
            this.rdo16.Text = "16 GBytes ($150)";
            this.rdo16.UseVisualStyleBackColor = true;
            // 
            // rdo256
            // 
            this.rdo256.AutoSize = true;
            this.rdo256.Location = new System.Drawing.Point(7, 59);
            this.rdo256.Name = "rdo256";
            this.rdo256.Size = new System.Drawing.Size(133, 17);
            this.rdo256.TabIndex = 1;
            this.rdo256.TabStop = true;
            this.rdo256.Text = "256 GByte SSD ($120)";
            this.rdo256.UseVisualStyleBackColor = true;
            // 
            // rdo128
            // 
            this.rdo128.AutoSize = true;
            this.rdo128.Location = new System.Drawing.Point(11, 25);
            this.rdo128.Name = "rdo128";
            this.rdo128.Size = new System.Drawing.Size(127, 17);
            this.rdo128.TabIndex = 0;
            this.rdo128.TabStop = true;
            this.rdo128.Text = "128 GByte SSD ($74)";
            this.rdo128.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo512);
            this.groupBox2.Controls.Add(this.rdo256);
            this.groupBox2.Controls.Add(this.rdo128);
            this.groupBox2.Location = new System.Drawing.Point(40, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 117);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Storage";
            // 
            // rdo512
            // 
            this.rdo512.AutoSize = true;
            this.rdo512.Location = new System.Drawing.Point(7, 93);
            this.rdo512.Name = "rdo512";
            this.rdo512.Size = new System.Drawing.Size(133, 17);
            this.rdo512.TabIndex = 2;
            this.rdo512.TabStop = true;
            this.rdo512.Text = "512 GByte SSD ($223)";
            this.rdo512.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(47, 293);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(333, 23);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:                                                                           " +
    "                $0";
            // 
            // ckbDiscount
            // 
            this.ckbDiscount.AutoSize = true;
            this.ckbDiscount.Location = new System.Drawing.Point(47, 261);
            this.ckbDiscount.Name = "ckbDiscount";
            this.ckbDiscount.Size = new System.Drawing.Size(97, 17);
            this.ckbDiscount.TabIndex = 4;
            this.ckbDiscount.Text = "Apply Discount";
            this.ckbDiscount.UseVisualStyleBackColor = true;
            // 
            // lblModelRash
            // 
            this.lblModelRash.AutoSize = true;
            this.lblModelRash.Location = new System.Drawing.Point(51, 328);
            this.lblModelRash.Name = "lblModelRash";
            this.lblModelRash.Size = new System.Drawing.Size(49, 13);
            this.lblModelRash.TabIndex = 5;
            this.lblModelRash.Text = "Model #:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(54, 354);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 379);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblModelRash);
            this.Controls.Add(this.ckbDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo16;
        private System.Windows.Forms.RadioButton rdo8;
        private System.Windows.Forms.RadioButton rdo256;
        private System.Windows.Forms.RadioButton rdo128;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo512;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox ckbDiscount;
        private System.Windows.Forms.Label lblModelRash;
        private System.Windows.Forms.Label lblModel;
    }
}

