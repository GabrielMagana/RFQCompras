using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFQCompras
{
    public partial class UploadTabla : UserControl
    {
        public UploadTabla()
        {
            InitializeComponent();
        }
 
        public string _descripcion;
        public int _idRFQ;
        public string _area;
   


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
      
       }
}
