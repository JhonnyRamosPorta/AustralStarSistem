using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace CapaPresentacion
{
    public partial class sjv_frmLogIn : Form
    {
        public static string Cn1 = ConfigurationManager.ConnectionStrings["dbgrifoConnectionString"].ToString();
        string CapaPresentacionLog1 = ConfigurationManager.AppSettings["CapaPresentacionLog"].ToString();
        public sjv_frmLogIn()
        {
            InitializeComponent();
            txtbPasswrd.PasswordChar = '*';
            txtbPasswrd.MaxLength = 16;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            StreamWriter WriteReportFile3 = File.AppendText(CapaPresentacionLog1);
            WriteReportFile3.WriteLine(DateTime.Now + "      :   Se ingreso los siguientes valores == " + Cn1);
            WriteReportFile3.Close();


            DataTable Datos = CapaNegocio.N_Usuarios.Login(this.txtbUsuario.Text, this.txtbPasswrd.Text);

            StreamWriter WriteReportFile = File.AppendText(CapaPresentacionLog1);
            WriteReportFile.WriteLine(DateTime.Now + "      :   Linea 24 -- pasamos  DataTable Datos = CapaNegocio.NUsuario.Login(this.TxtUsuario.Text,this.TxtPassword.Text) U:" + this.txtbUsuario.Text + " P:" + this.txtbPasswrd.Text);
            WriteReportFile.Close();


            try
            {
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("NO Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    StreamWriter WriteReportFile1 = File.AppendText(CapaPresentacionLog1);
                    WriteReportFile1.WriteLine(DateTime.Now + "     :   NO Tiene Acceso al Sistema", "Sistema de Ventas");
                    WriteReportFile1.Close();
                }
                else
                {
                    for (int i = 0; i < Datos.Rows.Count; i++)
                    {
                        if (String.Compare(Datos.Rows[i][2].ToString(), this.txtbPasswrd.Text.ToString()) == 0)
                        {
                            int idusuario = Int32.Parse(Datos.Rows[i][0].ToString());
                            int idcargo = Int32.Parse(Datos.Rows[i][3].ToString());
                            string usuario = Datos.Rows[i][1].ToString();
                            string nombre = Datos.Rows[i][4].ToString();
                            string apellidos = Datos.Rows[i][5].ToString();

                            sjv_frmPrincipal frm = new sjv_frmPrincipal();
                            frm.tSLUsuario.Text = usuario;
                            frm.tSLUsuarioApellidos.Text = apellidos;
                            frm.tSLUsuarioNombres.Text = nombre;
                            frm.tSLidusuario.Text = Datos.Rows[i][0].ToString();
                            frm.tSLidcargo.Text = Datos.Rows[i][3].ToString();

                            StreamWriter WriteReportFile1 = File.AppendText(CapaPresentacionLog1);
                            WriteReportFile1.WriteLine(DateTime.Now + "     :   Se realizar la conexion de manera exitosa ");
                            WriteReportFile1.Close();

                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("NO Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex12)
            {
                StreamWriter WriteReportFile2 = File.AppendText(CapaPresentacionLog1);
                WriteReportFile2.WriteLine(DateTime.Now + "     --      En el Try de validación de entrada , retornando valores de us y pas   " + ex12.Message);
                WriteReportFile2.Close();

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
