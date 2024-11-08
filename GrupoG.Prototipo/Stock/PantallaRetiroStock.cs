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
                foreach (var (ubicacion, id, nombre, cantidad, retirada, _, _) in mercaderias)
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
                MessageBox.Show("Debe seleccionar al menos un item para retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var seleccionados = listView1.SelectedItems.Cast<ListViewItem>()
                .Select(item => new
                {
                    Ubicacion = item.Text,
                    Id = (int)item.Tag,
                    Nombre = item.SubItems[2].Text,
                    Cantidad = int.Parse(item.SubItems[3].Text),
                    OrdenSeleccion = int.Parse(comboBox1.SelectedItem.ToString())
                }).ToList();

            var duplicados = seleccionados.GroupBy(m => new { m.Id, m.Nombre, m.Cantidad, m.OrdenSeleccion })
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            if (duplicados.Any())
            {
                MessageBox.Show("No puede retirar la misma mercadería de la misma orden en dos ubicaciones distintas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var item in seleccionados)
            {
                modelo.RetiroStock(item.Id, item.Ubicacion, item.Cantidad);

                var itemsAEliminar = listView1.Items.Cast<ListViewItem>()
                    .Where(lvItem =>
                        lvItem.Tag != null &&
                        (int)lvItem.Tag == item.Id &&
                        lvItem.SubItems[2].Text == item.Nombre &&
                        int.Parse(lvItem.SubItems[3].Text) == item.Cantidad &&
                        comboBox1.SelectedItem.ToString() == item.OrdenSeleccion.ToString() 
                    ).ToList();

                foreach (var lvItem in itemsAEliminar)
                {
                    listView1.Items.Remove(lvItem);
                }
            }


            if (listView1.Items.Count == 0)
            {
                modelo.ActualizarEstadoOrdenSeleccionCumplida(int.Parse(comboBox1.SelectedItem.ToString()));
                MessageBox.Show("Todos los items fueron retirados y el estado de la orden de selección ha sido actualizado a Cumplida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarOrdenes();
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
