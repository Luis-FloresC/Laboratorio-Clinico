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
    }
}
