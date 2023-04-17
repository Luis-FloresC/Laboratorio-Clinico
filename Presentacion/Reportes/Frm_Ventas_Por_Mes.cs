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
    public partial class Frm_Ventas_Por_Mes : Form
    {
        public Frm_Ventas_Por_Mes()
        {
            InitializeComponent();
        }

        private void Frm_Ventas_Por_Mes_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Enero";
            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteVentasPorMes(comboBox1.Text, comboBox1.SelectedIndex + 1);
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.VentasPorMes;
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReporteModel reporteModel = new ReporteModel();
            reporteModel.ReporteVentasPorMes(comboBox1.Text,comboBox1.SelectedIndex + 1);
            ReporteModelBindingSource.DataSource = reporteModel;
            ReportesBindingSource.DataSource = reporteModel.VentasPorMes;
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
