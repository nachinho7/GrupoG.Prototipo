using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Empaquetar
{
    internal class PantallaEmpaquetarModel
    {

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

        public static List<OrdenPreparacionEntidad> ListarOrdenesSeleccionadas()
        {
            return OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => o.Estado == OrdenPreparacionEstados.Cumplida)
                .ToList();
        }

        public void CambiarEstadoOrden(int nroOrdenPrep)
        {
            var orden = OrdenPreparacionAlmacen.OrdenPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == nroOrdenPrep);
            if (orden != null)
            {
                OrdenPreparacionAlmacen.ModificarEstado(orden, OrdenPreparacionEstados.Empaquetada);

            }
        }


    }
}
