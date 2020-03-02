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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total, IMP;
            total = (Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCantidad.Text));
            txtSubtotal.Text = "$ " + total.ToString("N2");
            IMP = (total * 0.13);
            txtImpuesto.Text = "$ " + IMP.ToString("N2");
            txtTotal.Text = "$ " + Convert.ToString((total + IMP).ToString("N2"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtImpuesto.Text = "";
            txtPrecio.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
