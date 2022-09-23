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

        string Pc = Environment.MachineName;
        public static void combos(ComboBox obj,int opcion)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn1 = new SqlConnection(ConnectionString))
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand("dbo.combos", conn1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@opcion", opcion);

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

        public static void enviarcorreos(string  subject, string body, int opcion, string correo, string attachment )
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
            
            if (!string.IsNullOrEmpty(attachment))
            {   Attachment data = new Attachment(attachment, MediaTypeNames.Application.Octet);
                Mensaje.Attachments.Add(data); }


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


        public static void enviocorreo(int opcion1, string ruta, string correos, string titulo, string comentarios)
        {

            string description = "", body = "", correo = "";
#pragma warning disable CS0219 // The variable 'opcion' is assigned but its value is never used
            int opcion;
#pragma warning restore CS0219 // The variable 'opcion' is assigned but its value is never used

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
                body = "La tabla comparativa o la cotización " + titulo + " fue rechazada"; //cancelacion
                correo = correos;
            }

            if (opcion1 == 3)
            {
                description = "Tabla comparativa o Cotización rfq: " + titulo; //2 veces se envía
                opcion = 2;
                body = "Tabla comparativa o Cotización " + titulo; //2 veces se envía
                correo = correos;
            }

            enviarcorreos(description, body, opcion1, correo, ruta);

        }

    }
}
