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
using Soporte.Cache;

namespace Presentacion.Resultados_Examenes
{
    public partial class Frm_Resultado_Main : Form
    {
        public Frm_Resultado_Main()
        {
            InitializeComponent();
        }

        private int IdExamenMedicoDetalle = 0;
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
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            byte[] archivo = null;
            Stream myStream = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            myStream.CopyTo(obj);
            archivo = obj.ToArray();
        }
    }
}
