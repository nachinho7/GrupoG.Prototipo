using GrupoG.Prototipo.Objetos;
using GrupoG.Prototipo.Pantallas.Preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrupoG.Prototipo
{
    public partial class PantallaPreparacion : Form
    {
        private readonly PantallaPreparacionModel model;

        // Variable para almacenar la cantidad disponible de la mercadería seleccionada
        private int cantidadDisponible;
        private int numeroOrden; // Variable para el número de orden

        public PantallaPreparacion()
        {
            InitializeComponent();
            model = new PantallaPreparacionModel();
            numeroOrden = 1;
        }

        private void BotonObtenerDatos_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(numeroCliente.Text, out int clienteNumero))
            {
                MessageBox.Show("El número de cliente ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mercaderias = model.ObtenerMercaderiaPorCliente(clienteNumero);

            ListaDatosMercaderia.Items.Clear();

            foreach (var mercaderia in mercaderias)
            {
                var item = new ListViewItem(mercaderia.id.ToString());
                item.SubItems.Add(mercaderia.nombreMercaderia);
                item.SubItems.Add(mercaderia.cantidadMercaderia.ToString());
                ListaDatosMercaderia.Items.Add(item);
            }

            if (mercaderias.Count == 0)
            {
                MessageBox.Show("El número de cliente ingresado no se encuentra registrado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                numeroCliente.Enabled = false;
            }
        }

        private void ListaDatosMercaderia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaDatosMercaderia.SelectedItems.Count > 0)
            {
                // Obtener el ítem seleccionado
                var selectedItem = ListaDatosMercaderia.SelectedItems[0];

                // Mostrar la cantidad disponible y habilitar el TextBox
                cantidadDisponible = int.Parse(selectedItem.SubItems[2].Text);
                TextBoxCantidad.Text = "";
                TextBoxCantidad.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ListaDatosMercaderia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione id de mercadería.");
                return;
            }
            // Validar la cantidad ingresada por el usuario
            int cantidadSeleccionada;

            if (TextBoxCantidad.Enabled && int.TryParse(TextBoxCantidad.Text, out cantidadSeleccionada))
            {
                if (cantidadSeleccionada > cantidadDisponible)
                {
                    MessageBox.Show("La cantidad seleccionada no puede exceder la cantidad disponible.");
                }
                else if (cantidadSeleccionada <= 0)
                {
                    MessageBox.Show("La cantidad seleccionada debe ser mayor que cero.");
                }
                else
                {
                    // Agregar la entrada a la lista de previsualización
                    var item = new ListViewItem(numeroOrden.ToString());
                    item.SubItems.Add(ListaDatosMercaderia.SelectedItems[0].Text);
                    item.SubItems.Add(ListaDatosMercaderia.SelectedItems[0].SubItems[1].Text);
                    item.SubItems.Add(cantidadSeleccionada.ToString());

                    // Agregar el ítem a la lista de previsualización
                    ListaPrevisualizacionOrdenesPreparacion.Items.Add(item);

                    // Reducir la cantidad disponible de mercadería
                    cantidadDisponible -= cantidadSeleccionada;
                    ListaDatosMercaderia.SelectedItems[0].SubItems[2].Text = cantidadDisponible.ToString();

                    MessageBox.Show($"Se agregaron {cantidadSeleccionada} unidades.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Verificar si hay elementos en la lista de previsualización
            if (ListaPrevisualizacionOrdenesPreparacion.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos en la lista de previsualización. Agrega mercadería antes de generar la orden.");
                return;
            }

            MessageBox.Show("La orden de preparación generada exitosamente.");

            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();
            ListaDatosMercaderia.Items.Clear();

            TextBoxCantidad.Text = string.Empty;
            TextBoxCantidad.Enabled = false;

            numeroCliente.Enabled = true;
            numeroCliente.Text = string.Empty;

            // Incrementar el número de orden.
            numeroOrden++;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en la lista de previsualización
            if (ListaPrevisualizacionOrdenesPreparacion.SelectedItems.Count > 0)
            {
                // Obtener el ítem seleccionado
                var selectedItem = ListaPrevisualizacionOrdenesPreparacion.SelectedItems[0];

                // Obtener la cantidad seleccionada
                int cantidadEliminada = int.Parse(selectedItem.SubItems[3].Text);

                var confirmResult = MessageBox.Show("¿Desea eliminar el elemento seleccionado?","Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Eliminar el ítem seleccionado
                    ListaPrevisualizacionOrdenesPreparacion.Items.Remove(selectedItem);
                    MessageBox.Show("Elemento eliminado.");

                    foreach (ListViewItem item in ListaDatosMercaderia.Items)
                    {
                        if (item.Text == selectedItem.SubItems[1].Text) // Comparar ID de mercadería
                        {
                            // Actualizar la cantidad de mercadería disponible
                            int cantidadDisponibleActual = int.Parse(item.SubItems[2].Text);
                            item.SubItems[2].Text = (cantidadDisponibleActual + cantidadEliminada).ToString();
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.");
            }
        }
        private void BotonLimpiarCliente_Click(object sender, EventArgs e)
        {

            numeroCliente.Enabled = true;
            numeroCliente.Text = string.Empty;

            ListaDatosMercaderia.Items.Clear();
            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();

            TextBoxCantidad.Text = string.Empty;
            TextBoxCantidad.Enabled = false;
        }


        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//TODO: descontar la cantidad si lo vuelvo a buscar 