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
                    new Mercaderias { idMercaderia = 854, nombreMercaderia = "Botellas", cantidadMercaderia = 200 },
                    new Mercaderias { idMercaderia = 9652, nombreMercaderia = "Vasos", cantidadMercaderia = 500 },
                    new Mercaderias { idMercaderia = 1111, nombreMercaderia = "Calabazas", cantidadMercaderia = 0 }
                }
            },
            new Clientes
            {
                NumeroCliente = 3080,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 874, nombreMercaderia = "Pelotas", cantidadMercaderia = 100 }
                }
            },
            new Clientes
            {
                NumeroCliente = 1224,
                Mercaderias = new List<Mercaderias>
                {
                    new Mercaderias { idMercaderia = 852, nombreMercaderia = "Aceites", cantidadMercaderia = 300 }
                }
            },
        };

        private List<OrdenPreparacion> ordenesPreparacion = new List<OrdenPreparacion>();

        public List<Mercaderias> ObtenerMercaderiaPorCliente(int numeroCliente)
        {
            var cliente = Clientes.FirstOrDefault(c => c.NumeroCliente == numeroCliente);
            return cliente?.Mercaderias ?? new List<Mercaderias>();
        }

        public void AgregarMercaderiaAPreparacion(int numeroOrden, int idMercaderia, string nombreMercaderia, int cantidadSeleccionada)
        {
            var orden = ordenesPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
            if (orden == null)
            {
                orden = new OrdenPreparacion
                {
                    NumeroOrdenPreparacion = numeroOrden,
                    FechaDespacho = DateTime.Now,
                    Mercaderias = new List<Mercaderias>() 
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
                    cantidadMercaderia = cantidadSeleccionada
                });
            }
            else
            {
                mercaderia.cantidadMercaderia += cantidadSeleccionada;
            }

            var cliente = Clientes.FirstOrDefault(c => c.Mercaderias.Any(m => m.idMercaderia == idMercaderia));
            if (cliente != null)
            {
                var mercaderiaCliente = cliente.Mercaderias.First(m => m.idMercaderia == idMercaderia);
                mercaderiaCliente.cantidadMercaderia -= cantidadSeleccionada;
            }
        }


        public List<OrdenPreparacion> ObtenerOrdenPreparacion(int numeroOrden)
        {
            return ordenesPreparacion.Where(o => o.NumeroOrdenPreparacion == numeroOrden).ToList();
        }

        public void EliminarMercaderiaDePreparacion(int numeroOrden, int idMercaderia, int cantidad)
        {
            var orden = ordenesPreparacion.Find(o => o.NumeroOrdenPreparacion == numeroOrden);
            if (orden != null)
            {
                var mercaderia = orden.Mercaderias.Find(m => m.idMercaderia == idMercaderia);
                if (mercaderia != null)
                {
                    int cantidadRemovida = Math.Min(cantidad, mercaderia.cantidadMercaderia);
                    mercaderia.cantidadMercaderia -= cantidadRemovida;

                    if (mercaderia.cantidadMercaderia <= 0)
                    {
                        orden.Mercaderias.Remove(mercaderia);
                    }

                    var cliente = Clientes.FirstOrDefault(c => c.Mercaderias.Any(m => m.idMercaderia == idMercaderia));
                    if (cliente != null)
                    {
                        var mercaderiaCliente = cliente.Mercaderias.First(m => m.idMercaderia == idMercaderia);
                        mercaderiaCliente.cantidadMercaderia += cantidadRemovida;
                    }
                }
            }
        }


        public void LimpiarOrdenesPreparacion()
        {
            ordenesPreparacion.Clear();
        }

        public bool GenerarOrdenPreparacion(int numeroOrden, DateTime fechaDespacho, int dniTransportista)
        {
            var orden = ordenesPreparacion.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
            if (orden != null)
            {
                orden.FechaDespacho = fechaDespacho;
                orden.DNITransportista = dniTransportista;

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
                                mercaderia.cantidadMercaderia = 0;
                            }
                        }
                    }
                }

                ordenesPreparacion.Remove(orden);
                return true;
            }

            return false;
        }
    }
}