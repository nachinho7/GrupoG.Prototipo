using System;
using System.Collections.Generic;
using System.Linq;
using GrupoG.Prototipo.Almacenes;
using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Almacenes.Remito;

namespace GrupoG.Prototipo.Despacho
{
    internal class PantallaDespachoModel
    {
        public List<ClientesEntidad> ObtenerClientesPorDni(int dniTransportista)
        {
            var clientesFiltrados = ClientesAlmacen.Clientes
                .Where(c => c.Transportistas.Any(t => t.DNITransportista == dniTransportista))
                .ToList();
            return clientesFiltrados;
        }


        public List<OrdenPreparacionEntidad> ObtenerOrdenesPorDni(int nroCliente, int dnitransportista)
        {
            var ordenesFiltradas = OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => o.NroCliente == nroCliente && o.Estado == OrdenPreparacionEstados.ADespacho && o.DNITransportista == dnitransportista)
                .ToList();
            return ordenesFiltradas;
        }

        public RemitoEntidad GenerarRemito(int dniTransportista, List<int> ordenesIds)
        {
            if (ordenesIds == null || ordenesIds.Count == 0)
                return null;

            
            var primerOrden = OrdenPreparacionAlmacen.OrdenPreparacion
                .FirstOrDefault(o => o.NumeroOrdenPreparacion == ordenesIds.First());

            if (primerOrden == null)
                return null; 

            
            int nroCliente = primerOrden.NroCliente;

            
            var deposito = ClientesAlmacen.ObtenerNroDeposito(nroCliente);

            if (deposito == null)
                return null; 

            var nuevoRemito = new RemitoEntidad
            {
                NroCliente = nroCliente,
                DNITransportista = dniTransportista,
                NroDeposito = deposito, 
                NroRemito = (RemitoAlmacen.Remito.Any() ? RemitoAlmacen.Remito.Max(r => r.NroRemito) : 0) + 1
            };

            nuevoRemito.Detalle.AddRange(ordenesIds);

            foreach (var nroOrden in ordenesIds)
            {
                CambiarEstadoOrdenPreparacion(nroOrden);
            }

            RemitoAlmacen.AgregarRemito(nuevoRemito);
            RemitoAlmacen.Grabar();

            return nuevoRemito;
        }

        public void CambiarEstadoOrdenPreparacion(int nroOrdenEmp)
        {
            var orden = OrdenPreparacionAlmacen.OrdenPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == nroOrdenEmp);
            if (orden != null)
            {
                OrdenPreparacionAlmacen.ModificarEstado(orden, OrdenPreparacionEstados.Despachada);
            }
        }
    }
}
