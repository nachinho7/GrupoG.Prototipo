using System;
using System.Collections.Generic;
using System.Linq;
using GrupoG.Prototipo.Almacenes;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Almacenes.Remito;

namespace GrupoG.Prototipo.Despacho
{
    internal class PantallaDespachoModel
    {
        public List<OrdenPreparacionEntidad> ObtenerOrdenesPorDni(int dniTransportista)
        {
            var ordenesFiltradas = OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => o.DNITransportista == dniTransportista && o.Estado == OrdenPreparacionEstados.ADespacho)
                .ToList();
            return ordenesFiltradas;
        }

        public RemitoEntidad GenerarRemito(int dniTransportista, List<OrdenPreparacionEntidad> ordenes)
        {
            // Verificar si hay órdenes para el transportista
            if (ordenes == null || ordenes.Count == 0)
                return null;

            // Creo el remito a partir de las órdenes
            var nuevoRemito = new RemitoEntidad
            {
                NroCliente = ordenes.First().NroCliente,
                DNITransportista = dniTransportista,
                NroDeposito = ordenes.First().NroDeposito,
                NroRemito = (RemitoAlmacen.Remito.Any() ? RemitoAlmacen.Remito.Max(r => r.NroRemito) : 0) + 1
            };

            // Detalles de la orden id, cantidad las agrego al remito
            foreach (var orden in ordenes)
            {
                foreach (var detalle in orden.Detalle)
                {
                    nuevoRemito.Detalle.Add(new OrdenPreparacionDetalle
                    {
                        idMercaderia = detalle.idMercaderia,
                        Cantidad = detalle.Cantidad
                    });
                }

                CambiarEstadoOrdenPreparacion(orden.NumeroOrdenPreparacion);
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
