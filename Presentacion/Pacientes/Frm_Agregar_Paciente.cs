using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
using Soporte.Cache;
using Soporte.Utilidades;

namespace Presentacion
{
    public partial class Frm_Agregar_Paciente : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Frm_Agregar_Paciente()
        {
            InitializeComponent();
        }

        private string Titulo = "Nuevo Paciente";
        public Frm_Agregar_Paciente(string titulo)
        {
            InitializeComponent();
            label1.Text = titulo;
            Titulo = titulo;
            CargarDatos();


        }

        private void CargarDatos()
        {
            PacientesModel paciente = new PacientesModel();

            var result = paciente.BuscarPacienteId(Cache_Pacientes.IdPaciente);
            if (result)
            {
                txtNombre.Text = Cache_Pacientes.NombrePaciente;
                txtApellido.Text = Cache_Pacientes.ApellidoPaciente;
                txtTelefono.Text = Cache_Pacientes.TelefonoPaciente;
                txtDni.Text = Cache_Pacientes.DniPaciente;
                TxtDireccion.Text = Cache_Pacientes.DireccionPaciente;
                cmbGenero.Text = Cache_Pacientes.GeneroPaciente;
                DtpFechaNac.Value = Cache_Pacientes.FechaNacimientoPaciente;
            }
            else
            {
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Agregar_Paciente_Load(object sender, EventArgs e)
        {

        }

        private void pnl_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Frm_Agregar_Paciente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var utilidades = new Utilidades();

            if (utilidades.CampoVacio(txtNombre.Text) || utilidades.CampoVacio(txtApellido.Text) || utilidades.CampoVacio(txtDni.Text) || utilidades.CampoVacio(txtTelefono.Text) || utilidades.CampoVacio(TxtDireccion.Text) || utilidades.CampoVacio(cmbGenero.Text) || utilidades.CampoVacio(DtpFechaNac.Text))
            {
                utilidades.AlertMessage("Todos los campos son Obligatorios","A");
            }
            else
            {

                
                var pacientesModel = new PacientesModel();

                if (Titulo == "Editar Paciente")
                {
                    var result = pacientesModel.EditarPaciente(txtNombre.Text, txtApellido.Text, txtDni.Text, cmbGenero.Text,
                        DtpFechaNac.Value, TxtDireccion.Text, txtTelefono.Text,true,Cache_Pacientes.IdPaciente);
                    utilidades.AlertMessage(result, "I");
                }
                else
                {
                    /*
                    var result = pacientesModel.NuevoPaciente(txtNombre.Text, txtApellido.Text, txtDni.Text, cmbGenero.Text,
                        DtpFechaNac.Value, TxtDireccion.Text, txtTelefono.Text);
                    utilidades.AlertMessage(result, "I");*/
                }

              
                this.Close();
               
                
            }

            

        }
    }
}
