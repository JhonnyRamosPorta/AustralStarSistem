using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class sjv_frmListar_Usuarios : Form
    {
        
        

        public sjv_frmListar_Usuarios()
        {
            InitializeComponent();
            dgvTablaUsuarios.DataSource = N_Usuarios.BusquedaSimple_Usuario();
            dgvTablaUsuarios.Columns[0].Visible = false;
            dgvTablaUsuarios.Columns[10].Visible = false;

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            sjv_frmGestionar_Usuarios frmGestionar_Usuarios = new sjv_frmGestionar_Usuarios();
            frmGestionar_Usuarios.Show();
            
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblidCargo_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Datos()
        {
            sjv_frmGestionar_Usuarios frmGestionar_Usuarios = new sjv_frmGestionar_Usuarios();
            frmGestionar_Usuarios.lblIDUsuario.Text = this.dgvTablaUsuarios.CurrentRow.Cells[0].Value.ToString();
            frmGestionar_Usuarios.txtbUsuario.Text = this.dgvTablaUsuarios.CurrentRow.Cells[1].Value.ToString();
            frmGestionar_Usuarios.txtbNombre.Text = this.dgvTablaUsuarios.CurrentRow.Cells[2].Value.ToString();
            frmGestionar_Usuarios.txtbApellidos.Text = this.dgvTablaUsuarios.CurrentRow.Cells[3].Value.ToString();
            frmGestionar_Usuarios.cbTipoDocumento.SelectedValue = this.dgvTablaUsuarios.CurrentRow.Cells[4].Value.ToString();
            frmGestionar_Usuarios.txtbNroDocumento.Text = this.dgvTablaUsuarios.CurrentRow.Cells[5].Value.ToString();
            frmGestionar_Usuarios.txtbNroTelefono.Text = this.dgvTablaUsuarios.CurrentRow.Cells[6].Value.ToString();
            frmGestionar_Usuarios.txbDireccion.Text = this.dgvTablaUsuarios.CurrentRow.Cells[7].Value.ToString();
            frmGestionar_Usuarios.txtbEmail.Text = this.dgvTablaUsuarios.CurrentRow.Cells[8].Value.ToString();
            frmGestionar_Usuarios.cbCargo.SelectedValue = this.dgvTablaUsuarios.CurrentRow.Cells[9].Value.ToString();
            frmGestionar_Usuarios.txtbPasswrd.Text = this.dgvTablaUsuarios.CurrentRow.Cells[10].Value.ToString();
            frmGestionar_Usuarios.btnModificar.Visible = true;
            frmGestionar_Usuarios.btnAceptar.Visible = false;
            frmGestionar_Usuarios.btnCancelar.Visible = false;
            frmGestionar_Usuarios.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_Datos();
        }

        private void dgvTablaUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Datos();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
