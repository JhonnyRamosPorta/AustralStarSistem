
namespace CapaPresentacion
{
    partial class sjv_frmGestionar_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sjv_frmGestionar_Cliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtbApellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTDoc = new System.Windows.Forms.ComboBox();
            this.tbltipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtbNroDoc = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataSource_tblTipoDocumento = new CapaPresentacion.DataSource_tblTipoDocumento();
            this.dataSourcetblTipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbltipodocumentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbltipodocumentoTableAdapter = new CapaPresentacion.DataSource_tblTipoDocumentoTableAdapters.tbltipodocumentoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource_tblTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourcetblTipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipodocumentoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDCliente);
            this.groupBox1.Controls.Add(this.txtbApellidos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTDoc);
            this.groupBox1.Controls.Add(this.txtbNroDoc);
            this.groupBox1.Controls.Add(this.txtbTelefono);
            this.groupBox1.Controls.Add(this.txtbEmail);
            this.groupBox1.Controls.Add(this.txtbDireccion);
            this.groupBox1.Controls.Add(this.txtbNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(138, 10);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(35, 13);
            this.lblIDCliente.TabIndex = 17;
            this.lblIDCliente.Text = "label8";
            // 
            // txtbApellidos
            // 
            this.txtbApellidos.Location = new System.Drawing.Point(21, 82);
            this.txtbApellidos.Name = "txtbApellidos";
            this.txtbApellidos.Size = new System.Drawing.Size(374, 20);
            this.txtbApellidos.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellidos";
            // 
            // cbTDoc
            // 
            this.cbTDoc.DataSource = this.tbltipodocumentoBindingSource1;
            this.cbTDoc.DisplayMember = "nombre_tblTipoDocumento";
            this.cbTDoc.FormattingEnabled = true;
            this.cbTDoc.Location = new System.Drawing.Point(472, 52);
            this.cbTDoc.Name = "cbTDoc";
            this.cbTDoc.Size = new System.Drawing.Size(149, 21);
            this.cbTDoc.TabIndex = 14;
            this.cbTDoc.ValueMember = "id_tblTipoDocumento";
            // 
            // txtbNroDoc
            // 
            this.txtbNroDoc.Location = new System.Drawing.Point(472, 128);
            this.txtbNroDoc.Name = "txtbNroDoc";
            this.txtbNroDoc.Size = new System.Drawing.Size(149, 20);
            this.txtbNroDoc.TabIndex = 13;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(472, 196);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(149, 20);
            this.txtbTelefono.TabIndex = 12;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(21, 196);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(374, 20);
            this.txtbEmail.TabIndex = 11;
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(21, 145);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(374, 20);
            this.txtbDireccion.TabIndex = 10;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(21, 43);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(374, 20);
            this.txtbNombre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "N° de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(117, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(581, 261);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 261);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataSource_tblTipoDocumento
            // 
            this.dataSource_tblTipoDocumento.DataSetName = "DataSource_tblTipoDocumento";
            this.dataSource_tblTipoDocumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSourcetblTipoDocumentoBindingSource
            // 
            this.dataSourcetblTipoDocumentoBindingSource.DataSource = this.dataSource_tblTipoDocumento;
            this.dataSourcetblTipoDocumentoBindingSource.Position = 0;
            // 
            // tbltipodocumentoBindingSource1
            // 
            this.tbltipodocumentoBindingSource1.DataMember = "tbltipodocumento";
            this.tbltipodocumentoBindingSource1.DataSource = this.dataSourcetblTipoDocumentoBindingSource;
            // 
            // tbltipodocumentoTableAdapter
            // 
            this.tbltipodocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // sjv_frmGestionar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(677, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sjv_frmGestionar_Cliente";
            this.Text = ".:: Gestionar clientes ::.";
            this.Load += new System.EventHandler(this.sjv_frmGestionar_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource_tblTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourcetblTipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipodocumentoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource tbltipodocumentoBindingSource;
        public System.Windows.Forms.TextBox txtbApellidos;
        public System.Windows.Forms.ComboBox cbTDoc;
        public System.Windows.Forms.TextBox txtbNroDoc;
        public System.Windows.Forms.TextBox txtbTelefono;
        public System.Windows.Forms.TextBox txtbEmail;
        public System.Windows.Forms.TextBox txtbDireccion;
        public System.Windows.Forms.TextBox txtbNombre;
        public System.Windows.Forms.Label lblIDCliente;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource dataSourcetblTipoDocumentoBindingSource;
        private DataSource_tblTipoDocumento dataSource_tblTipoDocumento;
        private System.Windows.Forms.BindingSource tbltipodocumentoBindingSource1;
        private DataSource_tblTipoDocumentoTableAdapters.tbltipodocumentoTableAdapter tbltipodocumentoTableAdapter;
    }
}