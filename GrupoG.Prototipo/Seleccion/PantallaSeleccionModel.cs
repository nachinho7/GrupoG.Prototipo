using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Seleccion
{
    internal class PantallaSeleccionModel
    {
        public List<OrdenPreparacion> OrdenPreparacion { get; private set; } = new List<OrdenPreparacion>
        {
            new OrdenPreparacion { NumeroOrdenPreparacion = 1, NumeroCliente = 1001, FechaDespacho = DateTime.Now.AddDays(1) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 2, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 3, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(3) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 4, NumeroCliente = 1001, FechaDespacho = DateTime.Now.AddDays(1) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 5, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 6, NumeroCliente = 1003, FechaDespacho = DateTime.Now.AddDays(3) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 7, NumeroCliente = 1004, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 8, NumeroCliente = 1005, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 9, NumeroCliente = 1006, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 10, NumeroCliente = 1007, FechaDespacho = DateTime.Now.AddDays(7) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 11, NumeroCliente = 1008, FechaDespacho = DateTime.Now.AddDays(8) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 12, NumeroCliente = 1009, FechaDespacho = DateTime.Now.AddDays(9) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 13, NumeroCliente = 1010, FechaDespacho = DateTime.Now.AddDays(10) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 14, NumeroCliente = 1011, FechaDespacho = DateTime.Now.AddDays(9) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 15, NumeroCliente = 1012, FechaDespacho = DateTime.Now.AddDays(12) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 16, NumeroCliente = 1013, FechaDespacho = DateTime.Now.AddDays(13) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 17, NumeroCliente = 1014, FechaDespacho = DateTime.Now.AddDays(10) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 18, NumeroCliente = 1015, FechaDespacho = DateTime.Now.AddDays(2) },
            new OrdenPreparacion { NumeroOrdenPreparacion = 19, NumeroCliente = 1016, FechaDespacho = DateTime.Now.AddDays(2) },

        };

        private List<OrdenSeleccion> ordenesSeleccionadas = new List<OrdenSeleccion>();
        private int siguienteIdSeleccion = 1;

        public List<OrdenPreparacion> ObtenerOrdenes()
        {
            return OrdenPreparacion;
        }

        public List<OrdenPreparacion> FiltrarOrdenesPorFecha(DateTime fecha)
        {
            return OrdenPreparacion.Where(o => o.FechaDespacho.Date == fecha.Date).ToList();
        }

        public OrdenSeleccion GenerarOrdenDeSeleccion(List<OrdenPreparacion> ordenesSeleccionadas)
        {
            if (ordenesSeleccionadas == null || !ordenesSeleccionadas.Any())
            {
                throw new ArgumentException("Debes seleccionar al menos una orden de preparación.");
            }

            OrdenSeleccion nuevaSeleccion = new OrdenSeleccion
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
