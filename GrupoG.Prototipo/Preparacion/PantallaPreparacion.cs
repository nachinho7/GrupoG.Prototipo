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
        }

        private void BotonObtenerDatos_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numeroCliente.Text, out int nroCliente))
            {
                var cliente = model.BuscarCliente(nroCliente);

                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado");
                    return;
                }

                model.ObtenerMercaderia(cliente.NroCliente);

            }
        }

        private void ActualizarListaMercaderias(List<(int idMercaderia, string nombre, int CantidadTotal)> mercaderias)
        {
            ListaDatosMercaderia.Items.Clear();

            foreach (var mercaderia in mercaderias)
            {
                var item = new ListViewItem(mercaderia.idMercaderia.ToString());
                item.SubItems.Add(mercaderia.nombre);
                item.SubItems.Add(mercaderia.CantidadTotal.ToString());
                ListaDatosMercaderia.Items.Add(item);
            }

            if (mercaderias.Count == 0)
            {
                MessageBox.Show("El número de cliente ingresado no se encuentra registrado en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    int numeroOrdenActual = int.Parse(textBoxNroOdenPrevisualizacion.Text);
                   
                }
                else
                {
                    if (cantidadSeleccionada <= cantidadDisponible)
                    {
                        int numeroOrdenActual = int.Parse(textBoxNroOdenPrevisualizacion.Text);
                        

                        selectedItem.SubItems[2].Text = (cantidadDisponible - cantidadSeleccionada).ToString();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad seleccionada es mayor a la cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                ActualizarListaPrevisualizacion();
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
            int cantidadEliminada = int.Parse(selectedItem.SubItems[2].Text);

            var confirmResult = MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                int numeroOrdenActual = int.Parse(textBoxNroOdenPrevisualizacion.Text);

                ActualizarListaPrevisualizacion();

                var clienteNumero = int.Parse(numeroCliente.Text);
                var mercaderias = model.ObtenerMercaderia(clienteNumero);
                ActualizarListaMercaderias(mercaderias);
            }
        }

        private void ActualizarListaPrevisualizacion()
        {
            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();

            int numeroOrdenActual = int.Parse(textBoxNroOdenPrevisualizacion.Text);
            var ordenesPreparacion = model.ObtenerMercaderia(numeroOrdenActual);

            foreach (var mercaderia in ordenesPreparacion)
            {
                var listItem = new ListViewItem(mercaderia.idMercaderia.ToString());
                listItem.SubItems.Add(mercaderia.nombre);
                listItem.SubItems.Add(mercaderia.CantidadTotal.ToString());

                ListaPrevisualizacionOrdenesPreparacion.Items.Add(listItem);
            }
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

        private void BotonLimpiarCliente_Click(object sender, EventArgs e)
        {
            //if (!int.TryParse(numeroCliente.Text, out int clienteNumero))
            //{
            //    MessageBox.Show("Tenes que buscar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //var mercaderiasOriginales = model.ObtenerMercaderia(clienteNumero);

            //foreach (ListViewItem item in ListaPrevisualizacionOrdenesPreparacion.Items)
            //{
            //    var idMercaderia = int.Parse(item.SubItems[0].Text);
            //    var cantidadMercaderia = int.Parse(item.SubItems[2].Text);

            //    var mercaderiaOriginal = mercaderiasOriginales.FirstOrDefault(m => m.idMercaderia == idMercaderia);
            //    if (mercaderiaOriginal != null)
            //    {
            //        mercaderiaOriginal.cantidadMercaderia += cantidadMercaderia;
            //    }
            //}

            ActualizarListaPrevisualizacion();
            LimpiarFormulario();
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
