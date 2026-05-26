using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Gestionar_Clientes : Form
    {
        public Gestionar_Clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // validamos que no este vacio el nommbre (minimo esto)  
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Los campos no pueden ir vacios");
                label.Focus();

                if (string.IsNullOrWhiteSpace(txtNombre.Text)) txtNombre.Focus();
                else txtTelefono.Focus();

                return;

            }

            //Agregamos los datos de la tabla
            dgvClientes.Rows.Add(txtNombre.Text.Trim(), txtTelefono.Text.Trim(), cmbCategoria.Text, DateTime.Now.ToString("dd/MM/yyyy"));

            //Limpiar para el siguiente cliente
            LimpiarFormulario();

            //Mensaje de exito 
            MessageBox.Show("Cliente registrado con exito", "sistema");
        }
            
            //creamos  este metodo aparte que se limpie el codigo
            private void LimpiarFormulario()
            {
                txtNombre.Clear();
                txtTelefono.Clear();
                cmbCategoria.SelectedIndex = -1;


            }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite letras, espacios y letras 
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; // "Bloquea" el número si intentan escribirlo
                MessageBox.Show(" Solo Letras", "Atención");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite numeros
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // "Bloquea" la letra si intentan escribirla
                MessageBox.Show("Solo Numeros.", "Atención");
            }
        }

        private void Gestionar_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
        }
    

