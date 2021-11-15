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
    public partial class startUser : Form
    {
        string user;
        public startUser(string passeduser)
        {
            user = passeduser;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List frm = new List(false, user);
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search frm = new Search(false, user);
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchVideo frm = new searchVideo(false, user);
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListVideo frm = new ListVideo(false, user);
            frm.Show();
            this.Close();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.DataSource = NLibro.Buscar(user);
        }

        private void startUser_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.DataSource = NVideo.Buscar(user);
        }
    }
}
