using System;
using System.Linq;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Stock
{
    public partial class PantallaRetiroStock : Form
    {
        private PantallaRetiroStockModel modelo;

        public PantallaRetiroStock()
        {
            InitializeComponent();
            modelo = new PantallaRetiroStockModel();
            Load += PantallaRetiroStock_Load; // Agregado en el constructor
        }

        private void PantallaRetiroStock_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            var ordenes = modelo.ObtenerOrdenesSeleccionadas();
            comboBox1.Items.Clear(); // Limpiar elementos existentes

            foreach (var orden in ordenes)
            {
                // Agregar ordenes al comboBox
                comboBox1.Items.Add($"Orden N° {orden.numeroOrdenSeleccion}");
            }

            // Si hay elementos, seleccionamos el primero
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0; // Selecciona el primer elemento
            }

            // Evento para manejar la selección en el comboBox
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            // Cargar el ListView con la primera orden
            if (comboBox1.Items.Count > 0)
            {
                ComboBox1_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // Limpiar ListView

            // Verificar que haya una selección
            if (comboBox1.SelectedIndex == -1) return;

            // Obtener la orden seleccionada utilizando el índice
            int numeroOrdenSeleccion = comboBox1.SelectedIndex; // Mantener base 0

            // Obtener la orden seleccionada directamente del modelo
            var ordenSeleccionada = modelo.ObtenerOrdenesSeleccionadas()[numeroOrdenSeleccion];

            if (ordenSeleccionada != null)
            {
                foreach (var mercaderia in ordenSeleccionada.Mercaderias)
                {
                    var item = new ListViewItem(mercaderia.idMercaderia.ToString());
                    item.SubItems.Add(mercaderia.nombreMercaderia);
                    item.SubItems.Add(mercaderia.cantidadMercaderia.ToString());
                    item.SubItems.Add(mercaderia.ubicacionMercaderia.ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void btnRetirarStock_Click(object sender, EventArgs e)
        {
            // Verificar que haya ítems seleccionados en el ListView
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos una mercadería para retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la orden seleccionada
            var ordenSeleccionada = modelo.ObtenerOrdenesSeleccionadas()[comboBox1.SelectedIndex];

            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                int idMercaderia = int.Parse(selectedItem.Text); // ID de la mercadería
                var mercaderia = ordenSeleccionada.Mercaderias.FirstOrDefault(m => m.idMercaderia == idMercaderia);

                if (mercaderia != null)
                {
                    // Verificar si la cantidad es mayor que cero
                    if (mercaderia.cantidadMercaderia > 0)
                    {
                        // Resta todo el stock
                        int cantidadRetirada = mercaderia.cantidadMercaderia;
                        mercaderia.cantidadMercaderia = 0; // Restar todo el stock
                        MessageBox.Show($"Se han retirado {cantidadRetirada} unidades de {mercaderia.nombreMercaderia}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No hay stock disponible para {mercaderia.nombreMercaderia}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Comprobar si la orden está vacía después de retirar
            if (ordenSeleccionada.Mercaderias.All(m => m.cantidadMercaderia == 0))
            {
                modelo.RemoverOrdenSeleccionada(ordenSeleccionada); // Eliminar la orden
                MessageBox.Show("La orden seleccionada ha sido completamente retirada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Volver a cargar la lista de órdenes
            CargarOrdenes();

            // Si no quedan más órdenes, mostrar mensaje y volver al menú
            if (modelo.ObtenerOrdenesSeleccionadas().Count == 0)
            {
                MessageBox.Show("No quedan órdenes de selección.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario y vuelve al menú
            }
            else
            {
                // Volver a cargar la orden seleccionada si sigue disponible
                if (comboBox1.SelectedIndex == -1 && comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0; // Selecciona la primera orden disponible
                }
                else
                {
                    ComboBox1_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
