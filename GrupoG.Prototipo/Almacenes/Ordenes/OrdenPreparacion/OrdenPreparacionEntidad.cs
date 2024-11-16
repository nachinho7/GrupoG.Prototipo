using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion
{
    internal class OrdenPreparacionEntidad
    {
        public int NumeroOrdenPreparacion { get; set; }
        public int NroCliente { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int DNITransportista { get; set; }
        public int NroDeposito { get; set; }
        public OrdenPreparacionEstados Estado {  get; set; }
        public List<OrdenPreparacionDetalle> Detalle { get; set; } = new List<OrdenPreparacionDetalle>();
    }
}
