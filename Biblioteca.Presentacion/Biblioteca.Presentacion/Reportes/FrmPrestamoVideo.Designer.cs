
namespace Biblioteca.Presentacion.Reportes
{
    partial class FrmPrestamoVideo
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
            this.listar_prestamoVideoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsSistema = new Biblioteca.Presentacion.Reportes.DsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listar_prestamoVideoTableAdapter = new Biblioteca.Presentacion.Reportes.DsSistemaTableAdapters.listar_prestamoVideoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listar_prestamoVideoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // listar_prestamoVideoBindingSource
            // 
            this.listar_prestamoVideoBindingSource.DataMember = "listar_prestamoVideo";
            this.listar_prestamoVideoBindingSource.DataSource = this.DsSistema;
            // 
            // DsSistema
            // 
            this.DsSistema.DataSetName = "DsSistema";
            this.DsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsPrestamoVideos";
            reportDataSource1.Value = this.listar_prestamoVideoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.Presentacion.Reportes.RptPrestamoVideos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(833, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // listar_prestamoVideoTableAdapter
            // 
            this.listar_prestamoVideoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrestamoVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 537);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmPrestamoVideo";
            this.Text = "Reporte préstamos vídeos";
            this.Load += new System.EventHandler(this.FrmPrestamoVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listar_prestamoVideoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource listar_prestamoVideoBindingSource;
        private DsSistema DsSistema;
        private DsSistemaTableAdapters.listar_prestamoVideoTableAdapter listar_prestamoVideoTableAdapter;
    }
}