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
    public partial class updateBook : Form
    {
        int codigo;
        DataTable results;
        public updateBook()
        {
            InitializeComponent();
            populateCombobox();
        }

        private void populateCombobox()
        {
            cbeditorial.DataSource = NEditorial.Listar();
            cbeditorial.DisplayMember = "nombre";
            cbeditorial.ValueMember = "codigo";
            cbpais.DataSource = NPais.Listar();
            cbpais.DisplayMember = "nombre";
            cbpais.ValueMember = "codigo";
            cbmateria.DataSource = NMateria.Listar();
            cbmateria.DisplayMember = "nombre";
            cbmateria.ValueMember = "codigo";
            cbtitulo.DataSource = NLibro.Listar();
            cbtitulo.DisplayMember = "titulo";
            cbtitulo.ValueMember = "titulo";

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            results = NLibro.ListarUpdate(cbtitulo.SelectedValue.ToString());
            if (results.Rows.Count > 0)
            {
                codigo = Int32.Parse(results.Rows[0][0].ToString());
                tbtitulo.Text = results.Rows[0][1].ToString();
                tbisbn.Text = results.Rows[0][2].ToString();
                tbnpaginas.Text = results.Rows[0][3].ToString();
                tbidioma.Text = results.Rows[0][4].ToString();
                tbautor.Text = results.Rows[0][5].ToString();
                tbnejemplares.Text = results.Rows[0][6].ToString();
                tbanioedicion.Text = results.Rows[0][7].ToString();
                tbdescripcion.Text = results.Rows[0][8].ToString();
                tbnedicion.Text = results.Rows[0][9].ToString();
                tbejemplar.Text = results.Rows[0][10].ToString();
                tbubicacion.Text = results.Rows[0][11].ToString();
                cbeditorial.SelectedIndex = Int32.Parse(results.Rows[0][12].ToString()) - 1;
                cbpais.SelectedIndex = Int32.Parse(results.Rows[0][13].ToString()) - 1;
                cbmateria.SelectedIndex = Int32.Parse(results.Rows[0][14].ToString()) - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime year = new DateTime(Convert.ToInt32(tbanioedicion.Text), 1, 1);
            NLibro.Actualizar(codigo,tbtitulo.Text, tbisbn.Text, Int32.Parse(tbnpaginas.Text), tbidioma.Text, tbautor.Text, Int32.Parse(tbnejemplares.Text), year, tbdescripcion.Text, Int32.Parse(tbnedicion.Text), tbejemplar.Text, tbubicacion.Text, cbeditorial.SelectedIndex + 1, cbpais.SelectedIndex + 1, cbmateria.SelectedIndex + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageBooks frm = new ManageBooks(true);
            frm.Show();
            this.Close();
        }

        private void updateBook_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
