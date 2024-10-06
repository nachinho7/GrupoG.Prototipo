using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Preparacion
{
    internal class PantallaPreparacionModel
    {
        public List<Clientes> Clientes { get; private set; } = new List<Clientes>
        {
            new Clientes
            {
                NumeroCliente = 2045,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { id = 1, nombreMercaderia = "Botellas", descripcionMercaderia = "Plástico", cantidadMercaderia = 2 },
                    new Mercaderias { id = 2, nombreMercaderia = "Vasos", descripcionMercaderia = "Plástico", cantidadMercaderia = 500 }
                }
            },
            new Clientes
            {
                NumeroCliente = 3080,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { id = 2, nombreMercaderia = "Pelotas", descripcionMercaderia = "Goma", cantidadMercaderia = 10 }
                }
            },
            new Clientes
            {
                NumeroCliente = 1224,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { id = 3, nombreMercaderia = "Aceites", descripcionMercaderia = "Comida", cantidadMercaderia = 30 }

                }
            },
        };

        public List<Mercaderias> ObtenerMercaderiaPorCliente(int numeroCliente)
        {
            var cliente = Clientes.FirstOrDefault(c => c.NumeroCliente == numeroCliente);
            return cliente?.Mercaderias ?? new List<Mercaderias>();
        }
    }
}