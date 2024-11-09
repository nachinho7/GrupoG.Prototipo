using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenSeleccion;
using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Stock
{
    internal class PantallaRetiroStockModel
    {
        public List<OrdenSeleccionEntidad> ObtenerOrdenesSeleccion()
        {
            return OrdenSeleccionAlmacen.OrdenSeleccion
                .Where(o => o.Estado == OrdenSeleccionEstados.Seleccionada)
                .ToList();
        }

        public List<(string Ubicacion, int CantidadUbicacion, int Id, string Nombre, int CantidadDetalle, OrdenSeleccionEntidad OrdenSeleccion, OrdenPreparacionEntidad OrdenPreparacion)>
        ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var ordenSeleccionada = ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccionada);

            if (ordenSeleccionada == null) return null;

            var mercaderiasList = new List<(string Ubicacion, int CantidadUbicacion, int Id, string Nombre, int CantidadDetalle, OrdenSeleccionEntidad, OrdenPreparacionEntidad)>();

            foreach (var numeroOrdenPreparacion in ordenSeleccionada.OrdenPreparacion)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.OrdenPreparacion
                    .FirstOrDefault(op => op.NumeroOrdenPreparacion == numeroOrdenPreparacion);

                if (ordenPreparacion == null || ordenPreparacion.Estado != OrdenPreparacionEstados.Seleccionada)
                    continue;

                foreach (var detalle in ordenPreparacion.Detalle)
                {
                    var mercaderiaEntidad = MercaderiasAlmacen.Mercaderias
                        .FirstOrDefault(m => m.idMercaderia == detalle.idMercaderia);

                    if (mercaderiaEntidad != null)
                    {
                        foreach (var ubicacion in mercaderiaEntidad.Ubicacion)
                        {
                            mercaderiasList.Add((
                                ubicacion.NombreUbicacion,
                                ubicacion.Cantidad,
                                mercaderiaEntidad.idMercaderia,
                                mercaderiaEntidad.nombreMercaderia,
                                detalle.Cantidad,
                                ordenSeleccionada,
                                ordenPreparacion
                            ));
                        }
                    }
                }
            }

            return mercaderiasList;
        }


        public void RetiroStock(int idMercaderia, string ubicacion, int cantidadDetalle)
        {
            var mercaderia = MercaderiasAlmacen.Mercaderias
                .FirstOrDefault(m => m.idMercaderia == idMercaderia && m.Ubicacion.Any(u => u.NombreUbicacion == ubicacion));

            if (mercaderia != null)
            {
                var ubicacionMercaderia = mercaderia.Ubicacion.First(u => u.NombreUbicacion == ubicacion);
                ubicacionMercaderia.Cantidad -= cantidadDetalle;
            }
        }

        public void ActualizarEstadoOrdenSeleccionCumplida(int numeroOrdenSeleccion)
        {
            var ordenSeleccion = OrdenSeleccionAlmacen.OrdenSeleccion
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccion);

            if (ordenSeleccion != null)
            {
                ordenSeleccion.Estado = OrdenSeleccionEstados.Cumplida;

                foreach (var numeroOrdenPreparacion in ordenSeleccion.OrdenPreparacion)
                {
                    var ordenPreparacionAlmacen = OrdenPreparacionAlmacen.OrdenPreparacion
                        .FirstOrDefault(op => op.NumeroOrdenPreparacion == numeroOrdenPreparacion);

                    if (ordenPreparacionAlmacen != null)
                    {
                        ordenPreparacionAlmacen.Estado = OrdenPreparacionEstados.Cumplida;
                    }
                }
            }
        }


    }
}
