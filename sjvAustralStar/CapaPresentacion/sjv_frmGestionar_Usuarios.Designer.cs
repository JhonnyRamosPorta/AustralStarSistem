
namespace CapaPresentacion
{
    partial class sjv_frmGestionar_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sjv_frmGestionar_Usuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.txtbPasswrd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.tblcargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtbNroTelefono = new System.Windows.Forms.TextBox();
            this.txtbNroDocumento = new System.Windows.Forms.TextBox();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tbltipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataSource_tblTipoDocumento = new CapaPresentacion.DataSource_tblTipoDocumento();
            this.tbltipodocumentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbltipodocumentoTableAdapter = new CapaPresentacion.DataSource_tblTipoDocumentoTableAdapters.tbltipodocumentoTableAdapter();
            this.dataSource_tblCargo = new CapaPresentacion.DataSource_tblCargo();
            this.tblcargoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblcargoTableAdapter = new CapaPresentacion.DataSource_tblCargoTableAdapters.tblcargoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource_tblTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipodocumentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource_tblCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcargoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDUsuario);
            this.groupBox1.Controls.Add(this.txtbPasswrd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtbUsuario);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbCargo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtbNroTelefono);
            this.groupBox1.Controls.Add(this.txtbNroDocumento);
            this.groupBox1.Controls.Add(this.cbTipoDocumento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbDireccion);
            this.groupBox1.Controls.Add(this.txtbEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbApellidos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(116, 11);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(41, 13);
            this.lblIDUsuario.TabIndex = 20;
            this.lblIDUsuario.Text = "label11";
            // 
            // txtbPasswrd
            // 
            this.txtbPasswrd.Location = new System.Drawing.Point(307, 177);
            this.txtbPasswrd.Name = "txtbPasswrd";
            this.txtbPasswrd.Size = new System.Drawing.Size(115, 20);
            this.txtbPasswrd.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Contraseña: ";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Location = new System.Drawing.Point(75, 177);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(127, 20);
            this.txtbUsuario.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cbCargo.DataSource = this.tblcargoBindingSource1;
            this.cbCargo.DisplayMember = "nombre_tblCargo";
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(460, 133);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 14;
            this.cbCargo.ValueMember = "id_tblCargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Numero teléfono";
            // 
            // txtbNroTelefono
            // 
            this.txtbNroTelefono.Location = new System.Drawing.Point(322, 133);
            this.txtbNroTelefono.Name = "txtbNroTelefono";
            this.txtbNroTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtbNroTelefono.TabIndex = 12;
            // 
            // txtbNroDocumento
            // 
            this.txtbNroDocumento.Location = new System.Drawing.Point(164, 133);
            this.txtbNroDocumento.Name = "txtbNroDocumento";
            this.txtbNroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtbNroDocumento.TabIndex = 11;
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DataSource = this.tbltipodocumentoBindingSource1;
            this.cbTipoDocumento.DisplayMember = "nombre_tblTipoDocumento";
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(23, 133);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(135, 21);
            this.cbTipoDocumento.TabIndex = 10;
            this.cbTipoDocumento.ValueMember = "id_tblTipoDocumento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Numero documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo Documento";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(322, 90);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(259, 20);
            this.txbDireccion.TabIndex = 7;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(23, 90);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(242, 20);
            this.txtbEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtbApellidos
            // 
            this.txtbApellidos.Location = new System.Drawing.Point(323, 45);
            this.txtbApellidos.Name = "txtbApellidos";
            this.txtbApellidos.Size = new System.Drawing.Size(259, 20);
            this.txtbApellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(20, 46);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(245, 20);
            this.txtbNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(543, 238);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(118, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(13, 238);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // dataSource_tblTipoDocumento
            // 
            this.dataSource_tblTipoDocumento.DataSetName = "DataSource_tblTipoDocumento";
            this.dataSource_tblTipoDocumento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltipodocumentoBindingSource1
            // 
            this.tbltipodocumentoBindingSource1.DataMember = "tbltipodocumento";
            this.tbltipodocumentoBindingSource1.DataSource = this.dataSource_tblTipoDocumento;
            // 
            // tbltipodocumentoTableAdapter
            // 
            this.tbltipodocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // dataSource_tblCargo
            // 
            this.dataSource_tblCargo.DataSetName = "DataSource_tblCargo";
            this.dataSource_tblCargo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcargoBindingSource1
            // 
            this.tblcargoBindingSource1.DataMember = "tblcargo";
            this.tblcargoBindingSource1.DataSource = this.dataSource_tblCargo;
            // 
            // tblcargoTableAdapter
            // 
            this.tblcargoTableAdapter.ClearBeforeFill = true;
            // 
            // sjv_frmGestionar_Usuarios
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(631, 276);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sjv_frmGestionar_Usuarios";
            this.Text = ".:: Gestion de usuarios ::.";
            this.Load += new System.EventHandler(this.sjv_frmGestionar_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblcargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource_tblTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltipodocumentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource_tblCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcargoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblcargoBindingSource;
        private System.Windows.Forms.BindingSource tbltipodocumentoBindingSource;
        private System.Windows.Forms.ErrorProvider errorIcono;
        public System.Windows.Forms.TextBox txtbPasswrd;
        public System.Windows.Forms.TextBox txtbUsuario;
        public System.Windows.Forms.ComboBox cbCargo;
        public System.Windows.Forms.TextBox txtbNroTelefono;
        public System.Windows.Forms.TextBox txtbNroDocumento;
        public System.Windows.Forms.ComboBox cbTipoDocumento;
        public System.Windows.Forms.TextBox txbDireccion;
        public System.Windows.Forms.TextBox txtbEmail;
        public System.Windows.Forms.TextBox txtbApellidos;
        public System.Windows.Forms.TextBox txtbNombre;
        public System.Windows.Forms.Label lblIDUsuario;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAceptar;
        private DataSource_tblTipoDocumento dataSource_tblTipoDocumento;
        private System.Windows.Forms.BindingSource tbltipodocumentoBindingSource1;
        private DataSource_tblTipoDocumentoTableAdapters.tbltipodocumentoTableAdapter tbltipodocumentoTableAdapter;
        private DataSource_tblCargo dataSource_tblCargo;
        private System.Windows.Forms.BindingSource tblcargoBindingSource1;
        private DataSource_tblCargoTableAdapters.tblcargoTableAdapter tblcargoTableAdapter;
    }
}