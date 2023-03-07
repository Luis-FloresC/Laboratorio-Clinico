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
    public partial class Frm_MiPerfil : Form
    {
        public Frm_MiPerfil()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_MiPerfil_Load(object sender, EventArgs e)
        {
            int edad = DateTime.Today.AddTicks(-Cache_Usuario.FechaNacimientoEmpleado.Ticks).Year - 1;

            Lbl_Cargo.Text = Cache_Usuario.Cargo;
            Lbl_Correo.Text = Cache_Usuario.CorreoElectronicoUsuario;
            Lbl_Genero.Text = Cache_Usuario.GeneroEmpleado;
            Lbl_Dni.Text = Cache_Usuario.DniEmpleado;
            Lbl_Nombre.Text = Cache_Usuario.NombreEmpleado + " " + Cache_Usuario.ApellidoEmpleado;
            Lbl_Telefono.Text = Cache_Usuario.TelefonoEmpleado;
            Lbl_Nombre_Us.Text = Cache_Usuario.NombreUsuario;
            Lbl_Fecha_Reg.Text = Cache_Usuario.FechaRegistroUsuario.ToLongDateString();
            Lbl_Fecha_Act.Text = Cache_Usuario.FechaActualizacionEmpleado.ToLongDateString();
            Lbl_Edad.Text = edad + " años ("+ Cache_Usuario.FechaNacimientoEmpleado.ToLongDateString() +")";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Editar_Perfil_Main editarPerfilMain = new Frm_Editar_Perfil_Main();
                editarPerfilMain.Show();
        }
    }
}
