using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;

namespace Presentacion
{
    public partial class Cnt_Editar_Usuario : UserControl
    {
        public Cnt_Editar_Usuario()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Editar_Perfil_Main);

            if (frm != null)
            {
                //si la instancia existe la cierro
                frm.Close();
                return;
            }
        }

        private void Cnt_Editar_Usuario_Load(object sender, EventArgs e)
        {
            txtPassword.Text = Cache_Usuario.ContraseniaUsuario;
            txtConfirmarPassword.Text = Cache_Usuario.ContraseniaUsuario;
            txtNombreUser.Text = Cache_Usuario.NombreUsuario;
            txtCorreoElectronico.Text = Cache_Usuario.CorreoElectronicoUsuario;
        }
    }
}
