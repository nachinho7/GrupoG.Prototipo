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
        private static List<OrdenPreparacionEntidad> ordenPreparacion = new List<OrdenPreparacionEntidad>();
        public static IReadOnlyCollection<OrdenPreparacionEntidad> OrdenPreparacion => ordenPreparacion.AsReadOnly();

        public static void Grabar()
        {

            var datos = JsonSerializer.Serialize(ordenPreparacion);
            File.WriteAllText("OrdenPreparacion.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("OrdenPreparacion.json"))
            {
                return;
            }

            var datos = File.ReadAllText("OrdenPreparacion.json");

            ordenPreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEntidad>>(datos)!;
        }

        public static void AgregarOrdenPreparacion(OrdenPreparacionEntidad ordenpreparacion)
        {
            ordenPreparacion.Add(ordenpreparacion);
        }

        public static void ModificarEstado(OrdenPreparacionEntidad orden, OrdenPreparacionEstados estado)
        {
            orden.Estado = estado;
        }

        public static List<OrdenPreparacionEntidad> ObtenerOrdenesPreparacionPorNumero(List<int> nroOrdenesPrepList)
        {
            return ordenPreparacion
                .Where(op => nroOrdenesPrepList.Contains(op.NumeroOrdenPreparacion))
                .ToList();
        }
        public static OrdenPreparacionEntidad ObtenerOrdenPreparacionPorNumero(int nroOrdenPrep)
        {
            return ordenPreparacion.FirstOrDefault(op => op.NumeroOrdenPreparacion == nroOrdenPrep);
        }
    }
}
