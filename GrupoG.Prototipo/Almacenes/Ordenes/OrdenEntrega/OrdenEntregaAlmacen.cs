using GrupoG.Prototipo.Almacenes.Mercaderias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega
{
    internal class OrdenEntregaAlmacen
    {
        private static List<OrdenEntregaEntidad> ordenEntrega = new List<OrdenEntregaEntidad>();
        public static IReadOnlyCollection<OrdenEntregaEntidad> OrdenEntrega => ordenEntrega.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(ordenEntrega);
            File.WriteAllText("OrdenEntrega.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("OrdenEntrega.json"))
            {
                return;
            }

            var datos = File.ReadAllText("OrdenEntrega.json");

            ordenEntrega = JsonSerializer.Deserialize<List<OrdenEntregaEntidad>>(datos)!;
        }
    }
}
