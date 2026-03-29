namespace WindowsFormsApp1
{
    partial class Nuevo_Producto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.numPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.numPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.numStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            this.SuspendLayout();
            this.lblCodigo.Location = new System.Drawing.Point(25, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 20);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Codigo:";
            this.txtCodigo.Location = new System.Drawing.Point(25, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(350, 20);
            this.txtCodigo.TabIndex = 19;
            this.lblNombre.Location = new System.Drawing.Point(25, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 20);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(25, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(350, 20);
            this.txtNombre.TabIndex = 17;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 20);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion:";
            this.txtDescripcion.Location = new System.Drawing.Point(25, 145);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(350, 20);
            this.txtDescripcion.TabIndex = 15;
            this.lblCategoria.Location = new System.Drawing.Point(25, 180);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 20);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria:";
            this.cmbCategoria.Items.AddRange(new object[] {
            "Bebidas",
            "Alimentos",
            "Limpieza"});
            this.cmbCategoria.Location = new System.Drawing.Point(25, 200);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(350, 21);
            this.cmbCategoria.TabIndex = 13;
            this.lblPrecioCompra.Location = new System.Drawing.Point(25, 235);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(150, 20);
            this.lblPrecioCompra.TabIndex = 12;
            this.lblPrecioCompra.Text = "Precio Compra (C$):";
            this.numPrecioCompra.DecimalPlaces = 2;
            this.numPrecioCompra.Location = new System.Drawing.Point(25, 255);
            this.numPrecioCompra.Name = "numPrecioCompra";
            this.numPrecioCompra.Size = new System.Drawing.Size(165, 20);
            this.numPrecioCompra.TabIndex = 11;
            this.lblPrecioVenta.Location = new System.Drawing.Point(210, 235);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(150, 20);
            this.lblPrecioVenta.TabIndex = 10;
            this.lblPrecioVenta.Text = "Precio Venta (C$):";
            this.numPrecioVenta.DecimalPlaces = 2;
            this.numPrecioVenta.Location = new System.Drawing.Point(210, 255);
            this.numPrecioVenta.Name = "numPrecioVenta";
            this.numPrecioVenta.Size = new System.Drawing.Size(165, 20);
            this.numPrecioVenta.TabIndex = 9;
            this.lblStock.Location = new System.Drawing.Point(25, 290);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(100, 20);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            this.numStock.Location = new System.Drawing.Point(25, 310);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(165, 20);
            this.numStock.TabIndex = 7;
            this.lblStockMinimo.Location = new System.Drawing.Point(210, 290);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.lblStockMinimo.TabIndex = 6;
            this.lblStockMinimo.Text = "Stock Minimo:";
            this.numStockMinimo.Location = new System.Drawing.Point(210, 310);
            this.numStockMinimo.Name = "numStockMinimo";
            this.numStockMinimo.Size = new System.Drawing.Size(165, 20);
            this.numStockMinimo.TabIndex = 5;
            this.lblUnidadMedida.Location = new System.Drawing.Point(25, 345);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(150, 20);
            this.lblUnidadMedida.TabIndex = 4;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            this.cmbUnidadMedida.Items.AddRange(new object[] {
            "Unidad",
            "Kilogramo"});
            this.cmbUnidadMedida.Location = new System.Drawing.Point(25, 365);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(165, 21);
            this.cmbUnidadMedida.TabIndex = 3;
            this.chkActivo.Checked = true;
            this.chkActivo.Location = new System.Drawing.Point(210, 365);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(100, 25);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            this.btnGuardar.Location = new System.Drawing.Point(25, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 31);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnCancelar.Location = new System.Drawing.Point(210, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 31);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.ClientSize = new System.Drawing.Size(400, 485);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.numStockMinimo);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.numPrecioVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.numPrecioCompra);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.MaximizeBox = false;
            this.Name = "Nuevo_Producto";
            this.Text = "Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.NumericUpDown numPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.NumericUpDown numPrecioVenta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}