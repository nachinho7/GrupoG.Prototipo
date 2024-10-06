using GrupoG.Prototipo.Pantallas.Entrega;
using GrupoG.Prototipo.Pantallas.Seleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Objetos
{
    internal class OrdenEntrega
    {
        public int IdEntrega { get; set; }
        public List<PantallaEntregaModel.Orden> Ordenes { get; set; } // Usar el tipo correcto aquí
        public int NroCliente { get; set; }
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string nombreMercaderia { get; set; }
        public int cantidadMercaderia { get; set; }

        public OrdenEntrega(int idEntrega, List<PantallaEntregaModel.Orden> ordenes)
        {
            IdEntrega = idEntrega;
            Ordenes = ordenes;
        }
    }
}