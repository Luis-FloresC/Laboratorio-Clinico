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
    public partial class Cnt_Usuarios : UserControl
    {
        public Cnt_Usuarios()
        {
            InitializeComponent();
            Actualizar();
        }

        private UserModel user = new UserModel();
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Usuario_Main user = new Frm_Usuario_Main();
            user.Show();
        }

        private void Actualizar()
        {
            dg_Usuarios.DataSource = user.DataTableUsuarios();
            
        }

        private void dg_pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
