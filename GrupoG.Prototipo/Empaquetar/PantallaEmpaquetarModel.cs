using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Empaquetar
{
    internal class PantallaEmpaquetarModel
    {
        /*
        public List<OrdenPreparacion> OrdenesPreparacion { get; private set; } = new List<OrdenPreparacion>
        {
            new OrdenPreparacion
            {
                NumeroOrdenPreparacion = 1,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 1, nombreMercaderia = "Producto A", cantidadMercaderia =20},
                    new Mercaderias {  idMercaderia = 2, nombreMercaderia = "Producto B", cantidadMercaderia = 1}
                }
            },
            new OrdenPreparacion
            {
                NumeroOrdenPreparacion = 2,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 3, nombreMercaderia = "Producto Z", cantidadMercaderia = 10 },
                    new Mercaderias { idMercaderia = 4, nombreMercaderia = "Producto W", cantidadMercaderia = 5 }
                }
            }
        };

        public List<OrdenPreparacion> ObtenerOrdenesPreparacion()
        {
            return OrdenesPreparacion;
        }
        

        public void RemoverOrdenPreparacion(OrdenPreparacion orden)
        {
            OrdenesPreparacion.Remove(orden);
        }

        public List<Mercaderias> ObtenerMercaderiasPorOrden(int index)
        {
            if (index >= 0 && index < OrdenesPreparacion.Count)
            {
                return OrdenesPreparacion[index].Mercaderias;
            }
            return new List<Mercaderias>();
        }
        */

        /*

        public List<Mercaderias> ObtenerMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var orden = ObtenerOrdenPorNumero(numeroOrdenSeleccionada);  

            if (orden == null) return null;

            
            return orden.Detalle.Select(detalle => new Mercaderias
            {
                idMercaderia = detalle.idMercaderia,  
                cantidadMercaderia = detalle.Cantidad,
                nombreMercaderia = MercaderiasAlmacen.BuscarNombreMercaderiaN(detalle.idMercaderia), // Aquí obtenemos el nombre
            }).ToList();
        }
        
        private OrdenPreparacionEntidad ObtenerOrdenPorNumero(int numeroOrden)
        {
            var ordenes = ObtenerOrdenesSeleccionadas();  
            return ordenes.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
        }
        */

        /*
        public static List<OrdenPreparacionEntidad> ListarOrdenesSeleccionadas()
        {
            var ordenes = new List<OrdenPreparacionEntidad>();

            foreach (var ordenPreparacionEntidad in OrdenPreparacionAlmacen.OrdenPreparacion
                    .Where(o => o.Estado == OrdenPreparacionEstados.Seleccionada)
                    .ToList())
            {
                var orden = new OrdenPreparacionEntidad
                {
                    NumeroOrdenPreparacion = ordenPreparacionEntidad.NumeroOrdenPreparacion,
                    NroCliente = ordenPreparacionEntidad.NroCliente,
                    Estado = ordenPreparacionEntidad.Estado,
                    FechaDespacho = ordenPreparacionEntidad.FechaDespacho,
                    DNITransportista = ordenPreparacionEntidad.DNITransportista,
                    NroDeposito = ordenPreparacionEntidad.NroDeposito,
                    Detalle = ordenPreparacionEntidad.Detalle 
                };

                ordenes.Add(orden);
            }

            return ordenes;
        }
        */
        
        public List<Mercaderias> ListarMercaderiasPorOrden(int numeroOrdenSeleccionada)
        {
            var orden = BuscarOrdenPorNumero(numeroOrdenSeleccionada);

            if (orden == null) return null;

            return orden.Detalle.Select(detalle => new Mercaderias
            {
                idMercaderia = detalle.idMercaderia,
                cantidadMercaderia = detalle.Cantidad,
                nombreMercaderia = MercaderiasAlmacen.BuscarNombreMercaderia(detalle.idMercaderia),
            }).ToList();
        }




        private OrdenPreparacionEntidad BuscarOrdenPorNumero(int numeroOrden)
        {
            var ordenes = ListarOrdenesSeleccionadas(); 
            return ordenes.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
        }

        /*
        private OrdenPreparacionEntidad BuscarOrdenPorNumero(int numeroOrden)
        {
            var ordenes = ListarOrdenesSeleccionadas();
            return ordenes.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
        }
        */
        public int ObtenerNumeroOrdenEnPantalla()
        {
            return OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => o.Estado == OrdenPreparacionEstados.Seleccionada)
                .OrderBy(o => o.NumeroOrdenPreparacion)
                .Select(o => o.NumeroOrdenPreparacion)
                .FirstOrDefault();
        }

        /*
        public static List<OrdenPreparacion> ListarOrdenesSeleccionadas()
        {
            var ordenes = new List<OrdenPreparacion>();

            foreach (var ordenPreparacionEntidad in OrdenPreparacionAlmacen.OrdenPreparacion
                    .Where(o => o.Estado == OrdenPreparacionEstados.Seleccionada)
                    .ToList())
            {
                var orden = new OrdenPreparacion
                {
                    NumeroOrdenPreparacion = ordenPreparacionEntidad.NumeroOrdenPreparacion,
                    // Solo agregamos las mercaderías relacionadas con esta orden.
                    Mercaderias = ordenPreparacionEntidad.Detalle.Select(detalle => new Mercaderias
                    {
                        idMercaderia = detalle.idMercaderia,
                        nombreMercaderia = MercaderiasAlmacen.BuscarNombreMercaderia(detalle.idMercaderia),
                        cantidadMercaderia = detalle.Cantidad
                    }).ToList()
                };

                ordenes.Add(orden);
            }

            return ordenes;
        }
        */
        public static List<OrdenPreparacionEntidad> ListarOrdenesSeleccionadas()
        {
            return OrdenPreparacionAlmacen.OrdenPreparacion
                .Where(o => o.Estado == OrdenPreparacionEstados.Seleccionada)
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
