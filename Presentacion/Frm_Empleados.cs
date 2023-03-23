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
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Frm_Empleados : Form
    {
        public Frm_Empleados()
        {
            InitializeComponent();
        }

        private EmpleadosModel empleadosModel = new EmpleadosModel();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Nuevo_Empleado_Main nuevoEmpleado = new Frm_Nuevo_Empleado_Main();
            nuevoEmpleado.Show();
            nuevoEmpleado.FormClosed += CloseForm;
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {

            if (dg_empleados.SelectedRows.Count > 0)
            {
                Cache_Empleado.IdEmpleado = Convert.ToInt32(dg_empleados.CurrentRow.Cells["Código"].Value);
                Frm_Nuevo_Empleado_Main nuevoEmpleado = new Frm_Nuevo_Empleado_Main("Editar Empleado");
                nuevoEmpleado.Show();
                nuevoEmpleado.FormClosed += CloseForm;
            }

        }

        private void Frm_Empleados_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            dg_empleados.DataSource = empleadosModel.ListaPacinetes();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (dg_empleados.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Empleado?", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dg_empleados.CurrentRow.Cells["Código"].Value);
                    Utilidades utilidades = new Utilidades();
                    var resultado = empleadosModel.EstadoPaciente(false, id);
                    utilidades.AlertMessage(resultado, "I");
                    Actualizar();
                }

            }
        }
    }
}
