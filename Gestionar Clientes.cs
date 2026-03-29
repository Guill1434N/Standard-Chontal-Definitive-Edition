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
            if ((label.Text.Trim() == ""))
            {
                MessageBox.Show("El nombre no puede ir vacio");
                label.Focus();
                return;

            }

            //Agregamos los datos de la tabla
            dgvClientes.Rows.Add(label.Text.Trim(), LabelTelefono.Text.Trim(), cmbCategoria.Text, DateTime.Now.ToString("add/MM/yyyy"));

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

            
                
            }
        }
    

