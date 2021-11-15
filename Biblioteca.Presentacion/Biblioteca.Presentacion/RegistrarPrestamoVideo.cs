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
    public partial class RegistrarPrestamoVideo : Form
    {
        bool isAdmin;
        int codigo_video, codigo_usuario;
        DateTime today = DateTime.Today;
        Object selectedUser;
        Object selectedVideo;

        public RegistrarPrestamoVideo(bool admin)
        {
            InitializeComponent();
            isAdmin = admin;
            dataGridView1.DataSource = NVideo.Listar();
            dataGridView2.DataSource = NUsuario.Listar();
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            codigo_usuario = int.Parse(selectedUser.ToString());
            dataGridView3.DataSource = NPrestamoVideo.BuscarPrestamoUsuario(codigo_usuario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = NUsuario.Buscar(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            codigo_video = int.Parse(selectedVideo.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedVideo = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            label2.Text = selectedVideo.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUser = dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            label1.Text = selectedUser.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NPrestamoVideo.Insertar(codigo_video, codigo_usuario, today, monthCalendar1.SelectionStart);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NVideo.Buscar(textBox1.Text);
        }
    }
}
