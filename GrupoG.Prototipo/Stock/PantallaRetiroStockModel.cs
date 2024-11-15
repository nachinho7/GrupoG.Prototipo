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

        public List<(int IdMercaderia, string NombreMercaderia, int CantidadTotal, List<(string Ubicacion, int Cantidad)>)> ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var ordenSeleccionada = ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccionada);

            if (ordenSeleccionada == null) return null;

            var mercaderiasList = new List<(int IdMercaderia, string NombreMercaderia, int CantidadTotal, List<(string Ubicacion, int Cantidad)>)>();

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

                    if (mercaderiaEntidad == null) continue;

                    int cantidadTotal = ordenPreparacion.Detalle
                        .Where(d => d.idMercaderia == detalle.idMercaderia)
                        .Sum(d => d.Cantidad);

                    var ubicacionesNecesarias = new List<(string Ubicacion, int Cantidad)>();
                    int cantidadPendiente = cantidadTotal;

                    // Loop over the locations and allocate quantities for withdrawal
                    foreach (var ubicacion in mercaderiaEntidad.Ubicacion)
                    {
                        if (cantidadPendiente <= 0) break;

                        int cantidadARetirar = Math.Min(ubicacion.Cantidad, cantidadPendiente);

                        if (cantidadARetirar > 0)
                        {
                            ubicacionesNecesarias.Add((ubicacion.NombreUbicacion, cantidadARetirar));
                            cantidadPendiente -= cantidadARetirar;
                        }
                    }

                    mercaderiasList.Add((
                        mercaderiaEntidad.idMercaderia,
                        mercaderiaEntidad.nombreMercaderia,
                        cantidadTotal,
                        ubicacionesNecesarias
                    ));
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
                    .FirstOrDefault(m => m.idMercaderia == idMercaderia);

                if (mercaderia == null) continue;

                var ubicacionMercaderia = mercaderia.Ubicacion.FirstOrDefault(u => u.NombreUbicacion == ubicacion);

                if (ubicacionMercaderia == null) continue;

                int cantidadARetirar = Math.Min(cantidadRestante, ubicacionMercaderia.Cantidad);

                ubicacionMercaderia.Cantidad -= cantidadARetirar;

                cantidadRestante -= cantidadARetirar;

                if (cantidadRestante == 0)
                    break;
            }

            if (cantidadRestante > 0)
            {
                MessageBox.Show($"No se pudo retirar toda la cantidad solicitada para la mercadería ID {idMercaderia}. " +
                                $"Cantidad restante: {cantidadRestante}.",
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
