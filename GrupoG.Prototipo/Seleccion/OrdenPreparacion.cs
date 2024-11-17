using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Seleccion
{
    public class OrdenPreparacion
    {
        public int NumeroOrdenPreparacion { get; set; }
        public int NroCliente { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int DNITransportista { get; set; }
        public int Deposito { get; set; }
    }
}
