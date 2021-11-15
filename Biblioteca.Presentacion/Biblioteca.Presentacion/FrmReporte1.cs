using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Presentacion
{
    public partial class FrmReporte1 : Form
    {
        public FrmReporte1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = cmbReportes.SelectedIndex;

            if(indice >= 0 && indice <= 4)
            {
                if (indice == 0)
                {
                    Reportes.FrmReporteLibro ReporteLibros = new Reportes.FrmReporteLibro();
                    ReporteLibros.ShowDialog();
                }
                else if (indice == 1)
                {
                    Reportes.FrmPrestamoLibro ReportePLibros = new Reportes.FrmPrestamoLibro();
                    ReportePLibros.ShowDialog();
                }
                else if (indice == 2)
                {
                    Reportes.FrmReporteVideo ReporteVideo = new Reportes.FrmReporteVideo();
                    ReporteVideo.ShowDialog();
                }
                else
                {
                    Reportes.FrmPrestamoVideo ReportePVideo = new Reportes.FrmPrestamoVideo();
                    ReportePVideo.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Elija un reporte a mostrar!", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmReporte1_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio frm = new Inicio(true);
            frm.Show();
            this.Close();
        }

        private void cmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
