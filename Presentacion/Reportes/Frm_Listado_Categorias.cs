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
    public partial class Frm_Listado_Categorias : Form
    {
        public Frm_Listado_Categorias()
        {
            InitializeComponent();
        }

        private void Frm_Listado_Categorias_Load(object sender, EventArgs e)
        {

           

            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteListaCategorias();
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.ListaCategorias;

            this.reportViewer1.RefreshReport();
        }
    }
}
