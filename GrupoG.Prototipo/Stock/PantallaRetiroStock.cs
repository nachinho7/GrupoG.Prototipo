using System;
using System.Linq;
using System.Windows.Forms;
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
                comboBox1.Items.Add($"Orden N° {orden.numeroOrdenSeleccion}");
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

            int numeroOrdenSeleccionada = int.Parse(comboBox1.SelectedItem.ToString().Split(' ')[2]);
            var mercaderias = modelo.ListarMercaderiasPorOrden(numeroOrdenSeleccionada);

            if (mercaderias != null)
            {
                foreach (var mercaderia in mercaderias)
                {
                    foreach (var ubicacion in mercaderia.Ubicacion)
                    {
                        var item = new ListViewItem(ubicacion.NombreUbicacion);
                        item.SubItems.Add(mercaderia.idMercaderia.ToString());
                        item.SubItems.Add(mercaderia.nombreMercaderia);
                        item.SubItems.Add(ubicacion.Cantidad.ToString());
                        item.Tag = mercaderia;
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void btnRetirarStock_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos una mercadería para retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numeroOrdenSeleccionada = int.Parse(comboBox1.SelectedItem.ToString().Split(' ')[2]);
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
                    return new Mercaderias { idMercaderia = idMercaderia, cantidadMercaderia = cantidad };
                })
                .ToList();

            modelo.RetiroStock(ordenSeleccionada, mercaderiasARetirar);

            CargarOrdenes();

            if (modelo.ObtenerOrdenesSeleccion().Count == 0)
            {
                MessageBox.Show("No quedan órdenes de selección.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PantallaMenu menu = new PantallaMenu();
                this.Hide();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Location = this.Location;
                menu.Show();
            }
            else
            {
                comboBox1.SelectedIndex = Math.Min(comboBox1.SelectedIndex, comboBox1.Items.Count - 1);
                ComboBox1_SelectedIndexChanged(this, EventArgs.Empty);
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
    }
}
