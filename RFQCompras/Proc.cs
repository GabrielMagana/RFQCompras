using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace RFQCompras
{       
    
    
   public class Proc
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConexionDB"];
        public static string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public static string emailsupervisor;
        public static string MailNotify;
        public static string pass;
        static List<Listas.Detalles> listaDetalles;

        string Pc = Environment.MachineName;
        public static void combos(ComboBox obj,int opcion, int Usuario)
        {
            

            DataTable dt = new DataTable();
            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.combos", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@opcion", opcion);
                cmd.Parameters.AddWithValue("@ClaUasuario", Usuario);

                SqlDataAdapter Lector = new SqlDataAdapter(cmd);
                Lector.Fill(dt);

                obj.DisplayMember = "descripcion";
                obj.ValueMember = "id";
                obj.DataSource = dt;
           
            }
        }
        public static DataTable llenarGrid(int idrfq)
        {

            DataTable dt = new DataTable();
            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.DetallesProductoSel", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idRrfq", idrfq);
              
                SqlDataAdapter Lector = new SqlDataAdapter(cmd);
                Lector.Fill(dt); 
            }
            return dt;
        }

        public static int GenerarRFQ(DateTime FechaIns,string uso,int IdUsuario,int ClaSubCategoria,DataGridView SenderGrid,string ProveedorS,string Observaciones,string usuario)
        {
            int idRfq;
            DataTable dtr = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = conn.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                cmd.Connection = conn;
                cmd.Transaction = transaction;

                try
                {
                    cmd.CommandText="dbo.GeneraRfqIU";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Fecha", FechaIns);
                    cmd.Parameters.AddWithValue("@Descripcion", uso);
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    cmd.Parameters.AddWithValue("@ClaSubCategoria", ClaSubCategoria);
                    cmd.Parameters.AddWithValue("@ProveedorS", ProveedorS);
                    cmd.Parameters.AddWithValue("@Observaciones", Observaciones);

                    SqlDataAdapter Dt = new SqlDataAdapter(cmd);
                    Dt.Fill(dtr);

                    idRfq = int.Parse(dtr.Rows[0]["Idrfq"].ToString());

                    int idDetail = 1;
                       foreach (DataGridViewRow row in SenderGrid.Rows)
                       {
                        if (row.Cells[0].Value != null)
                        {
                            cmd.CommandText = "dbo.DetalleProductoIU";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IdRfq", idRfq);
                            cmd.Parameters.AddWithValue("@IdDetail", idDetail);
                            cmd.Parameters.AddWithValue("@Cantidad", int.Parse(row.Cells[0].Value.ToString()));
                            cmd.Parameters.AddWithValue("@ClaUnidad", int.Parse(row.Cells[1].Value.ToString()));
                            cmd.Parameters.AddWithValue("@DescripcionProducto", row.Cells[2].Value);
                            cmd.Parameters.AddWithValue("@NumeroSerie", row.Cells[3].Value);
                            cmd.Parameters.AddWithValue("@MarcaSugerida", row.Cells[4].Value);
                            cmd.Parameters.AddWithValue("@Imagen", row.Cells[6].Value);
                            cmd.Parameters.AddWithValue("@extension", row.Cells[8].Value);
                            cmd.Parameters.AddWithValue("@NombreArchivo", row.Cells[7].Value);
                            cmd.Parameters.AddWithValue("@UsuarioIns", usuario);
                            cmd.ExecuteNonQuery();
                            idDetail = idDetail + 1;
                        }

                       }

                    
                    transaction.Commit();


                    MessageBox.Show("El RFQ fue generado esta esperando ser autorizado.", "Successful", MessageBoxButtons.OK);

                }


                catch (Exception e)
                {

                    transaction.Rollback();
                    MessageBox.Show("Hubo error en la actualización favor de contactar al equipo de Compras y de IT");
                    return 0;
                }
            }
            return 1;

        }

        public static void GetCmb(DataGridViewComboBoxColumn obj, int opcion, int Usuario)
        {

            DataTable dt = new DataTable();
            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.combos", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@opcion", opcion);
                cmd.Parameters.AddWithValue("@ClaUasuario", Usuario);

                SqlDataAdapter Lector = new SqlDataAdapter(cmd);
                Lector.Fill(dt);

                obj.DisplayMember = "descripcion";
                obj.ValueMember = "id";
                obj.DataSource = dt;

            }
        }

        public static DataTable ObtenerConfiguraciones(int configuracion)
        {
            DataTable config = new DataTable();

            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.ConfiguracionSel", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Configuracion", configuracion);

                SqlDataAdapter Lector = new SqlDataAdapter(cmd);
                Lector.Fill(config);

            }


            return config;
        }


        public static DataTable RegresaUsuario(int Usuario)
        {
           
            DataTable perm = new DataTable();


            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("Select NombreUsuario, Email From CatUsuarios with (NoLock) where idUsuario = @Usuario", conn1);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("Usuario", Usuario);

                SqlDataAdapter Lector = new SqlDataAdapter(cmd);
                Lector.Fill(perm);

            }
            return perm;

        }

        public static DataTable ValidarUsuarios(string opcion)
        { int Validacion=0, usuario = 0;
            DataTable perm = new DataTable();


            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.ProcValidacion", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@email", opcion);

                SqlDataAdapter Lector = new SqlDataAdapter(cmd);
                Lector.Fill(perm);

            }
            return perm;
            
        }
        public static DataTable ValidarG(string opcion)
        {
            int Validacion = 0, usuario = 0;
            DataTable perm = new DataTable();


            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.ProcValidacionG", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@email", opcion);

                SqlDataAdapter Lector = new SqlDataAdapter(cmd);
                Lector.Fill(perm);

            }
            return perm;

        }
        public static DataTable llenarCatalogo(int tipo, string descripcion, int activo)
        {


            DataTable Ds = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            string sql = "[dbo].[CatalogosSel]";

            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand(sql, conn1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opcion", tipo);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@Activo", activo);
                cmd.CommandTimeout = 420;
                Da = new SqlDataAdapter();
                Da.SelectCommand = cmd;
                Ds.Locale = System.Globalization.CultureInfo.InvariantCulture;
                Da.Fill(Ds);
            }
            return Ds;

        }
        public static int CambiarEstatus(int estatus,int idrfq,string Comentarios,int usuario,int tipo)
        {
            int resultado;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = conn.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                cmd.Connection = conn;
                cmd.Transaction = transaction;

                try
                {
                   cmd.CommandText= "dbo.CambiosEstatusIU";
                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.AddWithValue("@idrfq", idrfq);
                   cmd.Parameters.AddWithValue("@Estatus", estatus);
                   cmd.Parameters.AddWithValue("@Usuario", usuario);
                   cmd.Parameters.AddWithValue("@Coments", Comentarios);
                   cmd.Parameters.AddWithValue("@tipo", tipo);


                    cmd.ExecuteNonQuery();


                   transaction.Commit();

                   MessageBox.Show("Se ha actualizado la información correctamente");

                    resultado = 1;
                }
            
                catch (Exception e)
                {
                
                transaction.Rollback();
                MessageBox.Show("Hubo error en la actualización favor de contactar al equipo de Compras y de IT");
                    resultado = 0;
                }
            }
            return resultado;

        }

        public static void enviarcorreos(string  subject, string body, int opcion, string correo,string cc, string attachment )
        {
            string Destinatario, Servidor;
            int Puerto;
            DataTable Correo = new DataTable();
            DataTable Supervisor = new DataTable();


            Correo = ObtenerConfiguraciones(1);

            Supervisor = ObtenerConfiguraciones(2);


            emailsupervisor = Supervisor.Rows[0]["Valor1"].ToString().Trim();

            MailNotify = Correo.Rows[0]["Valor2"].ToString().Trim();
            pass = Correo.Rows[0]["Valor3"].ToString().Trim();

            Servidor = Correo.Rows[0]["Valor1"].ToString().Trim();
            Puerto = int.Parse(Correo.Rows[0]["Valor1Num"].ToString().Trim());




            if (opcion == 1)
            {
                Destinatario = emailsupervisor; //aprobación 
            }
            else
            {
                Destinatario = correo;
            }


            MailMessage Mensaje = new MailMessage();

            Mensaje.To.Add(new MailAddress(Destinatario));
            Mensaje.From = new MailAddress(MailNotify);
            Mensaje.Subject = subject;
            Mensaje.Body = body;

            foreach (string email in cc.Split(','))
            {
                Mensaje.CC.Add(new MailAddress(email));
            }

            if (!string.IsNullOrEmpty(attachment))
            {
                Attachment data = new Attachment(attachment, MediaTypeNames.Application.Octet);
                Mensaje.Attachments.Add(data);
            }


            SmtpClient ClienteSMTP = new SmtpClient(Servidor, Puerto);

            ClienteSMTP.EnableSsl = true;

            NetworkCredential credentials = new NetworkCredential(MailNotify, pass, "");
            ClienteSMTP.Credentials = credentials;


            try
            {
                ClienteSMTP.Send(Mensaje);
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al enviar el correo electrónico: " + ex.Message);
            }
        }
        public static void IUCatalogo(int tipo, int id, string desc, string details, int activo, string usuario)
        {

            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();

                SqlCommand cmd = conn1.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = conn1.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                cmd.Connection = conn1;
                cmd.Transaction = transaction;
                try
                {

                    cmd.CommandText = "dbo.CatalogosUI";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@opcion", tipo);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Clave", details);
                    cmd.Parameters.AddWithValue("@Descripcion", desc);
                    cmd.Parameters.AddWithValue("@Activo", activo);
                    cmd.Parameters.AddWithValue("@usuario", usuario);


                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Se actualizado correctamente", "RFQ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    MessageBox.Show("No se actualizo correctamentr, favor de contactar al personal de Finanzas o de IT");
                }

            }
        }

        public static void enviocorreo(int opcion1, string ruta, string correodestino,string cc, string titulo, string comentarios,string emailAutorizador)
        {

            string description = "", body = "", correo = "";
            int opcion;

            if (opcion1 == 1)
            {
                description = "Notificación de aprobación para la tabla: " + titulo; //aprobacion
                opcion = 1;
                body = "Favor de revisar la tabla comparativa o la cotización " + titulo + " para su aprobación "; //aprobacion


            }

            if (opcion1 == 2)
            {
                description = "Rechazo de tabla comparativa o cotización"; //cancelacion
                opcion = 2;
                body = "La tabla comparativa o la cotización " + titulo + " fue rechazada:"; //cancelacion
            }

            if (opcion1 == 3)
            {
                description = "Tabla comparativa o Cotización rfq: " + titulo; 
                opcion = 3;
                body = "Tabla comparativa o Cotización " + titulo;  
            }

            if (opcion1 == 4)
            {
                description = "Se genera y se manda autorización del RFQ: " + titulo;
                opcion = 4;
                body = "El RFQ ha sido enviado para autorización por el gerente de área.";
            }

            if (opcion1 == 5)
            {
                description = "Se Autoriza el RFQ: " + titulo; 
                opcion = 5;
                body = "El RFQ ha sido autorizado y es enviado a compras";
            }

            if (opcion1 == 6)
            {
                description = "Se Autoriza pero requiere autorización adicional: " + titulo; //2 veces se envía
                opcion = 6;
                body = "El RFQ debe ser autorizado por el gerente de SQE y/o IT y para ser enviado a compras"; //2 veces se envía
            }

            if (opcion1 == 7)
            {
                description = "Se rechaza el RFQ: " + titulo +" por "+ emailAutorizador+"."; 
                opcion = 7;
                body = "Se rechaza el RFQ por los siguientes comentarios: " + comentarios; 
            }


            enviarcorreos(description, body, opcion1, correodestino, cc, ruta);

        }
        public static DataTable llenarUsuario(string Usuario, int Activo)
        {
            DataTable Ds = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter();
            string sql = "dbo.UsuariosAreaSel";

            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand(sql, conn1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", Usuario);
                cmd.Parameters.AddWithValue("@Activo", Activo);
                cmd.CommandTimeout = 420;
                Da = new SqlDataAdapter();
                Da.SelectCommand = cmd;
                Ds.Locale = System.Globalization.CultureInfo.InvariantCulture;
                Da.Fill(Ds);
            }
            return Ds;

        }
        public static void IUsuario(int id, int Tipo, string usuario)
        {

            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();

                SqlCommand cmd = conn1.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = conn1.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                cmd.Connection = conn1;
                cmd.Transaction = transaction;
                try
                {

                    cmd.CommandText = "dbo.UsuariosUI";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ClaUsuario", id);
                    cmd.Parameters.AddWithValue("@TipoUSuario", Tipo);
                    cmd.Parameters.AddWithValue("@usuario", usuario);



                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Se actualizado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    MessageBox.Show("No se actualizo correctamentr, favor de contactar al personal de Finanzas o de IT");
                }

            }
        }

    }
}
