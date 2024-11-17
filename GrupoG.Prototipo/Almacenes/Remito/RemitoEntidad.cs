using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Remito
{
    internal class RemitoEntidad
    {
        public int NroCliente { get; set; }
        public int NroRemito { get; set; }
        public int DNITransportista { get; set; }
        public List<int> Detalle { get; } = new();
    }
}
