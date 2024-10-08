using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Empaquetar
{
    internal class PantallaEmpaquetarModel
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; private set; }

        public PantallaEmpaquetarModel()
        {
            // Hardcode de órdenes de preparación
            OrdenesPreparacion = new List<OrdenPreparacion>
            {
                new OrdenPreparacion
                {
                    NumeroOrdenPreparacion = 1,
                    NumeroCliente = 101,
                    FechaDespacho = DateTime.Now.AddDays(2),
                    DNITransportista = 12345678,
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto X", cantidadMercaderia = 15 },
                        new Mercaderias { idMercaderia = 2, nombreMercaderia = "Producto Y", cantidadMercaderia = 20 }
                    }
                },
                new OrdenPreparacion
                {
                    NumeroOrdenPreparacion = 2,
                    NumeroCliente = 102,
                    FechaDespacho = DateTime.Now.AddDays(3),
                    DNITransportista = 87654321,
                    Mercaderias = new List<Mercaderias>
                    {
                        new Mercaderias { idMercaderia = 3, nombreMercaderia = "Producto Z", cantidadMercaderia = 10 },
                        new Mercaderias { idMercaderia = 4, nombreMercaderia = "Producto W", cantidadMercaderia = 5 }
                    }
                }
            };
        }

        // Obtener las órdenes de preparación
        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            return OrdenesPreparacion;
        }

        // Remover la orden empaquetada
        public void RemoverOrdenPreparacion(OrdenPreparacion orden)
        {
            OrdenesPreparacion.Remove(orden);
        }
    }
}
