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

        public List<(string Ubicacion, int CantidadUbicacion, int Id, string Nombre, int CantidadDetalle, OrdenSeleccionEntidad OrdenSeleccion, int numOrdenPreparacion)>
        ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var ordenSeleccionada = ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccionada);

            if (ordenSeleccionada == null) return null;

            var mercaderiasList = new List<(string Ubicacion, int CantidadUbicacion, int Id, string Nombre, int CantidadDetalle, OrdenSeleccionEntidad, int numOrdenPreparacion)>();

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
                                numeroOrdenPreparacion
                            ));
                        }
                    }
                }
            }

            return mercaderiasList;
        }


        public int RetiroStock(int idMercaderia, string ubicacion, int cantidadDetalle)
        {
            int cantidadRestante = cantidadDetalle; 

            var mercaderia = MercaderiasAlmacen.Mercaderias
                .FirstOrDefault(m => m.idMercaderia == idMercaderia && m.Ubicacion.Any(u => u.NombreUbicacion == ubicacion));

            if (mercaderia != null)
            {
                var ubicacionMercaderia = mercaderia.Ubicacion.First(u => u.NombreUbicacion == ubicacion);

                if (ubicacionMercaderia.Cantidad >= cantidadRestante)
                {
                    ubicacionMercaderia.Cantidad -= cantidadRestante; 
                    cantidadRestante = 0; 
                }
                else
                {
                    cantidadRestante -= ubicacionMercaderia.Cantidad; 
                    ubicacionMercaderia.Cantidad = 0;  

                    if (ubicacionMercaderia.Cantidad == 0)
                    {
                        MessageBox.Show($"La Ubicacion {ubicacion} se ha quedado sin stock, por favor selecciona otra ubicación para retirar lo faltante.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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
