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
    public partial class Frm_Catalogo_Examen_Main : Form
    {
        public Frm_Catalogo_Examen_Main()
        {
            InitializeComponent();
        }

        public Frm_Catalogo_Examen_Main(string titulo)
        {
            InitializeComponent();
            label1.Text = titulo;
            label3.Visible = true;
            comboBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
