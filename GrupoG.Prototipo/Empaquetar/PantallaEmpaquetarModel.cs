using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Empaquetar
{
    internal class PantallaEmpaquetarModel
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; private set; } = new List<OrdenPreparacion>
        {
            new OrdenPreparacion
            {
                NumeroOrdenPreparacion = 1,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto X", cantidadMercaderia = 15 },
                    new Mercaderias { idMercaderia = 2, nombreMercaderia = "Producto Y", cantidadMercaderia = 20 }
                }
            },
            new OrdenPreparacion
            {
                NumeroOrdenPreparacion = 2,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 3, nombreMercaderia = "Producto Z", cantidadMercaderia = 10 },
                    new Mercaderias { idMercaderia = 4, nombreMercaderia = "Producto W", cantidadMercaderia = 5 }
                }
            }
        };

        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            return OrdenesPreparacion;
        }

        public void RemoverOrdenPreparacion(OrdenPreparacion orden)
        {
            OrdenesPreparacion.Remove(orden);
        }

        public List<Mercaderias> ObtenerMercaderiasPorOrden(int index)
        {
            if (index >= 0 && index < OrdenesPreparacion.Count)
            {
                return OrdenesPreparacion[index].Mercaderias;
            }
            return new List<Mercaderias>();
        }
    }
}
