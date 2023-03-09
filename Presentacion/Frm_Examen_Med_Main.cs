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
    public partial class Frm_Examen_Med_Main : Form
    {
        public Frm_Examen_Med_Main()
        {
            InitializeComponent();
        }

        public Frm_Examen_Med_Main(string accion,string titulo)
        {
            InitializeComponent();
            label1.Text = titulo;
            this.Accion = accion;
        }

        private string Accion = "Nuevo";


        private void Frm_Examen_Med_Main_Load(object sender, EventArgs e)
        {
            if (this.Accion == "Nuevo")
            {

            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
