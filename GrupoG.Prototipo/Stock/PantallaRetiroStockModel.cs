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

        public List<MercaderiasEntidad> ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var ordenSeleccionada = ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccionada);

            if (ordenSeleccionada == null) return null;

            var mercaderiasList = new List<MercaderiasEntidad>();

            foreach (var ordenPreparacion in ordenSeleccionada.OrdenPreparacion)
            {
                foreach (var detalle in ordenPreparacion.Detalle)
                {
                    var mercaderiaEntidad = MercaderiasAlmacen.Mercaderias
                        .FirstOrDefault(m => m.idMercaderia == detalle.idMercaderia);

                    if (mercaderiaEntidad != null)
                    {
                        var mercaderiaConUbicaciones = new MercaderiasEntidad
                        {
                            idMercaderia = mercaderiaEntidad.idMercaderia,
                            nombreMercaderia = mercaderiaEntidad.nombreMercaderia,
                            NroCliente = mercaderiaEntidad.NroCliente,
                            Ubicacion = mercaderiaEntidad.Ubicacion
                                .GroupBy(u => u.NombreUbicacion)
                                .Select(grupo => new MercaderiasUbicacion
                                {
                                    NombreUbicacion = grupo.Key,
                                    Cantidad = grupo.Sum(u => u.Cantidad),
                                    NroDeposito = grupo.First().NroDeposito,
                                    idMercaderia = detalle.idMercaderia
                                })
                                .ToList()
                        };

                        mercaderiasList.Add(mercaderiaConUbicaciones);
                    }
                }
            }

            return mercaderiasList;
        }

        public void RetiroStock(OrdenSeleccionEntidad ordenSeleccionada, List<Mercaderias> mercaderiasARetirar)
        {
            foreach (var mercaderia in mercaderiasARetirar)
            {
                var mercaderiaEntidad = MercaderiasAlmacen.Mercaderias
                    .FirstOrDefault(m => m.idMercaderia == mercaderia.idMercaderia);

                if (mercaderiaEntidad != null)
                {
                    foreach (var ubicacion in mercaderiaEntidad.Ubicacion)
                    {
                        if (ubicacion.Cantidad >= mercaderia.cantidadMercaderia)
                        {
                            ubicacion.Cantidad -= mercaderia.cantidadMercaderia;
                            break;
                        }
                    }
                }
            }

            if (ordenSeleccionada.OrdenPreparacion.All(op => op.Detalle.All(d => d.Cantidad == 0)))
            {
                OrdenSeleccionAlmacen.ModificarEstado(ordenSeleccionada, OrdenSeleccionEstados.Cumplida);
                foreach (var ordenPreparacion in ordenSeleccionada.OrdenPreparacion)
                {
                    OrdenPreparacionAlmacen.ModificarEstado(ordenPreparacion, OrdenPreparacionEstados.Cumplida);
                }
            }
        }
    }
}
