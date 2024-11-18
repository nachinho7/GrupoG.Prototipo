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

        private void PantallaEmpaquetar_Shown(object sender, EventArgs e)
        {
            CargarDepositos();

            //if (ComboBoxOrdenesPreparacion.Items.Count == 0)
            //{
            //    MessageBox.Show("No hay depósitos con órdenes disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void CargarDepositos()
        {
            var depositosConOrdenes = PantallaEmpaquetarModel.ListarDepositosConOrdenes();

            ComboBoxDeposito.Items.Clear();

            if (depositosConOrdenes.Count > 0)
            {
                depositosConOrdenes.Sort();
                ComboBoxDeposito.Items.AddRange(depositosConOrdenes.Select(d => $"Depósito N° {d}").ToArray());
                ComboBoxDeposito.SelectedIndex = 0;

                int numeroDepositoSeleccionado = Convert.ToInt32(depositosConOrdenes.First());
                CargarOrdenesPreparacionDelDeposito(numeroDepositoSeleccionado);
            }
            else
            {
                MessageBox.Show("No hay depósitos con órdenes disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComboBoxOrdenesPreparacion.Items.Clear();
                listView1.Items.Clear();
            }
        }




        private void CargarOrdenesPreparacionDelDeposito(int numeroDeposito)
        {
            listView1.Items.Clear();
            ComboBoxOrdenesPreparacion.Items.Clear();

            var ordenesFiltradas = PantallaEmpaquetarModel.ListarOrdenesPorDeposito(numeroDeposito);

            if (ordenesFiltradas.Count > 0)
            {
                ordenesFiltradas = ordenesFiltradas.OrderBy(o => o.NumeroOrdenPreparacion).ToList();

                foreach (var orden in ordenesFiltradas)
                {
                    ComboBoxOrdenesPreparacion.Items.Add($"Orden N° {orden.NumeroOrdenPreparacion}");
                }

                ComboBoxOrdenesPreparacion.SelectedIndex = 0;
                ComboBoxOrdenesPreparacion_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show($"No hay órdenes de preparación para el depósito N° {numeroDeposito}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDeposito.SelectedIndex == -1) return;

            int numeroDepositoSeleccionado = Convert.ToInt32(
                ComboBoxDeposito.SelectedItem.ToString().Split(' ')[2]);

            CargarOrdenesPreparacionDelDeposito(numeroDepositoSeleccionado);
        }

        private void ComboBoxOrdenesPreparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (ComboBoxOrdenesPreparacion.SelectedIndex == -1) return;

            int numeroOrdenSeleccionada = Convert.ToInt32(
                ComboBoxOrdenesPreparacion.SelectedItem.ToString().Split(' ')[2]);

            var mercaderias = modelo.ListarMercaderiasPorOrden(numeroOrdenSeleccionada);

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

            int numeroOrdenSeleccionada = Convert.ToInt32(ComboBoxOrdenesPreparacion.SelectedItem.ToString().Split(' ')[2]);

            modelo.CambiarEstadoOrden(numeroOrdenSeleccionada);

            MessageBox.Show($"La orden de preparación N° {numeroOrdenSeleccionada} ha sido empaquetada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDepositos();

            if (ComboBoxOrdenesPreparacion.Items.Count > 0)
            {
                ComboBoxOrdenesPreparacion.SelectedIndex = 0;
                ComboBoxOrdenesPreparacion_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
            {
                listView1.Items.Clear();
                ComboBoxOrdenesPreparacion.Items.Clear();

                MessageBox.Show("No hay más órdenes de preparación disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
