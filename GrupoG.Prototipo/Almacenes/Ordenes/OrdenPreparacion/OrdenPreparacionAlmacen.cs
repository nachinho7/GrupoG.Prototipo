using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion
{
    internal class OrdenPreparacionAlmacen
    {
        private static List<OrdenPreparacionEntidad> ordenpreparacion = new List<OrdenPreparacionEntidad>();

        static OrdenPreparacionAlmacen()
        {
            Leer();
        }

        public static IReadOnlyCollection<OrdenPreparacionEntidad> OrdenPreparacion => ordenpreparacion.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(ordenpreparacion);
            File.WriteAllText(@"Json\OrdenPreparacion.json", datos);
        }

        public static void Leer()
        {

            if (!File.Exists(@"Json\OrdenPreparacion.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Json\OrdenPreparacion.json");

            ordenpreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEntidad>>(datos)!;
        }

        public static void AgregarOrdenPreparacion(OrdenPreparacionEntidad ordenPreparacion)
        {
            ordenpreparacion.Add(ordenPreparacion);
        }

        public static OrdenPreparacionEntidad ObtenerOrdenPreparacionPorNumero(int nroOrdenPrep)
        {
            return ordenpreparacion.FirstOrDefault(op => op.NumeroOrdenPreparacion == nroOrdenPrep);
        }

        public static List<OrdenPreparacionEntidad> ObtenerOrdenesPreparacionPorNumero(List<int> numOrdenPreparacionLista)
        {
            return ordenpreparacion
                .Where(op => numOrdenPreparacionLista.Contains(op.NumeroOrdenPreparacion))
                .ToList();
        }

        public static void ModificarEstado(OrdenPreparacionEntidad orden, OrdenPreparacionEstados estado)
        {
            orden.Estado = estado;
        }
       
    }
}
