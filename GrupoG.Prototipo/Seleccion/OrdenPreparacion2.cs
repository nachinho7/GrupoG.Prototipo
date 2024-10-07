using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Seleccion
{
    internal class OrdenPreparacion2
    {
        public int NumeroOrdenPreparacion { get; set; }
        public int NumeroCliente { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int DNITransportista { get; set; }

        public List<Mercaderias2> Mercaderias { get; set; } = new List<Mercaderias2>();
    }
}
