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
    public partial class sjv_frmListar_TipoDocumento : Form
    {
        public sjv_frmListar_TipoDocumento()
        {
            InitializeComponent();
            dgvTablaTipoDocumento.DataSource = N_TipoDocumento.BusquedaSimple_Tipo_Documento();
            dgvTablaTipoDocumento.Columns[0].Visible = false;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            sjv_frmGestionar_TipoDocumento frm = new sjv_frmGestionar_TipoDocumento();
            frm.Show();
        }

        private void ModificarTipoDOcumento()
        {
            sjv_frmGestionar_TipoDocumento frm = new sjv_frmGestionar_TipoDocumento();

            frm.lblIDTipoDoc.Text = this.dgvTablaTipoDocumento.CurrentRow.Cells[0].Value.ToString();
            frm.txtbNombre.Text = this.dgvTablaTipoDocumento.CurrentRow.Cells[1].Value.ToString();
            frm.txbDescripcion.Text = this.dgvTablaTipoDocumento.CurrentRow.Cells[2].Value.ToString();
            frm.btnModificar.Visible = true;
            frm.btnAceptar.Visible = false;
            frm.btnCancelar.Visible = false;
            frm.Show();
        }

        private void dgvTablaTipoDocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarTipoDOcumento();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarTipoDOcumento();
        }
    }
}
