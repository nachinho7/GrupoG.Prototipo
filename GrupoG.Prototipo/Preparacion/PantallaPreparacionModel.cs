using GrupoG.Prototipo.Almacenes;
using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Deposito;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Preparacion
{
    internal class PantallaPreparacionModel
    {
        public Clientes BuscarCliente(int nroCliente)
        {
            foreach (ClientesEntidad clientesEntidad in ClientesAlmacen.Clientes)
            {
                if (clientesEntidad.NroCliente == nroCliente)
                {
                    return new Clientes { NroCliente = clientesEntidad.NroCliente };
                }
            }

            return null;
        }

        public List<DepositoEntidad> Depositos
        {
            get
            {
                var depositos = new List<DepositoEntidad>();
                foreach (var depositoEntidad in DepositoAlmacen.Depositos)
                {
                    var deposito = new DepositoEntidad();
                    deposito.NroDeposito = depositoEntidad.NroDeposito;
                    deposito.NombreDeposito = depositoEntidad.NombreDeposito;

                    depositos.Add(deposito);
                }
                return depositos;
            }
        }



        public int SumaNumOrden()
        {
            int sumaNumOrden = (OrdenPreparacionAlmacen.OrdenPreparacion.Any() ? OrdenPreparacionAlmacen.OrdenPreparacion.Max(o => o.NumeroOrdenPreparacion) : 0) + 1;
            return sumaNumOrden;
        }


        public List<(int CantidadTotal, int idMercaderia, string nombre)> ObtenerMercaderia(int nroCliente)
        {
            var mercaderiaPorCliente = MercaderiasAlmacen.Mercaderias
                .Where(m => m.NroCliente == nroCliente)
                .GroupBy(m => m.idMercaderia)
                .Select(g => (
                    CantidadTotal: g.Sum(m => m.Ubicacion.Sum(u => u.Cantidad)),
                    idMercaderia: g.Key,
                    nombre: MercaderiasAlmacen.BuscarNombreMercaderia(g.Key)
                ))
                .ToList();

            return mercaderiaPorCliente;
        }

        public void CrearOrdenPreparacion(int nrocliente, DateTime fechadespacho, int dni, string nombredeposito, ListBox ListaPrevisualizacionOrdenesPreparacion)
        {
            int nroOrdenPreparacion = SumaNumOrden();
            var estadoOrdenPreparacion = OrdenPreparacionEstados.Pendiente;
            var ordenPreparacionDetalle = new List<OrdenPreparacionDetalle>();

            foreach (ListViewItem item in ListaPrevisualizacionOrdenesPreparacion.Items)
            {
                int idMercaderia = int.Parse(item.SubItems[0].Text);
                int cantidad = int.Parse(item.SubItems[2].Text);

                var detalle = new OrdenPreparacionDetalle
                {
                    idMercaderia = idMercaderia,
                    Cantidad = cantidad
                };

                ordenPreparacionDetalle.Add(detalle);
            }

            var nuevaorden = new OrdenPreparacionEntidad
            {
                NumeroOrdenPreparacion = nroOrdenPreparacion,
                NroCliente = nrocliente,
                Estado = estadoOrdenPreparacion,
                FechaDespacho = fechadespacho,
                DNITransportista = dni,
                NroDeposito = DepositoAlmacen.BuscarNroDeposito(nombredeposito),
                Detalle = ordenPreparacionDetalle,
            };

            OrdenPreparacionAlmacen.AgregarOrdenPreparacion(nuevaorden);
            foreach (var item in nuevaorden.Detalle)
            {
                // Encuentra la mercadería específica
                var mercaderiaItem = MercaderiasAlmacen.Mercaderias.First(s => s.idMercaderia == item.idMercaderia
                && s.NroCliente == nuevaorden.NroCliente);

                // Busca la ubicación específica que coincida con el depósito
                var ubicacion = mercaderiaItem.Ubicacion.FirstOrDefault(u => u.NroDeposito == nuevaorden.NroDeposito);

                if (ubicacion != null) // Asegúrate de que se encontró una ubicación
                {
                    if (ubicacion.Cantidad >= item.Cantidad)
                    {
                        int cantidadRetirada = item.Cantidad;

                        // Actualiza la cantidad en la ubicación
                        ubicacion.Cantidad -= cantidadRetirada; // Restar la cantidad retirada

                        // Crea una nueva entidad para el stock retirado
                        var mercaderiaRetirada = new MercaderiasEntidad
                        {
                            idMercaderia = mercaderiaItem.idMercaderia,
                            NroCliente = mercaderiaItem.NroCliente,
                            // Asegúrate de incluir la lista de ubicaciones si es necesario
                            Ubicacion = new List<MercaderiasUbicacion> {
                                    new MercaderiasUbicacion {
                                        NroDeposito = ubicacion.NroDeposito,
                                        Cantidad = cantidadRetirada,
                                        NombreUbicacion = ubicacion.NombreUbicacion
                                    }
                                }
                            };
                        MercaderiasAlmacen.AgregarStock(mercaderiaRetirada); 

                    }
                    else
                    {
                        MessageBox.Show($"No hay suficiente cantidad en la ubicación para la mercadería ID: {item.idMercaderia}");
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontró la ubicación para el depósito: {nuevaorden.NroDeposito} en la mercadería ID: {item.idMercaderia}");
                }
            }



            /*public List<Mercaderias> ObtenerMercaderiaPorCliente(int numeroCliente)
            {
                var cliente = Clientes.FirstOrDefault(c => c.NumeroCliente == numeroCliente);
                return cliente?.Mercaderias ?? new List<Mercaderias>();
            }
            */

            /*public void AgregarMercaderiaAPreparacion(int numeroOrden, int idMercaderia, string nombreMercaderia, int cantidadSeleccionada)
            {
                var orden = OrdenPreparacionEntidad.FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrden);
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
            */

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