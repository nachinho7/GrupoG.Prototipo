using GrupoG.Prototipo.Almacenes.Ordenes.OrdenPreparacion;
using GrupoG.Prototipo.Menu;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Extra.Estados
{
    public partial class PantallaConsultaEstados : Form
    {
        private PantallaConsultaEstadosModel modelo;

        public PantallaConsultaEstados()
        {
            InitializeComponent();
            modelo = new PantallaConsultaEstadosModel();
            CargarEstados();
        }

        private void CargarEstados()
        {
            var estados = modelo.GetEstados();
            comboBoxEstados.DataSource = estados;
        }

        private void comboBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            var estadoSeleccionado = comboBoxEstados.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(estadoSeleccionado))
            {
                var ordenes = modelo.GetOrdenes(estadoSeleccionado);
                ActualizarListViewOrdenes(ordenes);
            }
        }

        public void ClearEstados_Click(object sender, EventArgs e)
        {
            comboBoxEstados.SelectedIndex = -1;
            listViewConsultaEstados.Items.Clear(); 
        }

        private void BuscarOrden_Click(object sender, EventArgs e)
        {
            string input = textBoxOrden.Text.Trim();

            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int numeroOrden) || numeroOrden <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número de orden válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxEstadoOrden.Clear();

            var estadoOrden = modelo.GetEstadoOrden(numeroOrden);

            if (!string.IsNullOrEmpty(estadoOrden))
            {
                textBoxEstadoOrden.Text = estadoOrden;

                var ordenes = modelo.GetOrdenes(estadoOrden);
                ActualizarListViewOrdenes(ordenes);
            }
            else
            {
                textBoxEstadoOrden.Clear();

                MessageBox.Show($"No se encontró ninguna orden con el número {numeroOrden}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void ClearOrden_Click(object sender, EventArgs e)
        {
            textBoxOrden.Clear();
            textBoxEstadoOrden.Clear();
        }

        private void ActualizarListViewOrdenes(List<OrdenPreparacionEntidad> ordenes)
        {
            listViewConsultaEstados.Items.Clear();
            foreach (var orden in ordenes)
            {
                var item = new ListViewItem($"Orden N°{orden.NumeroOrdenPreparacion}");
                item.SubItems.Add(orden.NroCliente.ToString());
                listViewConsultaEstados.Items.Add(item);
            }
        }

        private void BotonVolverMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu menu = new PantallaMenu();
            this.Hide();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Location = this.Location;
        }
    }
}
