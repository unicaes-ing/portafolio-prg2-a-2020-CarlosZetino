﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int nt;
            if (int.TryParse(txtNumero.Text, out nt))
            {
                lstTabla.Items.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    lstTabla.Items.Add(nt + " x " + i + " = " + nt * i);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero.");
            }
        }
    }
}
