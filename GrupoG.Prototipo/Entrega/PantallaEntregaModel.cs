using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Entrega
{
    internal class PantallaEntregaModel
    {
        public List<OrdenPreparacionEntidad> ObtenerOrdenes()
        {
            return OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => o.Estado == OrdenPreparacionEstados.Empaquetada)
                .ToList();
        }

        

        public void CambiarEstadoOrden(int nroOrdenEmp)
        {
            var orden = OrdenPreparacionAlmacen.OrdenPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == nroOrdenEmp);
            if (orden != null)
            {
                OrdenPreparacionAlmacen.ModificarEstado(orden, OrdenPreparacionEstados.ADespacho);

            }
        }

        public List<OrdenEntregaEntidad> GenerarOrdenEntregaPorOrden(List<OrdenPreparacionEntidad> ordenesEmpaquetadas)
        {
            var ordenesEntregas = new List<OrdenEntregaEntidad>();

            foreach (var ordenPreparacion in ordenesEmpaquetadas)
            {
                CambiarEstadoOrden(ordenPreparacion.NumeroOrdenPreparacion);

                int nuevoNroOrdenEntrega = (OrdenEntregaAlmacen.OrdenEntrega.Any() ? OrdenEntregaAlmacen.OrdenEntrega.Max(o => o.NumeroOrdenEntrega) : 0) + 1;
                var cliente = ClientesAlmacen.ObtenerNroCliente(ordenPreparacion.NroCliente);
                var numOrdenPrepracion = ordenPreparacion.NumeroOrdenPreparacion;

                if (cliente != null)
                {
                    var ordenEntrega = new OrdenEntregaEntidad
                    {
                        NumeroOrdenEntrega = nuevoNroOrdenEntrega,
                        NroCliente = ordenPreparacion.NroCliente,
                        NumeroOrdenPrepracion = numOrdenPrepracion,
                        NroDeposito = cliente.NroDeposito
                    };

                    ordenesEntregas.Add(ordenEntrega);

                    OrdenEntregaAlmacen.AgregarOrdenEntrega(ordenEntrega);
                }
            }

            OrdenEntregaAlmacen.Grabar();

            return ordenesEntregas;
        }

    }
}
