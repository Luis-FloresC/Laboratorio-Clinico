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
    public partial class Frm_Reporte_Empleados : Form
    {
        public Frm_Reporte_Empleados()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Empleados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            ReportesEmpleados reportesEmpleados = new ReportesEmpleados();
            reportesEmpleados.ReporteListaDeEmpleados();
            ReportesEmpleadosBindingSource.DataSource = reportesEmpleados;
            EmpleadoBindingSource.DataSource = reportesEmpleados.LisaEmpleados;
        }


    }
}
