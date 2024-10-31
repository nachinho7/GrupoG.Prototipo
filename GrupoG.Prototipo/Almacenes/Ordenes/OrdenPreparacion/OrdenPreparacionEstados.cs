using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion
{
    public enum OrdenPreparacionEstados
    {
        Pendiente,
        ASeleccionar,
        Seleccionada,
        Cumplida,
        Empaquetada,
        ADespacho,
        Despachada
    }
}
