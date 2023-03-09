using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Presentacion
{
    public partial class Frm_Nuevo_Empleado_Main : Form
    {

        private IconButton buttonActivo;
        private Panel bordeInferior;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Frm_Nuevo_Empleado_Main()
        {
            InitializeComponent();
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(350, 3);
            panel1.Controls.Add(bordeInferior);
            activarBoton(iconButton1);
            Cnt_Editar_Usuario editarUsuario = new Cnt_Editar_Usuario("Nuevo");
            aplicarFiltro(editarUsuario);
        }

        private void aplicarFiltro(UserControl filtro)
        {
            filtro.Dock = DockStyle.Fill;
            pnl_contenedor.Controls.Clear();
            pnl_contenedor.Controls.Add(filtro);
            filtro.BringToFront();
        }

        private void DeshabilitarBoton()
        {
            if (buttonActivo != null)
            {
                buttonActivo.ForeColor = Color.White;
                buttonActivo.BackColor = Color.FromArgb(4, 41, 68);
                buttonActivo.IconColor = Color.White;
            }
        }

        private void activarBoton(object boton)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                buttonActivo = (IconButton)boton;
                buttonActivo.ForeColor = Color.White;
                buttonActivo.IconColor = Color.White;
                buttonActivo.BackColor = Color.FromArgb(0, 154, 76);
                bordeInferior.BackColor = Color.White;
                bordeInferior.Location = new Point(buttonActivo.Location.X, 27);
                bordeInferior.Visible = true;
                bordeInferior.BringToFront();
            }
        }

        private void Frm_Nuevo_Empleado_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
