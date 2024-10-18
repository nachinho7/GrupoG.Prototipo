using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenSeleccion
{
    internal class OrdenSeleccionAlmacen
    {
        private static List<OrdenSeleccionEntidad> ordenSeleccion = new List<OrdenSeleccionEntidad>();
        public static IReadOnlyCollection<OrdenSeleccionEntidad> OrdenSeleccion => ordenSeleccion.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(ordenSeleccion);
            File.WriteAllText("OrdenSeleccion.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("OrdenSeleccion.json"))
            {
                return;
            }

            var datos = File.ReadAllText("OrdenSeleccion.json");

            ordenSeleccion = JsonSerializer.Deserialize<List<OrdenSeleccionEntidad>>(datos)!;
        }
    }
}
