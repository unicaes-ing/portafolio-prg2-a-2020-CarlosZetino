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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inv1, inv2, inv3, total;
            inv1 = Convert.ToDouble(txt1.Text);
            inv2 = Convert.ToDouble(txt2.Text);
            inv3 = Convert.ToDouble(txt3.Text);
            total = inv1 + inv2 + inv3;
            txtPorc1.Text = Convert.ToString(((inv1 / total) * 100).ToString("N2")) + " %";
            txtPorc2.Text = Convert.ToString(((inv2 / total) * 100).ToString("N2")) + " %";
            txtPorc3.Text = Convert.ToString(((inv3 / total) * 100).ToString("N2")) + " %";
            txtTotal.Text = "$ " + total.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txtPorc1.Text = "";
            txtPorc2.Text = "";
            txtPorc3.Text = "";
            txtTotal.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
