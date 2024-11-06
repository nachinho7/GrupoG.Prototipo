using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using GrupoG.Prototipo.Menu;

namespace GrupoG.Prototipo.Preparacion
{
    public partial class PantallaPreparacion : Form
    {
        PantallaPreparacionModel model;

        public PantallaPreparacion()
        {
            InitializeComponent();
            model = new PantallaPreparacionModel();
            textBoxNroOdenPrevisualizacion.Text = model.SumaNumOrden().ToString();
        }

        private void BotonObtenerDatos_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numeroCliente.Text, out int nroCliente))
            {
                var cliente = model.ObtenerCliente(nroCliente);

                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado");
                    return;
                }

                ActualizarListaMercaderias(model.ObtenerMercaderiasPorCliente(nroCliente));
            }
        }
        private void ActualizarListaMercaderias(List<Mercaderias> mercaderias)
        {
            ListaDatosMercaderia.Items.Clear();

            foreach (var mercaderia in mercaderias)
            {

                var item = new ListViewItem(mercaderia.idMercaderia.ToString());
                item.SubItems.Add(mercaderia.nombreMercaderia);
                item.SubItems.Add(mercaderia.cantidadMercaderia.ToString());
                ListaDatosMercaderia.Items.Add(item);
            }
        }

        private void BotonLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void ListaDatosMercaderia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaDatosMercaderia.SelectedItems.Count > 0)
            {
                var selectedItem = ListaDatosMercaderia.SelectedItems[0];
                TextBoxCantidad.Text = ""; 
                TextBoxCantidad.Enabled = true;
            }
        }

        public void ActualizarListaPrevisualizacion()
        {
            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();

            foreach (var mercaderia in model.MercaderiasAgregadas)
            {
                ListViewItem item = new ListViewItem(mercaderia.idMercaderia.ToString());
                item.SubItems.Add(mercaderia.nombreMercaderia);
                item.SubItems.Add(mercaderia.cantidadMercaderia.ToString());

                ListaPrevisualizacionOrdenesPreparacion.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ListaDatosMercaderia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una mercadería.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedItem = ListaDatosMercaderia.SelectedItems[0];

            if (int.TryParse(TextBoxCantidad.Text, out int cantidadSeleccionada))
            {
                if (cantidadSeleccionada < 0)
                {
                    MessageBox.Show("No se pueden agregar cantidades negativas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var idMercaderia = int.Parse(selectedItem.SubItems[0].Text);
                var nombreMercaderia = selectedItem.SubItems[1].Text;
                int cantidadDisponible = int.Parse(selectedItem.SubItems[2].Text);

                if (cantidadDisponible == 0)
                {
                    MessageBox.Show("No hay stock disponible para agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (cantidadSeleccionada <= cantidadDisponible)
                    {
                        selectedItem.SubItems[2].Text = (cantidadDisponible - cantidadSeleccionada).ToString();

                        // Agregar el producto a la lista de mercaderías agregadas
                        model.AgregarProducto(idMercaderia, nombreMercaderia, cantidadSeleccionada);
                    }
                    else
                    {
                        MessageBox.Show("La cantidad seleccionada es mayor a la cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                ActualizarListaPrevisualizacion();  // Actualizar la lista de previsualización con los productos agregados
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaPrevisualizacionOrdenesPreparacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedItem = ListaPrevisualizacionOrdenesPreparacion.SelectedItems[0];
            int idMercaderia = int.Parse(selectedItem.SubItems[0].Text);

            // Eliminar del modelo
            model.EliminarProducto(idMercaderia);

            // Actualizar la lista de previsualización
            ActualizarListaPrevisualizacion();
        }



        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar número de orden
            if (!int.TryParse(textBoxNroOdenPrevisualizacion.Text, out int numeroOrdenGenerar))
            {
                MessageBox.Show("El número de orden no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar DNI del transportista
            if (!int.TryParse(textBoxDNITransportista.Text, out int dniTransportista))
            {
                MessageBox.Show("El DNI del transportista ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar fecha de despacho
            if (PickerFechaDespacho.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de despacho no puede ser menor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que no haya mercaderías con cantidad 0
            foreach (ListViewItem item in ListaPrevisualizacionOrdenesPreparacion.Items)
            {
                if (int.TryParse(item.SubItems[2].Text, out int cantidad) && cantidad == 0)
                {
                    MessageBox.Show("No se puede generar la orden. Hay mercaderías con cantidad 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Obtener el número del cliente
            if (!int.TryParse(numeroCliente.Text, out int numerocliente))
            {
                MessageBox.Show("El número de cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el nombre del depósito
            string nombreDeposito = model.ObtenerNombreDepositoPorCliente(numerocliente);

            // Verifica si se encontró un depósito
            if (string.IsNullOrEmpty(nombreDeposito) || nombreDeposito == "Depósito no encontrado")
            {
                MessageBox.Show("No se encontró el depósito para el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Resto de la lógica para crear la orden
            var fechaDespacho = PickerFechaDespacho.Value.Date;
            var mercaderias = new List<(int idMercaderia, int cantidad)>();

            foreach (ListViewItem item in ListaPrevisualizacionOrdenesPreparacion.Items)
            {
                if (int.TryParse(item.SubItems[0].Text, out int idMercaderia) &&
                    int.TryParse(item.SubItems[2].Text, out int cantidad))
                {
                    // Agregar a la lista de mercaderías como tuplas
                    mercaderias.Add((idMercaderia, cantidad));
                }
            }

            // Crear la orden
            model.CrearOrdenPreparacion(numerocliente, fechaDespacho, dniTransportista, nombreDeposito, mercaderias);
        }


        private void LimpiarFormulario()
        {
            numeroCliente.Text = "";
            numeroCliente.Enabled = true;
            textBoxDNITransportista.Text = "";
            PickerFechaDespacho.Value = DateTime.Today;
            ListaDatosMercaderia.Items.Clear();
            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();
            TextBoxCantidad.Text = "";
            TextBoxCantidad.Enabled = false;
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
