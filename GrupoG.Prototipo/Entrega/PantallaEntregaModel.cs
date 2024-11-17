using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Deposito;
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

        public static List<int> ListarDepositosDisponibles()
        {
            var depositos = DepositoAlmacen.Depositos;
            return depositos.Select(d => d.NroDeposito).ToList();
        }

        public static List<OrdenPreparacionEntidad> ListarOrdenesPorDeposito(int nroDeposito)
        {
            var clientes = ClientesAlmacen.Clientes
                .Where(c => c.NroDeposito == nroDeposito)
                .Select(c => c.NroCliente)
                .ToList();

            return OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => clientes.Contains(o.NroCliente) && o.Estado == OrdenPreparacionEstados.Empaquetada)
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

        public OrdenPreparacionEntidad ObtenerOrdenPorNumero(int numeroOrden)
        {
            return OrdenPreparacionAlmacen.OrdenPreparacion
                .FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
        }


        public OrdenEntregaEntidad GenerarOrdenEntregaPorOrden(List<OrdenPreparacionEntidad> ordenesEmpaquetadas)
        {
            var depositoUnico = ordenesEmpaquetadas
                .Select(o => ClientesAlmacen.ObtenerNroCliente(o.NroCliente)?.NroDeposito)
                .Distinct()
                .SingleOrDefault();

            if (depositoUnico == null)
            {
                throw new InvalidOperationException("No se puede generar una orden de entrega para órdenes de depósitos diferentes.");
            }

            int nuevoNroOrdenEntrega = (OrdenEntregaAlmacen.OrdenEntrega.Any() ? OrdenEntregaAlmacen.OrdenEntrega.Max(o => o.NumeroOrdenEntrega) : 0) + 1;

            var nuevaOrdenEntrega = new OrdenEntregaEntidad
            {
                NumeroOrdenEntrega = nuevoNroOrdenEntrega,
                Detalle = ordenesEmpaquetadas.Select(o => o.NumeroOrdenPreparacion).ToList(),
                NroDeposito = depositoUnico.Value
            };

            foreach (var ordenPreparacion in ordenesEmpaquetadas)
            {
                CambiarEstadoOrden(ordenPreparacion.NumeroOrdenPreparacion);
            }

            OrdenEntregaAlmacen.AgregarOrdenEntrega(nuevaOrdenEntrega);
            OrdenEntregaAlmacen.Grabar();

            return nuevaOrdenEntrega;
        }


    }
}
