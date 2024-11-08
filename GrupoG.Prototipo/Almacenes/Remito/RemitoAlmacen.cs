using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Remito;
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
        private static List<RemitoEntidad> remito = new List<RemitoEntidad>();

        static RemitoAlmacen()
        {
            Leer();
        }

        public static IReadOnlyCollection<RemitoEntidad> Remito => remito.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(remito);
            File.WriteAllText(@"Json\Remito.json", datos);
        }

        public static void Leer()
        {

            if (!File.Exists(@"Json\Remito.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Json\Remito.json");

            remito = JsonSerializer.Deserialize<List<RemitoEntidad>>(datos)!;
        }


        public static void AgregarRemito(RemitoEntidad ordenEntrega)
        {
            remito.Add(ordenEntrega);
        }
    }
}
