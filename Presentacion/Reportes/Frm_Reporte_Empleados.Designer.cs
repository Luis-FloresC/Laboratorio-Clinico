
namespace Presentacion.Reportes
{
    partial class Frm_Reporte_Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportesEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReportesEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ListaDeEmpleados";
            reportDataSource1.Value = this.ReportesEmpleadosBindingSource;
            reportDataSource2.Name = "EmpleadosList";
            reportDataSource2.Value = this.EmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Diseño_De_Informes.ReporteDeEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(926, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportesEmpleadosBindingSource
            // 
            this.ReportesEmpleadosBindingSource.DataSource = typeof(Negocio.ReportesEmpleados);
            // 
            // EmpleadoBindingSource
            // 
            this.EmpleadoBindingSource.DataSource = typeof(Negocio.Empleado);
            // 
            // Frm_Reporte_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 358);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Empleados";
            this.Text = "Listado de Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Reporte_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportesEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportesEmpleadosBindingSource;
        private System.Windows.Forms.BindingSource EmpleadoBindingSource;
    }
}