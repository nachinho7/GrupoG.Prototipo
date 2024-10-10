
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                item.SubItems.Add(orden.FechaDespacho.ToString());

              
                ListaOrdenesEmpaquetar.Items.Add(item);
            }
        }

        private void BotonEmpaquetar_Click(object sender, EventArgs e)
        {
            if (ListaOrdenesEmpaquetar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden para empaquetar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ListaOrdenesEmpaquetar.SelectedItems.Count > 1)
            {
                MessageBox.Show("No se puede seleccionar más de una orden seguida para empaquetar.", "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var selectedItem = ListaOrdenesEmpaquetar.SelectedItems[0];

            // nro orden
            int nroOrden = int.Parse(selectedItem.Text);
            var orden = model.ObtenerOrdenes().FirstOrDefault(o => o.NumeroOrdenPreparacion == nroOrden);

            if (orden != null)
            {
                
                orden.Empaquetada = true;
                ListaOrdenesEmpaquetar.Items.Remove(selectedItem);

                MessageBox.Show($"La orden {nroOrden} ha sido empaquetada.", "Orden Empaquetada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}