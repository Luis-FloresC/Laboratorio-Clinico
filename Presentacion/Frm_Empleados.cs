using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Empleados : Form
    {
        public Frm_Empleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Empleado_Main nuevoEmpleado = new Frm_Nuevo_Empleado_Main();
            nuevoEmpleado.Show();
        }
    }
}
