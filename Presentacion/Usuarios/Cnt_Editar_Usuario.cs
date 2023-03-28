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
    public partial class Cnt_Editar_Usuario : UserControl
    {
        private string Accion = "Mi Perfil";

        public Cnt_Editar_Usuario()
        {
            InitializeComponent();
            this.Accion = "Mi Perfil";
        }

        public Cnt_Editar_Usuario(string Mode)
        {
            this.Accion = Mode;
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (this.Accion == "Mi Perfil")
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Editar_Perfil_Main);

                if (frm != null)
                {
                    //si la instancia existe la cierro
                    frm.Close();
                    return;
                }
            }
            else if (this.Accion == "Nuevo")
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

        private void Cnt_Editar_Usuario_Load(object sender, EventArgs e)
        {
            if (this.Accion == "Mi Perfil")
            {
                txtPassword.Text = Cache_Usuario.ContraseniaUsuario;
                txtConfirmarPassword.Text = Cache_Usuario.ContraseniaUsuario;
                txtNombreUser.Text = Cache_Usuario.NombreUsuario;
                txtCorreoElectronico.Text = Cache_Usuario.CorreoElectronicoUsuario;
            }
            else if (this.Accion == "Nuevo")
            {
                txtPassword.Text = "";
                txtConfirmarPassword.Text = "";
                txtNombreUser.Text = "";
                txtCorreoElectronico.Text = "";
            }
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (this.Accion == "Mi Perfil")
            {
                Utilidades utilidades = new Utilidades();
                if (utilidades.CampoVacio(txtNombreUser.Text) || utilidades.CampoVacio(txtPassword.Text) || utilidades.CampoVacio(txtCorreoElectronico.Text))
                {
                    utilidades.AlertMessage("Los Campos son Obligatorios","A");
                }
                else
                {
                    if (utilidades.AlgoritmoContraseñaSegura(txtPassword.Text))
                    {
                        if (txtPassword.Text == txtConfirmarPassword.Text)
                        {
                            
                            UserModel user = new UserModel();
                            var result = user.EditarUsuario(txtPassword.Text, Cache_Usuario.DniEmpleado, txtCorreoElectronico.Text, txtNombreUser.Text,Cache_Usuario.IdRol);
                          
                            utilidades.AlertMessage(result, "I");
                            var res = user.LoginUser(Cache_Usuario.DniEmpleado, txtPassword.Text);
                            if (res)
                            {
                                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Editar_Perfil_Main);
                                if (frm != null)
                                {
                                    //si la instancia existe la cierro
                                    frm.Close();
                                    return;
                                }
                            }
                          
                          
                            
                            
                        }
                        else
                        {
                            utilidades.AlertMessage("Las contraseñas deben coincidir", "A");
                        }
                    }
                    else
                    {
                        utilidades.AlertMessage("La Contraseña debe contener:\n1 carcter especial\nal menos 1 letra Mayuscula y \nal menos 1 número\ny debe contener al menos 8 caracteres", "A");
                    }
                }
               
            }
        }

        private void txtConfirmarPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
