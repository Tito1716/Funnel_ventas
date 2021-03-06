using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FUNNELVENTAS.Clases;
namespace FUNNELVENTAS
{
    public partial class Form1 : Form
    {
        cConexion con = new cConexion();
        public Form1()
        {
            InitializeComponent();
            cargarComboClase();
            cargarComboTipo();
            cargarComboProx();
            cargarComboEstado();
        }
        //Variables globales
       

        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.tipo_gestion = int.Parse(comboBox3.SelectedValue.ToString());
            venta.tipo_estado = int.Parse(comboBox4.SelectedValue.ToString()) ;
            venta.tipo_clase = int.Parse(comboBox1.SelectedValue.ToString());
            venta.prox_Gestion = int.Parse(comboBox5.SelectedValue.ToString());
            venta.Ejecutivo_Cuentas = comboBox2.Text;
            venta.tipo_proyeccion = 2;
            venta.nombre_cliente = textBox2.Text;
            venta.tipo_proyeccion = 1;
            Form2 form2 = new Form2(venta);
            form2.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void cargarComboClase()
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            string query = "SELECT * FROM tipo_clase order by nombre_tipo_clase ASC";
            var data =  con.getCombo(query);
            if (data != null)
            {
                comboBox1.ValueMember = "id_tipo_clase";
                comboBox1.DisplayMember = "nombre_tipo_clase";
                comboBox1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarComboTipo()
        {
            comboBox3.DataSource = null;
            comboBox3.Items.Clear();

            string query = "SELECT * FROM tipo_gestion order by nombre_tipo_gestion ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox3.ValueMember = "id_tipo_gestion";
                comboBox3.DisplayMember = "nombre_tipo_gestion";
                comboBox3.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarComboProx()
        {
            comboBox5.DataSource = null;
            comboBox5.Items.Clear();

            string query = "SELECT * FROM prox_gestion order by nombre_tipo_gestion ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox5.ValueMember = "id_tipo_gestion";
                comboBox5.DisplayMember = "nombre_tipo_gestion";
                comboBox5.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarComboEstado()
        {
            comboBox4.DataSource = null;
            comboBox4.Items.Clear();

            string query = "SELECT * FROM tipo_estado order by nombre_tipo_estado ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox4.ValueMember = "id_tipo_estado";
                comboBox4.DisplayMember = "nombre_tipo_estado";
                comboBox4.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
