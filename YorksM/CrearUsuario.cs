using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YorksM
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // instancia de la tabla usuarios
            Usuarios usuario = new Usuarios();
            usuario.Nombre = txtnombre.Text;
            usuario.Apellido = txtapellido.Text;
            usuario.Usuario = txtusuario.Text;
            usuario.Password = txtcontraseña.Text; 
            usuario.ConPassword = txtconcontraseña.Text;

            try
            {



                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

           


        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
