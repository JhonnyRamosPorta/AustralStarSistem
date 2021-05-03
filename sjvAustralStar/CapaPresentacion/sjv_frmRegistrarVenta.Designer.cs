
namespace CapaPresentacion
{
    partial class sjv_frmRegistrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sjv_frmRegistrarVenta));
            this.Venta = new System.Windows.Forms.GroupBox();
            this.txtbCliente = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.btnAddCompra = new System.Windows.Forms.Button();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbComprobante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtbFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.GroupBox();
            this.txtbDetalleIDArticulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbDetalleNomProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbDetalleCantidad = new System.Windows.Forms.TextBox();
            this.txtbDetallePrecioUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.Venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Venta
            // 
            this.Venta.Controls.Add(this.lblIDUsuario);
            this.Venta.Controls.Add(this.txtbTotal);
            this.Venta.Controls.Add(this.label9);
            this.Venta.Controls.Add(this.Detalle);
            this.Venta.Controls.Add(this.dgvDetalleVenta);
            this.Venta.Controls.Add(this.txtbCliente);
            this.Venta.Controls.Add(this.lblIDCliente);
            this.Venta.Controls.Add(this.btnAddCompra);
            this.Venta.Controls.Add(this.txtbNumero);
            this.Venta.Controls.Add(this.label4);
            this.Venta.Controls.Add(this.cbComprobante);
            this.Venta.Controls.Add(this.label3);
            this.Venta.Controls.Add(this.btnBuscarCliente);
            this.Venta.Controls.Add(this.txtbFecha);
            this.Venta.Controls.Add(this.label2);
            this.Venta.Controls.Add(this.label1);
            this.Venta.Location = new System.Drawing.Point(13, 13);
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(592, 490);
            this.Venta.TabIndex = 0;
            this.Venta.TabStop = false;
            this.Venta.Text = "Venta";
            // 
            // txtbCliente
            // 
            this.txtbCliente.Location = new System.Drawing.Point(20, 43);
            this.txtbCliente.Name = "txtbCliente";
            this.txtbCliente.Size = new System.Drawing.Size(248, 20);
            this.txtbCliente.TabIndex = 12;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(92, 26);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(35, 13);
            this.lblIDCliente.TabIndex = 11;
            this.lblIDCliente.Text = "label5";
            // 
            // btnAddCompra
            // 
            this.btnAddCompra.Location = new System.Drawing.Point(20, 144);
            this.btnAddCompra.Name = "btnAddCompra";
            this.btnAddCompra.Size = new System.Drawing.Size(131, 23);
            this.btnAddCompra.TabIndex = 9;
            this.btnAddCompra.Text = "Agregar Articulos";
            this.btnAddCompra.UseVisualStyleBackColor = true;
            this.btnAddCompra.Click += new System.EventHandler(this.btnAddCompra_Click);
            // 
            // txtbNumero
            // 
            this.txtbNumero.Enabled = false;
            this.txtbNumero.Location = new System.Drawing.Point(174, 102);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(129, 20);
            this.txtbNumero.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero";
            // 
            // cbComprobante
            // 
            this.cbComprobante.Enabled = false;
            this.cbComprobante.FormattingEnabled = true;
            this.cbComprobante.Items.AddRange(new object[] {
            "Ticket"});
            this.cbComprobante.Location = new System.Drawing.Point(20, 102);
            this.cbComprobante.Name = "cbComprobante";
            this.cbComprobante.Size = new System.Drawing.Size(121, 21);
            this.cbComprobante.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comprobante";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscarCliente.Location = new System.Drawing.Point(274, 42);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(29, 23);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtbFecha
            // 
            this.txtbFecha.Enabled = false;
            this.txtbFecha.Location = new System.Drawing.Point(376, 43);
            this.txtbFecha.Name = "txtbFecha";
            this.txtbFecha.Size = new System.Drawing.Size(188, 20);
            this.txtbFecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(13, 509);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(530, 509);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.Nombre,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal});
            this.dgvDetalleVenta.Location = new System.Drawing.Point(20, 263);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(557, 191);
            this.dgvDetalleVenta.TabIndex = 13;
            this.dgvDetalleVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellEndEdit);
            // 
            // idArticulo
            // 
            this.idArticulo.HeaderText = "idArticulo";
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.Controls.Add(this.btnLess);
            this.Detalle.Controls.Add(this.btnMore);
            this.Detalle.Controls.Add(this.label8);
            this.Detalle.Controls.Add(this.txtbDetallePrecioUnitario);
            this.Detalle.Controls.Add(this.txtbDetalleCantidad);
            this.Detalle.Controls.Add(this.label7);
            this.Detalle.Controls.Add(this.label6);
            this.Detalle.Controls.Add(this.txtbDetalleNomProducto);
            this.Detalle.Controls.Add(this.label5);
            this.Detalle.Controls.Add(this.txtbDetalleIDArticulo);
            this.Detalle.Location = new System.Drawing.Point(20, 174);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(557, 72);
            this.Detalle.TabIndex = 14;
            this.Detalle.TabStop = false;
            this.Detalle.Text = "Detalle";
            // 
            // txtbDetalleIDArticulo
            // 
            this.txtbDetalleIDArticulo.Enabled = false;
            this.txtbDetalleIDArticulo.Location = new System.Drawing.Point(7, 43);
            this.txtbDetalleIDArticulo.Name = "txtbDetalleIDArticulo";
            this.txtbDetalleIDArticulo.Size = new System.Drawing.Size(78, 20);
            this.txtbDetalleIDArticulo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "IdArticulo";
            // 
            // txtbDetalleNomProducto
            // 
            this.txtbDetalleNomProducto.Enabled = false;
            this.txtbDetalleNomProducto.Location = new System.Drawing.Point(91, 43);
            this.txtbDetalleNomProducto.Name = "txtbDetalleNomProducto";
            this.txtbDetalleNomProducto.Size = new System.Drawing.Size(120, 20);
            this.txtbDetalleNomProducto.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cantidad";
            // 
            // txtbDetalleCantidad
            // 
            this.txtbDetalleCantidad.Location = new System.Drawing.Point(240, 43);
            this.txtbDetalleCantidad.Name = "txtbDetalleCantidad";
            this.txtbDetalleCantidad.Size = new System.Drawing.Size(53, 20);
            this.txtbDetalleCantidad.TabIndex = 5;
            // 
            // txtbDetallePrecioUnitario
            // 
            this.txtbDetallePrecioUnitario.Enabled = false;
            this.txtbDetallePrecioUnitario.Location = new System.Drawing.Point(317, 43);
            this.txtbDetallePrecioUnitario.Name = "txtbDetallePrecioUnitario";
            this.txtbDetallePrecioUnitario.Size = new System.Drawing.Size(73, 20);
            this.txtbDetallePrecioUnitario.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio Unitario";
            // 
            // btnMore
            // 
            this.btnMore.Image = global::CapaPresentacion.Properties.Resources.agregar_p;
            this.btnMore.Location = new System.Drawing.Point(476, 40);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(28, 23);
            this.btnMore.TabIndex = 8;
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnLess
            // 
            this.btnLess.Image = global::CapaPresentacion.Properties.Resources.Remove1;
            this.btnLess.Location = new System.Drawing.Point(516, 40);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(28, 23);
            this.btnLess.TabIndex = 9;
            this.btnLess.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total:";
            // 
            // txtbTotal
            // 
            this.txtbTotal.Enabled = false;
            this.txtbTotal.Location = new System.Drawing.Point(463, 464);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(100, 20);
            this.txtbTotal.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(151, 26);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblIDUsuario.TabIndex = 17;
            this.lblIDUsuario.Text = "label5";
            // 
            // sjv_frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 544);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Venta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sjv_frmRegistrarVenta";
            this.Text = ".:: Registrar Venta ::.";
            this.Activated += new System.EventHandler(this.sjv_frmRegistrarVenta_Activated);
            this.Venta.ResumeLayout(false);
            this.Venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.Detalle.ResumeLayout(false);
            this.Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Venta;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCompra;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbComprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtbFecha;
        public System.Windows.Forms.Label lblIDCliente;
        public System.Windows.Forms.TextBox txtbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        public System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.GroupBox Detalle;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbDetalleCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtbDetallePrecioUnitario;
        public System.Windows.Forms.TextBox txtbDetalleNomProducto;
        public System.Windows.Forms.TextBox txtbDetalleIDArticulo;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label lblIDUsuario;
    }
}