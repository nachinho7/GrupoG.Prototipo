using System;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo.Seleccion
{
    public partial class PantallaSeleccion : Form
    {
        private PantallaSeleccionModel modelo;

        public PantallaSeleccion()
        {
            InitializeComponent();
            modelo = new PantallaSeleccionModel();
        }

        private void PantallaSeleccion_Load(object sender, EventArgs e)
        {
            datetimeDespacho.CustomFormat = " "; 
            datetimeDespacho.Format = DateTimePickerFormat.Custom; 

            CargarOrdenes();
            CargarClientes();
            CargarTransportistas();
        }

        private void CargarOrdenes()
        {
            listView1.Items.Clear();

            var ordenes = modelo.ObtenerOrdenes();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                item.SubItems.Add(orden.NumeroCliente.ToString());
                item.SubItems.Add(orden.FechaDespacho.ToShortDateString());
                item.SubItems.Add(orden.DNITransportista.ToString());
                item.Tag = orden;
                listView1.Items.Add(item);
            }
        }

        private void CargarClientes()
        {
            var clientes = modelo.ObtenerClientesDisponibles();

            comboBoxCliente.Items.Clear();
            comboBoxCliente.Items.Add("Todos");
            foreach (var cliente in clientes)
            {
                comboBoxCliente.Items.Add(cliente);
            }
            comboBoxCliente.SelectedIndex = 0;
            comboBoxCliente.SelectedIndexChanged += ComboBoxCliente_SelectedIndexChanged;
        }

        private void CargarTransportistas()
        {
            var transportistas = modelo.ObtenerTransportistasDisponibles();

            comboBoxTransportista.Items.Clear();
            comboBoxTransportista.Items.Add("Todos");
            foreach (var transportista in transportistas)
            {
                comboBoxTransportista.Items.Add(transportista);
            }
            comboBoxTransportista.SelectedIndex = 0;
            comboBoxTransportista.SelectedIndexChanged += ComboBoxTransportista_SelectedIndexChanged;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
            datetimeDespacho.CustomFormat = "dd/MM/yyyy"; 
            FiltrarOrdenes(); 
        }

        private void ComboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarOrdenes();
        }

        private void ComboBoxTransportista_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarOrdenes();
        }

        private void FiltrarOrdenes()
        {
            listView1.Items.Clear();

            
            DateTime fechaSeleccionada = datetimeDespacho.CustomFormat == " " ? DateTime.MinValue : datetimeDespacho.Value.Date;
            var clienteSeleccionado = comboBoxCliente.SelectedItem.ToString();
            int? numeroCliente = clienteSeleccionado == "Todos" ? (int?)null : int.Parse(clienteSeleccionado);

            var transportistaSeleccionado = comboBoxTransportista.SelectedItem.ToString();
            int? dniTransportista = transportistaSeleccionado == "Todos" ? (int?)null : int.Parse(transportistaSeleccionado);

            var ordenesFiltradas = modelo.FiltrarOrdenesPorClienteYFechaYTransportista(numeroCliente, fechaSeleccionada == DateTime.MinValue ? (DateTime?)null : fechaSeleccionada, dniTransportista);

            foreach (var orden in ordenesFiltradas)
            {
                var item = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                item.SubItems.Add(orden.NumeroCliente.ToString());
                item.SubItems.Add(orden.FechaDespacho.ToShortDateString());
                item.SubItems.Add(orden.DNITransportista.ToString());
                item.Tag = orden;
                listView1.Items.Add(item);
            }
        }

        private void BotonGenerarOS_Click(object sender, EventArgs e)
        {
            var ordenesSeleccionadas = listView1.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => item.Tag as OrdenPreparacion)
                .ToList();

            if (ordenesSeleccionadas.Count > 0)
            {
                var nuevaSeleccion = modelo.GenerarOrdenDeSeleccion(ordenesSeleccionadas);
                MessageBox.Show($"Orden de Selección N°{nuevaSeleccion.numeroOrdenSeleccion} generada!\n" +
                                $"Incluye {ordenesSeleccionadas.Count} órdenes de preparación.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarOrdenes();
            }
            else
            {
                MessageBox.Show("No se seleccionaron órdenes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu menu = new PantallaMenu();
            this.Hide();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Location = this.Location;
            menu.Show();
        }

        private void BotonMostrarTodas_Click(object sender, EventArgs e)
        {
            datetimeDespacho.CustomFormat = " ";
            CargarOrdenes();
        }
    }
}
