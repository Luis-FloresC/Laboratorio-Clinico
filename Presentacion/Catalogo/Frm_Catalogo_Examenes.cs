using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Presentacion.Catalogo;

namespace Presentacion
{
    public partial class Frm_Catalogo_Examenes : Form
    {

        private IconButton buttonActivo;
        private Panel bordeInferior;
        public Frm_Catalogo_Examenes()
        {
            InitializeComponent();
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(417, 3);
            panel1.Controls.Add(bordeInferior);
            activarBoton(iconButton6);
            Frm_Catalogo_Exam_Main catalogos = new Frm_Catalogo_Exam_Main();
            aplicarFiltro(catalogos);
        }

        private void aplicarFiltro(UserControl filtro)
        {
            filtro.Dock = DockStyle.Fill;
            pnl_contenedor.Controls.Clear();
            pnl_contenedor.Controls.Add(filtro);
            filtro.BringToFront();
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

        private void DeshabilitarBoton()
        {
            if (buttonActivo != null)
            {
                buttonActivo.ForeColor = Color.White;
                buttonActivo.BackColor = Color.FromArgb(4, 41, 68);
                buttonActivo.IconColor = Color.White;
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Frm_Catalogo_Examenes_Load(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
            Frm_Catalogo_Exam_Main catalogo = new Frm_Catalogo_Exam_Main();
            aplicarFiltro(catalogo);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
            Frm_Analisis_Main analisis = new Frm_Analisis_Main();
            aplicarFiltro(analisis);
        }
    }
}
