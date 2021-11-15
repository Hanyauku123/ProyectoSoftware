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
    public partial class FrmPrestamoLibro : Form
    {
        public FrmPrestamoLibro()
        {
            InitializeComponent();
        }

        private void FrmPrestamoLibro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.listar_prestamoLibro' Puede moverla o quitarla según sea necesario.
            this.listar_prestamoLibroTableAdapter.Fill(this.DsSistema.listar_prestamoLibro);

            this.reportViewer1.RefreshReport();
        }
    }
}
