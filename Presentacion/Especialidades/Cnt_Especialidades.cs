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
using Presentacion.Especialidades;
using Presentacion.Seguridad;

namespace Presentacion
{
    public partial class Cnt_Especialidades : UserControl
    {
        public Cnt_Especialidades()
        {
            InitializeComponent();
        }

        private EspecialidadesModel especialidadesModel = new EspecialidadesModel();

        private void Cnt_Especialidades_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            dg_especialidades.DataSource = especialidadesModel.DataTableEspecialidades();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Especialidades_Main especialidades = new Frm_Especialidades_Main();
            especialidades.Show();
            especialidades.FormClosed += Logout;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dg_especialidades.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dg_especialidades.CurrentRow.Cells["Codigo"].Value);
                string nombre = dg_especialidades.CurrentRow.Cells["Especialidad"].Value.ToString();
                bool estado = Convert.ToBoolean(dg_especialidades.CurrentRow.Cells["Activo"].Value);
                Frm_Especialidades_Main especialidades = new Frm_Especialidades_Main("Editar",id,nombre,estado);
                especialidades.Show();
                especialidades.FormClosed += Logout;
            }
        }
    }
}
