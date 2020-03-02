using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Promedio;
            Promedio = Convert.ToDouble(txtExamen1.Text) + Convert.ToDouble(txtExamen2.Text) + Convert.ToDouble(txtExamen3.Text);
            txtPromedio.Text = (Promedio / 3).ToString("N2");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExamen1.Text = "";
            txtExamen2.Text = "";
            txtExamen3.Text = "";
            txtPromedio.Text = "";
        }
    }
}
