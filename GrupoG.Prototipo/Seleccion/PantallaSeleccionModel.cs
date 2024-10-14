using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Seleccion
{
    internal class PantallaSeleccionModel
    {
        // Inicializamos la lista de órdenes de preparación
        public List<OrdenPreparacion> OrdenPreparacion { get; private set; } = new List<OrdenPreparacion>
        {
            new OrdenPreparacion { NumeroOrdenPreparacion = 1, NumeroCliente = 1001, FechaDespacho = DateTime.Now.AddDays(1), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 2, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(2), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 3, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(3), DNITransportista = 1238513 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 4, NumeroCliente = 1001, FechaDespacho = DateTime.Now.AddDays(1), DNITransportista = 2421411 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 5, NumeroCliente = 1002, FechaDespacho = DateTime.Now.AddDays(2), DNITransportista = 46364364 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 6, NumeroCliente = 1003, FechaDespacho = DateTime.Now.AddDays(3), DNITransportista = 4643636 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 7, NumeroCliente = 1004, FechaDespacho = DateTime.Now.AddDays(2), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 8, NumeroCliente = 1005, FechaDespacho = DateTime.Now.AddDays(2), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 9, NumeroCliente = 1006, FechaDespacho = DateTime.Now.AddDays(2), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 10, NumeroCliente = 1007, FechaDespacho = DateTime.Now.AddDays(7), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 11, NumeroCliente = 1008, FechaDespacho = DateTime.Now.AddDays(8), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 12, NumeroCliente = 1009, FechaDespacho = DateTime.Now.AddDays(9), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 13, NumeroCliente = 1010, FechaDespacho = DateTime.Now.AddDays(10), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 14, NumeroCliente = 1011, FechaDespacho = DateTime.Now.AddDays(9), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 15, NumeroCliente = 1012, FechaDespacho = DateTime.Now.AddDays(12), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 16, NumeroCliente = 1013, FechaDespacho = DateTime.Now.AddDays(13), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 17, NumeroCliente = 1014, FechaDespacho = DateTime.Now.AddDays(10), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 18, NumeroCliente = 1015, FechaDespacho = DateTime.Now.AddDays(2), DNITransportista = 1238128 },
            new OrdenPreparacion { NumeroOrdenPreparacion = 19, NumeroCliente = 1016, FechaDespacho = DateTime.Now.AddDays(2), DNITransportista = 1238128 },
        };

        private List<OrdenSeleccion> ordenesSeleccionadas = new List<OrdenSeleccion>();
        private int siguienteIdSeleccion = 1;

        public List<OrdenSeleccion> OrdenesSeleccionadas => ordenesSeleccionadas;

        public List<OrdenPreparacion> ObtenerOrdenes()
        {
            var ordenesEnSeleccion = ordenesSeleccionadas
                .SelectMany(os => os.ordenes) 
                .Select(o => o.NumeroOrdenPreparacion)
                .ToList();

            // Filtrar las órdenes que no están seleccionadas
            return OrdenPreparacion.Where(o => !ordenesEnSeleccion.Contains(o.NumeroOrdenPreparacion)).ToList();
        }

        public List<int> ObtenerClientesDisponibles()
        {
            var ordenesSeleccionadasActuales = ordenesSeleccionadas
                .SelectMany(os => os.ordenes);

            return OrdenPreparacion
                .Where(o => !ordenesSeleccionadasActuales.Select(sel => sel.NumeroOrdenPreparacion).Contains(o.NumeroOrdenPreparacion))
                .Select(o => o.NumeroCliente)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }


        public List<OrdenPreparacion> FiltrarOrdenesPorClienteYFecha(int? numeroCliente, DateTime fecha)
        {
            var ordenesEnSeleccion = ordenesSeleccionadas
                .SelectMany(os => os.ordenes)
                .Select(o => o.NumeroOrdenPreparacion)
                .ToList();

            return OrdenPreparacion
                .Where(o => (!numeroCliente.HasValue || o.NumeroCliente == numeroCliente.Value)
                             && o.FechaDespacho.Date == fecha.Date
                             && !ordenesEnSeleccion.Contains(o.NumeroOrdenPreparacion))
                .ToList();
        }

        public OrdenSeleccion GenerarOrdenDeSeleccion(List<OrdenPreparacion> ordenes)
        {
            var nuevaSeleccion = new OrdenSeleccion
            {
                numeroOrdenSeleccion = siguienteIdSeleccion++,
                FechaCreacion = DateTime.Now,
                ordenes = ordenes 
            };
            ordenesSeleccionadas.Add(nuevaSeleccion);
            return nuevaSeleccion;
        }
    }
}
