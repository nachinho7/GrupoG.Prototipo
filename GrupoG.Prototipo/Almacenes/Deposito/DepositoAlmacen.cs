using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Deposito
{
    internal class DepositoAlmacen
    {
        private static List<DepositoEntidad> depositos = new List<DepositoEntidad>();

        static DepositoAlmacen()
        {
            Leer();
        }

        public static IReadOnlyCollection<DepositoEntidad> Depositos => depositos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(depositos);
            File.WriteAllText(@"Json\Deposito.json", datos);
        }

        public static void Leer()
        {

            if (!File.Exists(@"Json\Deposito.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Json\Deposito.json");

            depositos = JsonSerializer.Deserialize<List<DepositoEntidad>>(datos)!;
        }

    }
}
