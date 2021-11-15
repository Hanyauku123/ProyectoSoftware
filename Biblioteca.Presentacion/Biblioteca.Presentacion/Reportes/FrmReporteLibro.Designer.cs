
namespace Biblioteca.Presentacion.Reportes
{
    partial class FrmReporteLibro
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
            this.listar_prestamoLibroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsSistema = new Biblioteca.Presentacion.Reportes.DsSistema();
            this.listar_libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listar_libroTableAdapter = new Biblioteca.Presentacion.Reportes.DsSistemaTableAdapters.listar_libroTableAdapter();
            this.listar_prestamoLibroTableAdapter = new Biblioteca.Presentacion.Reportes.DsSistemaTableAdapters.listar_prestamoLibroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listar_prestamoLibroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listar_libroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listar_prestamoLibroBindingSource
            // 
            this.listar_prestamoLibroBindingSource.DataMember = "listar_prestamoLibro";
            this.listar_prestamoLibroBindingSource.DataSource = this.DsSistema;
            // 
            // DsSistema
            // 
            this.DsSistema.DataSetName = "DsSistema";
            this.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listar_libroBindingSource
            // 
            this.listar_libroBindingSource.DataMember = "listar_libro";
            this.listar_libroBindingSource.DataSource = this.DsSistema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsLibros";
            reportDataSource1.Value = this.listar_libroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.Presentacion.Reportes.RptLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(820, 477);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // listar_libroTableAdapter
            // 
            this.listar_libroTableAdapter.ClearBeforeFill = true;
            // 
            // listar_prestamoLibroTableAdapter
            // 
            this.listar_prestamoLibroTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 477);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteLibro";
            this.Text = "Reporte de libros";
            this.Load += new System.EventHandler(this.FrmReporteLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listar_prestamoLibroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listar_libroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listar_libroBindingSource;
        private DsSistema DsSistema;
        private DsSistemaTableAdapters.listar_libroTableAdapter listar_libroTableAdapter;
        private System.Windows.Forms.BindingSource listar_prestamoLibroBindingSource;
        private DsSistemaTableAdapters.listar_prestamoLibroTableAdapter listar_prestamoLibroTableAdapter;
    }
}