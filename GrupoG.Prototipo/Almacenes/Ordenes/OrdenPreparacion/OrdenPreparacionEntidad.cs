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
        public int NumeroCliente { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int DNITransportista { get; set; }
        public bool Empaquetada { get; set; }
        //public List<Mercaderias> Mercaderias { get; set; }
    }
}
