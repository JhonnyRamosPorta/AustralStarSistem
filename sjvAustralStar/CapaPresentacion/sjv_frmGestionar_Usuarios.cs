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
    public partial class sjv_frmGestionar_Usuarios : Form
    {
        public sjv_frmGestionar_Usuarios()
        {
            InitializeComponent();
            cbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            if (txtbNombre.Text ==string.Empty)
            {
                
                btnAceptar.Visible = true;
                btnCancelar.Visible = true;
                btnModificar.Visible = false;
            }
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
            this.txtbEmail.Text = string.Empty;
            this.txbDireccion.Text = string.Empty;
            this.cbTipoDocumento.Text = string.Empty;
            this.txtbNroDocumento.Text = string.Empty;
            this.txtbNroTelefono.Text = string.Empty;
            this.cbCargo.Text = string.Empty;
            this.txtbUsuario.Text = string.Empty;
            this.txtbPasswrd.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text == string.Empty || this.txtbApellidos.Text == string.Empty || this.txtbEmail.Text == string.Empty || this.txbDireccion.Text == string.Empty || this.cbTipoDocumento.Text == string.Empty || this.txtbNroDocumento.Text == string.Empty || this.txtbNroTelefono.Text == string.Empty || this.cbCargo.Text == string.Empty || this.txtbUsuario.Text == string.Empty || this.txtbPasswrd.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(this.txtbNombre, "Ingrese un valor");
                    errorIcono.SetError(this.txtbApellidos, "Ingrese un valor");
                    errorIcono.SetError(this.txtbEmail, "Ingrese un valor");
                    errorIcono.SetError(this.txbDireccion, "Ingrese un valor");
                    errorIcono.SetError(this.cbTipoDocumento, "Ingrese un valor");
                    errorIcono.SetError(this.txtbNroDocumento, "Ingrese un valor");
                    errorIcono.SetError(this.txtbNroTelefono, "Ingrese un valor");
                    errorIcono.SetError(this.cbCargo, "Ingrese un valor");
                    errorIcono.SetError(this.txtbUsuario, "Ingrese un valor");
                    errorIcono.SetError(this.txtbPasswrd, "Ingrese un valor");

                }
                else
                {
                    int idtipodoc = Int32.Parse(this.cbTipoDocumento.SelectedValue.ToString());
                    int idtipocargo = Int32.Parse(this.cbCargo.SelectedValue.ToString());
                    Rpta = N_Usuarios.Ingresar_Usuario(idtipodoc, this.txtbNroDocumento.Text, this.txtbNroTelefono.Text, idtipocargo, this.txbDireccion.Text, this.txtbEmail.Text, this.txtbUsuario.Text, this.txtbPasswrd.Text, this.txtbNombre.Text, this.txtbApellidos.Text);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void sjv_frmGestionar_Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSource_tblCargo.tblcargo' table. You can move, or remove it, as needed.
            this.tblcargoTableAdapter.Fill(this.dataSource_tblCargo.tblcargo);
            // TODO: This line of code loads data into the 'dataSource_tblTipoDocumento.tbltipodocumento' table. You can move, or remove it, as needed.
            this.tbltipodocumentoTableAdapter.Fill(this.dataSource_tblTipoDocumento.tbltipodocumento);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text == string.Empty || this.txtbApellidos.Text == string.Empty || this.txtbEmail.Text == string.Empty || this.txbDireccion.Text == string.Empty || this.cbTipoDocumento.Text == string.Empty || this.txtbNroDocumento.Text == string.Empty || this.txtbNroTelefono.Text == string.Empty || this.cbCargo.Text == string.Empty || this.txtbUsuario.Text == string.Empty || this.txtbPasswrd.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(this.txtbNombre, "Ingrese un valor");
                    errorIcono.SetError(this.txtbApellidos, "Ingrese un valor");
                    errorIcono.SetError(this.txtbEmail, "Ingrese un valor");
                    errorIcono.SetError(this.txbDireccion, "Ingrese un valor");
                    errorIcono.SetError(this.cbTipoDocumento, "Ingrese un valor");
                    errorIcono.SetError(this.txtbNroDocumento, "Ingrese un valor");
                    errorIcono.SetError(this.txtbNroTelefono, "Ingrese un valor");
                    errorIcono.SetError(this.cbCargo, "Ingrese un valor");
                    errorIcono.SetError(this.txtbUsuario, "Ingrese un valor");
                    errorIcono.SetError(this.txtbPasswrd, "Ingrese un valor");

                }
                else
                {
                    int idtipodoc = Int32.Parse(this.cbTipoDocumento.SelectedValue.ToString());
                    int idtipocargo = Int32.Parse(this.cbCargo.SelectedValue.ToString());
                    int idusuario = Int32.Parse(this.lblIDUsuario.Text);
                    Rpta = N_Usuarios.Modificar_Usuario(idusuario,idtipodoc, this.txtbNroDocumento.Text, this.txtbNroTelefono.Text, idtipocargo, this.txbDireccion.Text, this.txtbEmail.Text, this.txtbUsuario.Text, this.txtbPasswrd.Text, this.txtbNombre.Text, this.txtbApellidos.Text);
                }
                if (Rpta.Equals("OK"))
                {
                    this.MensajeOK("Se modificó de forma correcta el registro");
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
