using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFQCompras
{
    class Listas
    {

        public class Encabezado
        {
            public int IdRfq { get; set; }
            
            public string Desripcion { get; set; }
            
            public string Estatus { get; set; }
            
            public string Solicitante { get; set; }

            public string Area { get; set; }
        }

        public class Detalles
        {
            public int IdRfq { get; set; }
            public string Desripcion { get; set; }

            public string Solicitante { get; set; }

            public int Comprador { get; set; }

            public int Estatus { get; set; }

            public int Tipo { get; set; }
                      
            public DateTime FechaSolicitud { get; set; }
            
            public DateTime FechaTabla { get; set; }
            public DateTime FechaCotizacion { get; set; }

            public int DiasTotales { get; set; }
            
            public int DiasTabla { get; set; }

            public decimal  Monto { get; set; }

            public string Observaciones { get; set; }

            public string lnkTabla { get; set; }
            public string lnkRfq { get; set; }
            public string email { get; set; }

        }
    }
}
