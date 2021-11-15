using Biblioteca.Negocio;
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
    public partial class LoginScreen : Form
    {
     
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuario.Login(textBox1.Text, textBox2.Text);
                if (Tabla.Rows.Count<=0)
                {
                    MessageBox.Show("El email o la clave es incorrecta.", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                      if (Tabla.Rows[0][0].ToString() == "True") {
                        //Inicio Frm = new Inicio(true);
                        ManageBooks Frm = new ManageBooks(true);
                        Frm.Show();
                        this.Close();
                    }

                    else if (Tabla.Rows[0][0].ToString() == "False")
                    {
                        startUser Frm = new startUser(textBox1.Text);
                        Frm.Show();
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Rol de Usuario Invalido", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
