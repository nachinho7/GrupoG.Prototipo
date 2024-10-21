using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GrupoG.Prototipo.Seleccion
{
    public class OrdenSeleccion
    {
        public int numeroOrdenSeleccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<OrdenPreparacion> OrdenPreparacion { get; set; }
    }
}
