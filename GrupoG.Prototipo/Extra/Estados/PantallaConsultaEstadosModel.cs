using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Extra.Estados
{
    internal class PantallaConsultaEstadosModel
    {
        public List<string> GetEstados()
        {
            List<string> estados = new List<string>();
            foreach (OrdenPreparacionEstados estado in Enum.GetValues(typeof(OrdenPreparacionEstados)))
            {
                estados.Add(estado.ToString());
            }
            return estados;
        }

        public List<OrdenPreparacionEntidad> GetOrdenes(string estado)
        {
            List<OrdenPreparacionEntidad> ordenes = new List<OrdenPreparacionEntidad>();
            foreach (OrdenPreparacionEntidad orden in OrdenPreparacionAlmacen.OrdenPreparacion)
            {
                if (orden.Estado.ToString() == estado)
                {
                    ordenes.Add(orden);
                }
            }
            return ordenes;
        }

        public string GetEstadoOrden(int numeroOrden)
        {
            foreach (OrdenPreparacionEntidad orden in OrdenPreparacionAlmacen.OrdenPreparacion)
            {
                if (orden.NumeroOrdenPreparacion == numeroOrden)
                {
                    return orden.Estado.ToString();
                }
            }
            return null;
        }
    }
}
