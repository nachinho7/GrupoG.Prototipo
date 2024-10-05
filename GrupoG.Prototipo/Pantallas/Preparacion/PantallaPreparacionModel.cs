using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Pantallas.Preparacion
{
    internal class PantallaPreparacionModel
    {
        public List<Clientes> Clientes { get; private set; } =
        [
            new Clientes { NumeroCliente = 2045 },
            new Clientes { NumeroCliente = 3080 },
            new Clientes { NumeroCliente = 1224 },
            new Clientes { NumeroCliente = 8564 },
            new Clientes { NumeroCliente = 8745 },
        ];



    };





}