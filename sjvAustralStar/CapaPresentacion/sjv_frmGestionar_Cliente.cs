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
    public partial class sjv_frmGestionar_Cliente : Form
    {
        public sjv_frmGestionar_Cliente()
        {
            InitializeComponent();
            cbTDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btnModificar.Visible = false;
            this.lblIDCliente.Visible = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Austral Star", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Austral Star", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            this.txtbNombre.Text = string.Empty;
            this.txtbApellidos.Text = string.Empty;
            this.txtbDireccion.Text = string.Empty;
            this.txtbEmail.Text = string.Empty;
            this.txtbNroDoc.Text = string.Empty;
            this.txtbTelefono.Text = string.Empty;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sjv_frmGestionar_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSource_tblTipoDocumento.tbltipodocumento' table. You can move, or remove it, as needed.
            this.tbltipodocumentoTableAdapter.Fill(this.dataSource_tblTipoDocumento.tbltipodocumento);
            // TODO: This line of code loads data into the 'dbgrifoDataSet.tbltipodocumento' table. You can move, or remove it, as needed.

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text == string.Empty || this.txtbApellidos.Text == string.Empty || this.cbTDoc.Text == string.Empty || this.txtbDireccion.Text == string.Empty || this.txtbEmail.Text == string.Empty || this.txtbNroDoc.Text == string.Empty || this.txtbTelefono.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(this.txtbNombre, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbApellidos, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbDireccion, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbEmail, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbNroDoc, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbTelefono, "Ingrese un valor");
                }
                else
                {
                    int idtipodoc = Int32.Parse(this.cbTDoc.SelectedValue.ToString());
                    Rpta = N_Clientes.Ingresar_Cliente(this.txtbNombre.Text, this.txtbApellidos.Text, idtipodoc, this.txtbNroDoc.Text, this.txtbDireccion.Text, this.txtbTelefono.Text, this.txtbEmail.Text);
                }
                if (Rpta.Equals("OK"))
                {
                    this.MensajeOK("Se insertó de forma correcta el registro");
                    this.Limpiar();
                }
                else
                {
                    //Mostramos el mensaje de error
                    this.MensajeError(Rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text == string.Empty || this.txtbApellidos.Text == string.Empty || this.cbTDoc.Text == string.Empty || this.txtbDireccion.Text == string.Empty || this.txtbEmail.Text == string.Empty || this.txtbNroDoc.Text == string.Empty || this.txtbTelefono.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(this.txtbNombre, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbApellidos, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbDireccion, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbEmail, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbNroDoc, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbTelefono, "Ingrese un valor");
                }
                else
                {
                    int idcli = Int32.Parse(this.lblIDCliente.Text.ToString());
                    int idtipodoc = Int32.Parse(this.cbTDoc.SelectedValue.ToString());
                    Rpta = N_Clientes.Modificar_Cliente(idcli, this.txtbNombre.Text, this.txtbApellidos.Text, idtipodoc, this.txtbNroDoc.Text, this.txtbDireccion.Text, this.txtbTelefono.Text, this.txtbEmail.Text);
                }
                if (Rpta.Equals("OK"))
                {
                    this.MensajeOK("Se modifico de forma correcta el registro");
                    this.Limpiar();
                }
                else
                {
                    //Mostramos el mensaje de error
                    this.MensajeError(Rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
