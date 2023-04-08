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
using Presentacion.Medicos;
using Soporte.Cache;

namespace Presentacion
{
    public partial class Cnt_Medicos : UserControl
    {
        public Cnt_Medicos()
        {
            InitializeComponent();
        }

        private MedicosModel medicosModel = new MedicosModel();
        private void Cnt_Medicos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            dg_medicos.DataSource = medicosModel.DataTableMedicos();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Medicos_Crud medicosCrud = new Frm_Medicos_Crud();
            medicosCrud.Show();
            medicosCrud.FormClosed += Logout;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dg_medicos.SelectedRows.Count > 0)
            {
                Cache_Medico.IdMedico = Convert.ToInt32(dg_medicos.CurrentRow.Cells["Código"].Value);
                Frm_Medicos_Crud medicosCrud = new Frm_Medicos_Crud("Editar");
                medicosCrud.Show();
                medicosCrud.FormClosed += Logout;
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (dg_medicos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dg_medicos.CurrentRow.Cells["Código"].Value);
                string nombre = dg_medicos.CurrentRow.Cells["Nombre"].Value.ToString();
                Frm_Asignar_Especialidades especialidades = new Frm_Asignar_Especialidades(id, nombre);
                especialidades.Show();
                especialidades.FormClosed += Logout;
            }
        }
    }
}
