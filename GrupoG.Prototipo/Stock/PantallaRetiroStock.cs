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
                foreach (var (idMercaderia, nombreMercaderia, cantidadTotal, ubicaciones) in mercaderias)
                {
                    int cantidadPendiente = cantidadTotal;

                    foreach (var (ubicacion, cantidadUbicacion) in ubicaciones)
                    {
                        if (cantidadPendiente <= 0) break;

                        int cantidadARetirar = Math.Min(cantidadPendiente, cantidadUbicacion);

                        var item = new ListViewItem(idMercaderia.ToString());
                        item.SubItems.Add(ubicacion);
                        item.SubItems.Add(cantidadARetirar.ToString());
                        item.SubItems.Add(nombreMercaderia);
                        item.SubItems.Add(cantidadARetirar.ToString());
                        item.Tag = idMercaderia;

                        listView1.Items.Add(item);

                        cantidadPendiente -= cantidadARetirar;
                    }

                    if (cantidadPendiente > 0)
                    {
                        MessageBox.Show($"No se pudo retirar toda la cantidad para la mercadería ID {idMercaderia}. " +
                                         $"Cantidad restante: {cantidadPendiente}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            foreach (ListViewItem item in listView1.Items.Cast<ListViewItem>().ToList())
            {
                int idMercaderia = (int)item.Tag;
                int cantidadDetalle = int.Parse(item.SubItems[4].Text);

                var ubicaciones = modelo.ListarMercaderiasPorOrden(numeroOrdenSeleccionada)
                    .Where(m => m.IdMercaderia == idMercaderia)
                    .SelectMany(m => m.Item4)
                    .ToList();

                int cantidadRestante = modelo.RetiroStock(idMercaderia, ubicaciones, cantidadDetalle);

                if (cantidadRestante == 0)
                {
                    listView1.Items.Remove(item);
                }
                else
                {
                    item.SubItems[4].Text = cantidadRestante.ToString();
                    stockCompletoRetirado = false;
                }
            }

            if (stockCompletoRetirado)
            {
                modelo.ActualizarEstadoOrdenSeleccionCumplida(numeroOrdenSeleccionada);
                MessageBox.Show("Orden de selección completada y stock retirado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.Items.Clear();
                comboBox1.Items.Remove(numeroOrdenSeleccionada);

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
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
