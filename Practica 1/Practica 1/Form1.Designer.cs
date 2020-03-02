namespace Practica_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtExamen3 = new System.Windows.Forms.TextBox();
            this.txtExamen2 = new System.Windows.Forms.TextBox();
            this.txtExamen1 = new System.Windows.Forms.TextBox();
            this.lblExamen3 = new System.Windows.Forms.Label();
            this.lblExamen2 = new System.Windows.Forms.Label();
            this.lblexamen1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 22);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(148, 227);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 22);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(35, 227);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(133, 182);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(89, 20);
            this.txtPromedio.TabIndex = 18;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(42, 182);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 17;
            this.lblPromedio.Text = "Promedio";
            // 
            // txtExamen3
            // 
            this.txtExamen3.Location = new System.Drawing.Point(120, 119);
            this.txtExamen3.Name = "txtExamen3";
            this.txtExamen3.Size = new System.Drawing.Size(102, 20);
            this.txtExamen3.TabIndex = 16;
            // 
            // txtExamen2
            // 
            this.txtExamen2.Location = new System.Drawing.Point(120, 80);
            this.txtExamen2.Name = "txtExamen2";
            this.txtExamen2.Size = new System.Drawing.Size(102, 20);
            this.txtExamen2.TabIndex = 15;
            // 
            // txtExamen1
            // 
            this.txtExamen1.Location = new System.Drawing.Point(121, 32);
            this.txtExamen1.Name = "txtExamen1";
            this.txtExamen1.Size = new System.Drawing.Size(102, 20);
            this.txtExamen1.TabIndex = 14;
            // 
            // lblExamen3
            // 
            this.lblExamen3.AutoSize = true;
            this.lblExamen3.Location = new System.Drawing.Point(34, 128);
            this.lblExamen3.Name = "lblExamen3";
            this.lblExamen3.Size = new System.Drawing.Size(54, 13);
            this.lblExamen3.TabIndex = 13;
            this.lblExamen3.Text = "Examen 3";
            // 
            // lblExamen2
            // 
            this.lblExamen2.AutoSize = true;
            this.lblExamen2.Location = new System.Drawing.Point(32, 82);
            this.lblExamen2.Name = "lblExamen2";
            this.lblExamen2.Size = new System.Drawing.Size(54, 13);
            this.lblExamen2.TabIndex = 12;
            this.lblExamen2.Text = "Examen 2";
            // 
            // lblexamen1
            // 
            this.lblexamen1.AutoSize = true;
            this.lblexamen1.Location = new System.Drawing.Point(32, 34);
            this.lblexamen1.Name = "lblexamen1";
            this.lblexamen1.Size = new System.Drawing.Size(54, 13);
            this.lblexamen1.TabIndex = 11;
            this.lblexamen1.Text = "Examen 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 280);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.txtExamen3);
            this.Controls.Add(this.txtExamen2);
            this.Controls.Add(this.txtExamen1);
            this.Controls.Add(this.lblExamen3);
            this.Controls.Add(this.lblExamen2);
            this.Controls.Add(this.lblexamen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtExamen3;
        private System.Windows.Forms.TextBox txtExamen2;
        private System.Windows.Forms.TextBox txtExamen1;
        private System.Windows.Forms.Label lblExamen3;
        private System.Windows.Forms.Label lblExamen2;
        private System.Windows.Forms.Label lblexamen1;
    }
}

