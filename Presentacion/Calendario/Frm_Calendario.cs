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

namespace Presentacion
{
    public partial class Frm_Calendario : Form
    {
        public Frm_Calendario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private SeguridadModel seguridadModel = new SeguridadModel();

        private void Actualizar(string fecha)
        {
            dg_pacientes.DataSource = seguridadModel.DataTableCalendario(Convert.ToDateTime(fecha));
        }
        private void Frm_Calendario_Load(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString();
            string[] soloFecha = (fecha.Split(' '));
            Actualizar(soloFecha[0]);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString();
            string[] soloFecha = (fecha.Split(' '));
            Actualizar(soloFecha[0]);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString();
            string[] soloFecha = (fecha.Split(' '));
            Actualizar(soloFecha[0]);
        }
    }
}
