using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Clientes
{
    internal static class ClientesAlmacen
    {
        private static List<ClientesEntidad> clientes = new List<ClientesEntidad>();

        static ClientesAlmacen()
        {
            Leer();
        }

        public static IReadOnlyCollection<ClientesEntidad> Clientes => clientes.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"Json\Clientes.json", datos);
        }

        public static void Leer()
        {

            if (!File.Exists(@"Json\Clientes.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Json\Clientes.json");

            clientes = JsonSerializer.Deserialize<List<ClientesEntidad>>(datos)!;
        }

        public static ClientesEntidad ObtenerNroCliente(int numero)
        { 
            var numeroCliente = Clientes.FirstOrDefault(c => c.NroCliente == numero);
            return numeroCliente;
        }
    }
}
