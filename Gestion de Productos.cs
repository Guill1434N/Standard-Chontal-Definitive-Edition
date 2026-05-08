using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Gestion_de_Productos : Form
    {
        public Gestion_de_Productos()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);

            dgvProductos.RowTemplate.Height = 50;
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 253, 245);
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(5, 150, 105);
            dgvProductos.GridColor = Color.FromArgb(238, 238, 238);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (double.TryParse(txtPrecio.Text, out double precioNumerico))
                {
                    int nuevoId = dgvProductos.Rows.Count + 1;

                    string precioFormateado = "C$ " + precioNumerico.ToString("N2", CultureInfo.InvariantCulture);

                    dgvProductos.Rows.Add(nuevoId, txtNombre.Text, precioFormateado);

                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text);
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}