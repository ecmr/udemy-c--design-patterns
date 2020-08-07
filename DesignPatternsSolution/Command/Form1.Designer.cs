namespace Command
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
            this.btnSetBackgroundColor = new System.Windows.Forms.Button();
            this.btnSetForeGroundColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnSetBackgroundColor
            // 
            this.btnSetBackgroundColor.Location = new System.Drawing.Point(26, 23);
            this.btnSetBackgroundColor.Name = "btnSetBackgroundColor";
            this.btnSetBackgroundColor.Size = new System.Drawing.Size(259, 23);
            this.btnSetBackgroundColor.TabIndex = 0;
            this.btnSetBackgroundColor.Text = "Set Background Color";
            this.btnSetBackgroundColor.UseVisualStyleBackColor = true;
            this.btnSetBackgroundColor.Click += new System.EventHandler(this.btnSetBackgroundColor_Click);
            // 
            // btnSetForeGroundColor
            // 
            this.btnSetForeGroundColor.Location = new System.Drawing.Point(26, 65);
            this.btnSetForeGroundColor.Name = "btnSetForeGroundColor";
            this.btnSetForeGroundColor.Size = new System.Drawing.Size(259, 23);
            this.btnSetForeGroundColor.TabIndex = 1;
            this.btnSetForeGroundColor.Text = "Set Foreground Color";
            this.btnSetForeGroundColor.UseVisualStyleBackColor = true;
            this.btnSetForeGroundColor.Click += new System.EventHandler(this.btnSetForeGroundColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 113);
            this.Controls.Add(this.btnSetForeGroundColor);
            this.Controls.Add(this.btnSetBackgroundColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetBackgroundColor;
        private System.Windows.Forms.Button btnSetForeGroundColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

