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
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 4, NumeroCliente = 1001, FechaDespacho = DateTime.Now.AddDays(1) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 5, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 6, NumeroCliente = 1003, FechaDespacho = DateTime.Now.AddDays(3) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 7, NumeroCliente = 1004, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 8, NumeroCliente = 1005, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 9, NumeroCliente = 1006, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 10, NumeroCliente = 1007, FechaDespacho = DateTime.Now.AddDays(7) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 11, NumeroCliente = 1008, FechaDespacho = DateTime.Now.AddDays(8) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 12, NumeroCliente = 1009, FechaDespacho = DateTime.Now.AddDays(9) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 13, NumeroCliente = 1010, FechaDespacho = DateTime.Now.AddDays(10) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 14, NumeroCliente = 1011, FechaDespacho = DateTime.Now.AddDays(9) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 15, NumeroCliente = 1012, FechaDespacho = DateTime.Now.AddDays(12) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 16, NumeroCliente = 1013, FechaDespacho = DateTime.Now.AddDays(13) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 17, NumeroCliente = 1014, FechaDespacho = DateTime.Now.AddDays(10) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 18, NumeroCliente = 1015, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion2 { NumeroOrdenPreparacion = 19, NumeroCliente = 1016, FechaDespacho = DateTime.Now.AddDays(2) },

        };

        private List<OrdenSeleccion2> ordenesSeleccionadas = new List<OrdenSeleccion2>();
        private int siguienteIdSeleccion = 1;

        public List<OrdenPreparacion2> ObtenerOrdenes()
        {
            return OrdenPreparacion;
        }

        public List<OrdenPreparacion2> FiltrarOrdenesPorFecha(DateTime fecha)
        {
            return OrdenPreparacion.Where(o => o.FechaDespacho.Date == fecha.Date).ToList();
        }

        public OrdenSeleccion2 GenerarOrdenDeSeleccion(List<OrdenPreparacion2> ordenesSeleccionadas)
        {
            if (ordenesSeleccionadas == null || !ordenesSeleccionadas.Any())
            {
                throw new ArgumentException("Debes seleccionar al menos una orden de preparación.");
            }

            OrdenSeleccion2 nuevaSeleccion = new OrdenSeleccion2
            {
                numeroOrdenSeleccion = siguienteIdSeleccion++,
                FechaCreacion = DateTime.Now,
            };

  
            nuevaSeleccion.ordenes = ordenesSeleccionadas; 

            foreach (var orden in ordenesSeleccionadas)
            {
                OrdenPreparacion.Remove(orden);
            }

            // Retornar la nueva orden de selección
            return nuevaSeleccion;
        }
    }
}
