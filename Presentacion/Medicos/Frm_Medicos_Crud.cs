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

namespace Presentacion.Medicos
{
    public partial class Frm_Medicos_Crud : Form
    {
        public Frm_Medicos_Crud()
        {
            InitializeComponent();
            txtDni.Enabled = true;
        }

        private string Mode = "Nuevo";
        private int Id;
        private MedicosModel medicosModel = new MedicosModel();
        private Utilidades utilidades = new Utilidades();
        public Frm_Medicos_Crud(string mode)
        {
            InitializeComponent();
            txtDni.Enabled = true;
            Mode = mode;
            label8.Text = "Editar Medico";
            var existe = medicosModel.BuscarMedicoId(Cache_Medico.IdMedico);
            if (existe)
            {
                txtNombre.Text = Cache_Medico.NombreMedico;
                txtApellido.Text = Cache_Medico.ApellidoMedico;
                txtDni.Text = Cache_Medico.DniMedico;
                TxtDireccion.Text = Cache_Medico.DireccionMedico;
                txtTelefono.Text = Cache_Medico.TelefonoMedico;
                DtpFechaNac.Value = Cache_Medico.FechaNacimientoMedico;
                cmbGenero.Text = Cache_Medico.GeneroMedico;
                checkBox1.Checked = Cache_Medico.EstadoMedico;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Mode == "Nuevo")
            {
              
                if (utilidades.CampoVacio(txtNombre.Text) || utilidades.CampoVacio(txtApellido.Text) ||
                    utilidades.CampoVacio(txtTelefono.Text) || utilidades.CampoVacio(TxtDireccion.Text) ||
                    utilidades.CampoVacio(DtpFechaNac.Text) || utilidades.CampoVacio(cmbGenero.Text))
                {
                    utilidades.AlertMessage("Todos los campos son obligatorios", "A");
                }
                else
                {
                
                    var resultado = medicosModel.NuevoMedico(txtNombre.Text, txtApellido.Text, txtDni.Text, cmbGenero.Text, DtpFechaNac.Value,
                        TxtDireccion.Text, txtTelefono.Text);
                    utilidades.AlertMessage(resultado, "I");
                    this.Close();
                }
            }
            else
            {
                if (utilidades.CampoVacio(txtNombre.Text) || utilidades.CampoVacio(txtApellido.Text) ||
                    utilidades.CampoVacio(txtTelefono.Text) || utilidades.CampoVacio(TxtDireccion.Text) ||
                    utilidades.CampoVacio(DtpFechaNac.Text) || utilidades.CampoVacio(cmbGenero.Text))
                {
                    utilidades.AlertMessage("Todos los campos son obligatorios", "A");
                }
                else
                {

                    var resultado = medicosModel.EditarMedico(txtNombre.Text, txtApellido.Text, txtDni.Text, cmbGenero.Text, DtpFechaNac.Value,
                        TxtDireccion.Text, txtTelefono.Text,checkBox1.Checked,Cache_Medico.IdMedico);
                    utilidades.AlertMessage(resultado, "I");
                    this.Close();
                }
            }
        }

        private void Frm_Medicos_Crud_Load(object sender, EventArgs e)
        {
            checkBox1.Visible = Mode == "Nuevo" ? false:true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
