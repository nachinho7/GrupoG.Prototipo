using System;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Stock
{
    public class Mercaderias
    {
        public int idMercaderia { get; set; }
        public string nombreMercaderia { get; set; }
        public int cantidadMercaderia { get; set; }
        public List<string> ubicacionesMercaderia { get; set; } 

        public Mercaderias()
        {
            ubicacionesMercaderia = new List<string>();
        }
    }
}
