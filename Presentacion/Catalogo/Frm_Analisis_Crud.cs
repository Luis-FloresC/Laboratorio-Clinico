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

namespace Presentacion.Catalogo
{
    public partial class Frm_Analisis_Crud : Form
    {
        public Frm_Analisis_Crud()
        {
            InitializeComponent();
        }

        private string Nombre;
        private bool Estado;
        private int Id;
        public Frm_Analisis_Crud(string mode)
        {
            InitializeComponent();
            if (mode == "Nuevo")
            {
                label3.Text = "Nueva Categoria";
                label2.Visible = false;
                comboBox1.Visible = false;

            }
            else
            {
                label3.Text = "Editar Categoria";
                label2.Visible = true;
                comboBox1.Visible = true;
            }
            this.Mode = mode;
        }


        public Frm_Analisis_Crud(string mode,string nombre,int estado ,int id)
        {
            InitializeComponent();
          
                label3.Text = "Editar Categoria";
                label2.Visible = true;
                comboBox1.Visible = true;
                comboBox1.SelectedIndex = (estado);
                textBox1.Text = nombre;
                Id = id;
            
            this.Mode = mode;
        }

        private string Mode;
        private Utilidades utilidades = new Utilidades();
        private AnalisisModel analisisModel = new AnalisisModel();
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Guardar
        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            if (Mode == "Nuevo")
            {
                if (utilidades.CampoVacio(textBox1.Text))
                {
                    utilidades.AlertMessage("Todos los campos son Obligatorios","A");
                }
                else
                {
                    var res = analisisModel.NuevaCategoria(textBox1.Text);
                    utilidades.AlertMessage(res, "I");
                    this.Close();
                }   
            }
            else
            {
                if (utilidades.CampoVacio(textBox1.Text) || utilidades.CampoVacio(comboBox1.Text))
                {
                    utilidades.AlertMessage("Todos los campos son Obligatorios", "A");
                }
                else
                {
                    int estado = comboBox1.Text == "Activo" ? 1 : 0;
                    var res = analisisModel.ActualizarCategoria(textBox1.Text,estado,Id);
                    utilidades.AlertMessage(res, "I");
                    this.Close();
                }
            }
        }
    }
}
