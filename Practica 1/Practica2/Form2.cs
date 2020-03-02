using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total, desc;
            total = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);


            if (rdo0.Checked)
            {
                desc = total * 0.0;
                txtDescuento.Text = "$ " + Convert.ToString((total * 0.00).ToString("N2"));
                txtTotal.Text = "$ " + Convert.ToString((total - desc).ToString("N2"));

            }
            else if (rdo5.Checked)
            {
                desc = total * 0.05;
                txtDescuento.Text = "$ " + Convert.ToString((total * 0.05).ToString("N2"));
                txtTotal.Text = "$ " + Convert.ToString((total - desc).ToString("N2"));
            }
            else if (rdo10.Checked)
            {
                desc = total * 0.10;
                txtDescuento.Text = "$ " + Convert.ToString((total * 0.10).ToString("N2"));
                txtTotal.Text = "$ " + Convert.ToString((total - desc).ToString("N2"));
            }
            else if (rdo15.Checked)
            {
                desc = total * 0.15;
                txtDescuento.Text = "$ " + Convert.ToString((total * 0.15).ToString("N2"));
                txtTotal.Text = "$ " + Convert.ToString((total - desc).ToString("N2"));
            }
            else if (rdo20.Checked)
            {
                desc = total * 0.20;
                txtDescuento.Text = "$ " + Convert.ToString((total * 0.20).ToString("N2"));
                txtTotal.Text = "$ " + Convert.ToString((total - desc).ToString("N2"));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtDescuento.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
