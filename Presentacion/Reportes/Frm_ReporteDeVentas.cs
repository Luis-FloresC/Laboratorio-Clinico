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
using Soporte.Utilidades;

namespace Presentacion.Reportes
{
    public partial class Frm_ReporteDeVentas : Form
    {
        public Frm_ReporteDeVentas()
        {
            InitializeComponent();
        }

        private Utilidades utilidades = new Utilidades();
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (utilidades.CheckDates(fechaInicial.Value, fechaFinal.Value))
            {
                ReporteModel reporteModel = new ReporteModel();
                reporteModel.ReporteVentas(fechaInicial.Value,fechaFinal.Value);
                ReporteModelBindingSource.DataSource = reporteModel;
                ReportesBindingSource.DataSource = reporteModel.VentasPorPeriodo;
                this.reportViewer1.RefreshReport();
            }
            else
            {
                utilidades.AlertMessage("La fecha final no puede ser menor a la fecha inicial","A");
            }
        }

        private void Frm_ReporteDeVentas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
