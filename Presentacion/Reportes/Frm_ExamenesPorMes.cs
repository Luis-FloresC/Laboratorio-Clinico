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

namespace Presentacion.Reportes
{
    public partial class Frm_ExamenesPorMes : Form
    {
        public Frm_ExamenesPorMes()
        {
            InitializeComponent();
        }

        private void Frm_ExamenesPorMes_Load(object sender, EventArgs e)
        {
            Actualizar();
            this.reportViewer1.RefreshReport();
            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteListaDeExamenesPorArea(comboBox1.Text);
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.ListaExamenesPorArea;
        }

        private AnalisisModel analisis = new AnalisisModel();

        private void Actualizar()
        {
            comboBox1.DataSource = analisis.DataTableAnalisisComboBox();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "id";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteListaDeExamenesPorArea(comboBox1.Text);
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.ListaExamenesPorArea;
            this.reportViewer1.RefreshReport();
        }
    }
}
