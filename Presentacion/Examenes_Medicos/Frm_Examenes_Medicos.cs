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
    public partial class Frm_Examenes_Medicos : Form
    {
        public Frm_Examenes_Medicos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Examen_Med_Main realizarExamenMedMain = new Frm_Examen_Med_Main();
            realizarExamenMedMain.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Frm_Examen_Med_Main realizarExamenMedMain = new Frm_Examen_Med_Main("Editar","Editar Examen Medico");
            realizarExamenMedMain.Show();
        }
    }
}
