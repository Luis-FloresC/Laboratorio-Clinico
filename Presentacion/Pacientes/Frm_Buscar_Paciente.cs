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

namespace Presentacion.Pacientes
{
    public partial class Frm_Buscar_Paciente : Form
    {
        private PacientesModel pacientesModel = new PacientesModel();
        private void Actualizar()
        {
            dg_pacientes.DataSource = pacientesModel.ListaPacinetes();
        }
        public Frm_Buscar_Paciente()
        {
            InitializeComponent();
        }

        private void Frm_Buscar_Paciente_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (dg_pacientes.SelectedRows.Count > 0)
            {
                Cache_Pacientes.IdPacienteSelected = Convert.ToInt32(dg_pacientes.CurrentRow.Cells["Código"].Value);
                Cache_Pacientes.NombreCompletoPaciente = (dg_pacientes.CurrentRow.Cells["Nombre Completo"].Value.ToString());
                Cache_Pacientes.DniPacienteSelected = (dg_pacientes.CurrentRow.Cells["Dni"].Value.ToString());
                this.Close();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
