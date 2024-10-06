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
            ordenes = new List<Orden>
            {
                new Orden(1, 1001, "Pendiente", DateTime.Now),
                new Orden(2, 1002, "Completado", DateTime.Now.AddDays(-1)),
                new Orden(4, 1002, "Pendiente", DateTime.Now.AddDays(-1)),
            };

            ordenesSeleccion = new List<OrdenSeleccion>();
        }

        public List<Orden> ObtenerOrdenes()
        {
            return ordenes;
        }

        public List<OrdenSeleccion> ObtenerOrdenesSeleccion()
        {
            return ordenesSeleccion;
        }

        public OrdenSeleccion GenerarOrdenDeSeleccion(List<Orden> ordenesSeleccionadas)
        {
            OrdenSeleccion nuevaSeleccion = new OrdenSeleccion(siguienteIdSeleccion++, ordenesSeleccionadas);
            ordenesSeleccion.Add(nuevaSeleccion);

            foreach (var orden in ordenesSeleccionadas)
            {
                ordenes.Remove(orden);
            }

            return nuevaSeleccion;
        }
    }
}
