using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFQCompras
{
    public partial class frmDetalle : Form
    {
        public int resultado = 1, validacion, idrfq;
        public static string ConnectionString = ConfigurationManager.AppSettings["ConexionDB"];
        static List<Listas.Encabezado> lista;
        static List<Listas.Detalles> listaDetalles;
        public static int Dato;
        
        DataGridViewImageColumn Imagen = new DataGridViewImageColumn();
        DataTable dt = new DataTable();

        DataTable permisos = new DataTable();
        public frmDetalle(int idRFQ)
        {
            InitializeComponent();
            idrfq = idRFQ;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            rfq_click(idrfq);
        }

        private static List<Listas.Detalles> Buscardetalle(int id)
        {
            listaDetalles = new List<Listas.Detalles>();
            DataTable dt = new DataTable();
            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.RfqSelDetalleAuto", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idRfq", id);

                SqlDataReader Lector = cmd.ExecuteReader();


                while (Lector.Read())
                {
                    frmDetalle.listaDetalles.Add(new Listas.Detalles { IdRfq = Lector.GetInt32(0), Compradort = Lector.GetString(4), EstatusT = Lector.GetString(6), Desripcion = Lector.GetString(1), Solicitante = Lector.GetString(2), FechaSolicitud = Lector.GetDateTime(7), SubCategoria = Lector.GetString(8), Observaciones = Lector.GetString(9), ProvSugerido = Lector.GetString(10), GerenteITSQE = Lector.GetString(11), EmailGerenteITSQE = Lector.GetString(12), ClaGerenteITSQE = Lector.GetInt32(13), emailEmpleado = Lector.GetString(3), emailcomprador = Lector.GetString(5) });
                }

                Lector.Close();
            }

            return listaDetalles;
        }
        public void rfq_click(int id)
        {
            int tipo = -1;
            DataTable DT = new DataTable();
            BindingSource bindingSource1 = new BindingSource();

            List<Listas.Detalles> Details = new List<Listas.Detalles>();

            Details = Buscardetalle(id);

            if (Details[0].Tipo == 0)
            {
                tipo = -1;
            }
            else
            {
                tipo = Details[0].Tipo;
            }

            this.txtIdRFQ.Text = Details[0].IdRfq.ToString().Trim();
            this.txtsolicitante.Text = Details[0].Solicitante.ToString().Trim();
            this.txtComprador.Text = Details[0].Compradort.ToString().Trim();
            this.txtEstatus.Text = Details[0].EstatusT;
            this.txtdescription.Text = Details[0].Desripcion;
            this.txtObservaciones.Text = Details[0].Observaciones;
            this.dtFechasolicitan.Value = Details[0].FechaSolicitud;
            this.txtProvSugerido.Text = Details[0].ProvSugerido;
            this.txtsubCategoria.Text = Details[0].SubCategoria;
           

            

            DT = Proc.llenarGrid(Details[0].IdRfq);


            dtgDetails.AutoGenerateColumns =false;
            dtgDetails.AllowUserToAddRows = false;
            dtgDetails.ColumnCount = 8;

            Imagen.Name = "Imagen";
            Imagen.DataPropertyName = "Imagen";

            dtgDetails.Columns.Add(Imagen);
            Imagen.HeaderText = "Imagen";

            Imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dtgDetails.Columns[0].HeaderText = "ID";
            dtgDetails.Columns[0].DataPropertyName = "IDRFQ";
            dtgDetails.Columns[1].HeaderText = "Descripción";
            dtgDetails.Columns[1].DataPropertyName = "Descripcion";
            dtgDetails.Columns[2].HeaderText = "Documento";
            dtgDetails.Columns[2].DataPropertyName = "NombreDocumento";
            dtgDetails.Columns[3].HeaderText = "Extension";
            dtgDetails.Columns[3].DataPropertyName = "ExtensionDocumento";
            dtgDetails.Columns[4].HeaderText = "Cantidad";
            dtgDetails.Columns[4].DataPropertyName = "Cantidad";
            dtgDetails.Columns[5].HeaderText = "Unidad";
            dtgDetails.Columns[5].DataPropertyName = "Unidad";
            dtgDetails.Columns[6].HeaderText = "Marca";
            dtgDetails.Columns[6].DataPropertyName = "Marca";
            dtgDetails.Columns[7].HeaderText = "Modelo / Numero Serie";
            dtgDetails.Columns[7].DataPropertyName = "NumeroSerie";
            



            dtgDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDetails.Columns[0].Visible = false;
            dtgDetails.Columns[2].Visible = false;
            dtgDetails.Columns[3].Visible = false;
            bindingSource1.DataSource = DT;
            dtgDetails.DataSource = bindingSource1;
           




            dtgDetails.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dtgDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgDetails.AllowUserToResizeRows = false;

            dtgDetails.RowHeadersVisible = false;
           foreach (DataGridViewRow row in dtgDetails.Rows)
            {
                row.Height = 150;
      
            }
           
          
            
        }
    }
}
