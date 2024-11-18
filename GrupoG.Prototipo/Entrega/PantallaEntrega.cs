using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Almacenes.Clientes;
using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Empaquetar;
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

        private void PantallaEntrega_Shown(object sender, EventArgs e)
        {
            CargarDepositosYOrdenes();
        }

        private void CargarDepositosYOrdenes()
        {
            var depositos = PantallaEntregaModel.ListarDepositosDisponibles();
            ComboBoxDeposito.Items.Clear();

            var depositosConOrdenes = depositos
                .Where(deposito => PantallaEntregaModel.ListarOrdenesPorDeposito(deposito).Any())
                .ToList();

            foreach (var deposito in depositosConOrdenes)
            {
                ComboBoxDeposito.Items.Add($"Depósito N° {deposito}");
            }

            if (depositosConOrdenes.Any())
            {
                ComboBoxDeposito.SelectedItem = $"Depósito N° {depositosConOrdenes.First()}";
                var ordenesFiltradas = PantallaEntregaModel.ListarOrdenesPorDeposito(depositosConOrdenes.First());
                CargarOrdenesFiltradas(ordenesFiltradas);
            }
            else
            {
                MessageBox.Show("No se encontraron depósitos con órdenes disponibles.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
        private void CargarOrdenesFiltradas(List<OrdenPreparacionEntidad> ordenesFiltradas)
        {
            ListaOrdenesEmpaquetar.Items.Clear();

            foreach (var orden in ordenesFiltradas)
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

        private void ComboBoxDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDeposito.SelectedIndex == -1) return;

            int numeroDepositoSeleccionado = Convert.ToInt32(
                ComboBoxDeposito.SelectedItem.ToString().Split(' ')[2]);

            var ordenesFiltradas = PantallaEntregaModel.ListarOrdenesPorDeposito(numeroDepositoSeleccionado);

            if (ordenesFiltradas.Any())
            {
                CargarOrdenesFiltradas(ordenesFiltradas);
            }
            else
            {
                ListaOrdenesEmpaquetar.Items.Clear();
                MessageBox.Show("No hay órdenes de preparación para el depósito seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BotonEntregar_Click(object sender, EventArgs e)
        {
            if (ListaOrdenesEmpaquetar.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes disponibles para entregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ordenesSeleccionadas = new List<OrdenPreparacionEntidad>();
            foreach (ListViewItem item in ListaOrdenesEmpaquetar.Items)
            {
                int numeroOrden = int.Parse(item.Text);
                var orden = model.ObtenerOrdenPorNumero(numeroOrden);
                if (orden != null)
                {
                    ordenesSeleccionadas.Add(orden);
                }
            }

            var depositos = ordenesSeleccionadas
                .Select(o => ClientesAlmacen.ObtenerNroCliente(o.NroCliente)?.NroDeposito)
                .Distinct()
                .ToList();

            if (depositos.Count != 1)
            {
                MessageBox.Show("Las órdenes seleccionadas pertenecen a diferentes depósitos. No se puede generar la orden de entrega.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ordenesEntregas = model.GenerarOrdenEntregaPorOrden(ordenesSeleccionadas);

            ListaOrdenesEmpaquetar.Items.Clear();

            MessageBox.Show("La orden de entrega ha sido generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDepositosYOrdenes();

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
