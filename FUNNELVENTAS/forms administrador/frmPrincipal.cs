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
    public partial class frmPrincipal : Form
    {
        int tipoUsuario;

        public frmPrincipal()
        {
            InitializeComponent();

          
            label1.Text = "Bienvenido " + Session.nombre;

            tipoUsuario = Session.id_tipo;

            if(tipoUsuario == 1)
            {
                this.subMenuRegistrarUsuario.Visible = true;
            } else
            {
                this.subMenuRegistrarUsuario.Visible = false;
                
            }
        }

        private void subMenuRegistrarUsuario_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Visible = true;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
        
        private void menuCerrarSession_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin frm = new frmLogin();
            
            frm.Visible = true;

            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'funnel_ventas2DataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.funnel_ventas2DataSet.usuario);

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void subMenuConsultarUsuarios_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            refreshbtn.Visible = true;
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FormModificar frmModificar = new FormModificar();
            frmModificar.Visible = true;


            
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal p = new frmPrincipal();
            p.Show();
            p.dataGridView1.Visible = true;
            p.refreshbtn.Visible = true;

        }
    }
}
