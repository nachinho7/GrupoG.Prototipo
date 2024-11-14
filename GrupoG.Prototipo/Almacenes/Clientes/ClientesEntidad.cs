using GrupoG.Prototipo.Despacho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Clientes
{
    internal class ClientesEntidad
    {
        public int NroCliente { get; set; }
        public int NroDeposito { get; set; }
        public List<ClientesTransportista> Transportistas { get; set; } = new List<ClientesTransportista>();

    }
}
