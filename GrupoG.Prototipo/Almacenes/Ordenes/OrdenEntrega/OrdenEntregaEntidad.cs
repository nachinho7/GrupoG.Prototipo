using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega
{
    internal class OrdenEntregaEntidad
    {
        public int NumeroOrdenEntrega { get; set; }
        public int NroDeposito { get; set; }
        public List<int> Detalle { get; set; }
    }
}
