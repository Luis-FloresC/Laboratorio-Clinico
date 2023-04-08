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
using Presentacion.Seguridad;
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Cnt_Roles : UserControl
    {
        public Cnt_Roles()
        {
            InitializeComponent();
        }

        private SeguridadModel seguridadModel = new SeguridadModel();
        private Utilidades utilidades = new Utilidades();
        private void Actualizar()
        {
            dg_roles.DataSource = seguridadModel.DataTableRoles();
        }
        private void Cnt_Roles_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Rol_Main rolMain = new Frm_Rol_Main();
            rolMain.Show();
            rolMain.FormClosed += CerrarForm;
        }

        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dg_roles.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dg_roles.CurrentRow.Cells["Codigo"].Value);
                string rol = dg_roles.CurrentRow.Cells["Cargo"].Value.ToString();
                bool estado = Convert.ToBoolean(dg_roles.CurrentRow.Cells["Activo"].Value);
                Frm_Rol_Main roleMain = new Frm_Rol_Main("Editar",id,rol,estado);
                roleMain.Show();
                roleMain.FormClosed += CerrarForm;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (dg_roles.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dg_roles.CurrentRow.Cells["Codigo"].Value);
                string rol = dg_roles.CurrentRow.Cells["Cargo"].Value.ToString();
                bool estado = Convert.ToBoolean(dg_roles.CurrentRow.Cells["Activo"].Value);
                seguridadModel.EdiatrRol(rol, false, id);
                utilidades.AlertMessage("El Cargo se elimino con Éxito","I");
                Actualizar();
            }
        }
    }
}
