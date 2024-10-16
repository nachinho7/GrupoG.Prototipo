using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Despacho
{
    internal class PantallaDespachoModel
    {
        public List<OrdenDespacho> OrdenDespacho { get; private set; } = new List<OrdenDespacho>
        {
            new OrdenDespacho{ IdDespacho = 1, NroCliente = 1234, Estado = "Empaquetado" },
            new OrdenDespacho{ IdDespacho = 2, NroCliente = 1234, Estado = "Empaquetado" },
            new OrdenDespacho{ IdDespacho = 3, NroCliente = 5678, Estado = "Empaquetado" },
            new OrdenDespacho{ IdDespacho = 4, NroCliente = 2045, Estado = "Empaquetado" },
            new OrdenDespacho{ IdDespacho = 5, NroCliente = 2045, Estado = "Empaquetado" },
            new OrdenDespacho{ IdDespacho = 6, NroCliente = 1224, Estado = "Empaquetado" },
        };

        public List<Transportistas> Transportistas { get; private set; } = new List<Transportistas>
        {
            new Transportistas
            {
                dniTransportista = 45013352,
                Clientes = new List<Clientes>
                {
                    new Clientes { NumeroCliente = 1234 }
                },
                habilitadoTransportista = true,
                patente = "AB098CC"
            },
            new Transportistas
            {
                dniTransportista = 45013353,
                Clientes = new List<Clientes>
                {
                    new Clientes { NumeroCliente = 4567 }
                },
                habilitadoTransportista = true,
                patente = "AA000BB"
            }
        };

        public List<OrdenDespacho> ObtenerOrdenesPorCliente(int numeroCliente)
        {
            var ordenesFiltradas = OrdenDespacho.Where(o => o.NroCliente == numeroCliente).ToList();
            return ordenesFiltradas;
        }

        public Transportistas ObtenerTransportistaPorDni(int dniTransportista)
        {
            var transportista = Transportistas.FirstOrDefault(t => t.dniTransportista == dniTransportista);
            return transportista;
        }

        public void EliminarOrdenPorId(int idDespacho)
        {
            var ordenAEliminar = OrdenDespacho.FirstOrDefault(o => o.IdDespacho == idDespacho);
            if (ordenAEliminar != null)
            {
                OrdenDespacho.Remove(ordenAEliminar);
            }
        }
    }
}
