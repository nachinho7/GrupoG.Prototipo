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
        public static IReadOnlyCollection<DepositoEntidad> Depositos => depositos.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(depositos);
            File.WriteAllText("Depositos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Depositos.json"))
            {
                return;
            }

            var datos = File.ReadAllText("Depositos.json");

            depositos = JsonSerializer.Deserialize<List<DepositoEntidad>>(datos)!;
        }

        public static int BuscarNroDeposito(string nombreDeposito)
        {
            var deposito = Depositos.FirstOrDefault(d => d.NombreDeposito == nombreDeposito);
            if (deposito != null)
            {
                return deposito.NroDeposito;
            }
            else
            {
                return -1;
            }
        }

        public static string BuscarNombreDeposito(int nroDeposito)
        {
            var deposito = Depositos.FirstOrDefault(d => d.NroDeposito == nroDeposito);
            if (deposito != null)
            {
                return deposito.NombreDeposito;
            }
            else
            {
                return "Depósito no encontrado";
            }
        }
    }
}
