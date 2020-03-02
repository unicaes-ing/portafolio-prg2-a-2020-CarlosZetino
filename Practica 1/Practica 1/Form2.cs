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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtDecimal.Focus();

            int Dec = Convert.ToInt32(txtDecimal.Text);
            txtBinario.Text = Convert.ToString(Dec, 2);
            txtOctal.Text = Convert.ToString(Dec, 8);
            txtHexadecimal.Text = Convert.ToString(Dec, 16);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBinario.Text = "";
            txtOctal.Text = "";
            txtHexadecimal.Text = "";
            txtDecimal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
