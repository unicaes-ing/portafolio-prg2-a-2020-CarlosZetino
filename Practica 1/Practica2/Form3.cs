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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            Double cantidad;
            cantidad = Convert.ToDouble(txtCantidad.Text);
            String Conversion = lst1.Text;
            String Conversion2 = lst2.Text;
            switch (Conversion)
            {
                case "Pulgadas":
                    switch (Conversion2)
                    {
                        case "Pulgadas":
                            txtConversion.Text = Convert.ToString((cantidad).ToString("N2"));
                            break;
                        case "Pies":
                            txtConversion.Text = Convert.ToString(((cantidad) * 0.0833333).ToString("N2"));
                            break;
                        case "Yardas":
                            txtConversion.Text = Convert.ToString(((cantidad) * 0.0277778).ToString("N2"));
                            break;
                    }
                    break;
                case "Pies":
                    switch (Conversion2)
                    {
                        case "Pulgadas":
                            txtConversion.Text = Convert.ToString(((cantidad) * 12).ToString("N2"));
                            break;
                        case "Pies":
                            txtConversion.Text = Convert.ToString((cantidad).ToString("N2")); break;
                        case "Yardas":
                            txtConversion.Text = Convert.ToString(((cantidad) * 0.333333).ToString("N2"));
                            break;
                    }
                    break;
                case "Yardas":
                    switch (Conversion2)
                    {
                        case "Pulgadas":
                            txtConversion.Text = Convert.ToString(((cantidad) * 36).ToString("N2"));
                            break;
                        case "Pies":
                            txtConversion.Text = Convert.ToString(((cantidad) * 3).ToString("N2"));
                            break;
                        case "Yardas":
                            txtConversion.Text = Convert.ToString((cantidad).ToString("N2")); break;
                    }
                    break;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
