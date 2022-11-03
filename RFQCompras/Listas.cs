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
            public string Compradort { get; set; }

            public int Estatus { get; set; }
            public string EstatusT { get; set; }

            public int Tipo { get; set; }

            public string GerenteITSQE { get; set; }
            public string EmailGerenteITSQE { get; set; }
            public int? ClaGerenteITSQE { get; set; }

            public DateTime FechaSolicitud { get; set; }
            
            public DateTime FechaTabla { get; set; }
            public DateTime FechaCotizacion { get; set; }

            public int DiasTotales { get; set; }
            
            public int DiasTabla { get; set; }

            public decimal  Monto { get; set; }

            public string Observaciones { get; set; }
            public string SubCategoria { get; set; }

            public string lnkTabla { get; set; }
            public string lnkRfq { get; set; }
            public string email { get; set; }
            public string  ProvSugerido { get; set; }
            public string emailEmpleado { get; set; }
            public string emailcomprador { get; set; }
            public string emailGerente { get; set; }

        }

        public class DetalleProducto
        {
            public int Id { get; set; }
            public int cantidad { get; set; }
            public int unidadmedida { get; set; }
            public string descripcion { get; set; }
            public string NumberSerial { get; set; }
            public string MarcaSugerida { get; set; }
            public byte[] bytes { get; set; }


        }
    }
}
