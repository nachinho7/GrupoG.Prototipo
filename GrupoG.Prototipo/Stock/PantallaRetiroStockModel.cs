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

        public List<(int IdMercaderia, string NombreMercaderia, List<(string Ubicacion, int Cantidad)>)> ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var ordenSeleccionada = ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccionada);

            if (ordenSeleccionada == null) return null;

            var mercaderiasList = new List<(int IdMercaderia, string NombreMercaderia, int CantidadTotal)>();

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

                    var mercaderiaExistente = mercaderiasList
                        .FirstOrDefault(m => m.IdMercaderia == detalle.idMercaderia);

                    if (mercaderiaExistente.IdMercaderia != 0)
                    {
                        var index = mercaderiasList.IndexOf(mercaderiaExistente);
                        var mercaderiaActualizada = mercaderiasList[index];
                        mercaderiaActualizada.CantidadTotal += detalle.Cantidad;
                        mercaderiasList[index] = mercaderiaActualizada;
                    }
                    else
                    {
                        mercaderiasList.Add((
                            detalle.idMercaderia,
                            mercaderiaEntidad.nombreMercaderia,
                            detalle.Cantidad
                        ));
                    }
                }
            }

            var mercaderiasConUbicaciones = new List<(int IdMercaderia, string NombreMercaderia, List<(string Ubicacion, int Cantidad)>)>();

            foreach (var mercaderia in mercaderiasList)
            {
                var mercaderiaEntidad = MercaderiasAlmacen.Mercaderias
                    .FirstOrDefault(m => m.idMercaderia == mercaderia.IdMercaderia);

                if (mercaderiaEntidad == null) continue;

                var ubicacionesNecesarias = new List<(string Ubicacion, int Cantidad)>();
                int cantidadPendiente = mercaderia.CantidadTotal;

                foreach (var ubicacion in mercaderiaEntidad.Ubicacion)
                {
                    if (cantidadPendiente <= 0) break;

                    
                    int cantidadARetirar = Math.Min(ubicacion.Cantidad, cantidadPendiente);

                    if (cantidadARetirar > 0)
                    {
                        ubicacionesNecesarias.Add((ubicacion.NombreUbicacion, cantidadARetirar));
                        cantidadPendiente -= cantidadARetirar;  
                    }

                    if (cantidadPendiente == 0) break; 
                }

                if (ubicacionesNecesarias.Any())
                {
                    mercaderiasConUbicaciones.Add((
                        mercaderia.IdMercaderia,
                        mercaderia.NombreMercaderia,
                        ubicacionesNecesarias
                    ));
                }
            }

            return mercaderiasConUbicaciones;
        }


        public int? ObtenerDepositoPorOrden(int numeroOrdenSeleccion)
        {
            var ordenSeleccionada = ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccion);

            if (ordenSeleccionada == null) return null;

            foreach (var numeroOrdenPreparacion in ordenSeleccionada.OrdenPreparacion)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.OrdenPreparacion
                    .FirstOrDefault(op => op.NumeroOrdenPreparacion == numeroOrdenPreparacion);

                if (ordenPreparacion != null)
                {
                    return ordenPreparacion.NroCliente; 
                }
            }

            return null;
        }





        public int RetiroStock(int idMercaderia, List<(string Ubicacion, int Cantidad)> ubicaciones, int cantidadTotalRetirar)
        {
            int cantidadRestante = cantidadTotalRetirar; 

            foreach (var (ubicacion, cantidadDisponible) in ubicaciones)
            {
                var mercaderia = MercaderiasAlmacen.Mercaderias
                    .FirstOrDefault(m => m.idMercaderia == idMercaderia);

                if (mercaderia == null) continue; 

                var ubicacionMercaderia = mercaderia.Ubicacion
                    .FirstOrDefault(u => u.NombreUbicacion == ubicacion);

                if (ubicacionMercaderia == null) continue; 

               
                int cantidadARetirar = Math.Min(cantidadRestante, ubicacionMercaderia.Cantidad);

                if (cantidadARetirar > 0)
                {
              
                    ubicacionMercaderia.Cantidad -= cantidadARetirar;

                    
                    cantidadRestante -= cantidadARetirar;
                }

                if (cantidadRestante == 0) break; 
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
