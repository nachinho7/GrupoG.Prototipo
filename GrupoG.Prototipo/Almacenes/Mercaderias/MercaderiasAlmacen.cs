using GrupoG.Prototipo.Almacenes.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Mercaderias
{
    internal class MercaderiasAlmacen
    {
        private static List<MercaderiasEntidad> mercaderias = new List<MercaderiasEntidad>();
        public static IReadOnlyCollection<MercaderiasEntidad> Mercaderias => mercaderias.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(mercaderias);
            File.WriteAllText("Mercaderias.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Mercaderias.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Mercaderias.json");

            mercaderias = JsonSerializer.Deserialize<List<MercaderiasEntidad>>(datos)!;
        }
    }
}
