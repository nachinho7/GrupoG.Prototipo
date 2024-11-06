using GrupoG.Prototipo.Almacenes.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrupoG.Prototipo.Almacenes.Mercaderias
{
    internal class MercaderiasAlmacen
    {
        private static List<MercaderiasEntidad> mercaderias = new List<MercaderiasEntidad>();

        static MercaderiasAlmacen()
        {
            Leer();
        }

        public static IReadOnlyCollection<MercaderiasEntidad> Mercaderias => mercaderias.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(mercaderias);
            File.WriteAllText(@"Json\Mercaderia.json", datos);
        }

        public static void Leer()
        {

            if (!File.Exists(@"Json\Mercaderia.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Json\Mercaderia.json");

            mercaderias = JsonSerializer.Deserialize<List<MercaderiasEntidad>>(datos)!;
        }

        public static MercaderiasEntidad ObtenerMercaderias(int numero)
        {
            var mercaderias = Mercaderias.FirstOrDefault(c => c.NroCliente == numero);
            return mercaderias;
        }

        public static int BuscaridMercaderia(string nombre)
        {
            var mercaderia = Mercaderias.FirstOrDefault(m => m.nombreMercaderia == nombre);
            return mercaderia.idMercaderia;
        }

        public static string BuscarNombreMercaderia(int id)
        {
            var mercaderia = Mercaderias.FirstOrDefault(m => m.idMercaderia == id);
            return mercaderia.nombreMercaderia;
        }

        public static void AgregarStock(MercaderiasEntidad mercaderia)
        {
            mercaderias.Add(mercaderia);
        }

        public static void EliminarPosicion(MercaderiasEntidad mercaderia)
        {
            mercaderia.Ubicacion = null;
        }

        public static void CambiarCantidad(MercaderiasUbicacion mercaderia, int mercaderiaretirada)
        {
            mercaderia.Cantidad -= mercaderiaretirada;
        }

    }
}
