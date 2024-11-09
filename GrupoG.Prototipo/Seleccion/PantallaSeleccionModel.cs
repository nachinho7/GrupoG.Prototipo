using GrupoG.Prototipo.Almacenes;
using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenSeleccion;
using GrupoG.Prototipo.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace GrupoG.Prototipo.Seleccion
{
    internal class PantallaSeleccionModel
    {


        public List<OrdenPreparacion> ObtenerOrdenPreparacion()
        {
            if (OrdenPreparacionAlmacen.OrdenPreparacion == null || !OrdenPreparacionAlmacen.OrdenPreparacion.Any())
            {
                MessageBox.Show("No se encontraron ordenes de preparacion.");
            }

            var ordenesPreparacion = OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(op => op.Estado == OrdenPreparacionEstados.Pendiente)
                .Select(op => new OrdenPreparacion
                {
                    NumeroOrdenPreparacion = op.NumeroOrdenPreparacion,
                    NroCliente = op.NroCliente,
                    FechaDespacho = op.FechaDespacho,
                    DNITransportista = op.DNITransportista,
                })
                .ToList();

            return ordenesPreparacion;

        }

        public List<int> ObtenerClientesDisponibles()
        {
            if (OrdenPreparacionAlmacen.OrdenPreparacion == null || !OrdenPreparacionAlmacen.OrdenPreparacion.Any())
            {
                MessageBox.Show("No se encontraron ordenes de preparacion.");
                return new List<int>();
            }

            var clientesDisponibles = OrdenPreparacionAlmacen.OrdenPreparacion
                .Select(op => op.NroCliente)
                .Distinct()
                .ToList();

            return clientesDisponibles;
        }

        public List<int> ObtenerTransportistasDisponibles()
        {
            if (OrdenPreparacionAlmacen.OrdenPreparacion == null || !OrdenPreparacionAlmacen.OrdenPreparacion.Any())
            {
                MessageBox.Show("No se encontraron ordenes de preparacion.");
                return new List<int>();
            }

            var transportistasDisponibles = OrdenPreparacionAlmacen.OrdenPreparacion
                .Select(op => op.DNITransportista)
                .Distinct()
                .ToList();

            return transportistasDisponibles;
        }

        public List<OrdenPreparacion> FiltrarOrdenesPorClienteYFechaYTransportista(int? numeroCliente, DateTime? fecha, int? dniTransportista)
        {
            var todasOrdenes = ObtenerOrdenPreparacion();

            if (todasOrdenes == null || !todasOrdenes.Any())
            {
                MessageBox.Show("No se encontraron órdenes de preparación.");
                return new List<OrdenPreparacion>();
            }

            return todasOrdenes
                .Where(o => (!numeroCliente.HasValue || o.NroCliente == numeroCliente.Value)
                            && (!fecha.HasValue || o.FechaDespacho.Date == fecha.Value.Date)
                            && (!dniTransportista.HasValue || o.DNITransportista == dniTransportista.Value))
                .ToList();
        }

        public static int SumaNumOrden()
        {
            int sumaNumOrden = (OrdenSeleccionAlmacen.OrdenSeleccion.Any() ? OrdenSeleccionAlmacen.OrdenSeleccion.Max(o => o.numeroOrdenSeleccion) : 0) + 1;
            return sumaNumOrden;
        }

        public OrdenSeleccionEntidad CrearOrdenSeleccion(List<OrdenPreparacion> listaOrdenesPreparacion)
        {
            int nroOrdenSeleccion = SumaNumOrden();
            var estadoOrdenSeleccion = OrdenSeleccionEstados.Seleccionada;

            var idsOrdenesPreparacion = new List<int>();

            foreach (var ordenPreparacion in listaOrdenesPreparacion)
            {
                var ordenEntidadExistente = OrdenPreparacionAlmacen.OrdenPreparacion
                    .FirstOrDefault(op => op.NumeroOrdenPreparacion == ordenPreparacion.NumeroOrdenPreparacion);

                if (ordenEntidadExistente != null)
                {
                    ordenEntidadExistente.Estado = OrdenPreparacionEstados.Seleccionada;

                    idsOrdenesPreparacion.Add(ordenEntidadExistente.NumeroOrdenPreparacion);
                }
            }

            var nuevaOrdenSeleccion = new OrdenSeleccionEntidad
            {
                numeroOrdenSeleccion = nroOrdenSeleccion,
                FechaCreacion = DateTime.Now,
                Estado = estadoOrdenSeleccion,
                OrdenPreparacion = idsOrdenesPreparacion 
            };

            OrdenSeleccionAlmacen.AgregarOrdenSeleccion(nuevaOrdenSeleccion);

            return nuevaOrdenSeleccion;
        }


    }
}
