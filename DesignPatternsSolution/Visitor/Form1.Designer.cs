namespace Visitor
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblGreg = new System.Windows.Forms.Label();
            this.lblRichard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Credits";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(32, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(259, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Expiration";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblGreg
            // 
            this.lblGreg.AutoSize = true;
            this.lblGreg.Location = new System.Drawing.Point(32, 119);
            this.lblGreg.Name = "lblGreg";
            this.lblGreg.Size = new System.Drawing.Size(63, 13);
            this.lblGreg.TabIndex = 2;
            this.lblGreg.Text = "Greg Status";
            // 
            // lblRichard
            // 
            this.lblRichard.AutoSize = true;
            this.lblRichard.Location = new System.Drawing.Point(32, 150);
            this.lblRichard.Name = "lblRichard";
            this.lblRichard.Size = new System.Drawing.Size(77, 13);
            this.lblRichard.TabIndex = 3;
            this.lblRichard.Text = "Richard Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 285);
            this.Controls.Add(this.lblRichard);
            this.Controls.Add(this.lblGreg);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblGreg;
        private System.Windows.Forms.Label lblRichard;
    }
}

