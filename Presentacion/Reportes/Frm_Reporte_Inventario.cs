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
    public partial class Frm_Reporte_Inventario : Form
    {
        public Frm_Reporte_Inventario()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Inventario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteInventario();
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.ListaInventario;
        }
    }
}
