
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //cambiar, no es boton Empaquetar
        private void BotonEmpaquetar_Click(object sender, EventArgs e)
        {
            /*
            if (ListaOrdenesEmpaquetar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una orden para entregar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ListaOrdenesEmpaquetar.SelectedItems.Count > 1)
            {
                MessageBox.Show("No se puede seleccionar más de una orden seguida para entregar.", "Selección inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                MessageBox.Show($"La orden {nroOrden} ha sido Generada.", "Orden Entrega pasa a despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */

            if (ListaOrdenesEmpaquetar.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes para generar.", "Sin órdenes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            else
            {
                ListaOrdenesEmpaquetar.Items.Clear();
                MessageBox.Show("Todas las órdenes de entrega han sido generadas.", "Orden de Entrega Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PantallaMenu menu = new PantallaMenu();
                this.Hide();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Location = this.Location;
                menu.Show();
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