namespace Practica2
{
    partial class Form3
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.gbxa = new System.Windows.Forms.GroupBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.gbxDe = new System.Windows.Forms.GroupBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.gbxa.SuspendLayout();
            this.gbxDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(202, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(61, 249);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 14;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // gbxa
            // 
            this.gbxa.Controls.Add(this.lst2);
            this.gbxa.Location = new System.Drawing.Point(193, 73);
            this.gbxa.Name = "gbxa";
            this.gbxa.Size = new System.Drawing.Size(143, 100);
            this.gbxa.TabIndex = 13;
            this.gbxa.TabStop = false;
            this.gbxa.Text = "a";
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lst2.Location = new System.Drawing.Point(6, 24);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(131, 69);
            this.lst2.TabIndex = 0;
            // 
            // gbxDe
            // 
            this.gbxDe.Controls.Add(this.lst1);
            this.gbxDe.Location = new System.Drawing.Point(37, 77);
            this.gbxDe.Name = "gbxDe";
            this.gbxDe.Size = new System.Drawing.Size(132, 97);
            this.gbxDe.TabIndex = 12;
            this.gbxDe.TabStop = false;
            this.gbxDe.Text = "De";
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.lst1.Location = new System.Drawing.Point(6, 19);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(120, 69);
            this.lst1.TabIndex = 8;
            // 
            // txtConversion
            // 
            this.txtConversion.Location = new System.Drawing.Point(142, 195);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.Size = new System.Drawing.Size(100, 20);
            this.txtConversion.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(202, 33);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(32, 198);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(104, 13);
            this.lblRes.TabIndex = 9;
            this.lblRes.Text = "Longitud convertida:";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(32, 36);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(164, 13);
            this.lblLong.TabIndex = 8;
            this.lblLong.Text = "Introduzca la longitud a convertir:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 309);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.gbxa);
            this.Controls.Add(this.gbxDe);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblLong);
            this.Name = "Form3";
            this.Text = "Form3";
            this.gbxa.ResumeLayout(false);
            this.gbxDe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.GroupBox gbxa;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.GroupBox gbxDe;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.TextBox txtConversion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblLong;
    }
}