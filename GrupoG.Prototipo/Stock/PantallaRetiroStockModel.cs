using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Stock
{
    internal class PantallaRetiroStockModel
    {
        public List<OrdenSeleccion> OrdenesSeleccionadas { get; private set; }

        public PantallaRetiroStockModel()
        {
            OrdenesSeleccionadas = new List<OrdenSeleccion>
            {
                new OrdenSeleccion
                {
                    numeroOrdenSeleccion = 1,
                    FechaCreacion = DateTime.Now,
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto A", cantidadMercaderia = 10, ubicacionesMercaderia = new List<string> { "3-6-6", "200-3-4" } },
                        new Mercaderias { idMercaderia = 2, nombreMercaderia = "Producto B", cantidadMercaderia = 5, ubicacionesMercaderia = new List<string> { "12-1-2", "400-30-100" } }
                    }
                },
                new OrdenSeleccion
                {
                    numeroOrdenSeleccion = 2,
                    FechaCreacion = DateTime.Now,
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 3, nombreMercaderia = "Producto C", cantidadMercaderia = 8, ubicacionesMercaderia = new List<string> { "103-43-23" } },
                        new Mercaderias { idMercaderia = 4, nombreMercaderia = "Producto D", cantidadMercaderia = 12, ubicacionesMercaderia = new List<string> { "2-5-6", "300-45-3", "1-100-2" } }
                    }
                }
            };
        }

        public List<OrdenSeleccion> ObtenerOrdenesSeleccionadas()
        {
            return OrdenesSeleccionadas;
        }

        public void RemoverOrdenSeleccionada(OrdenSeleccion orden)
        {
            OrdenesSeleccionadas.Remove(orden);
        }

        public void RemoverMercaderiaDeOrden(OrdenSeleccion orden, Mercaderias mercaderia)
        {
            orden.Mercaderias.Remove(mercaderia);
        }
    }
}
