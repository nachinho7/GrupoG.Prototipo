using GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion
{
    internal class OrdenPreparacionAlmacen
    {
        private static List<OrdenPreparacionEntidad> ordenPreparacion = new List<OrdenPreparacionEntidad>();
        public static IReadOnlyCollection<OrdenPreparacionEntidad> OrdenPreparacion => ordenPreparacion.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(ordenPreparacion);
            File.WriteAllText("OrdenPreparacion.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("OrdenPreparacion.json"))
            {
                return;
            }

            var datos = File.ReadAllText("OrdenPreparacion.json");

            ordenPreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEntidad>>(datos)!;
        }
    }
}
