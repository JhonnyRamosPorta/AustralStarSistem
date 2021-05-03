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
    public partial class sjv_frmGestionar_TipoDocumento : Form
    {
        public sjv_frmGestionar_TipoDocumento()
        {
            InitializeComponent();
            if (txtbNombre.Text == string.Empty)
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
            this.txbDescripcion.Text = string.Empty;
            
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text==string.Empty||this.txbDescripcion.Text==string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(this.txtbNombre, "Ingrese un valor");
                }
                else
                {
                    Rpta = N_TipoDocumento.Ingresar_Tipo_Documento(this.txtbNombre.Text, this.txbDescripcion.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text == string.Empty || this.txbDescripcion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(this.txtbNombre, "Ingrese un valor");
                }
                else
                {
                    int id = Int32.Parse(this.lblIDTipoDoc.Text.ToString());
                    Rpta = N_TipoDocumento.Modificar_Tipo_Documento(id,this.txtbNombre.Text, this.txbDescripcion.Text);
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
    }
}
