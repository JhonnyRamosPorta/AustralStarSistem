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
    public partial class sjv_frmListar_CargoUsuario : Form
    {
        public sjv_frmListar_CargoUsuario()
        {
            InitializeComponent();
            dgvTablaCargos.DataSource = N_Usuarios.BusquedaSimple_Cargo_Usuario();
            dgvTablaCargos.Columns[0].Visible = false;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            sjv_frmGestionar_CargoUsuario frm = new sjv_frmGestionar_CargoUsuario();
            frm.Show();
        }

        private void dgvTablaCargos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarCargoUsuario()
        {
            sjv_frmGestionar_CargoUsuario frm = new sjv_frmGestionar_CargoUsuario();
            frm.lblIDCargoUsuario.Text = this.dgvTablaCargos.CurrentRow.Cells[0].Value.ToString();
            frm.txtbNombre.Text = this.dgvTablaCargos.CurrentRow.Cells[1].Value.ToString();
            frm.txbDescripcion.Text = this.dgvTablaCargos.CurrentRow.Cells[2].Value.ToString();
            frm.btnModificar.Visible = true;
            frm.btnAceptar.Visible = false;
            frm.btnCancelar.Visible = false;
            frm.Show();
        }

        private void dgvTablaCargos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarCargoUsuario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCargoUsuario();
        }
    }
}
