using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFQCompras;

namespace RFQCompras
{
    public partial class ucListado : UserControl
    {
        public ucListado()
        {
            
            InitializeComponent();
           

       
        }

        public int id;
        public string _descripcion;
        public int _idRFQ;
        public string _solicitante;
        public string _area;
        public string _estatus;
        

        [Category("Custom Props")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; txtDescription.Text = value; }

        }
        [Category("Custom Props")]
        public int IDRFQ
        {
            get { return _idRFQ; }
            set { _idRFQ = value; txtIdrfq.Text = value.ToString(); }

        }
        [Category("Custom Props")]
        public string Solicitante
        {
            get { return _solicitante; }
            set { _solicitante = value; txtsolicitante.Text = value; }

        }
        [Category("Custom Props")]
        public string Area
        {
            get { return _area; }
            set { _area = value; txtarea.Text = value; }

        }
        [Category("Custom Props")]
        public string Estatus
        {
            get { return _estatus; }
            set { _estatus = value; txtestatus.Text = value; }

        }
    }
}
