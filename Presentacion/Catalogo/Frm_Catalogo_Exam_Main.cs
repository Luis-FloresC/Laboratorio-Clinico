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
using Soporte.Utilidades;

namespace Presentacion.Catalogo
{
    public partial class Frm_Catalogo_Exam_Main : UserControl
    {
        private ExamenesModel examenesModel = new ExamenesModel();
        private Utilidades utilidades = new Utilidades();
        public Frm_Catalogo_Exam_Main()
        {
            InitializeComponent();
            Actualizar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Catalogo_Examen_Main nuevoExamenMain = new Frm_Catalogo_Examen_Main();
            nuevoExamenMain.Show();
            nuevoExamenMain.FormClosed += CerrarForm;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dg_examenes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dg_examenes.CurrentRow.Cells["Codigo"].Value);
                Frm_Catalogo_Examen_Main nuevoExamenMain = new Frm_Catalogo_Examen_Main("Editar Examen",id);
                nuevoExamenMain.Show();
                nuevoExamenMain.FormClosed += CerrarForm;
            }

           
        }

        private void Frm_Catalogo_Exam_Main_Load(object sender, EventArgs e)
        {

        }

        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            dg_examenes.DataSource = examenesModel.DataTableExamenes();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (dg_examenes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Examen?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dg_examenes.CurrentRow.Cells["Codigo"].Value);
                    var resultado = examenesModel.BuscarExamenePorId(id);
                    if (resultado)
                    {
                        examenesModel.EditarExamen(Cache_Examenes.Nombre, Cache_Examenes.IdAnalisis,
                            Cache_Examenes.Precio, 0, id);
                    }
                    utilidades.AlertMessage("Examen Eliminado con Exito","I");
                    Actualizar();
                }
               
            }
        }
    }
}
