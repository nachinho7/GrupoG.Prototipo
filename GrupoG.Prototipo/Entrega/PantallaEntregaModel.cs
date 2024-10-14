using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Entrega
{
    internal class PantallaEntregaModel
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; private set; } = new List<OrdenPreparacion>
        {
            new OrdenPreparacion
            {
                NumeroOrdenPreparacion = 1,
                NumeroCliente = 101,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { cantidadMercaderia = 15 },
                },
                DNITransportista = 12345678,
                FechaDespacho = DateTime.Now
                
            },
            new OrdenPreparacion
            {
                NumeroOrdenPreparacion = 2,
                NumeroCliente = 102,
                 Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { cantidadMercaderia = 20 },       
                },
                DNITransportista = 87654321,
                FechaDespacho = DateTime.Now
                  
            }
        };

        public List<OrdenPreparacion> ObtenerOrdenes()
        {
            return OrdenesPreparacion;
        }
    }
}
