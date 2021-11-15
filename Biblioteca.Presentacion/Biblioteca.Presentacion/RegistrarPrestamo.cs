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
    public partial class RegistrarPrestamo : Form
    {
        bool isAdmin;
        int codigo_libro, codigo_usuario;
        DateTime today = DateTime.Today;
        Object selectedUser;
        Object selectedBook;
        public RegistrarPrestamo(bool admin)
        {
            InitializeComponent();
            isAdmin = admin;
            dataGridView1.DataSource = NLibro.Listar();
            dataGridView2.DataSource = NUsuario.Listar();
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBook = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NLibro.Buscar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = NUsuario.Buscar(textBox2.Text);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NPrestamo.Insertar( codigo_libro, codigo_usuario, today, monthCalendar1.SelectionStart);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUser = dataGridView2.Rows[e.RowIndex].Cells[0].Value;
           
        }

        private void RegistrarPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            codigo_usuario = int.Parse(selectedUser.ToString());
            dataGridView3.DataSource = NPrestamo.BuscarPrestamoUsuario(codigo_usuario);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            codigo_libro = int.Parse(selectedBook.ToString());
        }
    }
}
