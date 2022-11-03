using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFQCompras
{
    public partial class frmInicio : Form
    {
        string _usuario;
        int _permiso,_gerentecompras,Usuario;
        public frmInicio(string usuario)
        {
            DataTable dt = new DataTable();
            DataTable dtc = new DataTable();
            InitializeComponent();
            _usuario = usuario;

            dtc = Proc.ObtenerConfiguraciones(4);
            _gerentecompras = int.Parse(dtc.Rows[0]["valor1"].ToString().Trim());
            dt = Proc.ValidarUsuarios(_usuario);
            _permiso = int.Parse(dt.Rows[0]["Permiso"].ToString());
            Usuario = int.Parse(dt.Rows[0]["idusuario"].ToString());

            if (_permiso ==3)
            { 
                autorizaciónToolStripMenuItem.Visible = false;
                catalogosToolStripMenuItem.Visible = false;
            }
            else if(_permiso == 1)
            { 
                autorizaciónToolStripMenuItem.Visible = false; 
            }
            else if ((_permiso == 4 || _permiso==5) && Usuario != _gerentecompras)
            {
                capturaToolStripMenuItem.Visible = false;
               catalogosToolStripMenuItem.Visible = false;
            }
            else
            { 
                capturaToolStripMenuItem.Visible=false;
                autorizaciónToolStripMenuItem.Visible = false;

            }
        }

        private void autorizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutorizacion frm = new frmAutorizacion(_usuario);
            frm.ShowDialog();

        }

        private void capturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaptura frm = new frmCaptura(_usuario);
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal(_usuario);
            frm.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhistorial frm = new frmhistorial(Usuario,DateTime.Now,_usuario);
            frm.ShowDialog();
        }
        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogos fr = new frmCatalogos(1, _usuario);
            fr.Text = "Catálogo de áreas";
            fr.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogos fr = new frmCatalogos(2, _usuario);
            fr.Text = "Catálogo de categorias";
            fr.Show();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogos fr = new frmCatalogos(5, _usuario);
            fr.Text = "Catálogo de subcategoria";
            fr.Show();
        }

        private void unidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogos fr = new frmCatalogos(4, _usuario);
            fr.Text = "Catálogo de unidad";
            fr.Show();
        }

        private void estatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogos fr = new frmCatalogos(3, _usuario);
            fr.Text = "Catálogo de estatus";
            fr.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fr = new frmUsuario(_usuario);
            fr.Text = "Catálogo de usuarios";
            fr.Show();
        }
    }
}
