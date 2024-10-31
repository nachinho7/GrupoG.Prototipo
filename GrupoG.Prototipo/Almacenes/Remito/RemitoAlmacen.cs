using GrupoG.Prototipo.Almacenes.Mercaderias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Remito
{
    internal class RemitoAlmacen
    {
        private static List<RemitoEntidad> remitos = new List<RemitoEntidad>();
        public static IReadOnlyCollection<RemitoEntidad> Remitos => remitos.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(remitos);
            File.WriteAllText("Remitos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Remitos.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Remitos.json");

            remitos = JsonSerializer.Deserialize<List<RemitoEntidad>>(datos)!;
        }
    }
}
