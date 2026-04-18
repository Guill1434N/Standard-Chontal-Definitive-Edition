using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Nuevo_Producto : Form
    {
        public Nuevo_Producto()
        {
            InitializeComponent();

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;

            if (cmbCategoria.Items.Count > 0)
                cmbCategoria.SelectedIndex = 0;

            if (cmbUnidadMedida.Items.Count > 0)
                cmbUnidadMedida.SelectedIndex = 0;

            this.Paint += Nuevo_Producto_Paint;
        }

        private void Nuevo_Producto_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 239, 243);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
               string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Complete Código y Nombre");
                return;
            }

            MessageBox.Show("Producto guardado correctamente");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Nuevo_Producto_Paint(object sender, PaintEventArgs e)
        {
            using (Pen azul = new Pen(Color.FromArgb(0, 83, 187), 4))
            using (Pen rojo = new Pen(Color.FromArgb(220, 40, 40), 2))
            {
                e.Graphics.DrawLine(azul, 0, 0, this.Width, 0);
                e.Graphics.DrawLine(rojo, 0, 5, this.Width, 5);

                e.Graphics.DrawLine(azul, 0, this.Height - 8, this.Width, this.Height - 8);
                e.Graphics.DrawLine(rojo, 0, this.Height - 3, this.Width, this.Height - 3);
            }
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblUnidadMedida_Click(object sender, EventArgs e)
        {

        }

        private void lblStockMinimo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}