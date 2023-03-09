using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;

namespace Presentacion
{
    public partial class Cnt_Editar_Datos_personales : UserControl
    {
        private string Mode = "Mi Perfil";
        public Cnt_Editar_Datos_personales()
        {
            InitializeComponent();
        }

        public Cnt_Editar_Datos_personales(string mode)
        {
            this.Mode = mode;
            InitializeComponent();
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (this.Mode == "Mi Perfil")
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Editar_Perfil_Main);

                if (frm != null)
                {
                    //si la instancia existe la cierro
                    frm.Close();
                    return;
                }
            }
            else if (this.Mode == "Nuevo")
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Nuevo_Empleado_Main);

                if (frm != null)
                {
                    //si la instancia existe la cierro
                    frm.Close();
                    return;
                }
            }
         

        }

        private void Cnt_Editar_Datos_personales_Load(object sender, EventArgs e)
        {
            if (this.Mode == "Mi Perfil")
            {
                txtApellido.Text = Cache_Usuario.ApellidoEmpleado;
                txtNombre.Text = Cache_Usuario.NombreEmpleado;
                txtDni.Text = Cache_Usuario.DniEmpleado;
                txtTelefono.Text = Cache_Usuario.TelefonoEmpleado;
                cmbGenero.SelectedText = Cache_Usuario.GeneroEmpleado;
                DtpFechaNac.Value = Cache_Usuario.FechaNacimientoEmpleado;
                TxtDireccion.Text = Cache_Usuario.DireccionEmpleado;
            }
            else if (this.Mode == "Nuevo")
            {
                txtApellido.Text = "";
                txtNombre.Text = "";
                txtDni.Text = "";
                txtTelefono.Text = "";
                cmbGenero.SelectedText = "";
               
                TxtDireccion.Text = "";
            }

          

        }
    }
}
