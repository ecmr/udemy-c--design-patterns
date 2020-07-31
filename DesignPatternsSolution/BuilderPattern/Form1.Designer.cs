namespace BuilderPattern
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
            this.btnGetDatabase = new System.Windows.Forms.Button();
            this.rBtnOleDb = new System.Windows.Forms.RadioButton();
            this.rBtnSqlServer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGetDatabase
            // 
            this.btnGetDatabase.Location = new System.Drawing.Point(163, 93);
            this.btnGetDatabase.Name = "btnGetDatabase";
            this.btnGetDatabase.Size = new System.Drawing.Size(136, 23);
            this.btnGetDatabase.TabIndex = 5;
            this.btnGetDatabase.Text = "Get Database";
            this.btnGetDatabase.UseVisualStyleBackColor = true;
            this.btnGetDatabase.Click += new System.EventHandler(this.btnGetDatabase_Click);
            // 
            // rBtnOleDb
            // 
            this.rBtnOleDb.AutoSize = true;
            this.rBtnOleDb.Location = new System.Drawing.Point(28, 52);
            this.rBtnOleDb.Name = "rBtnOleDb";
            this.rBtnOleDb.Size = new System.Drawing.Size(77, 17);
            this.rBtnOleDb.TabIndex = 4;
            this.rBtnOleDb.TabStop = true;
            this.rBtnOleDb.Text = "Use OleDb";
            this.rBtnOleDb.UseVisualStyleBackColor = true;
            // 
            // rBtnSqlServer
            // 
            this.rBtnSqlServer.AutoSize = true;
            this.rBtnSqlServer.Location = new System.Drawing.Point(28, 28);
            this.rBtnSqlServer.Name = "rBtnSqlServer";
            this.rBtnSqlServer.Size = new System.Drawing.Size(96, 17);
            this.rBtnSqlServer.TabIndex = 3;
            this.rBtnSqlServer.TabStop = true;
            this.rBtnSqlServer.Text = "Use Sql Server";
            this.rBtnSqlServer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 165);
            this.Controls.Add(this.btnGetDatabase);
            this.Controls.Add(this.rBtnOleDb);
            this.Controls.Add(this.rBtnSqlServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetDatabase;
        private System.Windows.Forms.RadioButton rBtnOleDb;
        private System.Windows.Forms.RadioButton rBtnSqlServer;
    }
}

