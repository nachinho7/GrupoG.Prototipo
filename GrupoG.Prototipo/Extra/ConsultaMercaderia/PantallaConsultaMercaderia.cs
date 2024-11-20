using GrupoG.Prototipo.Extra.ConsultaMercaderia;
using GrupoG.Prototipo.Almacenes.Mercaderias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo.Extra.ConsultaMercaderia
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

            var resultado = model.ObtenerCliente(nroCliente);

            if (resultado == null)
            {
                return; 
            }

            var (cliente, numeroDeposito) = resultado.Value;

            textBoxNumDeposito.Text = numeroDeposito.ToString();

            var mercaderias = model.ObtenerMercaderiasPorCliente(nroCliente);

            if (mercaderias != null && mercaderias.Any())
            {
                listViewMercaderias.Items.Clear();

                foreach (var (IdMercaderia, NombreMercaderia, Ubicaciones) in mercaderias)
                {
                    foreach (var (Ubicacion, Cantidad) in Ubicaciones)
                    {
                        var item = new ListViewItem(IdMercaderia.ToString());
                        item.SubItems.Add(NombreMercaderia);
                        item.SubItems.Add(Ubicacion);
                        item.SubItems.Add(Cantidad.ToString());

                        listViewMercaderias.Items.Add(item);
                    }
                }

                textBoxCliente.Enabled = false;
                buttonBuscar.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se encontraron mercaderías para el cliente especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (listViewMercaderias.CheckedItems.Count != 1)
            {
                MessageBox.Show("Por favor, marque una única mercadería para agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var itemSeleccionado = listViewMercaderias.CheckedItems[0];

            int idMercaderia = int.Parse(itemSeleccionado.SubItems[0].Text);
            string nombreMercaderia = itemSeleccionado.SubItems[1].Text;
            string ubicacion = itemSeleccionado.SubItems[2].Text;

            int cantidad;
            if (!int.TryParse(textBoxCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            model.AgregarCantidadMercaderia(idMercaderia, nombreMercaderia, ubicacion, cantidad);

            MessageBox.Show($"Se agregó correctamente la cantidad {cantidad} de '{nombreMercaderia}' en la ubicación '{ubicacion}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            itemSeleccionado.Checked = false;
            ActualizarListView();
        }




        private void buttonSacar_Click(object sender, EventArgs e)
        {
            if (listViewMercaderias.CheckedItems.Count != 1)
            {
                MessageBox.Show("Por favor, marque una única mercadería para sacar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var itemSeleccionado = listViewMercaderias.CheckedItems[0];

            int idMercaderia = int.Parse(itemSeleccionado.SubItems[0].Text);
            string nombreMercaderia = itemSeleccionado.SubItems[1].Text;
            string ubicacion = itemSeleccionado.SubItems[2].Text;

            int cantidad;
            if (!int.TryParse(textBoxCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            model.RestarCantidadMercaderia(idMercaderia, nombreMercaderia, ubicacion, cantidad);

            itemSeleccionado.Checked = false;
            ActualizarListView();
        }



        private void ActualizarListView()
        {
            listViewMercaderias.Items.Clear();

            int nroCliente;
            if (int.TryParse(textBoxCliente.Text, out nroCliente))
            {
                var mercaderias = model.ObtenerMercaderiasPorCliente(nroCliente);

                foreach (var (IdMercaderia, NombreMercaderia, Ubicaciones) in mercaderias)
                {
                    foreach (var (Ubicacion, Cantidad) in Ubicaciones)
                    {
                        var item = new ListViewItem(IdMercaderia.ToString());
                        item.SubItems.Add(NombreMercaderia);
                        item.SubItems.Add(Ubicacion);
                        item.SubItems.Add(Cantidad.ToString());
                        listViewMercaderias.Items.Add(item);
                    }
                }
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCliente.Clear();
            textBoxNumDeposito.Clear();
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
        }
       
    }
}
