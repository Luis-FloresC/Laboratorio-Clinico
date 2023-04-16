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
using Presentacion.Examenes_Medicos;
using Presentacion.Resultados_Examenes;

namespace Presentacion
{
    public partial class Frm_Examenes_Medicos : Form
    {
        private IconButton buttonActivo;
        private Panel bordeInferior;
        public Frm_Examenes_Medicos()
        {
            InitializeComponent();
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(417, 3);
            panel1.Controls.Add(bordeInferior);
            activarBoton(iconButton1);
            Cnt_Examenes_Medicos examenesMedicos = new Cnt_Examenes_Medicos();
            aplicarFiltro(examenesMedicos);
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

       

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Frm_Examen_Med_Main realizarExamenMedMain = new Frm_Examen_Med_Main("Editar","Editar Examen Medico");
            realizarExamenMedMain.Show();
        }

        private void Frm_Examenes_Medicos_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
            Cnt_Resultados_Examenes resultadosExamenes = new Cnt_Resultados_Examenes();
            aplicarFiltro(resultadosExamenes);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
            Cnt_Examenes_Medicos examenesMedicos = new Cnt_Examenes_Medicos();
            aplicarFiltro(examenesMedicos);
        }
    }
}
