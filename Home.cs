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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {

            if (this.panelEscritorio.Controls.Count > 0)
            {
                this.panelEscritorio.Controls.RemoveAt(0);
            }

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            this.panelEscritorio.Controls.Add(formularioHijo);
            this.panelEscritorio.Tag = formularioHijo;
            formularioHijo.Show();
            formularioHijo.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Gestionar_Proveedores());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Gestion_de_Ventas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Gestionar_Clientes());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Gestion_de_Productos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir del sistema?",
                                     "Standard Chontal Matagalpa",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIrInicio_Click(object sender, EventArgs e)
        {
            if (this.panelEscritorio.Controls.Count > 0)
            {
                this.panelEscritorio.Controls.Clear();
            }

            DialogResult reset = MessageBox.Show("¿Desea regresar al menú principal?", "Standard Chontal", MessageBoxButtons.YesNo);
            if (reset == DialogResult.Yes)
            {
                this.Controls.Clear();
                InitializeComponent();
            }
        }
    }
}
