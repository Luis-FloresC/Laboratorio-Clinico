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
using Soporte.Cache;
namespace Presentacion
{
    public partial class Frm_Main_Menu : Form
    {
        public Frm_Main_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Main_Menu_Load(object sender, EventArgs e)
        {
            btn_nornal.Visible = false;
            lbl_nombre.Text = Cache_Usuario.NombreEmpleado + " " + Cache_Usuario.ApellidoEmpleado;
            lbl_cargo.Text = Cache_Usuario.Cargo;
            lbl_email.Text = Cache_Usuario.CorreoElectronicoUsuario;

            foreach (var cargos in Cache_Cargos.ListaCargos )
            {
                Console.WriteLine(cargos);
            }
            
        }

        #region Funcionalida_Form

        

       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

     

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnl_contenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


       

        private void btn_nornal_Click(object sender, EventArgs e)
        {
            btn_max.Visible = true;
            btn_nornal.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void pnl_hijo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_Lateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btn_max.Visible = false;
            btn_nornal.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Calendario>();
            button2.BackColor = Color.FromArgb(0, 129, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Pacientes>();
            button1.BackColor = Color.FromArgb(0, 129, 64);
            
            
        }

        private void pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_hijo_Paint(object sender, PaintEventArgs e)
        {

        }

        //AbrirFormulario<Frm_Pacientes>();


        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Salir del Sistema?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        //Boton de Cerrar Sesion
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Application.Exit();
                this.Close();
                
            }
        }

        private void Link_Perfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario<Frm_MiPerfil>();
            Link_Perfil.BackColor = Color.FromArgb(0, 129, 64);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Empleados>();
            button3.BackColor = Color.FromArgb(0, 129, 64);
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnl_hijo.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnl_hijo.Controls.Add(formulario);
                pnl_hijo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        //Funcion para cerrar el formulario
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Frm_Pacientes"] == null)
            {
                button1.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Frm_MiPerfil"] == null)
            {
                Link_Perfil.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Frm_Calendario"] == null)
            {
                button2.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Frm_Empleados"] == null)
            {
                button3.BackColor = Color.FromArgb(4, 41, 68);
            }
        }
       
    }
}
