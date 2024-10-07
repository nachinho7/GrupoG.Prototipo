using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Seleccion
{
    internal class OrdenPreparacion
    {
        public int NumeroOrdenPreparacion { get; set; }
        public int NumeroCliente { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int DNITransportista { get; set; }
        public string Prioridad { get; set; }

        public List<Mercaderias> Mercaderias { get; set; } = new List<Mercaderias>();


    }
}
