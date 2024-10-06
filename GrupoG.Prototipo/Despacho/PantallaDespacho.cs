using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Despacho;
using GrupoG.Prototipo.Preparacion;

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
                MessageBox.Show("Por favor, ingrese un número de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ordenes = model.ObtenerOrdenesPorCliente(numeroClienteInt);

            if (ordenes == null || ordenes.Count == 0)
            {
                MessageBox.Show("No se encontraron órdenes para el cliente ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listviewOrdenEntrega.Items.Clear();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(orden.IdDespacho.ToString());
                item.SubItems.Add(orden.Estado);
                item.SubItems.Add(orden.NroCliente.ToString());
                listviewOrdenEntrega.Items.Add(item);
            }

            dniTransportista.Enabled = true;
            btnBuscarTransportista.Enabled = true;
        }

        private void btnBuscarTransportista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dniTransportista.Text) || !int.TryParse(dniTransportista.Text, out int dniInt))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No se encontró el transportista con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGenerarRemito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeroCliente.Text) || !int.TryParse(numeroCliente.Text, out int clienteNumero) || listviewTransportista.Items.Count == 0)
            {
                MessageBox.Show("No se puede generar remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(dniTransportista.Text) || !int.TryParse(dniTransportista.Text, out int dniTransportistaInt))
            {
                MessageBox.Show("No se puede generar remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el transportista seleccionado
            var transportista = model.ObtenerTransportistaPorDni(dniTransportistaInt);

            if (transportista == null || !transportista.habilitadoTransportista)
            {
                MessageBox.Show("No se puede generar remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el número de orden desde el ListView
            if (listviewOrdenEntrega.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una orden de entrega antes de generar el remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listviewOrdenEntrega.SelectedItems.Count > 1)
            {
                MessageBox.Show("No se puede seleccionar más de una orden seguida para despachar.", "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listviewOrdenEntrega.SelectedItems[0];
            string numeroOrden = selectedItem.SubItems[0].Text;

            if (!int.TryParse(numeroOrden, out int idDespacho))
            {
                MessageBox.Show("Error al obtener el ID de la orden seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string datosAdicionales = textboxDatosAdicionales.Text;

            string mensaje = $"La orden N°{numeroOrden} ha sido despachada, y el remito ha sido generado.\n" +
                             $"Cliente: {clienteNumero}\n" +
                             $"DNI Transportista: {dniTransportistaInt}\n" +
                             $"{(string.IsNullOrWhiteSpace(datosAdicionales) ? "" : $"Datos Adicionales: {datosAdicionales}")}";

            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listviewOrdenEntrega.Items.Remove(selectedItem);

            model.EliminarOrdenPorId(idDespacho);
            listviewOrdenEntrega.Items.Clear();

            numeroCliente.Text = string.Empty;
            numeroCliente.Enabled = true;

            dniTransportista.Text = string.Empty;
            listviewTransportista.Items.Clear();
            textboxDatosAdicionales.Text = string.Empty;

            dniTransportista.Enabled = false;
            btnBuscarTransportista.Enabled = false;
        }

        private void btnlimpiarCliente_Click(object sender, EventArgs e)
        {
            numeroCliente.Enabled = true;
            numeroCliente.Text = string.Empty;

            listviewOrdenEntrega.Items.Clear();
            dniTransportista.Text = string.Empty;
            textboxDatosAdicionales.Text = string.Empty;
            listviewTransportista.Items.Clear();


            dniTransportista.Enabled = false;
            btnBuscarTransportista.Enabled = false;
        }

       
    }
}
