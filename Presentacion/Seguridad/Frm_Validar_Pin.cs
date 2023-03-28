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

namespace Presentacion
{
    public partial class Frm_Validar_Pin : Form
    {
        public Frm_Validar_Pin()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.buscarUsuarioPorPin(textBox1.Text);
            if (result)
            {
               this.Hide();
               var restablecer = new Frm_Restablecer_Password();
               restablecer.Show();
            }
            else
            {
                label2.Visible = true;
                label2.Text = "Pin Incorrecto";
            }
        }
    }
}
