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

namespace Presentacion.Resultados_Examenes
{
    public partial class Frm_Buscar_Examen_Medico : Form
    {
        public Frm_Buscar_Examen_Medico()
        {
            InitializeComponent();
        }

        private ExamenesMedicosModel examenesMedicos = new ExamenesMedicosModel();

        private void Actualizar()
        {
            dg_examen.DataSource = examenesMedicos.DataTableExamenes();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Buscar_Examen_Medico_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            /**
             *    em.Id_Examen_Med 'Codigo'
                                    ,e.Nombre_Exm 'Nombre del Examen'
                                    ,CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) 'Paciente'
             */
            if (dg_examen.SelectedRows.Count > 0)
            {
                Cache_Examenes.IdExamenMedico = Convert.ToInt32(dg_examen.CurrentRow.Cells["Codigo"].Value);
                Cache_Examenes.NombreExamen = (dg_examen.CurrentRow.Cells["Nombre del Examen"].Value.ToString());
                Cache_Examenes.NombrePaciente = (dg_examen.CurrentRow.Cells["Paciente"].Value.ToString());
               
                this.Close();
            }
        }
    }
}
