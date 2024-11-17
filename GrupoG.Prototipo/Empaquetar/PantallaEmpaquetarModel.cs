using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Empaquetar
{
    internal class PantallaEmpaquetarModel
    {

        public static List<OrdenPreparacionEntidad> ListarOrdenesSeleccionadas()
        {
            return OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => o.Estado == OrdenPreparacionEstados.Cumplida)
                .ToList();
        }

        public List<Mercaderias> ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var orden = ListarOrdenesSeleccionadas()
                .FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrdenSeleccionada);

            if (orden == null) return null;

            return orden.Detalle.Select(detalle => new Mercaderias
            {
                idMercaderia = detalle.idMercaderia,
                cantidadMercaderia = detalle.Cantidad,
                nombreMercaderia = MercaderiasAlmacen.BuscarNombreMercaderia(detalle.idMercaderia),
            }).ToList();
        }

        

        public void CambiarEstadoOrden(int nroOrdenPrep)
        {
            var orden = OrdenPreparacionAlmacen.OrdenPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == nroOrdenPrep);
            if (orden != null)
            {
                OrdenPreparacionAlmacen.ModificarEstado(orden, OrdenPreparacionEstados.Empaquetada);

            }
        }

        

        public static List<OrdenPreparacionEntidad> ListarOrdenesPorDeposito(int nroDeposito)
        {
            var clientes = ClientesAlmacen.Clientes
                .Where(c => c.NroDeposito == nroDeposito)
                .Select(c => c.NroCliente)
                .ToList();

            return OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => clientes.Contains(o.NroCliente) && o.Estado == OrdenPreparacionEstados.Cumplida)
                .ToList();
        }

        public static List<int> ListarDepositosConOrdenes()
        {
            var ordenesPorDeposito = OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => o.Estado == OrdenPreparacionEstados.Cumplida)
                .Select(o => o.NroCliente)
                .Distinct()
                .ToList();

            var depositosConOrdenes = ClientesAlmacen.Clientes
                .Where(c => ordenesPorDeposito.Contains(c.NroCliente))
                .Select(c => c.NroDeposito)
                .Distinct()
                .ToList();

            return depositosConOrdenes;
        }


    }
}
