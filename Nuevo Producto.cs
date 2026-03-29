using System;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Nuevo_Producto : Form
    {
        public Nuevo_Producto()
        {
            InitializeComponent();

            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
            if (cmbUnidadMedida.Items.Count > 0) cmbUnidadMedida.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete el Código y el Nombre del producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numPrecioVenta.Value < numPrecioCompra.Value)
            {
                DialogResult resp = MessageBox.Show("El precio de venta es menor al precio de compra. ¿Desea continuar de todos modos?",
                                                   "Confirmación de margen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.No) return;
            }

            MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNombre_Click(object sender, EventArgs e) { }
        private void lblCodigo_Click(object sender, EventArgs e) { }
    }
}