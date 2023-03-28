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

namespace Presentacion.Catalogo
{
    public partial class Frm_Analisis_Main : UserControl
    {
        private AnalisisModel analisis = new AnalisisModel();
        public Frm_Analisis_Main()
        {
            InitializeComponent();
        }

        private void Frm_Analisis_Main_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            dg_analisis.DataSource = analisis.DataTableAnalisis();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Analisis_Crud nuevoAnalisisCrud = new Frm_Analisis_Crud("Nuevo");
            nuevoAnalisisCrud.Show();
            nuevoAnalisisCrud.FormClosed += CerarrForm;
        }


        private void CerarrForm(object sender, FormClosedEventArgs e)
        {
           Actualizar();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dg_analisis.SelectedRows.Count > 0)
            {
               int id = Convert.ToInt32(dg_analisis.CurrentRow.Cells["Codigo"].Value);
               string nombre = dg_analisis.CurrentRow.Cells["Nombre"].Value.ToString();
               int estado = Convert.ToInt32(dg_analisis.CurrentRow.Cells["Activo"].Value);
               Frm_Analisis_Crud nuevoAnalisisCrud = new Frm_Analisis_Crud("Editar",nombre,estado,id);
               nuevoAnalisisCrud.Show();
               nuevoAnalisisCrud.FormClosed += CerarrForm;
            }

           
        }
    }
}
