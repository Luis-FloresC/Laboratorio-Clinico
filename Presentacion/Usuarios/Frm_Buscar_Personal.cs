using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Soporte.Cache;

namespace Presentacion.Usuarios
{
    public partial class Frm_Buscar_Personal : Form
    {
        public Frm_Buscar_Personal()
        {
            InitializeComponent();
            CargarPersonal();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private UserModel userModel = new UserModel();

        private void CargarPersonal()
        {
            dg_personal.DataSource = userModel.BuscarPersonal();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Buscar Personal")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Buscar Personal";
                dg_personal.DataSource = userModel.BuscarPersonal();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dg_personal.DataSource = userModel.BuscarPersonal(textBox1.Text);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (dg_personal.SelectedRows.Count > 0)
            {
                BuscarPersonal.Id = Convert.ToInt32(dg_personal.CurrentRow.Cells["Id"].Value);
                BuscarPersonal.Nombre = (dg_personal.CurrentRow.Cells["Nombre"].Value.ToString());
                BuscarPersonal.Cargo = (dg_personal.CurrentRow.Cells["Cargo"].Value.ToString());
                BuscarPersonal.Dni = (dg_personal.CurrentRow.Cells["Dni"].Value.ToString());
                this.Close();
            }
        }
    }
}
