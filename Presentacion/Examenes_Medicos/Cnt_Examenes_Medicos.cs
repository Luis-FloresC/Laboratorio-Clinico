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

namespace Presentacion.Examenes_Medicos
{
    public partial class Cnt_Examenes_Medicos : UserControl
    {
        private ExamenesMedicosModel examenesMedicos = new ExamenesMedicosModel();
        public Cnt_Examenes_Medicos()
        {
            InitializeComponent();
        }

        private void Actualizar()
        {
            dg_Examenes.DataSource = examenesMedicos.DataTableExamenes();
        }

        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private void Cnt_Examenes_Medicos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Examen_Med_Main realizarExamenMedMain = new Frm_Examen_Med_Main();
            realizarExamenMedMain.Show();
            realizarExamenMedMain.FormClosed += CerrarForm;
        }
    }
}
