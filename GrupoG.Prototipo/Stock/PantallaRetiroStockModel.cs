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

        public List<(int Id, string Nombre, int CantidadTotal, List<(string Ubicacion, int Cantidad)>)> ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var ordenSeleccionada = ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccionada);

            if (ordenSeleccionada == null) return null;

            var mercaderiasList = new List<(int Id, string Nombre, int CantidadTotal, List<(string Ubicacion, int Cantidad)>)>();

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
                        int cantidadTotal = ordenPreparacion.Detalle
                            .Where(d => d.idMercaderia == detalle.idMercaderia)
                            .Sum(d => d.Cantidad);

                        var ubicacionesNecesarias = new List<(string Ubicacion, int Cantidad)>();
                        int cantidadPendiente = cantidadTotal;

                        foreach (var ubicacion in mercaderiaEntidad.Ubicacion)
                        {
                            if (cantidadPendiente <= 0) break;

                            int cantidadRetirar = Math.Min(ubicacion.Cantidad, cantidadPendiente);
                            ubicacionesNecesarias.Add((ubicacion.NombreUbicacion, cantidadRetirar));
                            cantidadPendiente -= cantidadRetirar;
                        }

                        mercaderiasList.Add((
                            mercaderiaEntidad.idMercaderia,
                            mercaderiaEntidad.nombreMercaderia,
                            cantidadTotal,
                            ubicacionesNecesarias
                        ));
                    }
                }
            }

            return mercaderiasList;
        }



        public int RetiroStock(int idMercaderia, List<(string Ubicacion, int Cantidad)> ubicaciones, int cantidadTotalRetirar)
        {
            int cantidadRestante = cantidadTotalRetirar;

            foreach (var (ubicacion, cantidadDisponible) in ubicaciones)
            {
                var mercaderia = MercaderiasAlmacen.Mercaderias
                    .FirstOrDefault(m => m.idMercaderia == idMercaderia &&
                                         m.Ubicacion.Any(u => u.NombreUbicacion == ubicacion));

                if (mercaderia == null) continue;

                var ubicacionMercaderia = mercaderia.Ubicacion.First(u => u.NombreUbicacion == ubicacion);

                if (ubicacionMercaderia.Cantidad >= cantidadRestante)
                {
                    ubicacionMercaderia.Cantidad -= cantidadRestante;
                    cantidadRestante = 0;
                    break; // Salimos del bucle si ya retiramos toda la cantidad requerida
                }
                else
                {
                    cantidadRestante -= ubicacionMercaderia.Cantidad;
                    ubicacionMercaderia.Cantidad = 0; // Agotamos esta ubicación
                }
            }

            if (cantidadRestante > 0)
            {
                MessageBox.Show("No se pudo retirar toda la cantidad solicitada. Verifique las ubicaciones de stock.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return cantidadRestante;
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
            MercaderiasAlmacen.Grabar();
        }


    }
}
