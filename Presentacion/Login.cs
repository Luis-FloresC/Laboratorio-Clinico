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
        public Login()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
            }
            lblError.Visible = false;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            lblError.Visible = false;
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

        /*
         * Evento para minimizar el formulario
         */
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text != "Usuario" && txtPassword.TextLength > 2)
            {
                if (txtPassword.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);
                    if (validLogin == true)
                    {
                        user.ObtenerCargos();
                        user.ObtenerPermisos();
                        user.ObtenerPermisosRol(Cache_Usuario.IdRol);
                        Frm_Bienvenida welcome = new Frm_Bienvenida();
                        welcome.ShowDialog();
                        Frm_Main_Menu mainMenu = new Frm_Main_Menu();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
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
                else msgError("Credenciales no validas.");
            }
            else msgError("Credenciales no validas.");

           

        }

        private void msgError(string msg)
        {
            lblError.Text = "    " + msg;
            lblError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Text = "Contraseña";
            txtPassword.UseSystemPasswordChar = false;
            txtUser.Text = "Usuario";
            lblError.Visible = false;
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new Frm_Recuperar_Password();
            this.Hide();
            recoverPassword.ShowDialog();
        }
    }
}
