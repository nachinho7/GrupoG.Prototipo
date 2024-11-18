using GrupoG.Prototipo.Extra.ConsultaStock;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Extra.ConsultaMercaderia;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo.Extra.ConsultaStock
{
    public partial class PantallaConsultaMercaderia : Form
    {
        private PantallaConsultaMercaderiaModel model;

        public PantallaConsultaMercaderia()
        {
            InitializeComponent();
            model = new PantallaConsultaMercaderiaModel();
        }

        public void buttonBuscar_Click(object sender, EventArgs e)
        {
            int nroCliente;
            if (!int.TryParse(textBoxCliente.Text, out nroCliente))
            {
                MessageBox.Show("Por favor, ingrese un número de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mercaderias = model.ObtenerMercaderiasPorCliente(nroCliente);

            if (mercaderias != null && mercaderias.Any())
            {
                listViewMercaderias.Items.Clear();

                foreach (var mercaderia in mercaderias)
                {
                    var item = new ListViewItem(mercaderia.NombreMercaderia);
                    item.SubItems.Add(mercaderia.IdMercaderia.ToString());

                    foreach (var ubicacion in mercaderia.Item3)
                    {
                        item.SubItems.Add($"{ubicacion.Ubicacion} - {ubicacion.Cantidad}");
                    }

                    listViewMercaderias.Items.Add(item);
                }

                textBoxCliente.Enabled = false;
                buttonBuscar.Enabled = false;
            }
        }




        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (listViewMercaderias.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una mercadería.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var itemSeleccionado = listViewMercaderias.SelectedItems[0];
            int idMercaderia = int.Parse(itemSeleccionado.SubItems[1].Text);
            string nombreMercaderia = itemSeleccionado.Text;
            string ubicacion = itemSeleccionado.SubItems[2].Text.Split('-')[0].Trim();
            int cantidad;

            // Verificamos si la cantidad es válida
            if (!int.TryParse(textBoxCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            model.AgregarCantidadMercaderia(idMercaderia, nombreMercaderia, ubicacion, cantidad);
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            if (listViewMercaderias.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una mercadería.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var itemSeleccionado = listViewMercaderias.SelectedItems[0];
            int idMercaderia = int.Parse(itemSeleccionado.SubItems[1].Text);
            string nombreMercaderia = itemSeleccionado.Text;
            string ubicacion = itemSeleccionado.SubItems[2].Text.Split('-')[0].Trim();
            int cantidad;

            if (!int.TryParse(textBoxCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            model.RestarCantidadMercaderia(idMercaderia, nombreMercaderia, ubicacion, cantidad);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCliente.Clear();
            textBoxCantidad.Clear();
            listViewMercaderias.Items.Clear();

            textBoxCliente.Enabled = true;
            buttonBuscar.Enabled = true;
        }

        private void BotonVolverMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu menu = new PantallaMenu();
            this.Hide();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Location = this.Location;
            menu.Show();
        }

        private void listViewMercaderias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí podrías agregar alguna validación o mostrar más detalles si es necesario
        }
    }
}
