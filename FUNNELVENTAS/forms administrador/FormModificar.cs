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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            if (checkBox1.Checked)
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

            int modid = Convert.ToInt32(txtid.Text);


            usuario.Id = modid;
            usuario.Usuario = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Id_tipo = usuario.Id_tipo;




            try
            {

                Control control = new Control();
                string respuesta = control.ctrlModificar(usuario);



                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void FormModificar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();



            int modid = Convert.ToInt32(txtid.Text);


            usuario.Id = modid;





            try
            {

                Control control = new Control();
                string respuesta = control.ctrleliminar(usuario);



                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }       
} 
         
