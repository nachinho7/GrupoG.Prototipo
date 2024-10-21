using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo.Entrega
{
    public partial class PantallaEntrega : Form
    {
        private readonly PantallaEntregaModel model;

        public PantallaEntrega()
        {
            InitializeComponent();
            model = new PantallaEntregaModel();
        }

        private void PantallaEntrega_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            var ordenes = model.ObtenerOrdenes();

            ListaOrdenesEmpaquetar.Items.Clear();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                item.SubItems.Add(orden.NumeroCliente.ToString());
                item.SubItems.Add(orden.Mercaderias[0].cantidadMercaderia.ToString());
                item.SubItems.Add(orden.DNITransportista.ToString());
                item.SubItems.Add(orden.FechaDespacho.ToString());

                ListaOrdenesEmpaquetar.Items.Add(item);
            }
        }

        private void BotonEntregar_Click(object sender, EventArgs e)
        {
            

            var ordenesSeleccionadas = new List<OrdenPreparacion>();
            foreach (ListViewItem selectedItem in ListaOrdenesEmpaquetar.SelectedItems)
            {
                var numeroOrdenPreparacion = int.Parse(selectedItem.Text);
                var ordenPreparacion = model.ObtenerOrdenes().FirstOrDefault(o => o.NumeroOrdenPreparacion == numeroOrdenPreparacion);

                if (ordenPreparacion != null)
                {
                    ordenesSeleccionadas.Add(ordenPreparacion);
                }
            }

            var ordenesEntregas = model.GenerarOrdenEntrega(ordenesSeleccionadas);

            ListaOrdenesEmpaquetar.Items.Clear();

            MessageBox.Show("Las órdenes de entrega han sido generadas.", "Órdenes de Entrega Generadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PantallaMenu menu = new PantallaMenu();
            this.Hide();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Location = this.Location;
            menu.Show();
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
