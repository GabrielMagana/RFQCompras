using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFQCompras
{
    public partial class frmPrincipal : Form
    {
        public int resultado=1,validacion,usuario, _gerentecompras,_superv;
        public static string ConnectionString = ConfigurationManager.AppSettings["ConexionDB"];
        public static string Ruta;
        public static string RutaCot;
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,_usuario;
        string Pc = Environment.MachineName;
        static List<Listas.Encabezado> lista;
        static List<Listas.Detalles> listaDetalles;
        public static int Dato;
        string lnktabla, lnkrfq,email;
        DataTable dt= new DataTable();
        DataTable dtc = new DataTable();
        DataTable dts = new DataTable();
        DataTable permisos = new DataTable();

        static frmPrincipal _obj;


        public frmPrincipal(string Usuario)
        {
            int opcion;
            InitializeComponent();

            dt = Proc.ObtenerConfiguraciones(3);
            Ruta = dt.Rows[0]["Valor1"].ToString();
            RutaCot = dt.Rows[0]["Valor1"].ToString();

            _usuario = Usuario;
            dtc = Proc.ObtenerConfiguraciones(4);
            _gerentecompras = int.Parse(dtc.Rows[0]["valor1"].ToString().Trim());

            dts = Proc.ObtenerConfiguraciones(2);
            _superv = int.Parse(dts.Rows[0]["valor1Num"].ToString().Trim());

            permisos = Proc.ValidarUsuarios(_usuario);

            validacion = int.Parse(permisos.Rows[0]["permiso"].ToString().Trim());
            usuario = int.Parse(permisos.Rows[0]["idusuario"].ToString().Trim());

            if (validacion == 2 || validacion == 1 || validacion == 4)
            { opcion = 3; }
            else { opcion = 4; }

            Proc.combos(cmbComprador, 4, usuario);
            cmbComprador.SelectedIndex = -1;
            this.dtfecha.Value = DateTime.Now;
            Proc.combos(cmbtipo, 1, usuario);
            cmbtipo.SelectedIndex = -1;
            Proc.combos(cmbestatus, 2, usuario);
            cmbestatus.SelectedIndex = -1;
            Proc.combos(cmbcomprador2, 3, usuario);
            cmbcomprador2.SelectedIndex = -1;
            groupBox2.Visible = false;



            cmbComprador.SelectedValue = usuario;
            if (validacion == 2)
            {   
                cmbComprador.Enabled = false;
                btnUpdate.Visible = true;
                txtObservaciones.Enabled = true;
                btnUpdate.Text = "Comentarios";
            }
            else if (validacion == 3)
            { 
                    cmbComprador.Enabled = false; 
                    btnUpdate.Visible = false;
                    txtObservaciones.Enabled = false;
            }
            else if (validacion == 1 || (validacion == 4 && usuario == _gerentecompras))
            { 
                    cmbComprador.Enabled = true; 
                    btnUpdate.Visible = true;
                    txtObservaciones.Enabled = true;
                    btnUpdate.Text = "Actualizar";
            }    
            else
            { 
                    cmbComprador.Enabled = true; 
                    btnUpdate.Visible = false;
                    txtObservaciones.Enabled = false;
            }

           


        }

        private void test_Load(object sender, EventArgs e)
        {
            int comprador;
            comprador = this.cmbComprador.SelectedIndex;

            if (comprador != -1)
            { 
                comprador = int.Parse(this.cmbComprador.SelectedValue.ToString());
            }
            

                List<Listas.Encabezado> Lista = new List<Listas.Encabezado>();
                Lista = ListaMenu(comprador, this.dtfecha.Value);
               groupBox2.Visible = false;

            Llenarlist(Lista);


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
                    listadorfq[i].DoubleClick += new EventHandler(this.rfq_click);
                    }
                }
            }



            private static List<Listas.Encabezado> ListaMenu(int comprador, DateTime fecha)
            {
                lista = new List<Listas.Encabezado>();


                using (SqlConnection conn1 = new SqlConnection(ConnectionString))
                {
                    conn1.Open();
                    SqlCommand cmd = new SqlCommand("dbo.RfqListadoSel", conn1);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@comprador", comprador);

                    SqlDataReader Lector = cmd.ExecuteReader(); 

                    while (Lector.Read())
                    {
                        frmPrincipal.lista.Add(new Listas.Encabezado { IdRfq = Lector.GetInt32(0), Desripcion = Lector.GetString(1), Solicitante = Lector.GetString(2), Estatus = Lector.GetString(3), Area = Lector.GetString(4) });
                    }

                    Lector.Close();

                }
                return lista;

            
              }

        public void rfq_click(object sender, EventArgs e)
        {
            int tipo = -1;

       
           ucListado obj = (ucListado)sender;

            Dato = obj.IDRFQ; 
           


            groupBox2.Visible = true;

            List<Listas.Detalles> Details = new List<Listas.Detalles>();
            Details = busquedaint(Dato);

            if (Details[0].Tipo == 0)
            {
                tipo = -1;
            }
            else
            {
                tipo = Details[0].Tipo;
            }

            this.txtIdRFQ.Text = Details[0].IdRfq.ToString();
            this.cmbtipo.SelectedValue = tipo;
            this.cmbcomprador2.SelectedValue = Details[0].Comprador;
            this.cmbestatus.SelectedValue = Details[0].Estatus;
            this.txtdescription.Text = Details[0].Desripcion;
            this.txtMonto.Text = Details[0].Monto.ToString();
            this.txtsolicitante.Text = Details[0].Solicitante;
            this.txtObservaciones.Text = Details[0].Observaciones;
            this.txtDiasTabla.Text = Details[0].DiasTabla.ToString();
            this.txtDiasTotales.Text = Details[0].DiasTotales.ToString();
            this.dtFechasolicitan.Value = Details[0].FechaSolicitud;
            this.dtFechaTabla.Value = Details[0].FechaTabla;
            this.dtCotizacion.Value = Details[0].FechaCotizacion;
            this.email = Details[0].email;
            this.lnktabla = Details[0].lnkTabla;
            this.lnkrfq = Details[0].lnkRfq;
            this.txtProvSugerido.Text= Details[0].ProvSugerido;


            Formato();

                       
        }
        public void rfq_clickdato(object sender, EventArgs e)
        {
            int tipo = -1;

            groupBox2.Visible = true;

            List<Listas.Detalles> Details = new List<Listas.Detalles>();
            Details = busquedaint(Dato);

            if (Details[0].Tipo == 0)
            {
                tipo = -1;
            }
            else
            {
                tipo = Details[0].Tipo;
            }

            this.txtIdRFQ.Text = Details[0].IdRfq.ToString();
            this.cmbtipo.SelectedValue = tipo;
            this.cmbcomprador2.SelectedValue = Details[0].Comprador;
            this.cmbestatus.SelectedValue = Details[0].Estatus;
            this.txtdescription.Text = Details[0].Desripcion;
            this.txtsolicitante.Text = Details[0].Solicitante;
            this.txtObservaciones.Text = Details[0].Observaciones;
            this.txtDiasTabla.Text = Details[0].DiasTabla.ToString();
            this.txtDiasTotales.Text = Details[0].DiasTotales.ToString();
            this.dtFechasolicitan.Value = Details[0].FechaSolicitud;
            this.dtFechaTabla.Value = Details[0].FechaTabla;
            this.dtCotizacion.Value = Details[0].FechaCotizacion;
            this.email = Details[0].email;
            this.lnktabla = Details[0].lnkTabla;
            this.lnkrfq = Details[0].lnkRfq;

            Formato();

        }

        private void Formato()
        {

            if (validacion == 3 || ((validacion == 4 || validacion == 5) && usuario != _gerentecompras))
            {   btnUpdate.Visible=false;
                txtsolicitante.Enabled = false;
                txtdescription.Enabled = false;
                txtObservaciones.Enabled = false;
                txtMonto.Enabled=false;
                dtFechasolicitan.Enabled = false;
                txtDiasTabla.Enabled = false;
                txtDiasTotales.Enabled = false;
                cmbcomprador2.Enabled = false;
                cmbestatus.Enabled = false;
                dtFechaTabla.Enabled=false;


                switch (int.Parse(cmbestatus.GetItemText(cmbestatus.SelectedValue).ToString()))
                {
                    case 12:
                        {
                            dtCotizacion.Visible = false;
                            dtFechaTabla.Visible = false;
                            label1.Visible = false;
                            label13.Visible = false;
                            break;
                        }
                    case 13:
                        {
                            dtCotizacion.Visible = false;
                            dtFechaTabla.Visible = false;
                            label1.Visible = false;
                            label13.Visible = false;
                            break;
                        }
                    case 1:
                        {
                            dtCotizacion.Visible = false;
                            dtFechaTabla.Visible = false;
                            label1.Visible = false;
                            label13.Visible = false;
                            break;
                        }
                    case 2:
                        {
                            dtCotizacion.Visible = true;
                            dtFechaTabla.Visible = false;
                            label1.Visible = true;
                            label13.Visible = false;
                            break;
                        }
                    case 3:
                        {
                            dtCotizacion.Visible = true;
                            dtFechaTabla.Visible = true;
                            label1.Visible = true;
                            label13.Visible = true;
                            break;
                        }
                }
         
               

                
                cmbtipo.Enabled = false;
                dtfecha.Enabled = true;
                dtFechasolicitan.Enabled=false;
                txtIdRFQ.Enabled = false;
                txtIdRFQ.Visible = false;
                dtCotizacion.Enabled = false;
                lnkTabla.Visible = false;
                lnkRFQ.Visible = false;
                btnCambiaEstatus.Visible = false;
                btnCambiar.Visible = false;
                btnCancelar.Visible = false;
                txtProvSugerido.Enabled = false;
            }
            else
            {

                txtsolicitante.Enabled = false;
                txtdescription.Enabled = false;
               
                dtFechasolicitan.Enabled = false;
                txtDiasTabla.Enabled = false;
                txtDiasTotales.Enabled = false;
                cmbcomprador2.Enabled = false;
                cmbestatus.Enabled = false;
                txtIdRFQ.Enabled = false;
                txtIdRFQ.Visible = false;
                dtCotizacion.Enabled = false;
                lnkTabla.Visible = false;
                btnCambiar.Text = "Cambiar";
                txtProvSugerido.Enabled = false;


                if (cmbestatus.SelectedValue.ToString() == "1")
                {
                    cmbtipo.Enabled = Enabled;
                    btnCambiaEstatus.Text = "Cotizar";
                    btnCambiaEstatus.Visible = true;
                    btnCambiar.Visible = true;
                    btnCancelar.Visible = true;
                    dtFechaTabla.Visible = false;
                    dtCotizacion.Visible = false;
                    txtDiasTabla.Visible = false;
                    txtMonto.Visible = false;
                    label1.Visible = false;
                    label10.Visible = false;
                    label13.Visible = false;
                    label11.Visible = false;
                }
                if (cmbestatus.SelectedValue.ToString() == "1" && (usuario == _superv || usuario == _gerentecompras) )
                {
                    cmbtipo.Enabled = false;
                    txtObservaciones.Enabled = true;
                   
                }
               

                if ((cmbestatus.SelectedValue.ToString() == "1" && usuario == _superv) || (cmbestatus.SelectedValue.ToString() == "1" && usuario == _gerentecompras))
                {
                   
                    cmbcomprador2.Enabled = true;
                    txtProvSugerido.Enabled = true;
                    cmbtipo.Enabled = true;
                    txtdescription.Enabled = true;
                }
                else
                {
                    
                    cmbcomprador2.Enabled = false;
                    txtProvSugerido.Enabled = false;
                    txtdescription.Enabled = false;
                }



                if (cmbestatus.SelectedValue.ToString() == "2")
                {
                    btnCambiaEstatus.Text = "Tabla Comparativa";
                    dtFechaTabla.Visible = false;
                    dtCotizacion.Visible = true;
                    txtDiasTabla.Visible = false;
                    txtMonto.Visible = true;
                    label1.Visible = true;
                    label10.Visible = false;
                    label13.Visible = false;
                    label11.Visible = true;
                    cmbtipo.Enabled = false;
                    txtMonto.Enabled = true;
                    btnCambiaEstatus.Visible = true;
                    btnCambiar.Visible = true;
                    btnCancelar.Visible = true;
                }

                if (cmbestatus.SelectedValue.ToString() == "3")
                {
                    btnCambiaEstatus.Visible = false;
                    dtFechaTabla.Enabled = false;
                    dtFechaTabla.Visible = true;
                    txtDiasTabla.Visible = true;
                    txtMonto.Visible = true;
                    label10.Visible = true;
                    label1.Visible = true;
                    label13.Visible = true;
                    label11.Visible = true;
                    txtMonto.Enabled = false;
                    lnkTabla.Visible = true;
                    dtCotizacion.Visible = true;
                    cmbtipo.Enabled = false;
                   
                }

                if (cmbestatus.SelectedValue.ToString() == "9")
                {
                    lnkTabla.Visible = false;
                }

                if (cmbestatus.SelectedValue.ToString() != "3" && (usuario == _superv || usuario == _gerentecompras))
                {
                    btnCambiaEstatus.Visible = false;

                }


                if (cmbestatus.SelectedValue.ToString() == "3" && (usuario == _superv || usuario == _gerentecompras))
                {
                    btnCambiaEstatus.Visible = true;
                    btnCambiaEstatus.Text = "Autorizar";
                    cmbtipo.Enabled = false;
                    btnCambiar.Visible = true;
                    btnCambiar.Text = "Rechazar";
                    //btnCancelar.Visible = true;
                }




                if (cmbestatus.SelectedValue.ToString() == "9")
                {
                    btnCambiaEstatus.Visible = false;
                    btnCambiar.Visible = false;
                    btnCancelar.Visible = false;
                    txtsolicitante.Enabled = false;
                    txtdescription.Enabled = false;
                    txtDiasTabla.Enabled = false;
                    txtMonto.Enabled = false;
                    cmbcomprador2.Enabled = false;
                    cmbestatus.Enabled = false;
                    cmbtipo.Enabled = false;
                    txtIdRFQ.Enabled = false;
                    txtIdRFQ.Visible = false;
                   
                    dtFechaTabla.Enabled = false;
                    dtFechasolicitan.Enabled = false;
                }
                else if (cmbestatus.SelectedValue.ToString() == "10")
                {
                    btnCambiaEstatus.Visible = false;
                    btnCambiar.Visible = false;
                    btnCancelar.Visible = false;
                    txtsolicitante.Enabled = false;
                    txtdescription.Enabled = false;
                    txtDiasTabla.Visible = true;
                    txtDiasTabla.Enabled = false;
                    txtMonto.Enabled = false;
                    cmbcomprador2.Enabled = false;
                    cmbestatus.Enabled = false;
                    cmbtipo.Enabled = false;
                    txtIdRFQ.Enabled = false;
                    txtIdRFQ.Visible = false;
                    
                    dtCotizacion.Enabled = false;
                    dtCotizacion.Visible = true;
                    dtFechaTabla.Enabled = false;
                    dtFechaTabla.Visible = true;
                    dtFechasolicitan.Enabled = false;
                    lnkTabla.Visible = true;
                    label10.Visible = true;
                    label13.Visible = true;
                    label11.Visible = true;
                    txtMonto.Visible = true;
                    label1.Visible = true;


                }
                if ((usuario == _superv || usuario == _gerentecompras)&& cmbestatus.SelectedValue.ToString() == "11" && (decimal.Parse(txtMonto.Text) <= 5000 && decimal.Parse(txtMonto.Text) > 0))
                {
                    btnCambiaEstatus.Visible = true;
                    btnCambiaEstatus.Text = "Autorizar";
                    cmbtipo.Enabled = false;
                    btnCambiar.Visible = true;
                    btnCambiar.Text = "Rechazar";
                    //btnCancelar.Visible = true;
                }

                if (validacion == 2 && cmbestatus.SelectedValue.ToString() == "11" && (decimal.Parse(txtMonto.Text) <= 5000 && decimal.Parse(txtMonto.Text) > 0))
                { cmbtipo.Enabled = false;
                    btnCambiaEstatus.Visible = false;
                    btnCambiar.Visible = false;
                    btnCancelar.Visible = false;
                }
            }
        }

        private static List<Listas.Detalles> busquedaint(int id)
        {
            listaDetalles = new List<Listas.Detalles>();
            DataTable dt = new DataTable();
            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.RfqSelDetalles", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idRfq", id);

                SqlDataReader Lector = cmd.ExecuteReader(); 


                while (Lector.Read())
                {
                    frmPrincipal.listaDetalles.Add(new Listas.Detalles { IdRfq = Lector.GetInt32(0), Comprador = Lector.GetInt32(3), Estatus = Lector.GetInt32(4),Tipo=Lector.GetInt32(5), DiasTotales = Lector.GetInt32(8), DiasTabla = Lector.GetInt32(9), Monto = Lector.GetDecimal(10), Desripcion = Lector.GetString(1), Solicitante = Lector.GetString(2), FechaSolicitud = Lector.GetDateTime(6), FechaTabla = Lector.GetDateTime(7), Observaciones = Lector.GetString(11),FechaCotizacion = Lector.GetDateTime(12), lnkRfq=Lector.GetString(13),lnkTabla=Lector.GetString(14),email = Lector.GetString(15),ProvSugerido= Lector.GetString(16) });
                }

                Lector.Close();
            }

            return listaDetalles;
        }



        private void btnCambiaEstatus_Click(object sender, EventArgs e)
        {
            decimal valor;
            resultado = 1;
            if (cmbtipo.SelectedItem == null && cmbestatus.SelectedValue.ToString() == "1")
            {
                MessageBox.Show("Favor de seleccionar una categoria", "Warning", MessageBoxButtons.OK);
                return;
            }

            if ((string.IsNullOrEmpty(txtMonto.Text) || decimal.Parse(txtMonto.Text)==0 )&& cmbestatus.SelectedValue.ToString() == "2"   )
            {
                MessageBox.Show("Favor de capturar un monto", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (txtMonto.Text == "")
            { valor = 0; }
            else
            {
                valor = decimal.Parse(txtMonto.Text);
            }


            if (valor > 5000 && cmbestatus.SelectedValue.ToString() == "2")
            {
                resultado = 0;
                 CargarDocumento myForm = new CargarDocumento(this.txtdescription.Text, int.Parse(this.txtIdRFQ.Text), 1);
                myForm.Text = "Cargar tabla comparativa";
                myForm.AutoSize = false;
                myForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                myForm.ShowDialog();
                myForm.MaximizeBox = false;
                resultado = myForm.resultado;
            }
            else if (valor <= 5000 && cmbestatus.SelectedValue.ToString() == "2")
            {
                resultado = 0;
                CargarDocumento myForm = new CargarDocumento(this.txtdescription.Text, int.Parse(this.txtIdRFQ.Text), 2);
                myForm.Text = "Cargar cotización";
                myForm.AutoSize = false;
                myForm.ShowDialog();
                myForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                myForm.MaximizeBox = false;
                resultado = myForm.resultado;
               
            }
           






            if (this.resultado != 0)
            {
                using (SqlConnection conn1 = new SqlConnection(ConnectionString))
                {
                    conn1.Open();
                    SqlCommand cmd = new SqlCommand("dbo.CambioEstatusRfqIU", conn1);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idrfq", int.Parse(txtIdRFQ.Text));
                    cmd.Parameters.AddWithValue("@estatus", int.Parse(cmbestatus.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@monto", valor);
                    cmd.Parameters.AddWithValue("@tipo", int.Parse(cmbtipo.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text);
                    cmd.ExecuteNonQuery();


                }
                 

                if (cmbestatus.SelectedValue.ToString()=="11" || cmbestatus.SelectedValue.ToString() == "3")
                {
                    try
                    {
                        Proc.enviocorreo(3, lnktabla, txtsolicitante.Text,email, txtdescription.Text, "","");
                        //Proc.enviocorreo(3, lnktabla,email, txtdescription.Text, "");
                        MessageBox.Show("Email enviado correctamente", "Succesfull", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al enviar el correo electrónico: " + ex.Message);
                    }
                }



                btnActualizar_Click_1(this, e);
                Dato = int.Parse(txtIdRFQ.Text);
                rfq_clickdato(this, e);
            }

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (txtMonto.Text=="")
            { txtMonto.Text = "0"; }

            if (int.Parse(txtMonto.Text) < 5001)
            { btnCambiaEstatus.Text = "Es cotización"; }
            else
            { btnCambiaEstatus.Text = "Tabla Comparativa"; }

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            int comprador;
            comprador = this.cmbComprador.SelectedIndex;

            if (comprador != -1)
            {
                comprador = int.Parse(this.cmbComprador.SelectedValue.ToString());
            }

            List<Listas.Encabezado> Lista = new List<Listas.Encabezado>();
            Lista = ListaMenu(comprador, this.dtfecha.Value);
            groupBox2.Visible = false;

            Llenarlist(Lista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.CambioRFQIU", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idrfq", int.Parse(txtIdRFQ.Text));
                cmd.Parameters.AddWithValue("@opcion", 1);
                cmd.ExecuteNonQuery();
            }

            try
            {
                Proc.enviocorreo(2, "",txtsolicitante.Text,email, txtdescription.Text, "","");
                MessageBox.Show("Email enviado correctamente", "Succesfull", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al enviar el correo electrónico: " + ex.Message);
            }


            btnActualizar_Click_1(this, e);
            Dato = int.Parse(txtIdRFQ.Text);
            rfq_clickdato(this, e);


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetalle frm = new frmDetalle(int.Parse(txtIdRFQ.Text));
        
            frm.AutoSize = false;
            frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frm.ShowDialog();
            frm.MaximizeBox = false;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            int opcion = 2;
           
            if (cmbestatus.SelectedValue.ToString() == "3" || cmbestatus.SelectedValue.ToString() == "11")
            {
                opcion = 3;

                File.Delete(lnktabla);
                
                try
                {
                    Proc.enviocorreo(2, "", txtsolicitante.Text, email, txtdescription.Text, txtObservaciones.Text, "");
                    MessageBox.Show("Email enviado correctamente", "Succesfull", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al enviar el correo electrónico: " + ex.Message);
                }
            }

       
            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.CambioRFQIU", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idrfq", int.Parse(txtIdRFQ.Text));
                cmd.Parameters.AddWithValue("@opcion", opcion);
                cmd.ExecuteNonQuery();


            }
           
            btnActualizar_Click_1(this, e);
            Dato = int.Parse(txtIdRFQ.Text);
            rfq_clickdato(this, e);



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdRFQ.Text))
            {
                MessageBox.Show("Favor de seleccionar un RFQ", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(txtdescription.Text))
            {
                MessageBox.Show("Favor de capturar una descripción", "Warning", MessageBoxButtons.OK);
                return;
                 
            }

            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.UpdateInfo", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idrfq", int.Parse(txtIdRFQ.Text));
                cmd.Parameters.AddWithValue("@descripcion", txtdescription.Text);
                cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
                cmd.Parameters.AddWithValue("@Proveedor", txtProvSugerido.Text);
                cmd.Parameters.AddWithValue("@idcomprador", cmbcomprador2.SelectedValue);
                cmd.Parameters.AddWithValue("@idtipo", cmbtipo.SelectedValue);
                cmd.ExecuteNonQuery();


            }


        }
            private void btnHistorial_Click(object sender, EventArgs e)
        {
           
            frmhistorial myForm = new frmhistorial(usuario,DateTime.Now,_usuario);
            myForm.Text = "Historico";
            myForm.AutoSize = false;
            myForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            myForm.MaximizeBox = false;
           


            myForm.ShowDialog();
           
        }



        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                     e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
                 {
                     e.Handled = false;
                  }
                 else if (Char.IsSeparator(e.KeyChar))
                  {
                     e.Handled = false;
                  }
                 else
                   {
                        e.Handled = true;
                   }
        }

      
        private void lnkRFQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                 
            Process proceso = new Process();
            proceso.StartInfo.FileName = lnkrfq;
            proceso.Start();
        }

        private void lnkTabla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Process proceso = new Process();
            proceso.StartInfo.FileName = lnktabla;
            proceso.Start();

          
        }
    }
}
