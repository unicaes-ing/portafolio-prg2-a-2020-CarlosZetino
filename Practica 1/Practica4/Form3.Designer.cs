namespace Practica4
{
    partial class Fibonacci
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblFibonacci = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(74, 25);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 0;
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.Location = new System.Drawing.Point(74, 101);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.Size = new System.Drawing.Size(100, 20);
            this.txtFibonacci.TabIndex = 1;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(12, 29);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(47, 13);
            this.lblnum.TabIndex = 2;
            this.lblnum.Text = "Número:";
            // 
            // lblFibonacci
            // 
            this.lblFibonacci.AutoSize = true;
            this.lblFibonacci.Location = new System.Drawing.Point(12, 105);
            this.lblFibonacci.Name = "lblFibonacci";
            this.lblFibonacci.Size = new System.Drawing.Size(56, 13);
            this.lblFibonacci.TabIndex = 3;
            this.lblFibonacci.Text = "Fibonacci:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(87, 60);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 141);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblFibonacci);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.txtFibonacci);
            this.Controls.Add(this.txtnum1);
            this.Name = "Fibonacci";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblFibonacci;
        private System.Windows.Forms.Button btnCalcular;
    }
}