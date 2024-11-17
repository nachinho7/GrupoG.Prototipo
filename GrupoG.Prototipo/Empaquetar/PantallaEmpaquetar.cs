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
            CargarOrdenesPreparacion();

            if (ComboBoxOrdenesPreparacion.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes de preparación disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarOrdenesPreparacion()
        {
            var ordenesPreparacion = PantallaEmpaquetarModel.ListarOrdenesSeleccionadas();

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
        }

        private void CargarDepositos()
        {
            // Listar solo depósitos con órdenes disponibles
            var depositosConOrdenes = PantallaEmpaquetarModel.ListarDepositosConOrdenes();

            ComboBoxDeposito.Items.Clear();

            if (depositosConOrdenes.Count > 0)
            {
                ComboBoxDeposito.Items.AddRange(depositosConOrdenes.Select(d => $"Depósito N° {d}").ToArray());
                ComboBoxDeposito.SelectedIndex = 0;
                ComboBoxDeposito_SelectedIndexChanged(this, EventArgs.Empty);
            }
            
        }


        private void ComboBoxDeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDeposito.SelectedIndex == -1) return;

            listView1.Items.Clear();

            int numeroDepositoSeleccionado = Convert.ToInt32(
                ComboBoxDeposito.SelectedItem.ToString().Split(' ')[2]);

            var ordenesFiltradas = PantallaEmpaquetarModel.ListarOrdenesPorDeposito(numeroDepositoSeleccionado);

            ComboBoxOrdenesPreparacion.Items.Clear();

            if (ordenesFiltradas.Count > 0)
            {
                foreach (var orden in ordenesFiltradas)
                {
                    ComboBoxOrdenesPreparacion.Items.Add($"Orden N° {orden.NumeroOrdenPreparacion}");
                }

                ComboBoxOrdenesPreparacion.SelectedIndex = 0;
                ComboBoxOrdenesPreparacion_SelectedIndexChanged(this, EventArgs.Empty); 
            }
            else
            {
                MessageBox.Show("No hay órdenes de preparación para el depósito seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            CargarOrdenesPreparacion();

            if (ComboBoxOrdenesPreparacion.Items.Count > 0)
            {
                ComboBoxOrdenesPreparacion.SelectedIndex = 0;
                ComboBoxOrdenesPreparacion_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else
            {
                
                listView1.Items.Clear();
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
