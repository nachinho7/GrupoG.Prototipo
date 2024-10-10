using System;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo.Empaquetar
{
    public partial class PantallaEmpaquetar : Form
    {
        private PantallaEmpaquetarModel modelo;

        public PantallaEmpaquetar()
        {
            InitializeComponent();
            modelo = new PantallaEmpaquetarModel();
        }

        private void PantallaEmpaquetar_Load(object sender, EventArgs e)
        {
            CargarOrdenesPreparacion();
        }

        private void CargarOrdenesPreparacion()
        {
            var ordenesPreparacion = modelo.ObtenerOrdenesPreparacion();

            ComboBoxOrdenesPreparacion.Items.Clear();

            if (ordenesPreparacion.Count > 0)
            {
                foreach (var orden in ordenesPreparacion)
                {
                    ComboBoxOrdenesPreparacion.Items.Add($"Orden N° {orden.NumeroOrdenPreparacion}");
                }

                ComboBoxOrdenesPreparacion.SelectedIndex = 0;
                ComboBoxOrdenesPreparacion.SelectedIndexChanged += ComboBoxOrdenesPreparacion_SelectedIndexChanged;
                ComboBoxOrdenesPreparacion_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("No hay órdenes de preparación disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxOrdenesPreparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (ComboBoxOrdenesPreparacion.SelectedIndex == -1) return;

            int indiceOrdenSeleccionada = ComboBoxOrdenesPreparacion.SelectedIndex;

            var mercaderias = modelo.ObtenerMercaderiasPorOrden(indiceOrdenSeleccionada);

            if (mercaderias != null)
            {
                foreach (var mercaderia in mercaderias)
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
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No hay mercaderías para empaquetar en esta orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ordenSeleccionada = modelo.ObtenerOrdenesPreparacion()[ComboBoxOrdenesPreparacion.SelectedIndex];

            MessageBox.Show($"La orden de preparación N° {ordenSeleccionada.NumeroOrdenPreparacion} ha sido empaquetada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            modelo.RemoverOrdenPreparacion(ordenSeleccionada);
            CargarOrdenesPreparacion();

            if (ComboBoxOrdenesPreparacion.Items.Count > 0)
            {
                ComboBoxOrdenesPreparacion.SelectedIndex = 0;
                ComboBoxOrdenesPreparacion_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
            {
                listView1.Items.Clear();
                this.Close();
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
