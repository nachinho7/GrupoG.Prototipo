using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenSeleccion
{
    internal class OrdenSeleccionEntidad
    {
        public int numeroOrdenSeleccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public OrdenSeleccionEstados Estado { get; set; }
        public List<OrdenPreparacionEntidad> OrdenPreparacion { get; set; } = new List<OrdenPreparacionEntidad>();

    }
}
