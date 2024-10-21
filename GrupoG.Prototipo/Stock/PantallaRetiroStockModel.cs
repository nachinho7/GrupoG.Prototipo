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
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto A", cantidadMercaderia = 10, ubicacionMercaderia = "3-6-6" },
                        new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto A", cantidadMercaderia = 2, ubicacionMercaderia = "4-8-6" },
                        new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto A", cantidadMercaderia = 9, ubicacionMercaderia = "1-2-3" },
                        new Mercaderias { idMercaderia = 2, nombreMercaderia = "Producto B", cantidadMercaderia = 5, ubicacionMercaderia = "12-1-2" },
                        new Mercaderias { idMercaderia = 2, nombreMercaderia = "Producto B", cantidadMercaderia = 5, ubicacionMercaderia = "12-1-3" },
                        new Mercaderias { idMercaderia = 2, nombreMercaderia = "Producto C", cantidadMercaderia = 5, ubicacionMercaderia = "12-2-2" }
                    }
                },
                new OrdenSeleccion
                {
                    numeroOrdenSeleccion = 2,
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 3, nombreMercaderia = "Producto C", cantidadMercaderia = 8, ubicacionMercaderia = "103-43-23" },
                        new Mercaderias { idMercaderia = 4, nombreMercaderia = "Producto D", cantidadMercaderia = 12, ubicacionMercaderia = "2-5-6" } 
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
