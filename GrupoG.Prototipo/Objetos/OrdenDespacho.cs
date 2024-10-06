using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Objetos
{
    internal class OrdenDespacho
    {
        public int IdDespacho { get; set; }
        public int NroCliente { get; set; }
        public string Estado { get; set; }

        // Constructor
        public OrdenDespacho(int idDespacho, int nroCliente, string estado)
        {
            IdDespacho = idDespacho;
            Estado = estado;
            NroCliente = nroCliente;
        }
    }
}
