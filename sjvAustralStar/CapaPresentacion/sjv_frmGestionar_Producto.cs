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
    public partial class sjv_frmGestionar_Producto : Form
    {
        public sjv_frmGestionar_Producto()
        {
            InitializeComponent();
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
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
            this.txtbDescripcion.Text = string.Empty;
            this.cbCategoria.Text = string.Empty;
            this.txtbPrecio.Text = string.Empty;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text == string.Empty || this.txtbDescripcion.Text == string.Empty || this.txtbPrecio.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(this.txtbNombre, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbDescripcion, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbPrecio, "Ingrese un valor");
                    

                }
                else
                {
                    decimal precio = Decimal.Parse(txtbPrecio.Text.ToString());
                    string categoria = this.cbCategoria.SelectedValue.ToString();
                    Rpta = N_Producto.Ingresar_Producto(this.txtbNombre.Text, this.txtbDescripcion.Text, categoria, precio);
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

        private void sjv_frmGestionar_Producto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.tblcategoria' table. You can move, or remove it, as needed.
            this.tblcategoriaTableAdapter.Fill(this.dataSet.tblcategoria);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtbNombre.Text == string.Empty || this.txtbDescripcion.Text == string.Empty || this.txtbPrecio.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(this.txtbNombre, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbDescripcion, "Ingrese un valor");
                    errorProvider1.SetError(this.txtbPrecio, "Ingrese un valor");


                }
                else
                {
                    decimal precio = Decimal.Parse(txtbPrecio.Text.ToString());
                    string categoria = this.cbCategoria.SelectedValue.ToString();
                    Rpta = N_Producto.Modificar_Producto(this.txtbIDProdcuto.Text,this.txtbNombre.Text, this.txtbDescripcion.Text, categoria, precio);
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
