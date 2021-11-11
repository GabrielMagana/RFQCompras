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
using RFQCompras;

namespace RFQCompras
{
    public partial class ucDetails : UserControl
    {
        public ucDetails()
        {
            InitializeComponent();


        }

        public int id;
        public string _descripcion;
        public string _solicitante;
        public string _observaciones;
        public int _idRFQ;
        public int _comprador;
        public int _estatus;
        public int _tipo;
        public int _diastotales;
        public int _diastabla;
        public decimal _monto;
        public DateTime _fechasolicitud;
        public DateTime _fechatabla;

        [Category("Custom Props")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; txtdescription.Text = value; }

        }
        [Category("Custom Props")]
        public int IDRFQ
        {
            get { return _idRFQ; }
            set { _idRFQ = value; txtIdRFQ.Text = value.ToString(); }

        }
        [Category("Custom Props")]
        public string Solicitante
        {
            get { return _solicitante; }
            set { _solicitante = value; txtsolicitante.Text = value; }

        }
        [Category("Custom Props")]
        public int Comprador
        {
            get { return _comprador; }
            set { _comprador = value; }

        }
        [Category("Custom Props")]
        public int Estatus
        {
            get { return _estatus; }
            set { _estatus = value;  }

        }

        [Category("Custom Props")]
        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value;  }

        }
        [Category("Custom Props")]
        public decimal Monto
        {
            get { return _monto; }
            set { _monto = value; txtMonto.Text = value.ToString(); }

        }
        [Category("Custom Props")]
        public DateTime FechaSolicitud
        {
            get { return _fechasolicitud; }
            set { _fechasolicitud = value; dtFechasolicitan.Value = DateTime.Now; }

        }
        [Category("Custom Props")]
        public DateTime FechaTabla
        {
            get { return _fechatabla; }
            set { _fechatabla = value; dtFechaTabla.Value= DateTime.Now;  }

        }
        [Category("Custom Props")]
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; txtObservaciones.Text = value; }

        }

    }
}
