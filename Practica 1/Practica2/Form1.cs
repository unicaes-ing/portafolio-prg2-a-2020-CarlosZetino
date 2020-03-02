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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int Numero = Convert.ToInt32(txtNum.Text);
                    string Romano = " ";
                    if (Numero >= 1 && Numero <= 10)
                    {
                        if (Numero == 1)
                        {
                            Romano = "I";
                        }
                        if (Numero == 2)
                        {
                            Romano = "II";
                        }
                        if (Numero == 3)
                        {
                            Romano = "III";
                        }
                        if (Numero == 4)
                        {
                            Romano = "IV";
                        }
                        if (Numero == 5)
                        {
                            Romano = "V";
                        }
                        if (Numero == 6)
                        {
                            Romano = "VI";
                        }
                        if (Numero == 7)
                        {
                            Romano = "VII";
                        }
                        if (Numero == 8)
                        {
                            Romano = "VIII";
                        }
                        if (Numero == 9)
                        {
                            Romano = "IX";
                        }
                        if (Numero == 10)
                        {
                            Romano = "X";
                        }
                        lblResultado.Text = "Equivale a " + Romano + " en romanos.";

                    }
                    else
                    {
                        txtNum.Focus();
                        txtNum.SelectAll();
                        lblResultado.Text = "Ingrese un numero entre 1 y 10";
                    }
                }
                catch (Exception)
                {
                    txtNum.Focus();
                    txtNum.SelectAll();
                    lblResultado.Text = "Solo numeros, intentelo de nuevo.";

                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
