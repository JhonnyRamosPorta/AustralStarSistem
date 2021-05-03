
namespace CapaPresentacion
{
    partial class sjv_frmListar_TipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sjv_frmListar_TipoDocumento));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevoTipoDoc = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTablaTipoDocumento = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(72, 278);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoTipoDoc
            // 
            this.btnNuevoTipoDoc.Location = new System.Drawing.Point(19, 278);
            this.btnNuevoTipoDoc.Name = "btnNuevoTipoDoc";
            this.btnNuevoTipoDoc.Size = new System.Drawing.Size(47, 23);
            this.btnNuevoTipoDoc.TabIndex = 12;
            this.btnNuevoTipoDoc.Text = "Añadir";
            this.btnNuevoTipoDoc.UseVisualStyleBackColor = true;
            this.btnNuevoTipoDoc.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(322, 278);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTablaTipoDocumento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 260);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de documento";
            // 
            // dgvTablaTipoDocumento
            // 
            this.dgvTablaTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaTipoDocumento.Location = new System.Drawing.Point(7, 20);
            this.dgvTablaTipoDocumento.Name = "dgvTablaTipoDocumento";
            this.dgvTablaTipoDocumento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaTipoDocumento.Size = new System.Drawing.Size(372, 234);
            this.dgvTablaTipoDocumento.TabIndex = 0;
            this.dgvTablaTipoDocumento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaTipoDocumento_CellDoubleClick);
            // 
            // sjv_frmListar_TipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 315);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevoTipoDoc);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sjv_frmListar_TipoDocumento";
            this.Text = ".:: Listado de tipos de documento ::.";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTipoDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevoTipoDoc;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTablaTipoDocumento;
    }
}