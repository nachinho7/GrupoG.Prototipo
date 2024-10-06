using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Pantallas.Seleccion
{
    public class Orden
    {
        public int NroOrden { get; set; }
        public int NroCliente { get; set; }
        public string Estado { get; set; }
        public DateTime FechaGeneracion { get; set; }

        public Orden(int nroOrden, int nroCliente, string estado, DateTime fechaGeneracion)
        {
            NroOrden = nroOrden;
            NroCliente = nroCliente;
            Estado = estado;
            FechaGeneracion = fechaGeneracion;
        }
    }

    public class OrdenSeleccion
    {
        public int IdSeleccion { get; set; }
        public List<Orden> Ordenes { get; set; }
        public DateTime FechaCreacion { get; set; }

        public OrdenSeleccion(int idSeleccion, List<Orden> ordenes)
        {
            IdSeleccion = idSeleccion;
            Ordenes = ordenes;
            FechaCreacion = DateTime.Now;
        }
    }

    public class PantallaSeleccionModel
    {
        private List<Orden> ordenes;
        private List<OrdenSeleccion> ordenesSeleccion;

        private int siguienteIdSeleccion = 1;

        public PantallaSeleccionModel()
        {
            // Inicializar la lista de órdenes (puede ser desde una base de datos o cualquier fuente de datos)
            ordenes = new List<Orden>
            {
                new Orden(1, 1001, "Pendiente", DateTime.Now),
                new Orden(2, 1002, "Completado", DateTime.Now.AddDays(-1)),
                new Orden(4, 1002, "Pendiente", DateTime.Now.AddDays(-1)),
                // Agrega más órdenes según sea necesario
            };

            ordenesSeleccion = new List<OrdenSeleccion>();
        }

        // Obtener todas las órdenes
        public List<Orden> ObtenerOrdenes()
        {
            return ordenes;
        }

        // Obtener todas las órdenes de selección
        public List<OrdenSeleccion> ObtenerOrdenesSeleccion()
        {
            return ordenesSeleccion;
        }

        // Generar una orden de selección y eliminar las órdenes seleccionadas
        public OrdenSeleccion GenerarOrdenDeSeleccion(List<Orden> ordenesSeleccionadas)
        {
            // Crear una nueva orden de selección
            OrdenSeleccion nuevaSeleccion = new OrdenSeleccion(siguienteIdSeleccion++, ordenesSeleccionadas);
            ordenesSeleccion.Add(nuevaSeleccion);

            // Eliminar las órdenes seleccionadas de la lista principal
            foreach (var orden in ordenesSeleccionadas)
            {
                ordenes.Remove(orden);
            }

            return nuevaSeleccion;
        }
    }
}
