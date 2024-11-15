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

        private void PantallaRetiroStock_Shown(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes de selección disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PantallaRetiroStock_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
            comboBox1.Enabled = false;

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
                foreach (var (id, nombre, cantidadTotal, ubicaciones) in mercaderias)
                {
                    foreach (var (ubicacion, cantidadUbicacion) in ubicaciones)
                    {
                        var item = new ListViewItem(id.ToString());
                        item.SubItems.Add(nombre);
                        item.SubItems.Add(cantidadTotal.ToString());
                        item.SubItems.Add(ubicacion);
                        item.SubItems.Add(cantidadUbicacion.ToString());
                        item.Tag = id;

                        listView1.Items.Add(item);
                    }
                }
            }
        }


        private void btnRetirarStock_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || listView1.Items.Count == 0)
            {
                MessageBox.Show("Seleccione una orden válida con mercaderías para retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int numeroOrdenSeleccionada = int.Parse(comboBox1.SelectedItem.ToString());
            bool stockCompletoRetirado = true;

            foreach (ListViewItem item in listView1.Items)
            {
                int idMercaderia = (int)item.Tag;
                int cantidadDetalle = int.Parse(item.SubItems[4].Text);

                var ubicaciones = modelo.ListarMercaderiasPorOrden(numeroOrdenSeleccionada)
                                      .Where(m => m.Id == idMercaderia)
                                      .SelectMany(m => m.Item4).ToList();

                int cantidadRestante = modelo.RetiroStock(idMercaderia, ubicaciones, cantidadDetalle);

                if (cantidadRestante > 0)
                {
                    stockCompletoRetirado = false;
                }
            }

            if (stockCompletoRetirado)
            {
                modelo.ActualizarEstadoOrdenSeleccionCumplida(numeroOrdenSeleccionada);
                MessageBox.Show("Orden de selección completada y stock retirado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.Items.Clear();

                int siguienteIndice = comboBox1.SelectedIndex + 1;
                if (siguienteIndice < comboBox1.Items.Count)
                {
                    comboBox1.SelectedIndex = siguienteIndice;
                }
                else
                {
                    comboBox1.SelectedIndex = -1;
                    listView1.Items.Clear();
                    MessageBox.Show("No hay más órdenes de selección.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se pudo retirar todo el stock de algunas mercaderías. Verifique la cantidad disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
