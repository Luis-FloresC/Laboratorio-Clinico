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
    public partial class Cnt_Usuarios : UserControl
    {
        public Cnt_Usuarios()
        {
            InitializeComponent();
            Actualizar();
        }

        private UserModel user = new UserModel();
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Usuario_Main user = new Frm_Usuario_Main();
            user.Show();
            user.FormClosed += CerrarSesion;

        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
           Actualizar();
        }

        private void Actualizar()
        {
            dg_Usuarios.DataSource = user.DataTableUsuarios();
            
        }

        private void dg_pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dg_Usuarios.SelectedRows.Count > 0)
            {
                Cache_Usuario.IdUsuarioEdit = Convert.ToInt32(dg_Usuarios.CurrentRow.Cells["Código"].Value);
                Frm_Usuario_Main user = new Frm_Usuario_Main("Editar");
                user.Show();
                user.FormClosed += CerrarSesion;
            }
        }
    }
}
