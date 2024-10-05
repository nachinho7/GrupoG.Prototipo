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

        public PantallaPreparacion()
        {
            InitializeComponent();
            model = new PantallaPreparacionModel();
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
                    // Aqu� puedes agregar la l�gica para procesar la cantidad seleccionada
                    MessageBox.Show($"Has agregado {cantidadSeleccionada} unidades.");
                    // Puedes agregar m�s l�gica aqu�, como actualizar un pedido o lista
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
