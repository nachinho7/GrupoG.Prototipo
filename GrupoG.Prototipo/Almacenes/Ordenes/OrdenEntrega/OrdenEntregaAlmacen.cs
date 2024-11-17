using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Entrega;
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
        private static List<OrdenEntregaEntidad> ordenentrega = new List<OrdenEntregaEntidad>();

        static OrdenEntregaAlmacen()
        {
            Leer();
        }

        public static IReadOnlyCollection<OrdenEntregaEntidad> OrdenEntrega => ordenentrega.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenentrega);
            File.WriteAllText(@"Json\OrdenEntrega.json", datos);
        }

        public static void Leer()
        {

            if (!File.Exists(@"Json\OrdenEntrega.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Json\OrdenEntrega.json");

            ordenentrega = JsonSerializer.Deserialize<List<OrdenEntregaEntidad>>(datos)!;
        }

        public static void AgregarOrdenEntrega(OrdenEntregaEntidad ordenEntrega)
        {
            ordenentrega.Add(ordenEntrega);
        }
        
    }
}
