using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Editar_Perfil_Main : Form
    {

        private Button buttonActivo;
        private Panel bordeInferior;
        public Frm_Editar_Perfil_Main()
        {
            InitializeComponent();
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(181, 2);
            panel1.Controls.Add(bordeInferior);
            activarBoton(btn_usuario);
        }

        private void activarBoton(object boton)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                buttonActivo = (Button)boton;
                buttonActivo.ForeColor = Color.White;
               
                bordeInferior.BackColor = Color.Crimson;
                bordeInferior.Location = new Point(buttonActivo.Location.X, 29);
                bordeInferior.Visible = true;
                bordeInferior.BringToFront();
            }
        }

        private void DeshabilitarBoton()
        {
            if (buttonActivo != null)
            {
                buttonActivo.ForeColor = Color.Black;
            }
        }

        private void Frm_Editar_Perfil_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
        }
    }
}
