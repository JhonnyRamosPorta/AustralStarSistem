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
    public partial class sjv_frmListar_Producto : Form
    {
        public sjv_frmListar_Producto()
        {
            InitializeComponent();
            dgvListadoProducto.DataSource = N_Producto.BusquedaSimple_Producto();
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema SAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Modificar()
        {
            sjv_frmGestionar_Producto frm = new sjv_frmGestionar_Producto();

            frm.txtbIDProdcuto.Text = this.dgvListadoProducto.CurrentRow.Cells[0].Value.ToString();
            frm.txtbNombre.Text = this.dgvListadoProducto.CurrentRow.Cells[1].Value.ToString();
            frm.txtbDescripcion.Text = this.dgvListadoProducto.CurrentRow.Cells[2].Value.ToString();
            frm.txtbPrecio.Text = this.dgvListadoProducto.CurrentRow.Cells[3].Value.ToString();
            frm.cbCategoria.Text = this.dgvListadoProducto.CurrentRow.Cells[4].Value.ToString();
            frm.btnModificar.Visible = true;
            frm.btnAceptar.Visible = false;
            frm.btnCancelar.Visible = false;
            frm.Show();
        }

        private void sjv_frmConsultarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sjv_frmGestionar_Producto frm = new sjv_frmGestionar_Producto();
            frm.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void dgvListadoProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvListadoProducto.SelectedRows.Count > 0)
            {
                string idarticulo, nomarticulo, precio;
                idarticulo= this.dgvListadoProducto.CurrentRow.Cells[0].Value.ToString();
                nomarticulo= this.dgvListadoProducto.CurrentRow.Cells[1].Value.ToString(); 
                precio= this.dgvListadoProducto.CurrentRow.Cells[3].Value.ToString();
                sjv_frmRegistrarVenta frm = sjv_frmRegistrarVenta.GetInstancia();
                int n = frm.dgvDetalleVenta.Rows.Add();
                frm.txtbDetalleIDArticulo.Text = idarticulo;
                frm.txtbDetalleNomProducto.Text = nomarticulo;
                frm.txtbDetallePrecioUnitario.Text = precio;
                this.Hide();
                frm.Show();
            }
            else
            {
                this.MensajeOK("Se debe seleccionar algun producto");
            }
        }
    }
}
