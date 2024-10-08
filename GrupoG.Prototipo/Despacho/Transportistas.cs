using GrupoG.Prototipo.Preparacion;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace GrupoG.Prototipo.Despacho

{

    public class Transportistas

    {

        public string nombreTransportista { get; set; }

        public string apellidoTransportista { get; set; }

        public string patente { get; set; }

        public int dniTransportista { get; set; }

        public bool habilitadoTransportista { get; set; }

        public List<Clientes> Clientes { get; set; }


    }

}

