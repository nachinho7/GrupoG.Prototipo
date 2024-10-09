using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Stock
{
    internal class PantallaRetiroStockModel
    {
        public List<OrdenSeleccion> OrdenesSeleccionadas { get; private set; }

        public PantallaRetiroStockModel()
        {
            // Aquí están los datos hardcodeados
            OrdenesSeleccionadas = new List<OrdenSeleccion>
            {
                new OrdenSeleccion
                {
                    numeroOrdenSeleccion = 1, // Corregido en minúscula
                    FechaCreacion = DateTime.Now,
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto A", cantidadMercaderia = 10, ubicacionMercaderia = 101 },
                        new Mercaderias { idMercaderia = 2, nombreMercaderia = "Producto B", cantidadMercaderia = 5, ubicacionMercaderia = 102 }
                    }
                },
                new OrdenSeleccion
                {
                    numeroOrdenSeleccion = 2, // Corregido en minúscula
                    FechaCreacion = DateTime.Now,
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 3, nombreMercaderia = "Producto C", cantidadMercaderia = 8, ubicacionMercaderia = 103 },
                        new Mercaderias { idMercaderia = 4, nombreMercaderia = "Producto D", cantidadMercaderia = 12, ubicacionMercaderia = 104 }
                    }
                }
            };
        }

        // Método para obtener las órdenes
        public List<OrdenSeleccion> ObtenerOrdenesSeleccionadas()
        {
            return OrdenesSeleccionadas;
        }

        // Método para remover una orden
        public void RemoverOrdenSeleccionada(OrdenSeleccion orden)
        {
            OrdenesSeleccionadas.Remove(orden);
        }

        // Método para remover una mercadería específica de una orden
        public void RemoverMercaderiaDeOrden(OrdenSeleccion orden, Mercaderias mercaderia)
        {
            orden.Mercaderias.Remove(mercaderia);
        }
    }
}
