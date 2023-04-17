
namespace Presentacion.Reportes
{
    partial class Frm_Reporte_Inventario
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
            this.ReporteModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InventarioReport";
            reportDataSource1.Value = this.ReporteModelBindingSource;
            reportDataSource2.Name = "ListaInventario";
            reportDataSource2.Value = this.ReportesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Diseño_De_Informes.ReporteDeInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(932, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteModelBindingSource
            // 
            this.ReporteModelBindingSource.DataSource = typeof(Negocio.ReporteModel);
            // 
            // ReportesBindingSource
            // 
            this.ReportesBindingSource.DataSource = typeof(Negocio.Reportes);
            // 
            // Frm_Reporte_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Inventario";
            this.Text = "Frm_Reporte_Inventario";
            this.Load += new System.EventHandler(this.Frm_Reporte_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteModelBindingSource;
        private System.Windows.Forms.BindingSource ReportesBindingSource;
    }
}