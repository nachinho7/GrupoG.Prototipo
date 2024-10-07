using GrupoG.Prototipo.Preparacion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Seleccion
{
    internal class PantallaSeleccionModel
    {
        public List<OrdenPreparacion2> OrdenPreparacion { get; private set; } = new List<OrdenPreparacion2>
        {
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 1, NumeroCliente = 1001, FechaDespacho = DateTime.Now.AddDays(1) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 2, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 3, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(3) },
        };

        private List<OrdenSeleccion2> ordenesSeleccion = new List<OrdenSeleccion2>();
        private int siguienteIdSeleccion = 1;

        // Método para obtener órdenes de preparación
        public List<OrdenPreparacion2> ObtenerOrdenes()
        {
            return OrdenPreparacion;
        }

        // Método para filtrar órdenes por fecha
        public List<OrdenPreparacion2> FiltrarOrdenesPorFecha(DateTime fecha)
        {
            return OrdenPreparacion.Where(o => o.FechaDespacho.Date == fecha.Date).ToList();
        }

        // Método para generar una nueva orden de selección
        public OrdenSeleccion2 GenerarOrdenDeSeleccion(List<OrdenPreparacion2> ordenesSeleccionadas)
        {
            if (ordenesSeleccionadas == null || !ordenesSeleccionadas.Any())
            {
                throw new ArgumentException("Debes seleccionar al menos una orden de preparación.");
            }

            OrdenSeleccion2 nuevaSeleccion = new OrdenSeleccion2
            {
                numeroOrdenSeleccion = siguienteIdSeleccion++,
                FechaCreacion = DateTime.Now
            };

            ordenesSeleccion.Add(nuevaSeleccion);

            // Aquí puedes agregar lógica para asociar las órdenes de preparación a la nueva selección si es necesario

            return nuevaSeleccion;
        }
    }
}
