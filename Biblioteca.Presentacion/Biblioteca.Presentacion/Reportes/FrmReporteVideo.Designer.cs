
namespace Biblioteca.Presentacion.Reportes
{
    partial class FrmReporteVideo
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
            this.listar_videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsSistema = new Biblioteca.Presentacion.Reportes.DsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listar_videoTableAdapter = new Biblioteca.Presentacion.Reportes.DsSistemaTableAdapters.listar_videoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listar_videoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // listar_videoBindingSource
            // 
            this.listar_videoBindingSource.DataMember = "listar_video";
            this.listar_videoBindingSource.DataSource = this.DsSistema;
            // 
            // DsSistema
            // 
            this.DsSistema.DataSetName = "DsSistema";
            this.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsVideo";
            reportDataSource1.Value = this.listar_videoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.Presentacion.Reportes.RptVideo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(844, 462);
            this.reportViewer1.TabIndex = 0;
            // 
            // listar_videoTableAdapter
            // 
            this.listar_videoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteVideo";
            this.Text = "Reporte de vídeos";
            this.Load += new System.EventHandler(this.FrmReporteVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listar_videoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listar_videoBindingSource;
        private DsSistema DsSistema;
        private DsSistemaTableAdapters.listar_videoTableAdapter listar_videoTableAdapter;
    }
}