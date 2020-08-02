namespace Singleton
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
            this.btnDoSomenthingBad = new System.Windows.Forms.Button();
            this.btnGoToForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoSomenthingBad
            // 
            this.btnDoSomenthingBad.Location = new System.Drawing.Point(56, 27);
            this.btnDoSomenthingBad.Name = "btnDoSomenthingBad";
            this.btnDoSomenthingBad.Size = new System.Drawing.Size(141, 23);
            this.btnDoSomenthingBad.TabIndex = 0;
            this.btnDoSomenthingBad.Text = "Do Something Bad";
            this.btnDoSomenthingBad.UseVisualStyleBackColor = true;
            this.btnDoSomenthingBad.Click += new System.EventHandler(this.btnDoSomenthingBad_Click);
            // 
            // btnGoToForm2
            // 
            this.btnGoToForm2.Location = new System.Drawing.Point(56, 79);
            this.btnGoToForm2.Name = "btnGoToForm2";
            this.btnGoToForm2.Size = new System.Drawing.Size(75, 23);
            this.btnGoToForm2.TabIndex = 1;
            this.btnGoToForm2.Text = "Go to Form 2";
            this.btnGoToForm2.UseVisualStyleBackColor = true;
            this.btnGoToForm2.Click += new System.EventHandler(this.btnGoToForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 233);
            this.Controls.Add(this.btnGoToForm2);
            this.Controls.Add(this.btnDoSomenthingBad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoSomenthingBad;
        private System.Windows.Forms.Button btnGoToForm2;
    }
}

