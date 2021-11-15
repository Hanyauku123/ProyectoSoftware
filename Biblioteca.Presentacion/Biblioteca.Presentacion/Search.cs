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
    public partial class Search : Form
    {
        bool isAdmin;
        string user;
        public Search(bool admin, string passeduser )
        {
            user = passeduser;
            isAdmin = admin;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = NLibro.Buscar(textBox1.Text); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (isAdmin)
            {
                Inicio frm = new Inicio(true);
                frm.Show();
                this.Close();
            }
            else
            {
                startUser frm = new startUser(user);
                frm.Show();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
