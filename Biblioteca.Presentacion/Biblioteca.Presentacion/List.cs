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
    public partial class List : Form
    {
        bool isAdmin;
        string user;
        public List(bool admin, string passeduser)
        {
            user = passeduser;
            isAdmin = admin;
            InitializeComponent();
            dataGridView1.DataSource = NLibro.Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
