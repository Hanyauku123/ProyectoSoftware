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
    public partial class DevolverVideo : Form
    {
        bool isAdmin;
        int videoId;
        public DevolverVideo(bool admin)
        {
            isAdmin = admin;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NPrestamoVideo.Devolver(videoId);
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
            }

            videoId = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NPrestamoVideo.Buscar(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DevolverVideo_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio frm = new Inicio(true);
            frm.Show();
            this.Close();
        }
    }
}
