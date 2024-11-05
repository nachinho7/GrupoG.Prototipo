using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Mercaderias
{
    internal class MercaderiasEntidad
    {
        public int idMercaderia { get; set; }
        public string nombreMercaderia { get; set; }
        public List<MercaderiasUbicacion> Ubicacion { get; set; } = new List<MercaderiasUbicacion>();
        public int NroCliente { get; set; }
        public int CalcularTotalStock(int id) => Ubicacion.Where(s => s.idMercaderia == id).Sum(s => s.Cantidad);
    }
}
