using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GrupoG.Prototipo.Stock
{
    public class OrdenSeleccion
    {
        public int numeroOrdenSeleccion { get; set; }
        public List<Mercaderias> Mercaderias { get; set; } = new List<Mercaderias>();

    }
}
