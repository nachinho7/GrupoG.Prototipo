using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GrupoG.Prototipo.Seleccion
{
    internal class OrdenSeleccion2
    {
        public int numeroOrdenSeleccion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<OrdenPreparacion2> OrdenPreparacion { get; set; }

    }
}
