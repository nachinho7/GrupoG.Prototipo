using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Objetos;
using GrupoG.Prototipo.Pantallas.Despacho;

namespace GrupoG.Prototipo.Pantallas
{
    public partial class PantallaDespacho : Form
    {
        private PantallaDespachoModel model;

        public PantallaDespacho()
        {
            InitializeComponent();
            model = new PantallaDespachoModel();
        }

        private void PantallaDespacho_Load(object sender, EventArgs e)
        {
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonObtenerDatos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeroCliente.Text) || !int.TryParse(numeroCliente.Text, out int numeroClienteInt))
            {
                MessageBox.Show("Por favor, ingrese un número de cliente válido.");
                return;
            }

            var ordenes = model.ObtenerOrdenesPorCliente(numeroClienteInt);
            listviewOrdenEntrega.Items.Clear();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(orden.IdDespacho.ToString());
                item.SubItems.Add(orden.Estado);
                item.SubItems.Add(orden.NroCliente.ToString());
                listviewOrdenEntrega.Items.Add(item);
            }
        }

        private void btnBuscarTransportista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dniTransportista.Text) || !int.TryParse(dniTransportista.Text, out int dniInt))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");
                return;
            }

            var transportista = model.ObtenerTransportistaPorDni(dniInt);

            if (transportista != null)
            {
                if (transportista.habilitadoTransportista && transportista.Clientes.Any(c => c.NumeroCliente == int.Parse(numeroCliente.Text)))
                {
                    MostrarTransportista(transportista);
                    MessageBox.Show("Transportista válido y asociado con el cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    listviewTransportista.Items.Clear();
                    MessageBox.Show("El transportista no está habilitado o no está asociado con este cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el transportista con ese DNI.");
                listviewTransportista.Items.Clear();
            }
        }

        private void MostrarTransportista(Transportistas transportista)
        {
            listviewTransportista.Items.Clear();
            string estadoTransportista = transportista.habilitadoTransportista ? "Habilitado" : "No habilitado";

            var item = new ListViewItem(transportista.Clientes[0].NumeroCliente.ToString());
            item.SubItems.Add(estadoTransportista);
            item.SubItems.Add(transportista.patente);
            listviewTransportista.Items.Add(item);
        }
    }
}
