using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenSeleccion
{
    internal class OrdenSeleccionAlmacen
    {
        private static List<OrdenSeleccionEntidad> ordenseleccion = new List<OrdenSeleccionEntidad>();

        static OrdenSeleccionAlmacen()
        {
            Leer();
        }

        public static IReadOnlyCollection<OrdenSeleccionEntidad> OrdenSeleccion => ordenseleccion.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenseleccion);
            File.WriteAllText(@"Json\OrdenSeleccion.json", datos);
        }

        public static void Leer()
        {

            if (!File.Exists(@"Json\OrdenSeleccion.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Json\OrdenSeleccion.json");

            ordenseleccion = JsonSerializer.Deserialize<List<OrdenSeleccionEntidad>>(datos)!;
        }

        public static void AgregarOrdenSeleccion(OrdenSeleccionEntidad ordenSeleccion)
        {
            ordenseleccion.Add(ordenSeleccion);
        }
        public static void ModificarEstado(OrdenSeleccionEntidad orden, OrdenSeleccionEstados estado)
        {
            orden.Estado = estado;
        }
    }
}
