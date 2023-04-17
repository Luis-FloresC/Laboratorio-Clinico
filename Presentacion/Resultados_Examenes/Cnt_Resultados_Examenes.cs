using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion.Resultados_Examenes
{
    public partial class Cnt_Resultados_Examenes : UserControl
    {

        public Cnt_Resultados_Examenes()
        {
            InitializeComponent();
        }

        private ResultadosExamenesMedicosModel resultadosExamenes = new ResultadosExamenesMedicosModel();
        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            dg_Resultados.DataSource = resultadosExamenes.DataTableResultados();
        }
        private void Cnt_Resultados_Examenes_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Frm_Resultado_Main resultadoMain = new Frm_Resultado_Main();
            resultadoMain.Show();
            resultadoMain.FormClosed += CerrarForm;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dg_Resultados.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dg_Resultados.CurrentRow.Cells[0].Value.ToString());
                var ListaArchivo = new List<ResultadosExamenes>();
                ListaArchivo = resultadosExamenes.filtrarDocumentos(id);

                foreach (ResultadosExamenes item in ListaArchivo)
                {
                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + "/temp/";
                    string ubicacionCompleta = carpeta + item.ExtensionArchivo;

                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    if (File.Exists(ubicacionCompleta))
                    {
                        File.Delete(ubicacionCompleta);
                    }

                    File.WriteAllBytes(ubicacionCompleta,item.Archivo);
                    Process.Start(ubicacionCompleta);
                }
            }
        }
    }
}
