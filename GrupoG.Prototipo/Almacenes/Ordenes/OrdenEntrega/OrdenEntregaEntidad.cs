using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Ordenes.OrdenEntrega
{
    internal class OrdenEntregaEntidad
    {
        public int IdEntrega { get; set; }
        public int NroCliente { get; set; }
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string nombreMercaderia { get; set; }
        public int cantidadMercaderia { get; set; }
    }
}
