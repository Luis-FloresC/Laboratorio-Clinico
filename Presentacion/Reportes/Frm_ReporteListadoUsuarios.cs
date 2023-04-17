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
    public partial class Frm_ReporteListadoUsuarios : Form
    {
        public Frm_ReporteListadoUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_ReporteListadoUsuarios_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteListaDeUsuarios();
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.ListUsuarios;
        }
    }
}
