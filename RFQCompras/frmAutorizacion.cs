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
        string emailEmpleado, emailcomprador, email, emailgerente,correo;
        DataTable dt = new DataTable();
        private BindingSource bindingSource1 = new BindingSource();
        

        DataTable permisos = new DataTable();

        public frmAutorizacion(string Usuario)
        {
            InitializeComponent();
            _usuario = Usuario;
            txtemailGerentealterno.Visible = false;
            txtGerentealterno.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            dt = Proc.ObtenerConfiguraciones(3);
            Ruta = dt.Rows[0]["Valor1"].ToString();
            RutaCot = dt.Rows[0]["Valor1"].ToString();
            
            permisos = Proc.ValidarUsuarios(_usuario); 

            validacion = int.Parse(permisos.Rows[0]["permiso"].ToString().Trim());
            usuario = int.Parse(permisos.Rows[0]["idusuario"].ToString().Trim());
            email = permisos.Rows[0]["email"].ToString().Trim();
            userName = permisos.Rows[0]["nombreusuario"].ToString().Trim();
            List <Listas.Encabezado> Lista = new List<Listas.Encabezado>();
            Lista = ListaMenuG(usuario, dtpFecha.Value);


            Llenarlist(Lista);
        }
        public bool ValidaRFq(string rfq)
        {
            if(string.IsNullOrWhiteSpace(rfq) || string.IsNullOrEmpty(rfq))
            {
                MessageBox.Show("Debes tener seleccionado un rfq", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
                return false;

            }
            return true;
        }

        
        private void btnAutoriza_Click(object sender, EventArgs e)
        {
            int estatus=0,resutado = 0, tipo=0, correotipo=0,tipoau=0;

            if (ValidaRFq(txtIdRFQ.Text) == true)
            {

                if (int.Parse(txtGerentealternoCla.Text) != 0 && txtEstatus.Text == "Por Autorizar")
                {
                    if (int.Parse(txtGerentealternoCla.Text) == usuario)
                    {
                        estatus = 1;
                        tipo = 3;
                        tipoau = 1;
                    }
                    else
                    { 
                        estatus = 13;
                        tipo = 2;
                        tipoau = 2;

                    }
                }
                else
                {
                   tipo = 1; 
                   estatus = 1;
                    tipoau = 1;

                }

                resultado = Proc.CambiarEstatus(estatus, int.Parse(txtIdRFQ.Text), txtObservaciones.Text,usuario, tipoau);

                if (resultado == 1)
                {
                    switch (tipo)
                    {
                        case 1:
                            correo = emailcomprador+", "+ email;
                            correotipo = 5;
                            break;
                    }

                    switch (tipo)
                    {
                        case 2:
                            correo = txtemailGerentealterno.Text + ", " + emailgerente;
                            correotipo = 6;
                            break;
                    }
                    switch (tipo)
                    {
                        case 3:
                            correo = email + ", " + emailgerente;
                            correotipo = 5;
                            break;
                    }

                   
                    Proc.enviocorreo(correotipo, "", emailEmpleado, correo, txtdescription.Text, txtObservaciones.Text,"");
                }

            }    
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            
            if (emailgerente != email)
            {
                correo = emailgerente+", "+email;

            }
            else
            {
                correo = email;
            }

            if (ValidaRFq(txtIdRFQ.Text) == true)
            {
                correo = "magana.g@mazdalogi.mx"; 
                emailEmpleado= "magana.g@mazdalogi.mx";

                Proc.CambiarEstatus(14, int.Parse(txtIdRFQ.Text), txtObservaciones.Text,usuario,0);
                Proc.enviocorreo(7, "", emailEmpleado, correo, txtdescription.Text, txtObservaciones.Text,"") ;
            }
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
            DataGridViewImageColumn Imagen = new DataGridViewImageColumn();

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
            this.txtGerentealterno.Text = Details[0].GerenteITSQE;
            this.txtemailGerentealterno.Text = Details[0].EmailGerenteITSQE;
            this.txtGerentealternoCla.Text = Details[0].ClaGerenteITSQE.ToString();
            this.txtProvSugerido.Text = Details[0].ProvSugerido;
            this.txtsubCategoria.Text = Details[0].SubCategoria;
            emailcomprador = Details[0].emailcomprador;
            emailEmpleado = Details[0].emailEmpleado;
            emailgerente = Details[0].emailGerente;

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
                if (Details[0].ClaGerenteITSQE != usuario)
                {
                    txtemailGerentealterno.Visible = true;
                    txtGerentealterno.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                }
                else
                {
                    txtemailGerentealterno.Visible = false;
                    txtGerentealterno.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                }
            }

            dtgProductosRFQ.DataSource = null;
            

            DT = Proc.llenarGrid(Details[0].IdRfq);

            dtgProductosRFQ.AutoGenerateColumns = false;
            dtgProductosRFQ.AllowUserToAddRows = false;
            dtgProductosRFQ.ColumnCount = 8;

            Imagen.Name = "Imagen";
            Imagen.DataPropertyName = "Imagen";
            dtgProductosRFQ.Columns.Add(Imagen);
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dtgProductosRFQ.Columns[0].HeaderText = "ID";
            dtgProductosRFQ.Columns[0].DataPropertyName = "IDRFQ";
            dtgProductosRFQ.Columns[1].HeaderText = "Descripción";
            dtgProductosRFQ.Columns[1].DataPropertyName = "Descripcion";
            dtgProductosRFQ.Columns[2].HeaderText = "Documento";
            dtgProductosRFQ.Columns[2].DataPropertyName = "NombreDocumento";
            dtgProductosRFQ.Columns[3].HeaderText = "Extension";
            dtgProductosRFQ.Columns[3].DataPropertyName = "ExtensionDocumento";
            dtgProductosRFQ.Columns[4].HeaderText = "Cantidad";
            dtgProductosRFQ.Columns[4].DataPropertyName = "Cantidad";
            dtgProductosRFQ.Columns[5].HeaderText = "Unidad";
            dtgProductosRFQ.Columns[5].DataPropertyName = "Unidad";
            dtgProductosRFQ.Columns[6].HeaderText = "Marca";
            dtgProductosRFQ.Columns[6].DataPropertyName = "Marca";
            dtgProductosRFQ.Columns[7].HeaderText = "Modelo / Numero Serie";
            dtgProductosRFQ.Columns[7].DataPropertyName = "NumeroSerie";




            dtgProductosRFQ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProductosRFQ.Columns[0].Visible = false;
            dtgProductosRFQ.Columns[2].Visible = false;
            dtgProductosRFQ.Columns[3].Visible = false;
            
            
            bindingSource1.DataSource = DT;
            dtgProductosRFQ.DataSource = bindingSource1;

            dtgProductosRFQ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProductosRFQ.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgProductosRFQ.AllowUserToResizeRows = false;

            dtgProductosRFQ.RowHeadersVisible = false;
            foreach (DataGridViewRow row in dtgProductosRFQ.Rows)
            {
                row.Height = 100;

            }


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
                    frmAutorizacion.listaDetalles.Add(new Listas.Detalles { IdRfq = Lector.GetInt32(0), Compradort = Lector.GetString(4), EstatusT = Lector.GetString(6), Desripcion = Lector.GetString(1), Solicitante = Lector.GetString(2), FechaSolicitud = Lector.GetDateTime(7),SubCategoria = Lector.GetString(8) , Observaciones = Lector.GetString(9), ProvSugerido = Lector.GetString(10),GerenteITSQE=Lector.GetString(11),EmailGerenteITSQE=Lector.GetString(12),ClaGerenteITSQE=Lector.GetInt32(13),emailEmpleado=Lector.GetString(3),emailcomprador=Lector.GetString(5) });
                }

                Lector.Close();
            }

            return listaDetalles;
        }
    }
}
