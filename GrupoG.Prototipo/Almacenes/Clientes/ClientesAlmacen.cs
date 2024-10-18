using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Cliente
{
    internal class ClientesAlmacen
    {
        private static List<ClientesEntidad> clientes = new List<ClientesEntidad>();
        public static IReadOnlyCollection<ClientesEntidad> Clientes => clientes.AsReadOnly();

        public static void Grabar()
        {
            
            var datos = JsonSerializer.Serialize(clientes);
            File.WriteAllText("Clientes.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("Clientes.json")) 
            {
                return;
            }

            var datos = File.ReadAllText("Clientes.json");

            clientes = JsonSerializer.Deserialize<List<ClientesEntidad>>(datos)!;
        }



        /*
        public static string BuscarDni(string dni)
        {
            var razonsocial = Clientes.FirstOrDefault(c => c.NumeroCliente == dni);
            return razonsocial.RazonSocial;
        }
        */
    }
}
