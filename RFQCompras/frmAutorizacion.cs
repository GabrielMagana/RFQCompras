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
    public partial class frmAutorizacion : Form
    {
        public int resultado = 1, validacion, usuario;
        public static string ConnectionString = ConfigurationManager.AppSettings["ConexionDB"];
        public static string Ruta;
        public static string RutaCot;
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name, _usuario;
        string Pc = Environment.MachineName;
        static List<Listas.Encabezado> lista;
        static List<Listas.Detalles> listaDetalles;
        public static int Dato;
        string lnktabla, lnkrfq, email;
        DataTable dt = new DataTable();

        DataTable permisos = new DataTable();

        public frmAutorizacion(string Usuario)
        {
            InitializeComponent();
            _usuario = Usuario;

            dt = Proc.ObtenerConfiguraciones(3);
            Ruta = dt.Rows[0]["Valor1"].ToString();
            RutaCot = dt.Rows[0]["Valor1"].ToString();

            permisos = Proc.ValidarG(_usuario); 

            validacion = int.Parse(permisos.Rows[0]["permiso"].ToString().Trim());
            usuario = int.Parse(permisos.Rows[0]["idusuario"].ToString().Trim());


            List<Listas.Encabezado> Lista = new List<Listas.Encabezado>();
            Lista = ListaMenuG(usuario, dtpFecha.Value);


            Llenarlist(Lista);
        }
        private void btnAutoriza_Click(object sender, EventArgs e)
        {

        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {

        }

        private static List<Listas.Encabezado> ListaMenuG(int usuario, DateTime fecha)
        {
            lista = new List<Listas.Encabezado>();


            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.RfqListadoSelg", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Autorizador", usuario);

                SqlDataReader Lector = cmd.ExecuteReader();

                while (Lector.Read())
                {
                    frmAutorizacion.lista.Add(new Listas.Encabezado { IdRfq = Lector.GetInt32(0), Desripcion = Lector.GetString(1), Solicitante = Lector.GetString(2), Estatus = Lector.GetString(3), Area = Lector.GetString(4) });
                }

                Lector.Close();

            }
            return lista;


        }
        private void Llenarlist(List<Listas.Encabezado> Listado)
        {
            int contador;
            this.flowLayoutPanel1.Controls.Clear();
            contador = Listado.Count;
            ucListado[] listadorfq = new ucListado[contador];

            for (int i = 0; i < listadorfq.Length; i++)
            {
                listadorfq[i] = new ucListado();
                listadorfq[i].Area = Listado[i].Area.Trim();
                listadorfq[i].Descripcion = Listado[i].Desripcion.Trim();
                listadorfq[i].Solicitante = Listado[i].Solicitante.Trim();
                listadorfq[i].Estatus = Listado[i].Estatus.Trim();
                listadorfq[i].IDRFQ = Listado[i].IdRfq;

                if (this.flowLayoutPanel1.Controls.Count < 0)
                { this.flowLayoutPanel1.Controls.Clear(); }
                else
                {

                    this.flowLayoutPanel1.Controls.Add(listadorfq[i]);
                    listadorfq[i].DoubleClick += new EventHandler(rfq_click);
                }
            }
        }

        public void rfq_click(object sender, EventArgs e)
        {
            int tipo = -1;
            DataTable DT = new DataTable();


            ucListado obj = (ucListado)sender;

            Dato = obj.IDRFQ;



            groupBox2.Visible = true;

            List<Listas.Detalles> Details = new List<Listas.Detalles>();

            Details = BuscarAutorizacion(Dato);

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
            this.txtProvSugerido.Text = Details[0].Compradort;
            this.txtGerentealterno.Text = Details[0].GerenteITSQE;
            this.txtemailGerentealterno.Text = Details[0].EmailGerenteITSQE;
            this.txtGerentealternoCla.Text = Details[0].ClaGerenteITSQE.ToString();
            this.txtProvSugerido.Text = Details[0].ProvSugerido;
            this.txtsubCategoria.Text = Details[0].SubCategoria;

            if (Details[0].ClaGerenteITSQE == 0)
            {
                txtemailGerentealterno.Text = "";
                txtGerentealterno.Text = "";
                txtemailGerentealterno.Visible =false;
                txtGerentealterno.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }  
            else
            {
                txtemailGerentealterno.Visible = true;
                txtGerentealterno.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }

            DT = Proc.llenarGrid(Details[0].IdRfq);

            dtgProductosRFQ.DataSource = DT;


        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            List<Listas.Encabezado> Lista = new List<Listas.Encabezado>();
            Lista = ListaMenuG(usuario, dtpFecha.Value);
            Llenarlist(Lista);
        }

        private static List<Listas.Detalles> BuscarAutorizacion(int id)
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
                    frmAutorizacion.listaDetalles.Add(new Listas.Detalles { IdRfq = Lector.GetInt32(0), Compradort = Lector.GetString(3), EstatusT = Lector.GetString(4), Desripcion = Lector.GetString(1), Solicitante = Lector.GetString(2), FechaSolicitud = Lector.GetDateTime(5),SubCategoria = Lector.GetString(6) , Observaciones = Lector.GetString(7), ProvSugerido = Lector.GetString(8),GerenteITSQE=Lector.GetString(9),EmailGerenteITSQE=Lector.GetString(10),ClaGerenteITSQE=Lector.GetInt32(11) });
                }

                Lector.Close();
            }

            return listaDetalles;
        }
    }
}
