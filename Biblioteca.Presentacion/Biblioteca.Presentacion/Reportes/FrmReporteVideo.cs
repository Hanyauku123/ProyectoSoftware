using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Presentacion.Reportes
{
    public partial class FrmReporteVideo : Form
    {
        public FrmReporteVideo()
        {
            InitializeComponent();
        }

        private void FrmReporteVideo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.listar_video' Puede moverla o quitarla según sea necesario.
            this.listar_videoTableAdapter.Fill(this.DsSistema.listar_video);

            this.reportViewer1.RefreshReport();
        }
    }
}
