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
    public partial class Form2 : Form
    {
        Venta ventaForm2 = new Venta();
        cConexion con = new cConexion();
        public Form2(Venta venta)
        {
            ventaForm2 = venta;
            InitializeComponent();
            cargarComboEquipo();
            cargarComboMarcaEquipo();
            cargarComboTipoEnlace();
            cargarComboAnchoBanda();
            cargarComboTipoConsultoria();
            cargarComboTipoConsultoria2();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ventaForm2.tipo_equipo = int.Parse(comboBox1.SelectedValue.ToString());
            ventaForm2.marca_equipo = int.Parse(comboBox2.SelectedValue.ToString());
            ventaForm2.tipo_enlace = int.Parse(comboBox4.SelectedValue.ToString());
            ventaForm2.tipo_ancho = int.Parse(comboBox3.SelectedValue.ToString());
            ventaForm2.tipo_consultoria = int.Parse(comboBox6.SelectedValue.ToString());
            ventaForm2.tipo_consultoria2 = int.Parse(comboBox5.SelectedValue.ToString());
            ventaForm2.cantidad_equipo = int.Parse(textBox3.Text);
            ventaForm2.detalle_equipo = textBox1.Text;
            ventaForm2.monto_equipo = int.Parse(textBox2.Text);
            ventaForm2.cantidad_enlace = int.Parse(textBox4.Text);
            ventaForm2.detalle_enlace = textBox6.Text;
            ventaForm2.monto_enlace = int.Parse(textBox5.Text);
            ventaForm2.cantidad_consultoria = int.Parse(textBox7.Text);
            ventaForm2.detalle_consultoria = textBox9.Text;
            ventaForm2.monto_consultoria = int.Parse(textBox8.Text);
            ventaForm2.total = ventaForm2.monto_consultoria + ventaForm2.monto_equipo + ventaForm2.monto_enlace;
            con.Guardar(ventaForm2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void cargarComboEquipo()
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            string query = "SELECT * FROM tipo_equipo order by nombre_tipo_equipo ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox1.ValueMember = "id_tipo_equipo";
                comboBox1.DisplayMember = "nombre_tipo_equipo";
                comboBox1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarComboMarcaEquipo()
        {
            comboBox2.DataSource = null;
            comboBox2.Items.Clear();

            string query = "SELECT * FROM tipo_marca order by nombre_tipo_marca ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox2.ValueMember = "id_tipo_marca";
                comboBox2.DisplayMember = "nombre_tipo_marca";
                comboBox2.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarComboTipoEnlace()
        {
            comboBox4.DataSource = null;
            comboBox4.Items.Clear();

            string query = "SELECT * FROM tipo_enlace order by nombre_tipo_enlace ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox4.ValueMember = "id_tipo_enlace";
                comboBox4.DisplayMember = "nombre_tipo_enlace";
                comboBox4.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarComboAnchoBanda()
        {
            comboBox3.DataSource = null;
            comboBox3.Items.Clear();

            string query = "SELECT * FROM tipo_ancho order by nombre_tipo_ancho ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox3.ValueMember = "id_tipo_ancho";
                comboBox3.DisplayMember = "nombre_tipo_ancho";
                comboBox3.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarComboTipoConsultoria()
        {
            comboBox6.DataSource = null;
            comboBox6.Items.Clear();

            string query = "SELECT * FROM tipo_consultoria order by nombre_tipo_consultoria ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox6.ValueMember = "id_tipo_consultoria";
                comboBox6.DisplayMember = "nombre_tipo_consultoria";
                comboBox6.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarComboTipoConsultoria2()
        {
            comboBox5.DataSource = null;
            comboBox5.Items.Clear();

            string query = "SELECT * FROM tipo_consultoria2 order by nombre_tipo_consultoria2 ASC";
            var data = con.getCombo(query);
            if (data != null)
            {
                comboBox5.ValueMember = "id_tipo_consultoria2";
                comboBox5.DisplayMember = "nombre_tipo_consultoria2";
                comboBox5.DataSource = data;
            }
            else
            {
                MessageBox.Show("No hay clases", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
