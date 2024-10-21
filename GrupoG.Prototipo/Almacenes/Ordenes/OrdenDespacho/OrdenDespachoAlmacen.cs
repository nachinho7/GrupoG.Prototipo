using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenDespacho
{
    internal class OrdenDespachoAlmacen
    {
        private static List<OrdenDespachoEntidad> ordenDespacho = new List<OrdenDespachoEntidad>();
        public static IReadOnlyCollection<OrdenDespachoEntidad> OrdenDespacho => ordenDespacho.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(ordenDespacho);
            File.WriteAllText("OrdenDespacho.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("OrdenDespacho.json"))
            {
                return;
            }

            var datos = File.ReadAllText("OrdenDespacho.json");

            ordenDespacho = JsonSerializer.Deserialize<List<OrdenDespachoEntidad>>(datos)!;
        }
    }
}
