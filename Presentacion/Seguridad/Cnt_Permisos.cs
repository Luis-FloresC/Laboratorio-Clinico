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
using Presentacion.Seguridad;

namespace Presentacion
{
    public partial class Cnt_Permisos : UserControl
    {
        public Cnt_Permisos()
        {
            InitializeComponent();
            Actualizar();
        }


        private SeguridadModel seguridadModel = new SeguridadModel();
        private void Actualizar()
        {
            dg_permisos.DataSource = seguridadModel.DataTablePermisos();
        }

        private void Cnt_Permisos_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Asignar_Permisos asignarPermisos = new Frm_Asignar_Permisos();
            asignarPermisos.Show();
        }
    }
}
