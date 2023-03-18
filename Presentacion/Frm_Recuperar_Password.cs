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
    public partial class Frm_Recuperar_Password : Form
    {
        public Frm_Recuperar_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(textBox1.Text);
            label2.Text = result;
        }
    }
}
