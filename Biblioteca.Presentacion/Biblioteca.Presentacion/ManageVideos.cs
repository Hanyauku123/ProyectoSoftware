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
    public partial class ManageVideos : Form
    {
        int videoId;
        bool isAdmin;
        public ManageVideos(bool admin)
        {
            isAdmin = admin;
            InitializeComponent();
            dataGridView1.DataSource = NVideo.Listar();
        }

        private void ManageVideos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVideo frm = new AddVideo();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateVideo frm = new updateVideo();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
                DataTable checkPrestado = NPrestamoVideo.BuscarEliminar(videoId.ToString());
                if (checkPrestado.Rows.Count > 0)
                {
                    MessageBox.Show("No puedes eliminar un video actualmente prestado.", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NVideo.Eliminar(videoId);
                    dataGridView1.DataSource = NVideo.Listar();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio frm = new Inicio(true);
            frm.Show();
            this.Close();
        }
    }
}
