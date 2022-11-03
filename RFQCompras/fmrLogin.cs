using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Data.SqlClient;
namespace RFQCompras
{
    public partial class fmrLogin : Form
    {

        string Usuario, NombreCompleto;
        int Nomina, Permiso=0;
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AutenticatheUser(txtUsuario.Text, txtPassword.Text))
            {

                
                frmInicio frm = new frmInicio(txtUsuario.Text);
                this.Hide();
                frm.ShowDialog();
                this.Close();


            }
        }
        string co = string.Empty;
        private bool AutenticatheUser(String userName, String password)
        {
            bool ret = false;
            string NombreCompleto, NTusername;

            try
            {
                DirectoryEntry de = new DirectoryEntry(GetCurrentDomainPath(), userName, password);
                DirectorySearcher dsearch = new DirectorySearcher(de);
                dsearch.Filter = "sAMAccountName=" + userName + "";
                SearchResult results = null;

                results = dsearch.FindOne();

                NombreCompleto = results.GetDirectoryEntry().Properties["DisplayName"].Value.ToString();
                NTusername = results.GetDirectoryEntry().Properties["sAMAccountName"].Value.ToString();
                co = results.GetDirectoryEntry().Properties["mail"].Value.ToString();//correo
                GetNTuser(txtUsuario.Text);

                if (Permiso!=0)
                {
                  ret = true;

                }
                else
                {
                    MessageBox.Show("La información proporcionada en correcta,\n pero su usuario no tiene permiso para utilizar el sistema.\nFavor de contactar al administrador del Sistema.");
                }
            }
            catch (Exception ex)
            {
                ret = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;

        }
        private string GetCurrentDomainPath()
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://RootDSE");
            //DAP://na.miempresa.com
            return "LDAP://" + de.Properties["defaultNamingContext"][0].ToString();
        }
         
        //private void txtPassword_Enter(object sender, EventArgs e)
        //{
        //    btnLogin.PerformClick();
        //}

        bool status = false;
        public void GetNTuser(string NTuserAD)
        {
            DataTable dt = new DataTable();
            dt = Proc.ValidarUsuarios(NTuserAD);
            Usuario = dt.Rows[0]["Usuario"].ToString().Trim();
            NombreCompleto = dt.Rows[0]["NombreUsuario"].ToString().Trim();
            Nomina = int.Parse(dt.Rows[0]["idUsuario"].ToString().Trim());

            if(string.IsNullOrEmpty(dt.Rows[0]["Permiso"].ToString().Trim())==true)
            {
                Permiso = 0;
            }
            else
            {
                Permiso = int.Parse(dt.Rows[0]["Permiso"].ToString().Trim());
            }
            


        }

    
    }
}
