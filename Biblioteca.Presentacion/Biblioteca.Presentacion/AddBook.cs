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
    public partial class AddBook : Form
    {
        
        public AddBook()
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
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
           
         
                DateTime year = new DateTime(Convert.ToInt32(tbanioedicion.Text), 1, 1);
                NLibro.Insertar(tbtitulo.Text, tbisbn.Text, Int32.Parse(tbnpaginas.Text), tbidioma.Text, tbautor.Text, Int32.Parse(tbnejemplares.Text), year, tbdescripcion.Text, Int32.Parse(tbnedicion.Text), tbejemplar.Text, tbubicacion.Text, cbeditorial.SelectedIndex + 1, cbpais.SelectedIndex + 1, cbmateria.SelectedIndex + 1);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageBooks frm = new ManageBooks(true);
            frm.Show();
            this.Close();
        }

        private void tbnejemplares_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
