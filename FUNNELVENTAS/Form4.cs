using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using FUNNELVENTAS.Clases;
using System.Windows.Forms;

namespace FUNNELVENTAS
{
    public partial class Form4 : Form
    {
        validaciones va = new validaciones();
        usuario usuarioClase = new usuario();
        cConexion con = new cConexion();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            


            usuarioClase.Nombre = textBox1.Text;
            usuarioClase.Password = textBox2.Text;
            

            if (va.Vacio(usuarioClase.Nombre, usuarioClase.Password))  {

                MessageBox.Show("Formulario Vacio", "Ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (con.login(usuarioClase.Nombre, usuarioClase.Password))
                {
                     
                    MessageBox.Show("Session iniciada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

               
                }
                else
                {
                    MessageBox.Show("Ingreso data incorrecta", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
