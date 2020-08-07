namespace ChainOfResponsability
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.txtDrawing = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drawing #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result";
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(43, 196);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(373, 31);
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Text = "Please Approve New Material";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "New Material";
            // 
            // txtPart
            // 
            this.txtPart.Location = new System.Drawing.Point(118, 74);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(298, 20);
            this.txtPart.TabIndex = 7;
            this.txtPart.Text = "NM12345";
            // 
            // txtDrawing
            // 
            this.txtDrawing.Location = new System.Drawing.Point(118, 110);
            this.txtDrawing.Name = "txtDrawing";
            this.txtDrawing.Size = new System.Drawing.Size(298, 20);
            this.txtDrawing.TabIndex = 8;
            this.txtDrawing.Text = "513451-367367";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(118, 144);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(298, 20);
            this.txtBudget.TabIndex = 9;
            this.txtBudget.Text = "25";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(43, 260);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(370, 20);
            this.txtResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 362);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtDrawing);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.TextBox txtDrawing;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtResult;
    }
}

