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
    public partial class AddVideo : Form
    {
        public AddVideo()
        {
            InitializeComponent();
            populateCombobox();
        }

        private void populateCombobox()
        {
            cbtipo.DataSource = NTipo.Listar();
            cbtipo.DisplayMember = "nombre";
            cbtipo.ValueMember = "codigo";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            


                DateTime year = new DateTime(Convert.ToInt32(tbanio.Text), 1, 1);
                NVideo.Insertar(tbtitulo.Text, tbduracion.Text, tbidiomas.Text, tbsubtitulos.Text, tbsinopsis.Text, year, tbubicacion.Text, tbdirector.Text, tbproductora.Text, cbtipo.SelectedIndex + 1);
 
        }

        private void cbmateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbpais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbeditorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbisbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnpaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbidioma_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnejemplares_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbanioedicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnedicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbejemplar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbubicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbautor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageVideos frm = new ManageVideos(true);
            frm.Show();
            this.Close();
        }

        private void AddVideo_Load(object sender, EventArgs e)
        {

        }

        private void tbproductora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
