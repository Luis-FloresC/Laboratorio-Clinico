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
using Soporte.Utilidades;

namespace Presentacion.Especialidades
{
    public partial class Frm_Asignar_Especialidades : Form
    {
        public Frm_Asignar_Especialidades()
        {
            InitializeComponent();
        }

        public Frm_Asignar_Especialidades(int id,string nombre)
        {
            InitializeComponent();
            Id = id;
            Nombre = nombre;
        }

        private int Id;
        private string Nombre;

        private EspecialidadesModel especialidadesModel = new EspecialidadesModel();

        private Utilidades utilidades = new Utilidades();

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool buscar(string nombre)
        {
            bool encontrado = false;
            foreach (var permisoUser in Cache_Medico.ListEspecialidadesMedico)
            {
                if (permisoUser.NombreEspecialidad == nombre && permisoUser.EstadoEspecialidad)
                {
                    encontrado = true;
                    break;
                }
            }

            return encontrado;
        }


        private bool PermisoActivo(string especialidad)
        {
            bool encontrado = false;
            foreach (var itemchecked in checkedListBox1.CheckedItems)
            {
                if (itemchecked.ToString() == especialidad)
                {
                    encontrado = true;
                    break;
                }

            }

            return encontrado;
        }

        private void GuardarEspecialidad()
        {
            bool estado = false;
         
            foreach (var item in checkedListBox1.Items)
            {
                estado = PermisoActivo(item.ToString());
                Cache_Medico.ListEspecialidadesMedicoAct.Add(new Soporte.Cache.Especialidades() {NombreEspecialidad = item.ToString(),EstadoEspecialidad = estado,IdMedico = Id});
            }
        }

        private void marcar(int id)
        {
            checkedListBox1.Items.Clear();
            listBox1.Items.Clear();
            especialidadesModel.EspecialidadesPorMedico(Id);
            foreach (var xp in Cache_Medico.ListEspecialidadesMedico)
            {
                if (buscar(xp.NombreEspecialidad))
                {
                    checkedListBox1.Items.Add(xp.NombreEspecialidad, true);
                    listBox1.Items.Remove("");
                    listBox1.Items.Add(xp.NombreEspecialidad);
                }
                else
                {
                    checkedListBox1.Items.Add(xp.NombreEspecialidad);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            listBox1.Items.Remove("");
            if (Convert.ToBoolean(e.CurrentValue))
            {
                listBox1.Items.Remove(checkedListBox1.Text);
            }
            else
            {
                listBox1.Items.Add(checkedListBox1.Text);
            }
        }

        private void Frm_Asignar_Especialidades_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
          


            lblDesPermiso.Text = "Especialidades del medico: " + Nombre;

            marcar(Id);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            GuardarEspecialidad();
            var result = especialidadesModel.AsignarEspecialidades();
            if (result)
            {
                utilidades.AlertMessage("Especialidades Actualizados con éxito", "I");
            }
            else
            {
                utilidades.AlertMessage("Ocurrio un Error", "E");
            }
            this.Close();
        }
    }
}
