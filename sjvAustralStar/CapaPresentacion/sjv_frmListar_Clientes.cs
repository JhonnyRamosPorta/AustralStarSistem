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
    public partial class sjv_frmListar_Clientes : Form
    {
        public sjv_frmListar_Clientes()
        {
            InitializeComponent();
            dgvListadoClientes.DataSource = N_Clientes.BusquedaSimple_Cliente();
            dgvListadoClientes.Columns[0].Visible = false;
        }

        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema SAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sjv_frmGestionar_Cliente frm = new sjv_frmGestionar_Cliente();
            frm.Show();
        }

        private void ModificarClientes()
        {
            sjv_frmGestionar_Cliente frm = new sjv_frmGestionar_Cliente();
            frm.lblIDCliente.Text = this.dgvListadoClientes.CurrentRow.Cells[0].Value.ToString();
            frm.txtbNombre.Text = this.dgvListadoClientes.CurrentRow.Cells[1].Value.ToString();
            frm.txtbApellidos.Text = this.dgvListadoClientes.CurrentRow.Cells[2].Value.ToString();
            frm.cbTDoc.Text = this.dgvListadoClientes.CurrentRow.Cells[3].Value.ToString();
            frm.txtbNroDoc.Text = this.dgvListadoClientes.CurrentRow.Cells[4].Value.ToString();
            frm.txtbDireccion.Text = this.dgvListadoClientes.CurrentRow.Cells[5].Value.ToString();
            frm.txtbTelefono.Text = this.dgvListadoClientes.CurrentRow.Cells[6].Value.ToString();
            frm.txtbEmail.Text = this.dgvListadoClientes.CurrentRow.Cells[7].Value.ToString();
            frm.btnModificar.Visible = true;
            frm.btnAgregar.Visible = false;
            frm.btnCancelar.Visible = false;
            frm.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgvListadoClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarClientes();
        }

        private void btnAddCli_Click(object sender, EventArgs e)
        {
            if (dgvListadoClientes.SelectedRows.Count > 0)
            {
                sjv_frmRegistrarVenta frm = sjv_frmRegistrarVenta.GetInstancia();
                string nombre, apellidos;
                int codigo;
                codigo = Convert.ToInt32(this.dgvListadoClientes.CurrentRow.Cells[0].Value);
                nombre = this.dgvListadoClientes.CurrentRow.Cells[1].Value.ToString();
                apellidos = this.dgvListadoClientes.CurrentRow.Cells[2].Value.ToString();
                frm.set_receptor_cliente_venta(nombre, apellidos, codigo);
                frm.lblIDCliente.Text = codigo.ToString();
                frm.txtbFecha.Text = frm.fechahora;
                this.Hide();
                frm.Show();
                

            }
            else
            {
                this.MensajeOK("Se debe seleccionar algun cliente");
            }
        }
    }
}
