using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion.Resultados_Examenes
{
    public partial class Frm_Resultado_Main : Form
    {
        public Frm_Resultado_Main()
        {
            InitializeComponent();
        }

        private int IdExamenMedicoDetalle = 0;
        private ResultadosExamenesMedicosModel resultadosExamenes = new ResultadosExamenesMedicosModel();
        private Utilidades utilidades = new Utilidades();

        private void CargarDatos(object sender, FormClosedEventArgs e)
        {
            txtExamen.Text = Cache_Examenes.NombreExamen;
            txtPaciente.Text = Cache_Examenes.NombrePaciente;
            IdExamenMedicoDetalle = Cache_Examenes.IdExamenMedico;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Frm_Buscar_Examen_Medico buscarExamen = new Frm_Buscar_Examen_Medico();
            buscarExamen.Show();
            buscarExamen.FormClosed += CargarDatos;
        }

        private void Frm_Resultado_Main_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
                txtNombreArchivo.Text = "P - " + txtPaciente.Text + " - " + txtExamen.Text;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            if (utilidades.CampoVacio(txtNombreArchivo.Text) || utilidades.CampoVacio(txtExamen.Text))
            {
                utilidades.AlertMessage("Todos los Campos son Obligatorios","A");
            }
            else
            {
                byte[] archivo = null;
                string extension = "";
                Stream myStream = openFileDialog1.OpenFile();
                MemoryStream obj = new MemoryStream();
                myStream.CopyTo(obj);
                archivo = obj.ToArray();
                extension = openFileDialog1.SafeFileName;
                txtNombreArchivo.Text = "P - " + txtPaciente.Text + " - " + txtExamen.Text;

                var result = resultadosExamenes.NuevoResultadoExamenMedico(txtNombreArchivo.Text,
                    Cache_Usuario.IdUsuario, archivo, IdExamenMedicoDetalle, extension);
             
                utilidades.AlertMessage(result,"I");
                this.Close();

            }

          


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
