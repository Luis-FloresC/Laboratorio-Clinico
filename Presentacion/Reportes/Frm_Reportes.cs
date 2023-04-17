using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Reportes;

namespace Presentacion
{
    public partial class Frm_Reportes : Form
    {
        public Frm_Reportes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Empleados reporteEmpleados = new Frm_Reporte_Empleados();
            reporteEmpleados.Show();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Frm_ReporteListadoUsuarios reporteListadoUsuarios = new Frm_ReporteListadoUsuarios();
            reporteListadoUsuarios.Show();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Inventario inventario = new Frm_Reporte_Inventario();
            inventario.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Frm_ExamenesPorMes examenesPorMes = new Frm_ExamenesPorMes();
            examenesPorMes.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_ReporteDeVentas ventas = new Frm_ReporteDeVentas();
            ventas.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Frm_Ventas_Por_Mes ventasPorMes = new Frm_Ventas_Por_Mes();
            ventasPorMes.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Frm_Reportes_Examenes_Top examenesTop = new Frm_Reportes_Examenes_Top();
            examenesTop.Show();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Listado_Medicos medicos = new Frm_Reporte_Listado_Medicos();
            medicos.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Frm_Examenes_Top_Precios topPrecios = new Frm_Examenes_Top_Precios();
            topPrecios.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Frm_Listado_Categorias categorias = new Frm_Listado_Categorias();
            categorias.Show();
        }
    }
}
