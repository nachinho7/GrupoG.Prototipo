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

        private void PantallaSeleccion_Shown(object sender, EventArgs e)
        {
            CargarOrdenes();

            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron órdenes para seleccionar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void PantallaSeleccion_Load(object sender, EventArgs e)
        {
            datetimeDespacho.CustomFormat = " "; 
            datetimeDespacho.Format = DateTimePickerFormat.Custom;

            CargarClientes();
            CargarTransportistas();
        }

        private void CargarOrdenes()
        {
            listView1.Items.Clear();

            var ordenes = modelo.ObtenerOrdenPreparacion();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                item.SubItems.Add(orden.NroCliente.ToString());
                item.SubItems.Add(orden.FechaDespacho.ToShortDateString());
                item.SubItems.Add(orden.DNITransportista.ToString());
                item.SubItems.Add(orden.Deposito.ToString());
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

        private void BotonMostrarTodas_Click(object sender, EventArgs e)
        {
            datetimeDespacho.CustomFormat = " ";
            comboBoxTransportista.SelectedIndex = 0;
            comboBoxCliente.SelectedIndex = 0;
            CargarOrdenes();
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
                item.SubItems.Add(orden.NroCliente.ToString());
                item.SubItems.Add(orden.FechaDespacho.ToShortDateString());
                item.SubItems.Add(orden.DNITransportista.ToString());
                item.SubItems.Add(orden.Deposito.ToString());
                item.Tag = orden;
                listView1.Items.Add(item);
            }
        }



        private void BotonGenerarOS_Click(object sender, EventArgs e)
        {
            var ordenesSeleccionadas = listView1.CheckedItems
                .Cast<ListViewItem>()
                .Select(item => item.Tag as OrdenPreparacion)
                .Where(orden => orden != null)
                .ToList();

            if (ordenesSeleccionadas.Any())
            {
                var depositoUnico = ordenesSeleccionadas.Select(o => o.Deposito).Distinct().Count() == 1;

                if (!depositoUnico)
                {
                    MessageBox.Show("No se puede generar una orden de selección con números de depósito distintos.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevaSeleccion = modelo.CrearOrdenSeleccion(ordenesSeleccionadas);
                MessageBox.Show($"Orden de Selección N°{nuevaSeleccion.numeroOrdenSeleccion} generada!\n" +
                                $"Incluye {ordenesSeleccionadas.Count} órdenes de preparación.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                datetimeDespacho.CustomFormat = " ";
                comboBoxTransportista.SelectedIndex = 0;
                comboBoxCliente.SelectedIndex = 0;

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
        }

        
    }
}
