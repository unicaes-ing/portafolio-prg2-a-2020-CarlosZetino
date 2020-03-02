namespace Practica2
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbxDescuento = new System.Windows.Forms.GroupBox();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo20 = new System.Windows.Forms.RadioButton();
            this.rdo0 = new System.Windows.Forms.RadioButton();
            this.rdo15 = new System.Windows.Forms.RadioButton();
            this.rdo10 = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.gbxDescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(198, 224);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(55, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbxDescuento
            // 
            this.gbxDescuento.Controls.Add(this.rdo5);
            this.gbxDescuento.Controls.Add(this.rdo20);
            this.gbxDescuento.Controls.Add(this.rdo0);
            this.gbxDescuento.Controls.Add(this.rdo15);
            this.gbxDescuento.Controls.Add(this.rdo10);
            this.gbxDescuento.Location = new System.Drawing.Point(238, 31);
            this.gbxDescuento.Name = "gbxDescuento";
            this.gbxDescuento.Size = new System.Drawing.Size(83, 166);
            this.gbxDescuento.TabIndex = 21;
            this.gbxDescuento.TabStop = false;
            this.gbxDescuento.Text = "Descuento";
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(6, 61);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(39, 17);
            this.rdo5.TabIndex = 13;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "5%";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // rdo20
            // 
            this.rdo20.AutoSize = true;
            this.rdo20.Location = new System.Drawing.Point(6, 130);
            this.rdo20.Name = "rdo20";
            this.rdo20.Size = new System.Drawing.Size(45, 17);
            this.rdo20.TabIndex = 14;
            this.rdo20.Text = "20%";
            this.rdo20.UseVisualStyleBackColor = true;
            // 
            // rdo0
            // 
            this.rdo0.AutoSize = true;
            this.rdo0.Location = new System.Drawing.Point(6, 38);
            this.rdo0.Name = "rdo0";
            this.rdo0.Size = new System.Drawing.Size(39, 17);
            this.rdo0.TabIndex = 10;
            this.rdo0.TabStop = true;
            this.rdo0.Text = "0%";
            this.rdo0.UseVisualStyleBackColor = true;
            // 
            // rdo15
            // 
            this.rdo15.AutoSize = true;
            this.rdo15.Location = new System.Drawing.Point(6, 107);
            this.rdo15.Name = "rdo15";
            this.rdo15.Size = new System.Drawing.Size(45, 17);
            this.rdo15.TabIndex = 12;
            this.rdo15.TabStop = true;
            this.rdo15.Text = "15%";
            this.rdo15.UseVisualStyleBackColor = true;
            // 
            // rdo10
            // 
            this.rdo10.AutoSize = true;
            this.rdo10.Location = new System.Drawing.Point(6, 84);
            this.rdo10.Name = "rdo10";
            this.rdo10.Size = new System.Drawing.Size(45, 17);
            this.rdo10.TabIndex = 11;
            this.rdo10.TabStop = true;
            this.rdo10.Text = "10%";
            this.rdo10.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(104, 177);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 20;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(104, 137);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 19;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(104, 70);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 18;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(104, 34);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(104, 103);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 21);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(26, 180);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total: ";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(26, 140);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(65, 13);
            this.lblDescuento.TabIndex = 14;
            this.lblDescuento.Text = "Descuento: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 73);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(26, 37);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 286);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbxDescuento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbxDescuento.ResumeLayout(false);
            this.gbxDescuento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbxDescuento;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo20;
        private System.Windows.Forms.RadioButton rdo0;
        private System.Windows.Forms.RadioButton rdo15;
        private System.Windows.Forms.RadioButton rdo10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
    }
}