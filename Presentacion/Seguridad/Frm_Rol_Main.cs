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
using Soporte.Utilidades;

namespace Presentacion.Seguridad
{
    public partial class Frm_Rol_Main : Form
    {
        public Frm_Rol_Main()
        {
            InitializeComponent();
        }

        private string Mode;
        private string Rol;
        private bool Estado;
        private int IdRol;
        private SeguridadModel seguridadModel = new SeguridadModel();
        private Utilidades utilidades = new Utilidades();
        public Frm_Rol_Main(string mode,int idRol,string rol,bool estado)
        {
            InitializeComponent();
            Mode = mode;
            IdRol = idRol;
            Rol = rol;
            Estado = estado;
            txtNombre.Text = rol;
            chEstado.Checked = estado;
            label3.Text = "Editar Rol";
            MessageBox.Show(idRol.ToString());
        }

        private void Frm_Rol_Main_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Mode == "Editar")
            {
                if (utilidades.CampoVacio(txtNombre.Text))
                {
                    utilidades.AlertMessage("Debe ingresar el Nombre del Rol", "A");
                }
                else
                {
                   
                    var resul = seguridadModel.EdiatrRol(txtNombre.Text, chEstado.Checked,IdRol);
                    utilidades.AlertMessage(resul, "I");
                    this.Close();
                }
            }
            else
            {
                if (utilidades.CampoVacio(txtNombre.Text))
                {
                    utilidades.AlertMessage("Debe ingresar el Nombre del Rol","A");
                }
                else
                {
                    var resul = seguridadModel.NuevoRol(txtNombre.Text, chEstado.Checked);
                    utilidades.AlertMessage(resul,"I");
                    this.Close();
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
