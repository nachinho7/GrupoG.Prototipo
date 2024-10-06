using System.Collections.Generic;
using System.Linq;
using GrupoG.Prototipo.Objetos;

namespace GrupoG.Prototipo.Pantallas.Despacho
{
    internal class PantallaDespachoModel
    {
        // Lista de órdenes de despacho
        private List<OrdenDespacho> ordenesDespacho;
        // Lista de transportistas
        public List<Transportistas> Transportistas { get; private set; }

        public PantallaDespachoModel()
        {
            ordenesDespacho = new List<OrdenDespacho>
            {
                new OrdenDespacho(1, 1234, "Empaquetado"),
                new OrdenDespacho(2, 1234, "Empaquetado"),
                new OrdenDespacho(3, 1234, "Empaquetado"),
                new OrdenDespacho(4, 4567, "Empaquetado"),
                new OrdenDespacho(5, 5555, "Empaquetado"),
                new OrdenDespacho(6, 5555, "Empaquetado")
            };

            Transportistas = new List<Transportistas>
            {
                new Transportistas
                {
                    dniTransportista = 45013352,
                    Clientes = new List<Clientes>
                    {
                        new Clientes { NumeroCliente = 1234 }
                    },
                    habilitadoTransportista = true,
                    patente = "AB098CC"
                },
                new Transportistas
                {
                    dniTransportista = 45013353,
                    Clientes = new List<Clientes>
                    {
                        new Clientes { NumeroCliente = 4567 }
                    },
                    habilitadoTransportista = true,
                    patente = "AA000BB"
                }
            };
        }

        public List<OrdenDespacho> ObtenerOrdenesPorCliente(int numeroCliente)
        {
            // Filtrar y devolver las órdenes de despacho relacionadas al cliente
            var ordenesFiltradas = ordenesDespacho.Where(o => o.NroCliente == numeroCliente).ToList();

            Console.WriteLine($"Se encontraron {ordenesFiltradas.Count} ordenes para el cliente {numeroCliente}", "Ordenes Encontradas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return ordenesFiltradas;
        }

        public Transportistas ObtenerTransportistaPorDni(int dniTransportista)
        {
            var transportista = Transportistas.FirstOrDefault(t => t.dniTransportista == dniTransportista);

            if (transportista != null)
            {
                Console.WriteLine($"Transportista encontrado con DNI {dniTransportista}", "Transportista Habilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine($"No se encontró el transportista con DNI {dniTransportista}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return transportista;
        }

        public void EliminarOrdenPorId(int idDespacho)
        {
            var ordenAEliminar = ordenesDespacho.FirstOrDefault(o => o.IdDespacho == idDespacho);

            if (ordenAEliminar != null)
            {
                ordenesDespacho.Remove(ordenAEliminar);
            }
        }

    }
}
