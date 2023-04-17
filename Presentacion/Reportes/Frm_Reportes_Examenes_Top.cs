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
    public partial class Frm_Reportes_Examenes_Top : Form
    {
        public Frm_Reportes_Examenes_Top()
        {
            InitializeComponent();
        }

        private void Frm_Reportes_Examenes_Top_Load(object sender, EventArgs e)
        {
            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteExamenesTop();
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.ListExamenesTop;
            this.reportViewer1.RefreshReport();
           
        }
    }
}
