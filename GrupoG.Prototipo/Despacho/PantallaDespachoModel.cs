using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Despacho
{
    internal class PantallaDespachoModel
    {
        public List<OrdenPreparacion> OrdenPreparacion { get; private set; } = new List<OrdenPreparacion>
        {
            new OrdenPreparacion{ NumeroOrdenPreparacion = 1, NroCliente = 1234, DNITransportista = 12345678},
            new OrdenPreparacion{ NumeroOrdenPreparacion = 2, NroCliente = 1234, DNITransportista = 12345678},
            new OrdenPreparacion{ NumeroOrdenPreparacion = 3, NroCliente = 5678, DNITransportista = 1234567},
            new OrdenPreparacion{ NumeroOrdenPreparacion = 4, NroCliente = 2045, DNITransportista = 12345679},
            new OrdenPreparacion{ NumeroOrdenPreparacion = 5, NroCliente = 2045, DNITransportista = 12345679},
            new OrdenPreparacion{ NumeroOrdenPreparacion = 6, NroCliente = 1224, DNITransportista = 12345671},
        };

        public List<OrdenPreparacion> ObtenerOrdenesPorDni(int dniTransportista)
        {
            var ordenesFiltradas = OrdenPreparacion.Where(o => o.DNITransportista == dniTransportista).ToList();
            return ordenesFiltradas;
        }

        public Remito GenerarRemito(int dniTransportista, List<OrdenPreparacion> ordenes)
        {
            Remito nuevoRemito = new Remito
            {
                NumeroRemito = OrdenPreparacion.Count + 1,
                NroCliente = ordenes.First().NroCliente,
                DNITransportista = dniTransportista
            };

            return nuevoRemito;
        }

        public void EliminarOrdenPorId(int NroOrdenPreparacion)
        {
            var ordenAEliminar = OrdenPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == NroOrdenPreparacion);
            if (ordenAEliminar != null)
            {
                OrdenPreparacion.Remove(ordenAEliminar);
            }
        }
        
    }
}
