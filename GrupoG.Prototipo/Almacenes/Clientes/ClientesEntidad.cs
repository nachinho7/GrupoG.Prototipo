using GrupoG.Prototipo.Despacho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Cliente
{
    internal class ClientesEntidad
    {
        public int NumeroCliente { get; set; }
        public List<Transportistas> Transportistas { get; set; }
    }
}
