using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class sjv_frmPrincipal : Form
    {
        public static int idUsuario;
        public static int idCargo;

        public sjv_frmPrincipal()
        {
            InitializeComponent();
        }

        
        private void sjv_frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        //USUARIOS
        //Usuarios->GestionUsuarios
        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sjv_frmListar_Usuarios frm_usmngm = new sjv_frmListar_Usuarios();
            frm_usmngm.MdiParent = this;
            frm_usmngm.Show();
        }
        //Usuarios->GestionCargos
        private void gestionDeCategoríasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sjv_frmListar_CargoUsuario frm_acmngm = new sjv_frmListar_CargoUsuario();
            frm_acmngm.MdiParent = this;
            frm_acmngm.Show();
        }
        //Usuarios->GestionDocumentos
        private void gestionDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sjv_frmListar_TipoDocumento frmListar_TipoDocumento = new sjv_frmListar_TipoDocumento();
            frmListar_TipoDocumento.MdiParent = this;
            frmListar_TipoDocumento.Show();
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sjv_frmListar_Producto frm = new sjv_frmListar_Producto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gestionDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sjv_frmListar_Categoria frm = new sjv_frmListar_Categoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sjv_frmListar_Clientes sjv_Frm = new sjv_frmListar_Clientes();
            sjv_Frm.MdiParent = this;
            sjv_Frm.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sjv_frmRegistrarVenta frm = new sjv_frmRegistrarVenta();
            frm.MdiParent = this;
            frm.Show();
            
        }
    }
}
