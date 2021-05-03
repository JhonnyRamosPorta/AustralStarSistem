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
    public partial class sjv_frmRegistrarVenta : Form
    {
        public string idproducto = "";
        public string nombreproducto = "";
        public decimal precio = 0;
        public string nombrecliente = "";
        public string apellidocliente = "";
        public int idcliente = 0;
        public string fechahora;
        public decimal cantidad = 0;
        public decimal subtotal = 0;
        static sjv_frmRegistrarVenta _instancia;
        private DataTable detalleventa;

        public sjv_frmRegistrarVenta()
        {
            InitializeComponent();
            txtbFecha.Text = DateTime.Now.ToString();
            fechahora = txtbFecha.Text;
            cbComprobante.DropDownStyle = ComboBoxStyle.DropDownList;
            cbComprobante.SelectedIndex = 0;
        }
        //Constructor del formulario

        public static sjv_frmRegistrarVenta GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new sjv_frmRegistrarVenta();
            }
            return _instancia;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtbCliente.Text==string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(txtbCliente, "Ingrese un Valor");
                }
                else
                {
                    rpta = N_Venta.Insertar(Convert.ToInt32(this.lblIDCliente.Text), 1, Convert.ToInt32(this.lblIDUsuario.Text), Convert.ToDateTime(this.txtbFecha.Text), this.txtbNumero.Text, detalleventa, Convert.ToDecimal(this.txtbTotal.Text));
                    
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            sjv_frmListar_Clientes frm = new sjv_frmListar_Clientes();
            frm.btnModificar.Visible = false;
            frm.btnAddCli.Visible = true;
            frm.Show();
        }

        private void btnAddCompra_Click(object sender, EventArgs e)
        {
            sjv_frmListar_Producto frm = new sjv_frmListar_Producto();
            frm.btnAdd.Visible = true;
            frm.btnModificar.Visible = false;
            frm.Show();
        }

        public void set_receptor_cliente_venta(string nombres, string apellidos, int codigo)
        {
            this.nombrecliente = nombres;
            this.apellidocliente = apellidos;
            this.idcliente = codigo;
            this.txtbCliente.Text = nombres + " " + apellidos;
        }
        public void receptor_detalleventa(string id, string nombre, decimal precio,decimal cantidad, decimal subtotal)
        {
            this.idproducto = id;
            this.nombreproducto = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        private void sjv_frmRegistrarVenta_Activated(object sender, EventArgs e)
        {
            
        }

        private void dgvDetalleVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            int n = dgvDetalleVenta.Rows.Add();
            dgvDetalleVenta.Rows[n].Cells[0].Value = txtbDetalleIDArticulo.Text;
            dgvDetalleVenta.Rows[n].Cells[1].Value = txtbDetalleNomProducto.Text;
            dgvDetalleVenta.Rows[n].Cells[2].Value = txtbDetalleCantidad.Text;
            dgvDetalleVenta.Rows[n].Cells[3].Value = txtbDetallePrecioUnitario.Text;
            decimal precio = decimal.Parse(dgvDetalleVenta.Rows[n].Cells[3].Value.ToString());
            decimal cantidad = decimal.Parse(dgvDetalleVenta.Rows[n].Cells[2].Value.ToString());
            decimal subtotal = precio * cantidad;
            dgvDetalleVenta.Rows[n].Cells[4].Value = subtotal.ToString();

        }
    }
}
