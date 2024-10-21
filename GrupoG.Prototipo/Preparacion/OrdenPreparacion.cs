using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Preparacion
{
    public class OrdenPreparacion
    {
        public int NumeroOrdenPreparacion { get; set; }
        public int NumeroCliente { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int DNITransportista { get; set; }
        public string EstadoOrden { get; set; } 
        public List<Mercaderias> Mercaderias { get; set; } = new List<Mercaderias>();

    }
}
