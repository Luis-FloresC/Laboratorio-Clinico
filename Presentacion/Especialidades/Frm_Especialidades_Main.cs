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

namespace Presentacion.Especialidades
{
    public partial class Frm_Especialidades_Main : Form
    {
        public Frm_Especialidades_Main()
        {
            InitializeComponent();
        }

        private string Mode = "Nuevo";
        private EspecialidadesModel especialidadesModel = new EspecialidadesModel();
        private Utilidades utilidades = new Utilidades();
        private int Id;
        private string Nombre;
        private bool Estado;
        public Frm_Especialidades_Main(string mode,int id,string nombre,bool estado)
        {
            InitializeComponent();
            Mode = mode;
            Id = id;
            txtNombre.Text = nombre;
            chEstado.Checked = estado;
        }

        private void Frm_Especialidades_Main_Load(object sender, EventArgs e)
        {
            chEstado.Visible = Mode == "Nuevo" ? false : true;
        }

        //Btn Aceptar
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Mode == "Editar")
            {
                if (utilidades.CampoVacio(txtNombre.Text))
                {
                    utilidades.AlertMessage("Debe ingresar el Nombre de la especialidad", "A");
                }
                else
                {

                    var resul = especialidadesModel.EditarEspecialidad(txtNombre.Text, chEstado.Checked, Id);
                    utilidades.AlertMessage(resul, "I");
                    this.Close();
                }
            }
            else
            {
                if (utilidades.CampoVacio(txtNombre.Text))
                {
                    utilidades.AlertMessage("Debe ingresar el Nombre de la especialidad", "A");
                }
                else
                {
                    var resul = especialidadesModel.NuevaEspecialidad(txtNombre.Text);
                    utilidades.AlertMessage(resul, "I");
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
