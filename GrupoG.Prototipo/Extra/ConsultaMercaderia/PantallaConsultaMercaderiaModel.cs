using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Extra.ConsultaMercaderia
{
    internal class PantallaConsultaMercaderiaModel
    {
        public List<ClientesEntidad> ObtenerCliente(int numeroCliente)
        {
            var clienteEntidad = ClientesAlmacen.ObtenerNroCliente(numeroCliente); 

            if (clienteEntidad == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new List<ClientesEntidad> { clienteEntidad };
        }

        public List<(int IdMercaderia, string NombreMercaderia, List<(string Ubicacion, int Cantidad)>)> ObtenerMercaderiasPorCliente(int nroCliente)
        {
            if (MercaderiasAlmacen.Mercaderias == null || !MercaderiasAlmacen.Mercaderias.Any())
            {
                MessageBox.Show("No se encontraron mercaderías.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            var mercaderias = MercaderiasAlmacen.Mercaderias
                .Where(m => m.NroCliente == nroCliente)  
                .Select(m => (
                    IdMercaderia: m.idMercaderia,
                    NombreMercaderia: m.nombreMercaderia,
                    Ubicaciones: m.Ubicacion.Select(u => (u.NombreUbicacion, u.Cantidad)).ToList() 
                ))
                .ToList();

            if (!mercaderias.Any())
            {
                MessageBox.Show("No se encontraron mercaderías para el cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return mercaderias;
        }

        public void AgregarCantidadMercaderia(int idMercaderia, string nombreMercaderia, string ubicacion, int cantidad)
        {
            var mercaderia = MercaderiasAlmacen.Mercaderias.FirstOrDefault(m => m.idMercaderia == idMercaderia);
            if (mercaderia == null)
            {
                MessageBox.Show("Mercadería no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ubicacionMercaderia = mercaderia.Ubicacion.FirstOrDefault(u => u.NombreUbicacion == ubicacion);
            if (ubicacionMercaderia == null)
            {
                MessageBox.Show("Ubicación no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ubicacionMercaderia.Cantidad += cantidad;
        }

        public void RestarCantidadMercaderia(int idMercaderia, string nombreMercaderia, string ubicacion, int cantidad)
        {
            var mercaderia = MercaderiasAlmacen.Mercaderias.FirstOrDefault(m => m.idMercaderia == idMercaderia);
            if (mercaderia == null)
            {
                MessageBox.Show("Mercadería no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ubicacionMercaderia = mercaderia.Ubicacion.FirstOrDefault(u => u.NombreUbicacion == ubicacion);
            if (ubicacionMercaderia == null)
            {
                MessageBox.Show("Ubicación no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ubicacionMercaderia.Cantidad < cantidad)
            {
                MessageBox.Show("No hay suficiente cantidad en la ubicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ubicacionMercaderia.Cantidad -= cantidad;
        }



    }
}
