using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Presentacion
{
    public partial class Inicio : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;

        bool isAdmin;
        public Inicio(bool admin)
        {
            isAdmin = admin;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void startAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List frm = new List(true, "admin");
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search frm = new Search(true, "admin");
            frm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DevolverLibro frm = new DevolverLibro(true);
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrestamoLibro frm = new PrestamoLibro(true);
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrestamoVideo frm = new PrestamoVideo(true);
            frm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DevolverVideo frm = new DevolverVideo(true);
            frm.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ManageBooks frm = new ManageBooks(true);
            frm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ManageVideos frm = new ManageVideos(true);
            frm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmReporte1 Reportes = new FrmReporte1();
            Reportes.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            searchVideo frm = new searchVideo(true, "admin");
            frm.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ListVideo frm = new ListVideo(true, "admin");
            frm.Show();
            this.Close();
        }
    }
}
