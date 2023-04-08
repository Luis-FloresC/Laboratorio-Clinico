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

namespace Presentacion
{
    public partial class Login : Form
    {
        private BitacoraModel bitacora = new BitacoraModel();
        public Login()
        {
            InitializeComponent();
            lblError.Visible = false;
            //Se Asigna la Misma posición a los botones
            hidePassword.Location = new Point(686, 160);
            MostrarPaasword.Location = new Point(686, 160);
        }

        #region MoverFormulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        /*
     * Evento para mover el formulario del login
     */
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region EventosCamposUsuarioContraseña

        /*
      *  Evento para cuando el usuario ingrese al textbox se elimine la palabra
      */
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
            }

        }

        /*
        * Evento para cuando el usuario salga del textbox y deje el campo vacio se agregue la palabra Contraseña
        */

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        /*
       *  Evento para cuando el usuario ingrese al textbox se elimine la palabra
       */
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        /*
         * Evento para cuando el usuario salga del textbox y deje el campo vacio se agregue la palabra Contraseña
         */
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
        }


        #endregion

        #region MinimizarCerrar

        /*
        * Evento para minimizar el formulario
        */
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton de Cerrar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }


        #region IniciarSesión

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Validacion de Campos
            if (txtUser.Text != "Usuario" && txtPassword.TextLength > 2)
            {
                if (txtPassword.Text != "Contraseña")
                {
                    //Declaracion de Instacia Local con la Capa de Negocios
                    UserModel user = new UserModel();
                    //declaracion de Variable de tipo Boleano que obtendra una respuesta verdadera (true) si el usuario existe.
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);
                    if (validLogin == true)
                    {

                        if ((Cache_Usuario.NombreUsuario == txtUser.Text || Cache_Usuario.DniUsuario == txtUser.Text) &&
                            Cache_Usuario.ContraseniaUsuario == txtPassword.Text)
                        {
                            //Obtenemos los cargos  y los permisos
                            user.ObtenerCargos();
                          
                            user.ObtenerPermisosRol(Cache_Usuario.IdRol);
                            string descripcionEvento =
                                "El Usuario " + Cache_Usuario.NombreUsuario + " Ingreso al Sistema.";
                            bitacora.NuevaActividad("Inicio Sesión", descripcionEvento, Cache_Usuario.IdUsuario);
                            //Mostramos Pantalla de Bienvenida
                            Frm_Bienvenida welcome = new Frm_Bienvenida();
                            welcome.ShowDialog();
                            //Mostramos el Menú principal
                            Frm_Main_Menu mainMenu = new Frm_Main_Menu();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            //Ocultamos el formulario
                            this.Hide();
                        }
                        else
                        {
                            msgError("Nombre de usuario o contraseña ingresados ​​incorrectamente. \n   Intenta de nuevo.");
                            txtPassword.Text = "Contraseña";
                            txtPassword.UseSystemPasswordChar = false;
                            txtUser.Focus();
                        }
                      
                    }
                    else
                    {
                        //Funcion de Error y se hace visible el label de error.
                        msgError("Nombre de usuario o contraseña ingresados ​​incorrectamente. \n   Intenta de nuevo.");
                        txtPassword.Text = "Contraseña";
                        txtPassword.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }
                }
                else msgError("Credenciales no validas.");
            }
            else msgError("Credenciales no validas.");



        }

        #endregion

        #region MostraOcultarContraseña

        //Mostrar Contraseña
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            hidePassword.Visible = true;
            MostrarPaasword.Visible = false;
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            hidePassword.Visible = false;
            MostrarPaasword.Visible = true;
        }

        #endregion

        #region FunciónError

        private void msgError(string msg)
        {
            lblError.Text = "    " + msg;
            lblError.Visible = true;
        }

        #endregion

        #region CerrarSesión

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Text = "Contraseña";
            txtPassword.UseSystemPasswordChar = false;
            txtUser.Text = "Usuario";
            lblError.Visible = false;
            this.Show();
        }

        #endregion



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new Frm_Recuperar_Password();
            this.Hide();
            recoverPassword.ShowDialog();
        }

     

    }
}
