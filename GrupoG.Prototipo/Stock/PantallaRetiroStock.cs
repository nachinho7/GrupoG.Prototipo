using System;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo.Stock
{
    public partial class PantallaRetiroStock : Form
    {
        private PantallaRetiroStockModel modelo;

        public PantallaRetiroStock()
        {
            InitializeComponent();
            modelo = new PantallaRetiroStockModel();
        }

        private void PantallaRetiroStock_Load_1(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            var ordenes = modelo.ObtenerOrdenesSeleccion();
            comboBox1.Items.Clear();

            foreach (var orden in ordenes)
            {
                comboBox1.Items.Add(orden.numeroOrdenSeleccion);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            if (comboBox1.Items.Count > 0)
            {
                ComboBox1_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (comboBox1.SelectedIndex == -1) return;

            int numeroOrdenSeleccionada = int.Parse(comboBox1.SelectedItem.ToString());
            var mercaderias = modelo.ListarMercaderiasPorOrden(numeroOrdenSeleccionada);

            if (mercaderias != null)
            {
                foreach (var (ubicacion, id, nombre, cantidad, _, _) in mercaderias)
                {
                    var item = new ListViewItem(ubicacion);
                    item.SubItems.Add(id.ToString());
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(cantidad.ToString());
                    item.Tag = id;

                    listView1.Items.Add(item);
                }
            }
        }

        private void btnRetirarStock_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona y marca al menos una mercadería para retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numeroOrdenSeleccionada = int.Parse(comboBox1.SelectedItem.ToString());
            var ordenSeleccionada = modelo.ObtenerOrdenesSeleccion()
                .FirstOrDefault(o => o.numeroOrdenSeleccion == numeroOrdenSeleccionada);

            if (ordenSeleccionada == null)
            {
                MessageBox.Show("No se encontró la orden de selección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mercaderiasARetirar = listView1.SelectedItems
                .Cast<ListViewItem>()
                .Select(item =>
                {
                    int idMercaderia = int.Parse(item.SubItems[1].Text);
                    int cantidad = int.Parse(item.SubItems[3].Text);
                    string ubicacionSeleccionada = item.SubItems[0].Text;

                    var mercaderiaEntidad = MercaderiasAlmacen.Mercaderias.FirstOrDefault(m => m.idMercaderia == idMercaderia);
                    return (mercaderiaEntidad, cantidad, ubicacionSeleccionada, item);
                })
                .Where(m => m.mercaderiaEntidad != null)
                .ToList();

            modelo.RetiroStock(ordenSeleccionada, mercaderiasARetirar.Select(m => (m.mercaderiaEntidad, m.cantidad, m.ubicacionSeleccionada)).ToList());

            foreach (var mercaderia in mercaderiasARetirar)
            {
                var itemsToRemove = listView1.Items
                    .Cast<ListViewItem>()
                    .Where(item =>
                        item.SubItems[1].Text == mercaderia.item.SubItems[1].Text &&
                        item.SubItems[3].Text == mercaderia.item.SubItems[3].Text &&
                        item.SubItems[0].Text == mercaderia.item.SubItems[0].Text &&
                        item.Tag.ToString() == mercaderia.item.Tag.ToString())
                    .ToList();

                foreach (var item in itemsToRemove)
                {
                    listView1.Items.Remove(item);
                }
            }

            if (modelo.ObtenerOrdenesSeleccion().Count == 0)
            {
                MessageBox.Show("No quedan órdenes de selección.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PantallaMenu menu = new PantallaMenu();
                this.Hide();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Location = this.Location;
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
