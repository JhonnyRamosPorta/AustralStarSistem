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
    public partial class sjv_frmListar_Categoria : Form
    {
        public sjv_frmListar_Categoria()
        {
            InitializeComponent();
            dgvTablaCategorias.DataSource = N_Producto.BusquedaSimple_Categoria();
        }

        private void Modificar()
        {
            sjv_frmGestionar_Categoria frm = new sjv_frmGestionar_Categoria();

            frm.txtbID.Text = this.dgvTablaCategorias.CurrentRow.Cells[0].Value.ToString();
            frm.txtbNombre.Text = this.dgvTablaCategorias.CurrentRow.Cells[1].Value.ToString();
            frm.txbDescripcion.Text = this.dgvTablaCategorias.CurrentRow.Cells[2].Value.ToString();
            frm.txtbStatus.Text = this.dgvTablaCategorias.CurrentRow.Cells[3].Value.ToString();
            frm.btnModificar.Visible = true;
            frm.btnAceptar.Visible = false;
            frm.btnModificar.Visible = false;
            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sjv_frmGestionar_Categoria frm = new sjv_frmGestionar_Categoria();
            frm.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void dgvTablaCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
    }
}
