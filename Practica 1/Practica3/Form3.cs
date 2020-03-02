using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int cont = 0;
            lstDado.Items.Clear();


            for (int i = 0; i <= 5000; i++)
            {
                int num = r.Next(1, 7);
                lstDado.Items.Add(num);
                if (num == 6) cont++;
            }
            MessageBox.Show("Se obtuvo el numero 6 la cantidad de " + cont + " veces.");
        }
    }
}
