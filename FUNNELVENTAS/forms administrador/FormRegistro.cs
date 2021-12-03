using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNNELVENTAS
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //int registrotipo_usuario;
            Usuarios usuario = new Usuarios();
            

           // string registro;
           // registro=Convert.ToString(comboBox1.SelectedIndex);

            if (checkBox1.Checked )
            {
               usuario.Id_tipo = 1;

            }

            else
            {
                if (checkBox2.Checked)
                {
                    usuario.Id_tipo = 2;
                }

            }


           
            usuario.Usuario = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            usuario.ConPassword = txtConPassword.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Id_tipo = usuario.Id_tipo ;

            
            

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
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
