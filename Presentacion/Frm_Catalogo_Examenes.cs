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
    public partial class Frm_Catalogo_Examenes : Form
    {
        public Frm_Catalogo_Examenes()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Catalogo_Examen_Main nuevoExamenMain = new Frm_Catalogo_Examen_Main();
            nuevoExamenMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Frm_Catalogo_Examen_Main nuevoExamenMain = new Frm_Catalogo_Examen_Main("Editar Examen");
            nuevoExamenMain.Show();
        }
    }
}
