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
                    cantidadMercaderia = m.CalcularTotalStock()
                })
                .ToList();
            
            if (!mercaderias.Any())
            {
                MessageBox.Show("No se encontraron mercaderías para el cliente.");
            }
            
            return mercaderias;
        }

        private List<Mercaderias> MercaderiasAgregadas = new List<Mercaderias>();


        public void AgregarProducto(int idMercaderia, string nombreMercaderia, int cantidadMercaderia)
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

        public void CrearOrdenPreparacion(int nrocliente, DateTime fechadespacho, int dni, string nombredeposito, List<(int idMercaderia, int cantidad)> listaMercaderias)
        {
            int nroOrdenPreparacion = SumaNumOrden();
            var estadoOrdenPreparacion = OrdenPreparacionEstados.Pendiente;
            var ordenPreparacionDetalle = new List<OrdenPreparacionDetalle>();

            foreach (var item in listaMercaderias)
            {
                int idMercaderia = item.idMercaderia;
                int cantidad = item.cantidad;

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

        public string ObtenerNombreDepositoPorCliente(int clienteNumero)
        {
            var deposito = Depositos.FirstOrDefault(d => d.NroCliente == clienteNumero);

            return deposito != null ? deposito.NombreDeposito : "Depósito no encontrado";
        }

    }
}