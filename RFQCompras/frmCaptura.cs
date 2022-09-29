using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFQCompras
{
    public partial class frmCaptura : Form
    { 
    
        public int resultado = 1, validacion, usuario;
        public static string ConnectionString = ConfigurationManager.AppSettings["ConexionDB"];
        public static string Ruta;
        public static string RutaCot;
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name, _usuario;
        string Pc = Environment.MachineName;
        int Area;
        DataTable permisos = new DataTable();
        DataTable dt = new DataTable();
        public static int Dato;
        int itmanager, sqemanager;
        byte[] _stream;
        string[] name;
        string[] ext;
        object imagen;

        string lnktabla, lnkrfq, email;

       

        public frmCaptura(string Usuario)
        {
            InitializeComponent();
            _usuario = Usuario;

        }

      

        private void frmCaptura_Load(object sender, EventArgs e)
        {
            dt = Proc.ObtenerConfiguraciones(3);
            Ruta = dt.Rows[0]["Valor1"].ToString();
            RutaCot = dt.Rows[0]["Valor1"].ToString();

            permisos = Proc.ValidarUsuarios(_usuario);

            validacion = int.Parse(permisos.Rows[0]["permiso"].ToString().Trim());
            usuario = int.Parse(permisos.Rows[0]["idusuario"].ToString().Trim());

            //dtgCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewComboBoxColumn ComboUnidad = dtgCompras.Columns["unit"] as DataGridViewComboBoxColumn;

            Proc.GetCmb(ComboUnidad, 7, usuario);

            Proc.combos(cmbArea, 5, usuario);
            cmbArea.SelectedValue = int.Parse(permisos.Rows[0]["ClaArea"].ToString().Trim());
            if (validacion == 3)
            { cmbArea.Enabled = false; }
            Proc.combos(cmbSubCategoria, 6, usuario);
            cmbSubCategoria.SelectedIndex = 0;
            txtSolicitante.Text = permisos.Rows[0]["nombreUsuario"].ToString();
            txtEmailSolicitante.Text = permisos.Rows[0]["email"].ToString();
            txtManager.Text = permisos.Rows[0]["Manager"].ToString();
            txtEmailManager.Text = permisos.Rows[0]["EmailM"].ToString();

        }

        private void dtgCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var senderGrid = (DataGridView)sender;
            string Ext;
            

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string _nomdocument, _extdocumento, _tipoDocuemnto, path;
                byte[] stream;

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Image Files (*.jpg,*.png,*jpeg)|*.png;*.jpeg;*.jpg";
                openFileDialog1.FilterIndex = 1;




                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    Stream myStream = openFileDialog1.OpenFile();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        myStream.CopyTo(ms);
                        stream = ms.ToArray();
                    }
                    senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = stream;
                    //name[e.RowIndex] = Path.GetFileName(openFileDialog1.FileName);
                    senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = Path.GetFileName(openFileDialog1.FileName);
                    senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value = Path.GetExtension(openFileDialog1.FileName);

                }

            }
            

        }
        private void dtgCompras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex != -1)
            {

                if (dtgCompras.Columns[e.ColumnIndex].Name.Equals("Image") && e.Value == null)
                {
                    byte[] str = Convert.FromBase64String(e.Value.ToString());
                    e.Value = GetImage(str);
                    
                }
            }

        }

        private void btnRFQ_Click(object sender, EventArgs e)
        {
            int usuarioadiaciente=0;
            string mensaje = "";
            if(txtUso.Text == "")
            {
                MessageBox.Show("Debes Capturar el titulo o uso destinado", "Warning", MessageBoxButtons.OK);
                return;
            }
            if (cmbSubCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Debes Capturar la subcategoria", "Warning", MessageBoxButtons.OK);
                return;
            }
            dtpFechaIns.Value = DateTime.Now;
            if(dtgCompras.Rows.Count==0)
            {
                MessageBox.Show("Debes Capturar fecha deseada", "Warning", MessageBoxButtons.OK);
                return;
            }


            mensaje = ValidaCell(dtgCompras);

            if (mensaje !="")
            {
                MessageBox.Show(mensaje,"Warning",MessageBoxButtons.OK);
                return;
            }

            Proc.GenerarRFQ(dtpFechaIns.Value,txtUso.Text, usuario,int.Parse(cmbSubCategoria.SelectedValue.ToString()),dtgCompras, txtProveedorSugerido.Text,txtObservaciones.Text,_usuario);

        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            dtgCompras.Rows.Clear();
            txtUso.Text = "";
            txtProveedorSugerido.Text = "";
            cmbSubCategoria.SelectedValue = 1;
            dtpFechaIns.Value = DateTime.Now;
            txtObservaciones.Text="";
        }

        private void dtgCompras_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Si es la primera columna y la celda es un número, la condición se cumple...
            if (e.ColumnIndex == 0 && ValidNumber(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
                dtgCompras.Rows[e.RowIndex].ErrorText = "Solo se puede ingresar números.";
            }
        }

        private string ValidaCell(DataGridView SenderGrid)
        {
            int renglon;
            renglon = SenderGrid.SelectedRows.Count;
            string mensaje="";
               if (SenderGrid.Rows[renglon].Cells[0].Value == null)
                {
                    mensaje = "Debe Capturar la cantidad requerida";
                    goto Salir;
                }
                if (SenderGrid.Rows[renglon].Cells[1].Value == null)
                {
                    mensaje = "Debe Capturar la unidad requerida";
                    goto Salir;
                }
                if (SenderGrid.Rows[renglon].Cells[2].Value == null)
                {
                    mensaje = "Debe Capturar la descripción del producto";
                    goto Salir;
                }
                if (SenderGrid.Rows[renglon].Cells[3].Value == null)
                {
                    mensaje = "Debe Capturar el número de serio o número de parte";
                    goto Salir;
                }
                if (SenderGrid.Rows[renglon].Cells[4].Value == null)
                {
                    mensaje = "Debe Capturar la marca sugerida";
                    goto Salir;
                }
                if (SenderGrid.Rows[renglon].Cells[6].Value == null)
                {
                    mensaje = "Debe Capturar la imagen del producto";
                    goto Salir;
                }

            
        Salir:
            return mensaje;
        }

        private void dtgCompras_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            dtgCompras.Rows[e.RowIndex].ErrorText = "";
        }
        private bool ValidNumber(string value)
        {
            //Obtenemos la longitud de la celda
            int len = value.Length;
            for (int i = 0; i != len; ++i)
            {
                //Detectamos si la celda tiene únicamente números
                if (!(value[i] >= '0' && value[i] <= '9'))
                    return true;
            }
            return false;
        }

        public Image GetImage(byte[] str)
        {
            MemoryStream ms = new MemoryStream(str);
            Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }





        private void cmbSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSubCategoria.SelectedItem.ToString()))
            {
                DataTable ITDt = new DataTable();
                DataTable SQEdt = new DataTable();

                string scIT, scSQE;
                int Sqe, IT;


                ITDt = Proc.ObtenerConfiguraciones(7);
                SQEdt = Proc.ObtenerConfiguraciones(8);


                IT = int.Parse(ITDt.Rows[0]["Valor1Num"].ToString());
                Sqe = int.Parse(SQEdt.Rows[0]["Valor1Num"].ToString());
                scIT = ITDt.Rows[0]["Valor1"].ToString().Trim();
                scSQE = SQEdt.Rows[0]["Valor1"].ToString().Trim();


                ITDt = Proc.ObtenerConfiguraciones(IT);
                SQEdt = Proc.ObtenerConfiguraciones(Sqe);


                itmanager = int.Parse(ITDt.Rows[0]["Valor1"].ToString().Trim());
                sqemanager = int.Parse(SQEdt.Rows[0]["Valor1"].ToString().Trim());


                string[] valoresSqe = scSQE.Split(',');

                string[] valoresIT = scIT.Split(',');


                foreach (string sqe in valoresSqe)
                {
                    if (cmbSubCategoria.SelectedValue.ToString() == int.Parse(sqe).ToString())
                    {

                        SQEdt = Proc.RegresaUsuario(sqemanager);
                        txtGerenteITSQE.Text = SQEdt.Rows[0]["NombreUsuario"].ToString().Trim();
                        txtEmailITSQE.Text = SQEdt.Rows[0]["email"].ToString().Trim();
                        label14.Visible = true;
                        label14.Text = "Nombre gerente SQE";
                        label15.Visible = true;
                        label15.Text = "Email gerente SQE";
                        txtGerenteITSQE.Visible = true;
                        txtEmailITSQE.Visible = true;
                        if (txtManager.Text == txtGerenteITSQE.Text)
                        {
                            label14.Visible = false;
                            label15.Visible = false;
                            txtGerenteITSQE.Text = "";
                            txtGerenteITSQE.Visible = false;
                            txtEmailITSQE.Visible = false;
                            txtEmailITSQE.Text = "";

                        }
                        return;
                    }
                    else
                    {
                        label14.Visible = false;
                        label15.Visible = false;
                        txtGerenteITSQE.Text = "";
                        txtGerenteITSQE.Visible = false;
                        txtEmailITSQE.Visible = false;
                        txtEmailITSQE.Text = "";
                    }

                }


                foreach (string it in valoresIT)
                {
                    if (cmbSubCategoria.SelectedValue.ToString() == int.Parse(it).ToString())
                    {
                        ITDt = Proc.RegresaUsuario(itmanager);
                        txtGerenteITSQE.Text = ITDt.Rows[0]["NombreUsuario"].ToString().Trim();
                        txtEmailITSQE.Text = ITDt.Rows[0]["email"].ToString().Trim();
                        label14.Visible = true;
                        label14.Text = "Nombre gerente IT";
                        label15.Visible = true;
                        label15.Text = "Email gerente IT";
                        txtGerenteITSQE.Visible = true;
                        txtEmailITSQE.Visible = true;
                        if (txtManager.Text == txtGerenteITSQE.Text)
                        {
                            label14.Visible = false;
                            label15.Visible = false;
                            txtGerenteITSQE.Text = "";
                            txtGerenteITSQE.Visible = false;
                            txtEmailITSQE.Visible = false;
                            txtEmailITSQE.Text = "";
                        }
                        return;
                    }
                    else
                    {
                        label14.Visible = false;
                        label15.Visible = false;
                        txtGerenteITSQE.Text = "";
                        txtGerenteITSQE.Visible = false;
                        txtEmailITSQE.Visible = false;
                        txtEmailITSQE.Text = "";
                    }
                }
            }

        }
    }
}
