using GrupoG.Prototipo.Pantallas.Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Objetos
{
    public class OrdenSeleccion
        {
            public int IdSeleccion { get; set; }
            public List<Orden> Ordenes { get; set; }
            public DateTime FechaCreacion { get; set; }

            public OrdenSeleccion(int idSeleccion, List<Orden> ordenes)
            {
                IdSeleccion = idSeleccion;
                Ordenes = ordenes;
                FechaCreacion = DateTime.Now;
            }
        }
}
