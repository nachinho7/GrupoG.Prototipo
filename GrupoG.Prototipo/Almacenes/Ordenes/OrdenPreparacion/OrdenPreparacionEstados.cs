using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion
{
    public enum EstadosOrdenPreparacion
    {
        Pendiente,
        EnSeleccion,
        Seleccionada,
        Preparada,
        EnDespacho,
        Despachada
    }
}
