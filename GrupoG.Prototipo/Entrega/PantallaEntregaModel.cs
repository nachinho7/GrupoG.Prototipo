using GrupoG.Prototipo.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Entrega
{
    internal class PantallaEntregaModel
    {
        public class Orden
        {
            public int NroOrden { get; set; }
            public int NroCliente { get; set; }
            public int Codigo { get; set; }
            public string Tipo { get; set; }
            public bool Empaquetada { get; set; }

            public Orden(int nroOrden, int nroCliente, int codigo, string tipo)
            {
                NroOrden = nroOrden;
                NroCliente = nroCliente;
                Codigo = codigo;
                Tipo = tipo;
                Empaquetada = false;
            }
        }

        public List<Orden> ObtenerOrdenes()
        {
            return new List<Orden>
            {
                new Orden(1, 2045, 1, "Plastico"),
                new Orden(2, 3080, 2, "Goma"),
                new Orden(3, 1224, 3, "Comida"),
            };
        }
    }
}