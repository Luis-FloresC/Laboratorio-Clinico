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
    public partial class Frm_Pacientes : Form
    {
        public Frm_Pacientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Pacientes_Load(object sender, EventArgs e)
        {
            int rowEscribir = dg_pacientes.Rows.Count - 1;

            dg_pacientes.Rows.Add(1);

            dg_pacientes.Rows[rowEscribir].Cells[0].Value = "Valor1";
            dg_pacientes.Rows[rowEscribir].Cells[1].Value = "Valor2";
            dg_pacientes.Rows[rowEscribir].Cells[2].Value = "Valor3";
            dg_pacientes.Rows[rowEscribir].Cells[3].Value = "Valor4";
            dg_pacientes.Rows[rowEscribir].Cells[4].Value = "Valor3";
            dg_pacientes.Rows[rowEscribir].Cells[5].Value = "Valor4";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Paciente nuevoPaciente = new Frm_Agregar_Paciente();
            nuevoPaciente.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Paciente nuevoPaciente = new Frm_Agregar_Paciente("Editar Pacientes");
            nuevoPaciente.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Eliminar El Paciente?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                MessageBox.Show("Paciente Eliminado con Éxito","Eliminar Paciente",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
