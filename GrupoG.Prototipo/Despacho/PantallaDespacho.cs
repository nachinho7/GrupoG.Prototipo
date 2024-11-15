using System;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Menu;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Almacenes.Remito;
using System.Reflection;

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
        }

        private void btnBuscarTransportista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dniTransportista.Text) || !int.TryParse(dniTransportista.Text, out int dniInt))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var clientes = model.ObtenerClientesPorDni(dniInt);

            if (clientes != null && clientes.Count > 0)
            {
                comboBoxClientes.DataSource = clientes;
                comboBoxClientes.DisplayMember = "NroCliente"; 
                comboBoxClientes.ValueMember = "NroCliente";
                comboBoxClientes.SelectedIndex = 0;
                comboBoxClientes.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron clientes relacionados al DNI ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listviewTransportista.Items.Clear();

            if (comboBoxClientes.SelectedValue is int nroClienteSeleccionado && dniTransportista.Text is string dnitransportista)
            {
                var ordenes = model.ObtenerOrdenesPorDni(nroClienteSeleccionado, int.Parse(dnitransportista));

                foreach (var orden in ordenes)
                {
                    var item = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                    item.SubItems.Add(orden.NroCliente.ToString());
                    listviewTransportista.Items.Add(item);
                }
            }
        }


        private void btnGenerarRemito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dniTransportista.Text) || !int.TryParse(dniTransportista.Text, out int dniTransportistaInt))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listviewTransportista.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes disponibles para generar el remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ordenesIds = listviewTransportista.Items.Cast<ListViewItem>()
                .Select(item => int.Parse(item.Text))
                .ToList();

            var nuevoRemito = model.GenerarRemito(dniTransportistaInt, ordenesIds);

            if (nuevoRemito != null)
            {
                string mensaje = $"El remito ha sido generado.\n" +
                                 $"DNI Transportista: {dniTransportistaInt}\n" +
                                 $"Número de Remito: {nuevoRemito.NroRemito}\n" +
                                 $"Ordenes: {ordenesIds.Count}";

                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo generar el remito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dniTransportista.Text = string.Empty;
            listviewTransportista.Items.Clear();
            comboBoxClientes.DataSource = null;
        }

    }
}
