using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Despacho
{
    internal class OrdenDespacho
    {
        public int IdDespacho { get; set; }
        public int NroCliente { get; set; }
        public string Estado { get; set; }

        // Creamos el constructor
        public OrdenDespacho(int idDespacho, int nroCliente, string estado)
        {
            IdDespacho = idDespacho;
            Estado = estado;
            NroCliente = nroCliente;
        }
    }
}
