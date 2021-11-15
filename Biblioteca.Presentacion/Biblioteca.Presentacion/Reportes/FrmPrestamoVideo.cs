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
    public partial class FrmPrestamoVideo : Form
    {
        public FrmPrestamoVideo()
        {
            InitializeComponent();
        }

        private void FrmPrestamoVideo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.listar_prestamoVideo' Puede moverla o quitarla según sea necesario.
            this.listar_prestamoVideoTableAdapter.Fill(this.DsSistema.listar_prestamoVideo);

            this.reportViewer1.RefreshReport();
        }
    }
}
