using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            errorProvider1.Clear();
            if (txtCorreo.TextLength <= 0)
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo");
                validado = false;
            }
            else
            {
                string PatronCorreo = @"^([a-z]{2,}[@]{1}[a-z]{2,}[.]{1,})";
                if (!Regex.IsMatch(txtCorreo.Text, PatronCorreo))
                {
                    errorProvider1.SetError(txtCorreo, "Formato de correo no válido.");
                    validado = false;
                }
            }
            string patronContra = @"^([A-Z]{1,}[a-z]{1,}[0-9]{1,})$";
            if (!Regex.IsMatch(txtContra.Text, patronContra))
            {
                errorProvider1.SetError(txtContra, "Debe contener al menos: \n Una mayúscula, una minúscula, un número y un caracter.");
                validado = false;
            }

            if (txtConfirmar.Text != txtContra.Text)
            {
                errorProvider1.SetError(txtConfirmar, "Las contraseñas no coinciden");
                validado = false;
            }
            if (validado)
            {
                MessageBox.Show("Los datos han sido validados");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
