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
                        new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto A", cantidadMercaderia = 10, ubicacionMercaderia = 101 },
                        new Mercaderias { idMercaderia = 2, nombreMercaderia = "Producto B", cantidadMercaderia = 5, ubicacionMercaderia = 102 }
                    }
                },
                new OrdenSeleccion
                {
                    numeroOrdenSeleccion = 2,
                    FechaCreacion = DateTime.Now,
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 3, nombreMercaderia = "Producto C", cantidadMercaderia = 8, ubicacionMercaderia = 103 },
                        new Mercaderias { idMercaderia = 4, nombreMercaderia = "Producto D", cantidadMercaderia = 12, ubicacionMercaderia = 104 }
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
    }
}
