using GrupoG.Prototipo.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                FechaDespacho = DateTime.Now.AddDays(2),
                DNITransportista = 12345678,
            },
            new OrdenPreparacion
            {
                NumeroOrdenPreparacion = 2,
                NumeroCliente = 102,
                FechaDespacho = DateTime.Now.AddDays(3),
                DNITransportista = 87654321,
            }
        };

        public List<OrdenPreparacion> ObtenerOrdenes()
        {
            return OrdenesPreparacion;
        }
    }
}