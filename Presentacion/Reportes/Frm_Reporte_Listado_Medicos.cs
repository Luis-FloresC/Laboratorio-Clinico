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
    public partial class Frm_Reporte_Listado_Medicos : Form
    {
        public Frm_Reporte_Listado_Medicos()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Listado_Medicos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteListaDeMedicos();
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.ListMedicos;
        }
    }
}
