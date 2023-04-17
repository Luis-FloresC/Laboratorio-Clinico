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
using Presentacion.Pacientes;
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Frm_Examen_Med_Main : Form
    {
        public Frm_Examen_Med_Main()
        {
            InitializeComponent();
        }



        private AnalisisModel analisisModel = new AnalisisModel();
        private ExamenesModel examenesModel = new ExamenesModel();
        private ExamenesMedicosModel examenesMedicosModel = new ExamenesMedicosModel();
        private Utilidades utilidades = new Utilidades();

        private void Actualizar()
        {
            cmb_Analisis.DataSource = analisisModel.DataTableAnalisis();
            cmb_Analisis.ValueMember = "Codigo";
            cmb_Analisis.DisplayMember = "Nombre";
            int id = Convert.ToInt32(cmb_Analisis.SelectedValue);
            cmbExamenes.DataSource = examenesModel.DataTableExamenesPorId(id);
            cmbExamenes.ValueMember = "Codigo";
            cmbExamenes.DisplayMember = "Nombre";
        }

        public Frm_Examen_Med_Main(string accion,string titulo)
        {
            InitializeComponent();
            label1.Text = titulo;
            this.Accion = accion;
        }

        private string Accion = "Nuevo";


        private void Frm_Examen_Med_Main_Load(object sender, EventArgs e)
        {
            if (this.Accion == "Nuevo")
            {
                Actualizar();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int IdPaciente = 0;
        private void CerrarFormBuscar(object sender, FormClosedEventArgs e)
        {
            txtDni.Text = Cache_Pacientes.DniPacienteSelected;
            txtNombre.Text = Cache_Pacientes.NombreCompletoPaciente;
            IdPaciente = Cache_Pacientes.IdPacienteSelected;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Paciente buscarPaciente = new Frm_Buscar_Paciente();
            buscarPaciente.Show();
            buscarPaciente.FormClosed += CerrarFormBuscar;
        }

        private void cmb_Analisis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cmb_Analisis.SelectedValue);
                cmbExamenes.DataSource = examenesModel.DataTableExamenesPorId(id);
                cmbExamenes.ValueMember = "Codigo";
                cmbExamenes.DisplayMember = "Nombre";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (this.Accion == "Nuevo")
            {
                if (utilidades.CampoVacio(txtDni.Text) || utilidades.CampoVacio(cmbExamenes.Text) || utilidades.CampoVacio(cmb_Analisis.Text) || utilidades.CampoVacio(txtNombre.Text))
                {
                    utilidades.AlertMessage("Todos los campos son Obligatorio","A");
                }
                else
                {
                    int idTipoExamen = Convert.ToInt32(cmbExamenes.SelectedValue);
                    int idAnalisis = Convert.ToInt32(cmb_Analisis.SelectedValue);
                    var resultado = examenesMedicosModel.NuevoExamenMedico(txtIndicacines.Text, Cache_Usuario.IdUsuario,
                        IdPaciente, idTipoExamen, idAnalisis);
                    utilidades.AlertMessage(resultado,"I");
                    this.Close();
                }
            }
            else
            {

            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
