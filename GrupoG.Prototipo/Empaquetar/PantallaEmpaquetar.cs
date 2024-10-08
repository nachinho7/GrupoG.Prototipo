using System;
using System.Linq;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Empaquetar
{
    public partial class PantallaEmpaquetar : Form
    {
        private PantallaEmpaquetarModel modelo;

        public PantallaEmpaquetar()
        {
            InitializeComponent();
            modelo = new PantallaEmpaquetarModel();

            // Asegurarnos de agregar el evento Load
            Load += PantallaEmpaquetar_Load;
        }

        private void PantallaEmpaquetar_Load(object sender, EventArgs e)
        {
            // Llamar al método para cargar las órdenes al iniciar el formulario
            CargarOrdenesPreparacion();
        }

        private void CargarOrdenesPreparacion()
        {
            var ordenesPreparacion = modelo.ObtenerOrdenesPreparacion();

            ComboBoxOrdenesPreparacion.Items.Clear(); // Limpiar elementos existentes en el ComboBox

            if (ordenesPreparacion.Count > 0)
            {
                // Agregar cada orden al ComboBox
                foreach (var orden in ordenesPreparacion)
                {
                    ComboBoxOrdenesPreparacion.Items.Add($"Orden N° {orden.NumeroOrdenPreparacion}");
                }

                // Seleccionar automáticamente la primera orden si hay elementos
                ComboBoxOrdenesPreparacion.SelectedIndex = 0;

                // Evento para manejar el cambio de selección en el ComboBox
                ComboBoxOrdenesPreparacion.SelectedIndexChanged += ComboBoxOrdenesPreparacion_SelectedIndexChanged;

                // Cargar los productos de la primera orden automáticamente
                ComboBoxOrdenesPreparacion_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("No hay órdenes de preparación disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxOrdenesPreparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // Limpiar el ListView

            // Verificar que haya una selección en el ComboBox
            if (ComboBoxOrdenesPreparacion.SelectedIndex == -1) return;

            // Obtener el número de la orden seleccionada (base 0 del índice)
            int indiceOrdenSeleccionada = ComboBoxOrdenesPreparacion.SelectedIndex;

            // Obtener la orden seleccionada directamente del modelo
            var ordenSeleccionada = modelo.ObtenerOrdenesPreparacion()[indiceOrdenSeleccionada];

            if (ordenSeleccionada != null)
            {
                // Agregar mercaderías de la orden seleccionada al ListView
                foreach (var mercaderia in ordenSeleccionada.Mercaderias)
                {
                    var item = new ListViewItem(mercaderia.idMercaderia.ToString());
                    item.SubItems.Add(mercaderia.nombreMercaderia);
                    item.SubItems.Add(mercaderia.cantidadMercaderia.ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void btnEmpaquetar_Click(object sender, EventArgs e)
        {
            // Verificar que haya ítems en el ListView para empaquetar
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No hay mercaderías para empaquetar en esta orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la orden seleccionada
            var ordenSeleccionada = modelo.ObtenerOrdenesPreparacion()[ComboBoxOrdenesPreparacion.SelectedIndex];

            MessageBox.Show($"La orden de preparación N° {ordenSeleccionada.NumeroOrdenPreparacion} ha sido empaquetada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Simular que la orden ha sido empaquetada y removerla del listado
            modelo.RemoverOrdenPreparacion(ordenSeleccionada);

            // Recargar las órdenes
            CargarOrdenesPreparacion();

            // Si todavía hay órdenes, seleccionar la siguiente automáticamente
            if (ComboBoxOrdenesPreparacion.Items.Count > 0)
            {
                ComboBoxOrdenesPreparacion.SelectedIndex = 0; // Seleccionar la primera orden
                ComboBoxOrdenesPreparacion_SelectedIndexChanged(this, EventArgs.Empty); // Forzar la actualización
            }
            else
            {
                // Si no quedan órdenes, limpiar el ListView y mostrar un mensaje
                listView1.Items.Clear();
                MessageBox.Show("No quedan más órdenes de preparación disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Volver al menú principal
                this.Close();
            }
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
