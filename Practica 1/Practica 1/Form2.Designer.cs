namespace Practica_1
{
    partial class Form2
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
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtHexadecimal = new System.Windows.Forms.TextBox();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(95, 28);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 4;
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.btnSalir);
            this.grpResultado.Controls.Add(this.btnLimpiar);
            this.grpResultado.Controls.Add(this.btnCalcular);
            this.grpResultado.Controls.Add(this.txtHexadecimal);
            this.grpResultado.Controls.Add(this.txtOctal);
            this.grpResultado.Controls.Add(this.txtBinario);
            this.grpResultado.Controls.Add(this.label1);
            this.grpResultado.Controls.Add(this.lblOctal);
            this.grpResultado.Controls.Add(this.lblBinario);
            this.grpResultado.Location = new System.Drawing.Point(24, 74);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(234, 166);
            this.grpResultado.TabIndex = 5;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Equivale a:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(173, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 20);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(90, 135);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 20);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(4, 135);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(70, 20);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtHexadecimal
            // 
            this.txtHexadecimal.Location = new System.Drawing.Point(120, 98);
            this.txtHexadecimal.Name = "txtHexadecimal";
            this.txtHexadecimal.ReadOnly = true;
            this.txtHexadecimal.Size = new System.Drawing.Size(86, 20);
            this.txtHexadecimal.TabIndex = 5;
            // 
            // txtOctal
            // 
            this.txtOctal.Location = new System.Drawing.Point(119, 66);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.ReadOnly = true;
            this.txtOctal.Size = new System.Drawing.Size(87, 20);
            this.txtOctal.TabIndex = 4;
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(120, 38);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.ReadOnly = true;
            this.txtBinario.Size = new System.Drawing.Size(86, 20);
            this.txtBinario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hexadecimal:";
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(25, 70);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(35, 13);
            this.lblOctal.TabIndex = 1;
            this.lblOctal.Text = "Octal:";
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Location = new System.Drawing.Point(25, 39);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(42, 13);
            this.lblBinario.TabIndex = 0;
            this.lblBinario.Text = "Binario:";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(31, 29);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(48, 13);
            this.lblDecimal.TabIndex = 3;
            this.lblDecimal.Text = "Decimal:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 257);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.lblDecimal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtHexadecimal;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblDecimal;
    }
}