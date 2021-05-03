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
    public partial class sjv_frmGestionar_Categoria : Form
    {
        public sjv_frmGestionar_Categoria()
        {
            InitializeComponent();
            this.txtbStatus.MaxLength = 1;
            this.txtbID.MaxLength = 3;
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
            this.txtbID.Text = string.Empty;
            this.txtbNombre.Text = string.Empty;
            this.txbDescripcion.Text = string.Empty;
            this.txtbStatus.Text = string.Empty;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text == string.Empty || this.txbDescripcion.Text == string.Empty || this.txtbID.Text == string.Empty || this.txtbStatus.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(this.txtbNombre, "Ingrese un valor");
                    errorProvider1.SetError(this.txbDescripcion, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbStatus, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbID, "Ingrese un valor");
                }
                else
                {
                    int estado = Int32.Parse(this.txtbStatus.Text.ToString());
                    Rpta = N_Producto.Ingresar_Categoria(this.txtbID.Text, this.txtbNombre.Text, this.txbDescripcion.Text,estado);
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
                if (this.txtbNombre.Text == string.Empty || this.txbDescripcion.Text == string.Empty || this.txtbID.Text == string.Empty || this.txtbStatus.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(this.txtbNombre, "Ingrese un valor");
                    errorProvider1.SetError(this.txbDescripcion, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbStatus, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbID, "Ingrese un valor");
                }
                else
                {
                    int estado = Int32.Parse(this.txtbStatus.Text.ToString());
                    Rpta = N_Producto.Modificar_Categoria(this.txtbID.Text, this.txtbNombre.Text, this.txbDescripcion.Text, estado);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
