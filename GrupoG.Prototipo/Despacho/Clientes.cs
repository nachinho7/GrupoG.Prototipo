using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GrupoG.Prototipo.Despacho
{
    public class Clientes
    {
        public int NumeroCliente { get; set; }
        public List<Transportistas> Transportistas { get; set; }
    }
}

