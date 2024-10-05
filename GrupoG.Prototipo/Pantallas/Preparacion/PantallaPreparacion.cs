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

        // Variable para almacenar la cantidad disponible de la mercader�a seleccionada
        private int cantidadDisponible;
        private int numeroOrden; // Variable para el n�mero de orden

        public PantallaPreparacion()
        {
            InitializeComponent();
            model = new PantallaPreparacionModel();
            numeroOrden = 1; // Inicializamos el n�mero de orden
        }

        private void BotonObtenerDatos_Click(object sender, EventArgs e)
        {
            // Convertimos el texto a n�mero de cliente
            var clienteNumeroText = numeroCliente.Text; // Aqu� 'numeroCliente' debe ser un TextBox
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
                    MessageBox.Show("No se encontr� mercader�a para el cliente ingresado.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un n�mero de cliente v�lido.");
            }
        }

        private void ListaDatosMercaderia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaDatosMercaderia.SelectedItems.Count > 0)
            {
                // Obtener el �tem seleccionado
                var selectedItem = ListaDatosMercaderia.SelectedItems[0];

                // Mostrar la cantidad disponible y habilitar el TextBox
                cantidadDisponible = int.Parse(selectedItem.SubItems[2].Text);
                TextBoxCantidad.Text = "";
                TextBoxCantidad.Enabled = true; // Aseg�rate de que el TextBox est� habilitado
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ListaDatosMercaderia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un id de mercader�a.");
                return; // Salir del m�todo si no hay selecci�n
            }
            // Validar la cantidad ingresada por el usuario
            int cantidadSeleccionada;

            // Aseg�rate de que el TextBox est� habilitado antes de leer el valor
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
                    // Agregar la entrada a la lista de previsualizaci�n
                    var item = new ListViewItem(numeroOrden.ToString());
                    item.SubItems.Add(ListaDatosMercaderia.SelectedItems[0].Text); // ID de mercader�a
                    item.SubItems.Add(ListaDatosMercaderia.SelectedItems[0].SubItems[1].Text); // Nombre de mercader�a
                    item.SubItems.Add(cantidadSeleccionada.ToString()); // Cantidad seleccionada

                    // Agregar el �tem a la lista de previsualizaci�n
                    ListaPrevisualizacionOrdenesPreparacion.Items.Add(item);

                    // Reducir la cantidad disponible de mercader�a
                    cantidadDisponible -= cantidadSeleccionada;
                    ListaDatosMercaderia.SelectedItems[0].SubItems[2].Text = cantidadDisponible.ToString();

                    // Incrementar el n�mero de orden. Mover a despues de "generar orden"
                    //numeroOrden++;

                    MessageBox.Show($"Has agregado {cantidadSeleccionada} unidades.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad v�lida.");
            }
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
