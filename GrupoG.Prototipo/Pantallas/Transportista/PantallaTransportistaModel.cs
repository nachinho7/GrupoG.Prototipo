using GrupoG.Prototipo.Objetos;
using System.Collections.Generic;

namespace GrupoG.Prototipo.Pantallas.ConsultaTransportista
{
    internal class PantallaTransportistaModel
    {
        public List<Transportistas> Clientes { get; private set; } = new List<Transportistas>
        {
            new Transportistas
            {
                dniTransportista = 45013352,
                Clientes = new List<Clientes>
                {
                    new Clientes { NumeroCliente = 2045 }
                },
                habilitadoTransportista = true,
                patente = "AB098CC"
            },
            new Transportistas
            {
                dniTransportista = 45013353,
                Clientes = new List<Clientes>
                {
                    new Clientes { NumeroCliente = 1111 }
                },
                habilitadoTransportista = true,
                patente = "AA000BB"
            }
        };
    }
}
