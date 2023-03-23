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
    public partial class Frm_Pacientes : Form
    {
        private PacientesModel pacientes = new PacientesModel();
        private int PagInicio = 1, indice = 0, numFilas = 10, pagFinal;
        public Frm_Pacientes()
        {
            InitializeComponent();
            pagFinal = numFilas;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Pacientes_Load(object sender, EventArgs e)
        {
           Actualizar();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            Utilidades utilidades = new Utilidades();
           
                DataTable dt = new DataTable();
                int totalPacientes = pacientes.totalPacientes();
                dt = pacientes.ListaPacinetes(PagInicio, pagFinal);
                dg_pacientes.DataSource = pacientes.ListaPacinetes(PagInicio, pagFinal); ;
                int cantidad = totalPacientes / numFilas;
               
                if (totalPacientes % numFilas > 0) cantidad++;

                txtTotalPag.Text = cantidad.ToString();
                CmbPag.Items.Clear();

                for (int i = 1; i <= cantidad; i++)
                {
                    CmbPag.Items.Add(i.ToString());
                }

                CmbPag.SelectedIndex = indice;

        }

        private void CmbPag_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Utilidades utilidades = new Utilidades();
            try
            {
                int pagina = Convert.ToInt32(CmbPag.Text);
                indice = pagina - 1;
                PagInicio = (pagina - 1) * numFilas + 1;
                pagFinal = pagina * numFilas;
                Console.WriteLine("Pagina:" + pagina + " Indice: " + indice);
                MessageBox.Show("Pagina: " + CmbPag.Text + " Indice: " + indice);
                Actualizar();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                utilidades.AlertMessage(exception.ToString(), "E");

            }
       
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Agregar_Paciente nuevoPaciente = new Frm_Agregar_Paciente();
            nuevoPaciente.Show();
            nuevoPaciente.FormClosed += CloseForm;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dg_pacientes.SelectedRows.Count > 0)
            {
                Cache_Pacientes.IdPaciente = Convert.ToInt32(dg_pacientes.CurrentRow.Cells["Código"].Value);
                Frm_Agregar_Paciente nuevoPaciente = new Frm_Agregar_Paciente("Editar Paciente");
                nuevoPaciente.Show();
                nuevoPaciente.FormClosed += CloseForm;
            }

            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (dg_pacientes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Paciente?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dg_pacientes.CurrentRow.Cells["Código"].Value);
                    Utilidades utilidades = new Utilidades();
                    var resultado = pacientes.EstadoPaciente(false, id);
                    utilidades.AlertMessage(resultado,"I");
                    Actualizar();
                }
                
            }

          
        }
    }
}
