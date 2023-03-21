using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Soporte.Cache;

namespace Presentacion
{
    public partial class Frm_Restablecer_Password : Form
    {
        public Frm_Restablecer_Password()
        {
            InitializeComponent();
        }

        private bool mayuscula, minuscula, numero, carespecial,min;

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("Las Contraseñas deben conincidir...", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if(AlgoritmoContraseñaSegura(textBox1.Text))
            {
                UserModel user = new UserModel();
                var result = user.cambiarContraseña(textBox1.Text,Recuperar_Contraseña.IdUsuario);
                this.Close();
                MessageBox.Show(result, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login newLogin = new Login();
                newLogin.Show();

            }
            else
            {
                MessageBox.Show("Verificar Bien la Contraseña", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AlgoritmoContraseñaSegura(textBox1.Text);
            if (textBox1.Text.Length >= 8)
            {
                min = true;
            }
            else
            {
                min = false;
            }
            ch_min.Checked = min;
            ch_carspecial.Checked = carespecial;
            ch_mayuscula.Checked = mayuscula;
            ch_numero.Checked = numero;
        }

        private bool AlgoritmoContraseñaSegura(string password)
        {
            mayuscula = false;
            minuscula = false;
            numero = false; 
            carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero = true;
                }
                else
                {
                    carespecial = true;
                }
            }
            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                return true;
            }
            return false;
        }
        private void Frm_Restablecer_Password_Load(object sender, EventArgs e)
        {

        }
    }
}
