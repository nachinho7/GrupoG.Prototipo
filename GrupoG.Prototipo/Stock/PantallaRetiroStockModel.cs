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

        public List<(string Ubicacion, int Id, string Nombre, int Cantidad, OrdenSeleccionEntidad OrdenSeleccion, OrdenPreparacionEntidad OrdenPreparacion)>
        ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var ordenSeleccionada = ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccionada);

            if (ordenSeleccionada == null) return null;

            var mercaderiasList = new List<(string Ubicacion, int Id, string Nombre, int Cantidad, OrdenSeleccionEntidad, OrdenPreparacionEntidad)>();

            foreach (var ordenPreparacion in ordenSeleccionada.OrdenPreparacion)
            {
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


        public void RetiroStock(OrdenSeleccionEntidad ordenSeleccionada, List<(MercaderiasEntidad mercaderia, int cantidadARetirar, string ubicacionSeleccionada)> mercaderiasARetirar)
        {
            var mercaderiasSeleccionadas = new List<(int idMercaderia, string ubicacion)>();

            foreach (var (mercaderiaEntidad, cantidadARetirar, ubicacionSeleccionada) in mercaderiasARetirar)
            {
                var mercaderiaExistente = mercaderiasSeleccionadas.FirstOrDefault(m => m.idMercaderia == mercaderiaEntidad.idMercaderia);

                if (mercaderiaExistente != default && mercaderiaExistente.ubicacion != ubicacionSeleccionada)
                {
                    MessageBox.Show($"Solo se puede seleccionar una ubicación por mercadería por orden de preparación.");
                    return;
                }

                mercaderiasSeleccionadas.Add((mercaderiaEntidad.idMercaderia, ubicacionSeleccionada));

                var ubicacionesRelacionadas = mercaderiaEntidad.Ubicacion
                    .Where(u => u.NombreUbicacion == ubicacionSeleccionada && u.idMercaderia == mercaderiaEntidad.idMercaderia)
                    .ToList();

                int cantidadRestante = cantidadARetirar;

                foreach (var ubicacion in ubicacionesRelacionadas)
                {
                    if (ubicacion.Cantidad >= cantidadRestante)
                    {
                        MercaderiasAlmacen.CambiarCantidad(ubicacion, cantidadRestante);

                        if (ubicacion.Cantidad == 0)
                        {
                            mercaderiaEntidad.Ubicacion.Remove(ubicacion);
                        }
                        break;
                    }
                    else
                    {
                        MercaderiasAlmacen.CambiarCantidad(ubicacion, ubicacion.Cantidad);

                        cantidadRestante -= ubicacion.Cantidad;

                        mercaderiaEntidad.Ubicacion.Remove(ubicacion);
                    }
                }
            }

            if (mercaderiasARetirar.All(m => m.cantidadARetirar == 0))
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
