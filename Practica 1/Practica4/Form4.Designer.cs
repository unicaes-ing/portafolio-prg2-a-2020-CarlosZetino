namespace Practica4
{
    partial class Form4
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
            this.lblMayor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnMayor = new System.Windows.Forms.Button();
            this.lblnum3 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(96, 234);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(0, 13);
            this.lblMayor.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mayor:";
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(109, 132);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(100, 20);
            this.txtNum3.TabIndex = 15;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(109, 83);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 14;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(109, 34);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 13;
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(109, 174);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(75, 23);
            this.btnMayor.TabIndex = 12;
            this.btnMayor.Text = "Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // lblnum3
            // 
            this.lblnum3.AutoSize = true;
            this.lblnum3.Location = new System.Drawing.Point(37, 135);
            this.lblnum3.Name = "lblnum3";
            this.lblnum3.Size = new System.Drawing.Size(56, 13);
            this.lblnum3.TabIndex = 11;
            this.lblnum3.Text = "Número 3:";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(37, 86);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(56, 13);
            this.lblnum2.TabIndex = 10;
            this.lblnum2.Text = "Número 2:";
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(37, 37);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(56, 13);
            this.lblnum1.TabIndex = 9;
            this.lblnum1.Text = "Número 1:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 270);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.lblnum3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Label lblnum3;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblnum1;
    }
}