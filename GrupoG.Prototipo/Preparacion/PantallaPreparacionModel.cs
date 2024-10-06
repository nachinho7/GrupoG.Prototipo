using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Preparacion
{
    internal class PantallaPreparacionModel
    {
        public List<Clientes> Clientes { get; private set; } = new List<Clientes>
        {
            new Clientes
            {
                NumeroCliente = 2045,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 1, nombreMercaderia = "Botellas", ubicacionMercaderia = "Almacén A", cantidadMercaderia = 2 },
                    new Mercaderias { idMercaderia = 2, nombreMercaderia = "Vasos", ubicacionMercaderia = "Almacén B", cantidadMercaderia = 500 }
                }
            },
            new Clientes
            {
                NumeroCliente = 3080,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 2, nombreMercaderia = "Pelotas", ubicacionMercaderia = "Almacén C", cantidadMercaderia = 10 }
                }
            },
            new Clientes
            {
                NumeroCliente = 1224,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 3, nombreMercaderia = "Aceites", ubicacionMercaderia = "Almacén D", cantidadMercaderia = 30 }
                }
            },
        };

        private List<OrdenPreparacion> ordenesPreparacion = new List<OrdenPreparacion>();

        public List<Mercaderias> ObtenerMercaderiaPorCliente(int numeroCliente)
        {
            var cliente = Clientes.FirstOrDefault(c => c.NumeroCliente == numeroCliente);
            return cliente?.Mercaderias ?? new List<Mercaderias>();
        }

        public void AgregarMercaderiaAPreparacion(int numeroOrden, int idMercaderia, string nombreMercaderia, string ubicacionMercaderia, int cantidadSeleccionada)
        {
            var orden = ordenesPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
            if (orden == null)
            {
                orden = new OrdenPreparacion
                {
                    NumeroOrdenPreparacion = numeroOrden,
                    FechaDespacho = DateTime.Now // Puedes ajustar esto según sea necesario
                };
                ordenesPreparacion.Add(orden);
            }

            var mercaderia = orden.Mercaderias.FirstOrDefault(m => m.idMercaderia == idMercaderia);
            if (mercaderia == null)
            {
                orden.Mercaderias.Add(new Mercaderias
                {
                    idMercaderia = idMercaderia,
                    nombreMercaderia = nombreMercaderia,
                    ubicacionMercaderia = ubicacionMercaderia,
                    cantidadMercaderia = cantidadSeleccionada
                });
            }
            else
            {
                mercaderia.cantidadMercaderia += cantidadSeleccionada;
            }
        }

        public List<OrdenPreparacion> ObtenerOrdenPreparacion(int numeroOrden)
        {
            return ordenesPreparacion.Where(o => o.NumeroOrdenPreparacion == numeroOrden).ToList();
        }

        public void EliminarMercaderiaDePreparacion(int numeroOrden, int idMercaderia, int cantidadEliminada)
        {
            var orden = ordenesPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
            if (orden != null)
            {
                var mercaderia = orden.Mercaderias.FirstOrDefault(m => m.idMercaderia == idMercaderia);
                if (mercaderia != null)
                {
                    mercaderia.cantidadMercaderia -= cantidadEliminada;
                    if (mercaderia.cantidadMercaderia <= 0)
                    {
                        orden.Mercaderias.Remove(mercaderia);
                    }
                }

                // Si la orden no tiene más mercaderías, eliminar la orden
                if (!orden.Mercaderias.Any())
                {
                    ordenesPreparacion.Remove(orden);
                }
            }
        }

        public bool GenerarOrdenPreparacion(int numeroOrden, DateTime fechaDespacho, int dniTransportista)
        {
            var orden = ordenesPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
            if (orden != null)
            {
                // Asignar fecha y transportista
                orden.FechaDespacho = fechaDespacho;
                orden.DNITransportista = dniTransportista;

                // Actualizar las cantidades disponibles en los clientes
                foreach (var cliente in Clientes)
                {
                    foreach (var mercaderia in cliente.Mercaderias)
                    {
                        var ordenMercaderia = orden.Mercaderias.FirstOrDefault(m => m.idMercaderia == mercaderia.idMercaderia);
                        if (ordenMercaderia != null)
                        {
                            mercaderia.cantidadMercaderia -= ordenMercaderia.cantidadMercaderia;
                            if (mercaderia.cantidadMercaderia < 0)
                            {
                                // Manejar el caso de cantidades negativas si es necesario
                                mercaderia.cantidadMercaderia = 0;
                            }
                        }
                    }
                }

                // Aquí podrías agregar lógica adicional para guardar la orden en una base de datos o realizar otras acciones necesarias.

                // Eliminar la orden de la lista de preparación después de generarla
                ordenesPreparacion.Remove(orden);
                return true;
            }

            return false;
        }
    }
}