using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void PantallaEntrega_Shown(object sender, EventArgs e)
        {
            if (ListaOrdenesEmpaquetar.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron ordenes para entregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void CargarOrdenes()
        {
            var ordenes = model.ObtenerOrdenes();
            ListaOrdenesEmpaquetar.Items.Clear();
            

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                item.SubItems.Add(orden.NroCliente.ToString());
                var cantidadTotal = orden.Detalle.Sum(d => d.Cantidad);
                item.SubItems.Add(cantidadTotal.ToString());

                item.SubItems.Add(orden.DNITransportista.ToString());
                item.SubItems.Add(orden.FechaDespacho.ToString());

                ListaOrdenesEmpaquetar.Items.Add(item);
            }
        }


        private void BotonEntregar_Click(object sender, EventArgs e)
        {
            if (ListaOrdenesEmpaquetar.Items.Count == 0)
            {
                MessageBox.Show("No hay ordenes disponibles para entregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ordenesEmpaquetadas = model.ObtenerOrdenes();
            var ordenesEntregas = model.GenerarOrdenEntregaPorOrden(ordenesEmpaquetadas);

            ListaOrdenesEmpaquetar.Items.Clear();

            MessageBox.Show("Las ordenes de entrega han sido generadas.", "Ordenes de Entrega Generadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
