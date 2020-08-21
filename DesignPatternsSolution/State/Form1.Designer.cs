namespace State
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
            this.i = new System.Windows.Forms.Button();
            this.btnUpgradeUser = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNextPageToShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(57, 35);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(343, 23);
            this.i.TabIndex = 0;
            this.i.Text = "Log in";
            this.i.UseVisualStyleBackColor = true;
            this.i.Click += new System.EventHandler(this.i_Click);
            // 
            // btnUpgradeUser
            // 
            this.btnUpgradeUser.Location = new System.Drawing.Point(57, 78);
            this.btnUpgradeUser.Name = "btnUpgradeUser";
            this.btnUpgradeUser.Size = new System.Drawing.Size(343, 23);
            this.btnUpgradeUser.TabIndex = 1;
            this.btnUpgradeUser.Text = "Upgrade User";
            this.btnUpgradeUser.UseVisualStyleBackColor = true;
            this.btnUpgradeUser.Click += new System.EventHandler(this.btnUpgradeUser_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(57, 119);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(343, 23);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Next Page to Show:";
            // 
            // txtNextPageToShow
            // 
            this.txtNextPageToShow.Location = new System.Drawing.Point(57, 200);
            this.txtNextPageToShow.Name = "txtNextPageToShow";
            this.txtNextPageToShow.Size = new System.Drawing.Size(343, 20);
            this.txtNextPageToShow.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 259);
            this.Controls.Add(this.txtNextPageToShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUpgradeUser);
            this.Controls.Add(this.i);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button i;
        private System.Windows.Forms.Button btnUpgradeUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNextPageToShow;
    }
}

