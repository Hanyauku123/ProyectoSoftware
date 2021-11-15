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
    public partial class searchVideo : Form
    {
        bool isAdmin;
        string user;
        public searchVideo(bool admin, string passeduser)
        {
            user = passeduser;
            isAdmin = admin;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NVideo.Buscar(textBox1.Text);
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

        private void searchVideo_Load(object sender, EventArgs e)
        {

        }
    }
}
