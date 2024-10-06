using System.Collections.Generic;
using System.Linq;
using GrupoG.Prototipo.Objetos;

namespace GrupoG.Prototipo.Pantallas.Despacho
{
    internal class PantallaDespachoModel
    {
        // Lista de órdenes de despacho
        private List<OrdenDespacho> ordenesDespacho;

        public PantallaDespachoModel()
        {
            // Inicializamos la lista de órdenes con algunos datos de ejemplo
            ordenesDespacho = new List<OrdenDespacho>
            {
                new OrdenDespacho(1,1234, "Empaquetado"),
                new OrdenDespacho(2, 1234, "Empaquetado"),
                new OrdenDespacho(3, 1234, "Empaquetado"),
                new OrdenDespacho(4, 4567, "Empaquetado"),
                new OrdenDespacho(5, 5555, "Empaquetado"),
                new OrdenDespacho(6, 5555, "Empaquetado")
            };
        }

        public List<OrdenDespacho> ObtenerOrdenesPorCliente(int numeroCliente)
        {
            // Filtrar y devolver las órdenes de despacho relacionadas al cliente
            return ordenesDespacho.Where(o => o.NroCliente == numeroCliente).ToList();
        }
    }
}
