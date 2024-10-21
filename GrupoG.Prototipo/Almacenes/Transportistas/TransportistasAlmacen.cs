using GrupoG.Prototipo.Almacenes.Transportistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Transportistas
{
    internal class MercaderiasAlmacen
    {
        private static List<TransportistasEntidad> transportistas = new List<TransportistasEntidad>();
        public static IReadOnlyCollection<TransportistasEntidad> Transportistas => transportistas.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(transportistas);
            File.WriteAllText("Transportistas.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Transportistas.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Transportistas.json");

            transportistas = JsonSerializer.Deserialize<List<TransportistasEntidad>>(datos)!;
        }
    }
}
