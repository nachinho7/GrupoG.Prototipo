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
            numeroOrden = 1; // Inicializamos el número de orden
        }

        private void BotonObtenerDatos_Click(object sender, EventArgs e)
        {
            // Convertimos el texto a número de cliente
            var clienteNumeroText = numeroCliente.Text; // Aquí 'numeroCliente' debe ser un TextBox
            int clienteNumero;

            if (int.TryParse(clienteNumeroText, out clienteNumero))
            {
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
                    MessageBox.Show("No se encontró mercadería para el cliente ingresado.");
                }
                else
                {
                    // Deshabilitar el campo de número de cliente después de obtener los datos
                    numeroCliente.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número de cliente válido.");
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
                TextBoxCantidad.Enabled = true; // Asegúrate de que el TextBox esté habilitado
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ListaDatosMercaderia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un id de mercadería.");
                return; // Salir del método si no hay selección
            }
            // Validar la cantidad ingresada por el usuario
            int cantidadSeleccionada;

            // Asegúrate de que el TextBox esté habilitado antes de leer el valor
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
                    item.SubItems.Add(ListaDatosMercaderia.SelectedItems[0].Text); // ID de mercadería
                    item.SubItems.Add(ListaDatosMercaderia.SelectedItems[0].SubItems[1].Text); // Nombre de mercadería
                    item.SubItems.Add(cantidadSeleccionada.ToString()); // Cantidad seleccionada

                    // Agregar el ítem a la lista de previsualización
                    ListaPrevisualizacionOrdenesPreparacion.Items.Add(item);

                    // Reducir la cantidad disponible de mercadería
                    cantidadDisponible -= cantidadSeleccionada;
                    ListaDatosMercaderia.SelectedItems[0].SubItems[2].Text = cantidadDisponible.ToString();

                    // Incrementar el número de orden. Mover a despues de "generar orden"
                    //numeroOrden++;

                    MessageBox.Show($"Has agregado {cantidadSeleccionada} unidades.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Verificar si hay elementos en la lista de previsualización
            if (ListaPrevisualizacionOrdenesPreparacion.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos en la lista de previsualización. Agrega mercadería antes de generar la orden.");
                return; // Salir del método si no hay elementos
            }

            // Mostrar mensaje de éxito
            MessageBox.Show("La orden de preparación ha sido generada exitosamente.");

            // Limpiar los datos de la lista de previsualización
            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();
            ListaDatosMercaderia.Items.Clear();

            // Limpiar el TextBox de cantidad y deshabilitarlo
            TextBoxCantidad.Text = string.Empty; // Limpiar el contenido del TextBox
            TextBoxCantidad.Enabled = false; // Deshabilitar el TextBox de cantidad

            // Habilitar el campo de número de cliente nuevamente
            numeroCliente.Enabled = true;
            numeroCliente.Text = string.Empty; // Limpiar el campo de número de cliente

            // Reiniciar el número de orden si es necesario
            //numeroOrden = 1; // Puedes ajustar esta lógica si quieres que el número de orden se reinicie o continúe
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

                // Confirmar la eliminación
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar el elemento seleccionado?",
                                                     "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Eliminar el ítem seleccionado
                    ListaPrevisualizacionOrdenesPreparacion.Items.Remove(selectedItem);
                    MessageBox.Show("Elemento eliminado.");

                    // Buscar el ítem correspondiente en ListaDatosMercaderia
                    foreach (ListViewItem item in ListaDatosMercaderia.Items)
                    {
                        if (item.Text == selectedItem.SubItems[1].Text) // Comparar ID de mercadería
                        {
                            // Actualizar la cantidad de mercadería disponible
                            int cantidadDisponibleActual = int.Parse(item.SubItems[2].Text);
                            item.SubItems[2].Text = (cantidadDisponibleActual + cantidadEliminada).ToString();
                            break; // Salir del bucle una vez encontrado
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
            // Habilitar el campo de número de cliente nuevamente y limpiar su contenido
            numeroCliente.Enabled = true;
            numeroCliente.Text = string.Empty;

            // Limpiar la lista de mercaderías mostradas
            ListaDatosMercaderia.Items.Clear();
            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();

            // Limpiar el TextBox de cantidad
            TextBoxCantidad.Text = string.Empty;
            TextBoxCantidad.Enabled = false;
        }


        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



//TODO: [cuando se pone generar, se tiene que limpiar todo - ok] y descontar la cantidad si lo vuelvo a buscar 
//TODO: agregar un crear all, para limpiar todo. Paracido a generar - ok
//TODO: Que se bloquee el boton de obtener datos si ya se uno xx - ok
//TODO: Ver comentarios
//TODO: ver mensajes de error
