
namespace CapaPresentacion
{
    partial class sjv_frmListar_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sjv_frmListar_Clientes));
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNoCli = new System.Windows.Forms.Button();
            this.btnAddCli = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(14, 417);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Location = new System.Drawing.Point(14, 44);
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoClientes.Size = new System.Drawing.Size(774, 367);
            this.dgvListadoClientes.TabIndex = 8;
            this.dgvListadoClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoClientes_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(615, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNoCli
            // 
            this.btnNoCli.Image = ((System.Drawing.Image)(resources.GetObject("btnNoCli.Image")));
            this.btnNoCli.Location = new System.Drawing.Point(731, 417);
            this.btnNoCli.Name = "btnNoCli";
            this.btnNoCli.Size = new System.Drawing.Size(25, 23);
            this.btnNoCli.TabIndex = 11;
            this.btnNoCli.UseVisualStyleBackColor = true;
            this.btnNoCli.Visible = false;
            // 
            // btnAddCli
            // 
            this.btnAddCli.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCli.Image")));
            this.btnAddCli.Location = new System.Drawing.Point(762, 417);
            this.btnAddCli.Name = "btnAddCli";
            this.btnAddCli.Size = new System.Drawing.Size(26, 23);
            this.btnAddCli.TabIndex = 10;
            this.btnAddCli.UseVisualStyleBackColor = true;
            this.btnAddCli.Visible = false;
            this.btnAddCli.Click += new System.EventHandler(this.btnAddCli_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.Buscar_p;
            this.btnBuscar.Location = new System.Drawing.Point(577, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // sjv_frmListar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.btnNoCli);
            this.Controls.Add(this.btnAddCli);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvListadoClientes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sjv_frmListar_Clientes";
            this.Text = ".:: Listado de clientes ::.";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListadoClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnAddCli;
        public System.Windows.Forms.Button btnNoCli;
        public System.Windows.Forms.Button btnModificar;
    }
}