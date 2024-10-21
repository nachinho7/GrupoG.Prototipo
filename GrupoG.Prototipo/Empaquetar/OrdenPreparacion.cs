using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Empaquetar
{
    public class OrdenPreparacion
    {
        public int NumeroOrdenPreparacion { get; set; }
        public List<Mercaderias> Mercaderias { get; set; } = new List<Mercaderias>();

    }
}
