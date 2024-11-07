using GrupoG.Prototipo.Almacenes;
using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Deposito;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Despacho;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoG.Prototipo.Preparacion
{
    internal class PantallaPreparacionModel
    {

        public int SumaNumOrden()
        {
            int sumaNumOrden = (OrdenPreparacionAlmacen.OrdenPreparacion.Any() ? OrdenPreparacionAlmacen.OrdenPreparacion.Max(o => o.NumeroOrdenPreparacion) : 0) + 1;
            return sumaNumOrden;
        }

        public List<Clientes> ObtenerCliente(int numeroCliente)
        {
            
            var clienteEntidad = ClientesAlmacen.ObtenerNroCliente(numeroCliente);

            if (clienteEntidad == null)
            {
                
                MessageBox.Show("Cliente no encontrado.");
                return new List<Clientes>();
            }

            
            var cliente = new Clientes
            {
                NroCliente = clienteEntidad.NroCliente
            };

            
            MessageBox.Show($"Cliente encontrado: NroCliente = {cliente.NroCliente}");

            return new List<Clientes> { cliente };
        }

        public List<Mercaderias> ObtenerMercaderiasPorCliente(int nroCliente)
        {
            if (MercaderiasAlmacen.Mercaderias == null || !MercaderiasAlmacen.Mercaderias.Any())
            {
                MessageBox.Show("No se encontraron mercaderías para el cliente.");
            }

            var mercaderias = MercaderiasAlmacen.Mercaderias
                .Where(m => m.NroCliente == nroCliente)
                .Select(m => new Mercaderias
                {
                    idMercaderia = m.idMercaderia,
                    nombreMercaderia = m.nombreMercaderia,
                    cantidadMercaderia = m.CalcularTotalStock() - OrdenPreparacionAlmacen.OrdenPreparacion
                                                                                         .Where(o => o.Estado == OrdenPreparacionEstados.Pendiente || o.Estado == OrdenPreparacionEstados.ASeleccionar)
                                                                                         .SelectMany(o => o.Detalle)
                                                                                         .Where(o => o.idMercaderia == m.idMercaderia)
                                                                                         .Select(o => o.Cantidad)
                                                                                         .DefaultIfEmpty()
                                                                                         .Sum()
                })
                .ToList();
            
            if (!mercaderias.Any())
            {
                MessageBox.Show("No se encontraron mercaderías para el cliente.");
            }
            
            return mercaderias;
        }


        public void AgregarProducto(int idMercaderia, string nombreMercaderia, int cantidadMercaderia)
        {
            var mercaderiaExistente = MercaderiasAgregadas.FirstOrDefault(m => m.idMercaderia == idMercaderia);

            if (mercaderiaExistente != null)
            {
                mercaderiaExistente.cantidadMercaderia += cantidadMercaderia;
                MessageBox.Show($"Se ha sumado {cantidadMercaderia} más a {mercaderiaExistente.nombreMercaderia}.");
            }
            else
            {
                var mercaderiaAGrabar = new Mercaderias
                {
                    idMercaderia = idMercaderia,
                    nombreMercaderia = nombreMercaderia,
                    cantidadMercaderia = cantidadMercaderia
                };

                MercaderiasAgregadas.Add(mercaderiaAGrabar);
                MessageBox.Show($"Mercadería {mercaderiaAGrabar.nombreMercaderia} agregada correctamente.");
            }
        }

        public List<Mercaderias> MercaderiasAgregadas = new List<Mercaderias>();

        public void EliminarProducto(int idMercaderia, ListView listaMercaderia)
        {
            var mercaderia = MercaderiasAgregadas.FirstOrDefault(m => m.idMercaderia == idMercaderia);

            if (mercaderia != null)
            {
                var mercaderiaEnLista = listaMercaderia.Items
                    .Cast<ListViewItem>()
                    .FirstOrDefault(item => int.Parse(item.SubItems[0].Text) == idMercaderia);

                if (mercaderiaEnLista != null)
                {
                    int cantidadEliminada = mercaderia.cantidadMercaderia;
                    int cantidadDisponible = int.Parse(mercaderiaEnLista.SubItems[2].Text);
                    mercaderiaEnLista.SubItems[2].Text = (cantidadDisponible + cantidadEliminada).ToString();
                }

                MercaderiasAgregadas.Remove(mercaderia);
                MessageBox.Show($"Mercadería {mercaderia.nombreMercaderia} eliminada correctamente.");
            }
        }


        public void CrearOrdenPreparacion(int nrocliente, DateTime fechadespacho, int dni, List<(int idMercaderia, int cantidad)> listaMercaderias)
        {
            int nroOrdenPreparacion = SumaNumOrden();
            int numeroDeposito = ClientesAlmacen.ObtenerNroDeposito(nrocliente);
            var estadoOrdenPreparacion = OrdenPreparacionEstados.Pendiente;
            var ordenPreparacionDetalle = new List<OrdenPreparacionDetalle>();

            foreach (var item in listaMercaderias)
            {
                int idMercaderia = item.idMercaderia;
                int cantidad = item.cantidad;

                // Resta el stock sin importar la ubicación
                //MercaderiasAlmacen.RestarStockGlobal(idMercaderia, cantidad);

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
                NroDeposito = numeroDeposito,
                Detalle = ordenPreparacionDetalle,
            };

            OrdenPreparacionAlmacen.AgregarOrdenPreparacion(nuevaorden);

        }
    }
}