using System;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo.Despacho
{
    public partial class PantallaDespacho : Form
    {
        private PantallaDespachoModel model;

        public PantallaDespacho()
        {
            InitializeComponent();
            model = new PantallaDespachoModel();

            dniTransportista.Enabled = true;
            btnBuscarTransportista.Enabled = true;
        }

        private void PantallaDespacho_Load(object sender, EventArgs e)
        {

        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu menu = new PantallaMenu();
            this.Hide();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Location = this.Location;
            menu.Show();
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
                if (transportista.habilitadoTransportista)
                {
                    MostrarTransportista(transportista);
                    MessageBox.Show("Transportista válido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El transportista no está habilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el transportista con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarTransportista(Transportistas transportista)
        {
            listviewTransportista.Items.Clear();
            string estadoTransportista = transportista.habilitadoTransportista ? "Habilitado" : "No habilitado";

            var ordenes = model.ObtenerOrdenesPorCliente(transportista.Clientes[0].NumeroCliente);

            foreach (var orden in ordenes)
            {
                var ordenItem = new ListViewItem(estadoTransportista);
                ordenItem.SubItems.Add(transportista.patente);
                ordenItem.SubItems.Add(orden.IdDespacho.ToString());
                ordenItem.SubItems.Add(transportista.Clientes[0].NumeroCliente.ToString());
                listviewTransportista.Items.Add(ordenItem);
            }
        }

        private void btnGenerarRemito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dniTransportista.Text) || !int.TryParse(dniTransportista.Text, out int dniTransportistaInt))
            {
                MessageBox.Show("No se puede generar remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var transportista = model.ObtenerTransportistaPorDni(dniTransportistaInt);

            if (transportista == null || !transportista.habilitadoTransportista)
            {
                MessageBox.Show("No se puede generar remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = $"El remito ha sido generado.\n" +
                             $"DNI Transportista: {dniTransportistaInt}\n";

            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dniTransportista.Text = string.Empty;
            listviewTransportista.Items.Clear();

            dniTransportista.Enabled = true;
            btnBuscarTransportista.Enabled = true;
        }
    }
}
