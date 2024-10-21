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

            var ordenes = model.ObtenerOrdenesPorDni(dniInt);

            if (ordenes != null && ordenes.Count > 0)
            {
                MostrarOrdenes(ordenes, true);
                MessageBox.Show("Transportista válido y con órdenes encontradas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron órdenes para el transportista con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarOrdenes(System.Collections.Generic.List<OrdenPreparacion> ordenes, bool habilitadoTransportista)
        {
            listviewTransportista.Items.Clear();
            string estadoTransportista = habilitadoTransportista ? "Habilitado" : "No habilitado";

            foreach (var orden in ordenes)
            {
                var ordenItem = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                ordenItem.SubItems.Add(orden.NroCliente.ToString());
                ordenItem.SubItems.Add(estadoTransportista);
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

            var transportista = model.ObtenerOrdenesPorDni(dniTransportistaInt);

            if (transportista == null || transportista.Count == 0)
            {
                MessageBox.Show("No se puede generar remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Remito nuevoRemito = model.GenerarRemito(dniTransportistaInt, transportista);

            string mensaje = $"El remito ha sido generado.\n" +
                             $"DNI Transportista: {dniTransportistaInt}\n" +
                             $"Número de Remito: {nuevoRemito.NumeroRemito}";

            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (var orden in transportista)
            {
                model.EliminarOrdenPorId(orden.NumeroOrdenPreparacion);
            }

            dniTransportista.Text = string.Empty;
            listviewTransportista.Items.Clear();

            dniTransportista.Enabled = true;
            btnBuscarTransportista.Enabled = true;
        }
    }
}
