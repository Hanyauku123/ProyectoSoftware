using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Presentacion
{
    public partial class updateVideo : Form
    {
        int codigo;
        DataTable results;
        public updateVideo()
        {
            InitializeComponent();
            populateCombobox();
        }

        private void populateCombobox()
        {
            cbtipo.DataSource = NTipo.Listar();
            cbtipo.DisplayMember = "nombre";
            cbtipo.ValueMember = "codigo";
            cbtitulo.DataSource = NVideo.Listar();
            cbtitulo.DisplayMember = "titulo";
            cbtitulo.ValueMember = "titulo";
        }
        private void cbtitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            results = NVideo.ListarUpdate(cbtitulo.SelectedValue.ToString());
            if (results.Rows.Count > 0)
            {
                codigo = Int32.Parse(results.Rows[0][0].ToString());
                tbtitulo.Text = results.Rows[0][1].ToString();
                tbdirector.Text = results.Rows[0][2].ToString();
                tbproductora.Text = results.Rows[0][3].ToString();
                cbtipo.SelectedIndex = Int32.Parse(results.Rows[0][4].ToString()) - 1;
                tbanio.Text = results.Rows[0][5].ToString();
                tbduracion.Text = results.Rows[0][6].ToString();
                tbidiomas.Text = results.Rows[0][7].ToString();
                tbsubtitulos.Text = results.Rows[0][8].ToString();
                tbsinopsis.Text = results.Rows[0][9].ToString();
                tbubicacion.Text = results.Rows[0][10].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime year = new DateTime(Convert.ToInt32(tbanio.Text), 1, 1);
            NVideo.Actualizar(codigo, tbtitulo.Text, tbduracion.Text, tbidiomas.Text, tbsubtitulos.Text, tbsinopsis.Text, year, tbubicacion.Text, tbdirector.Text, tbproductora.Text, cbtipo.SelectedIndex+1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageVideos frm = new ManageVideos(true);
            frm.Show();
            this.Close();
        }
    }
}
