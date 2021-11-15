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
    public partial class PrestamoVideo : Form
    {
        bool isAdmin;
        int userId, videoId;
        public PrestamoVideo(bool admin)
        {
            isAdmin = admin;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NVideo.Buscar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
                int index = dataGridView1.CurrentCell.RowIndex;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Rows[index].Cells[i].Style.BackColor = Color.Yellow;
                }
                videoId = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
                int index = dataGridView2.CurrentCell.RowIndex;
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    dataGridView2.Rows[index].Cells[i].Style.BackColor = Color.Yellow;
                }

                userId = Int32.Parse(dataGridView2.SelectedCells[0].Value.ToString());

                dataGridView3.DataSource = NPrestamoVideo.Buscar(dataGridView2.Rows[index].Cells[1].Value.ToString());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            NPrestamoVideo.Insertar(videoId, userId, DateTime.Now, dateTimePicker1.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inicio frm = new Inicio(true);
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = NUsuario.Buscar(textBox2.Text);
        }
    }
}
