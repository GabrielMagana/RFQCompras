using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFQCompras;

namespace RFQCompras
{
    public partial class frmhistorial : Form
    {
        int _comprador; DateTime _fecha;
        public int  validacion, usuario;
        string _usuario;
        public static string ConnectionString = ConfigurationManager.AppSettings["ConexionDB"];
        DataTable permisos = new DataTable();
        public frmhistorial(int comprador, DateTime fecha,string Usuario)
        {
            int opcion; 
            InitializeComponent();
            _comprador = comprador;
            _fecha = fecha;
            _usuario = Usuario;

            permisos = Proc.ValidarUsuarios(_usuario);

            validacion = int.Parse(permisos.Rows[0]["permiso"].ToString().Trim());
            usuario = int.Parse(permisos.Rows[0]["idusuario"].ToString().Trim());

            if (validacion == 2 || validacion == 1 || validacion == 4)
            { opcion = 3; }
            else { opcion = 4; }
            
            Proc.combos(cmbComprador, opcion);

            cmbComprador.SelectedValue = comprador;
            _comprador = usuario;
            cmbComprador.SelectedValue = usuario;
            if (validacion != 1)
            { cmbComprador.Enabled = false;
            }
        }

        private void frmhistorial_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.RfqHistoricoSel", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecha", _fecha);
                cmd.Parameters.AddWithValue("@comprador", _comprador);

               

                SqlDataAdapter dta = new SqlDataAdapter(cmd);

                dta.Fill(dt);
               
                dgvHistorico.DataSource = dt;
                dgvHistorico.RowHeadersVisible = false;
                dgvHistorico.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);

                formateargrid();



            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int comprador;
            comprador = this.cmbComprador.SelectedIndex;
            DataTable dt = new DataTable();

            if (comprador != -1)
            {
                comprador = int.Parse(this.cmbComprador.SelectedValue.ToString());
            }

            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.RfqHistoricoSel", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecha", dtfecha.Value);
                cmd.Parameters.AddWithValue("@comprador", comprador);

                SqlDataAdapter dta = new SqlDataAdapter(cmd);

                dta.Fill(dt);




                dgvHistorico.DataSource = dt;
                dgvHistorico.RowHeadersVisible = false;
                dgvHistorico.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);

                formateargrid();
            }

          

        }

        private void formateargrid()
        {
            dgvHistorico.Columns[0].HeaderText = "ID";
            dgvHistorico.Columns[1].HeaderText = "Fecha Solicitud";
            dgvHistorico.Columns[2].HeaderText = "Descripción";
            dgvHistorico.Columns[3].HeaderText = "Área";
            dgvHistorico.Columns[4].HeaderText = "Solicitante";
            dgvHistorico.Columns[5].HeaderText = "Comprador";
            dgvHistorico.Columns[6].HeaderText = "Email Comprador";
            dgvHistorico.Columns[7].HeaderText = "Estatus";
            dgvHistorico.Columns[8].HeaderText = "Categoria";
            dgvHistorico.Columns[9].HeaderText = "Fecha Cotización";
            dgvHistorico.Columns[10].HeaderText = "Dias Totales";
            dgvHistorico.Columns[11].HeaderText = "Fecha Tabla Comparativa";
            dgvHistorico.Columns[12].HeaderText = "Dias Tabla Comparativa";
            dgvHistorico.Columns[13].HeaderText = "Monto";
            dgvHistorico.Columns[14].HeaderText = "Observaciones";
            dgvHistorico.Columns[15].HeaderText = "RFQ";
            dgvHistorico.Columns[16].HeaderText = "Tabla Comparativa";


            //foreach 
            //DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
            foreach (DataGridViewRow row in dgvHistorico.Rows)
            {
                for (int i = 0; i < dgvHistorico.Columns.Count; i++)
                {
                    if (i == 15 || i == 16)
                    {
                        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                        linkCell.Value = row.Cells[i].Value;
                        row.Cells[i] = linkCell;
                    }
                }
            }

            if (validacion == 3)
            {
                dgvHistorico.Columns[14].Visible = false;
                dgvHistorico.Columns[15].Visible = false;
                dgvHistorico.Columns[16].Visible = false;

            }
        }
        private void dgvHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ruta="";
            var senderGrid = (DataGridView)sender;


            if ((e.ColumnIndex==15 || e.ColumnIndex==16) && e.RowIndex >= 0)
            {
                ruta= senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); 
                Process proceso = new Process();
                proceso.StartInfo.FileName = ruta;
                proceso.Start();
            }
        }
    }
}
