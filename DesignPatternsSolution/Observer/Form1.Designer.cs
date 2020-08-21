namespace Observer
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
            this.label1 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnNewPrice = new System.Windows.Forms.Button();
            this.lblObserver1 = new System.Windows.Forms.Label();
            this.lblObserver2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPrice.Location = new System.Drawing.Point(63, 43);
            this.numPrice.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            65536});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 1;
            this.numPrice.Value = new decimal(new int[] {
            250,
            0,
            0,
            131072});
            // 
            // btnNewPrice
            // 
            this.btnNewPrice.Location = new System.Drawing.Point(63, 91);
            this.btnNewPrice.Name = "btnNewPrice";
            this.btnNewPrice.Size = new System.Drawing.Size(154, 23);
            this.btnNewPrice.TabIndex = 2;
            this.btnNewPrice.Text = "Set New Price";
            this.btnNewPrice.UseVisualStyleBackColor = true;
            this.btnNewPrice.Click += new System.EventHandler(this.btnNewPrice_Click);
            // 
            // lblObserver1
            // 
            this.lblObserver1.AutoSize = true;
            this.lblObserver1.Location = new System.Drawing.Point(28, 137);
            this.lblObserver1.Name = "lblObserver1";
            this.lblObserver1.Size = new System.Drawing.Size(62, 13);
            this.lblObserver1.TabIndex = 3;
            this.lblObserver1.Text = "Observer 1:";
            // 
            // lblObserver2
            // 
            this.lblObserver2.AutoSize = true;
            this.lblObserver2.Location = new System.Drawing.Point(31, 182);
            this.lblObserver2.Name = "lblObserver2";
            this.lblObserver2.Size = new System.Drawing.Size(62, 13);
            this.lblObserver2.TabIndex = 4;
            this.lblObserver2.Text = "Observer 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 297);
            this.Controls.Add(this.lblObserver2);
            this.Controls.Add(this.lblObserver1);
            this.Controls.Add(this.btnNewPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnNewPrice;
        private System.Windows.Forms.Label lblObserver1;
        private System.Windows.Forms.Label lblObserver2;
    }
}

