namespace Composite
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
            this.btnBuildPartsList = new System.Windows.Forms.Button();
            this.listParts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnBuildPartsList
            // 
            this.btnBuildPartsList.Location = new System.Drawing.Point(21, 27);
            this.btnBuildPartsList.Name = "btnBuildPartsList";
            this.btnBuildPartsList.Size = new System.Drawing.Size(222, 47);
            this.btnBuildPartsList.TabIndex = 0;
            this.btnBuildPartsList.Text = "Build Parts List";
            this.btnBuildPartsList.UseVisualStyleBackColor = true;
            this.btnBuildPartsList.Click += new System.EventHandler(this.btnBuildPartsList_Click);
            // 
            // listParts
            // 
            this.listParts.HideSelection = false;
            this.listParts.Location = new System.Drawing.Point(21, 80);
            this.listParts.Name = "listParts";
            this.listParts.Size = new System.Drawing.Size(222, 358);
            this.listParts.TabIndex = 1;
            this.listParts.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(this.listParts);
            this.Controls.Add(this.btnBuildPartsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuildPartsList;
        private System.Windows.Forms.ListView listParts;
    }
}

