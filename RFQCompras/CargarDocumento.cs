using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFQCompras
{
    public partial class CargarDocumento : Form
    {
        string _descripcion; int _idrfq, _establa;

        public int resultado { get; set; }

        public static string ConnectionString = ConfigurationManager.AppSettings["ConexionDB"];
        public static string Ruta = ConfigurationManager.AppSettings["rutaTabla"];
        public static string RutaCot = ConfigurationManager.AppSettings["rutaCotizacion"];
        public CargarDocumento(string descripcion, int idrfq,int esTabla)
        {
            InitializeComponent();
            _descripcion = descripcion;
            _idrfq = idrfq;
            _establa = esTabla;

            this.flowLayoutPanel1.Controls.Clear();

            UploadTabla tabla = new UploadTabla();

            tabla.Descripcion = _descripcion;
            tabla.IDRFQ = _idrfq;

            this.flowLayoutPanel1.Controls.Add(tabla);
            tabla.btnGuardarDoc.Click += new EventHandler(this.guardar_click);
            tabla.btnCancelar.Click += new EventHandler(this.Cancelar_click);

        }

        private void Cancelar_click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
        
        private void guardar_click(object sender, EventArgs e)
        {
            string RutaFin;
            string filName;
            string xtName;
            string destinotabla="";
        
            Ruta = Ruta ;
           RutaCot = RutaCot;


            if (_establa == 1)
            {
                RutaFin = Ruta;
            }
            else
            {
                RutaFin = RutaCot;
            }

         
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png*)|*.png*|PDF (*.pdf)|*.pdf (*.xlsx)|*.xlsx (*.docx)|*.docx";
            //Restaurar la ventana despues del open fileDialog
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
          
                filName = ofd.FileName;
                xtName= Path.GetExtension(ofd.FileName);
               
                txtruta.Text = filName;  
                //nombre = ofd;
                  
                //Copia del archivo
                string destino = Path.Combine(Application.StartupPath, String.Format(RutaFin+"\\"+_descripcion+xtName, Path.GetFileName(ofd.FileName)));
                destinotabla = destino;
                File.Copy(ofd.FileName, destino);

                using (SqlConnection conn1 = new SqlConnection(ConnectionString))
                {
                    conn1.Open();
                    SqlCommand cmd = new SqlCommand("Update [dbo].[RFQ_Detalle] set [RutaTabla] = '" + destinotabla + "' where idRfq=" + _idrfq.ToString(), conn1);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                } 

                MessageBox.Show("Se realizo la carga de manera exitosa", "Confirmación", MessageBoxButtons.OK);
                resultado = 1;

                try
                {
                    Proc.enviocorreo(1, destinotabla, "", _descripcion, "");
                    MessageBox.Show("Email enviado correctamente", "Succesfull", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al enviar el correo electrónico: " + ex.Message);
                }
            }
            



            this.Close();
            return;
        }

        private void CargarDocumento_Load(object sender, EventArgs e)
        {
            UploadTabla tabla = new UploadTabla();

            tabla.Descripcion=  _descripcion;
            tabla.IDRFQ = _idrfq;
        }
    }
}
