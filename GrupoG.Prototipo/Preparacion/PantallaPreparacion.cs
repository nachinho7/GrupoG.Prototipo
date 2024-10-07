using GrupoG.Prototipo.Preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrupoG.Prototipo
{
    public partial class PantallaPreparacion : Form
    {
        private readonly PantallaPreparacionModel model;
        private int cantidadDisponible;
        private int numeroOrden;

        public PantallaPreparacion()
        {
            InitializeComponent();
            model = new PantallaPreparacionModel();
            numeroOrden = 1;


            textBoxNroOdenPrevisualizacion.Text = numeroOrden.ToString();
            textBoxNroOdenPrevisualizacion.ReadOnly = true;


            //textBoxDNITransportista.Text = string.Empty;


            //PickerFechaDespacho.Format = DateTimePickerFormat.Custom;
            //PickerFechaDespacho.CustomFormat = " "; // Aparece vacío
            //PickerFechaDespacho.Checked = false;
            //PickerFechaDespacho.ShowCheckBox = true;


            //PickerFechaDespacho.ValueChanged += PickerFechaDespacho_ValueChanged;
        }

        private void PickerFechaDespacho_ValueChanged(object sender, EventArgs e)
        {
            if (PickerFechaDespacho.Checked)
            {
                PickerFechaDespacho.Format = DateTimePickerFormat.Short;
            }
            else
            {
                PickerFechaDespacho.Format = DateTimePickerFormat.Custom;
                PickerFechaDespacho.CustomFormat = " ";
            }
        }

        private void BotonObtenerDatos_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(numeroCliente.Text, out int clienteNumero))
            {
                MessageBox.Show("El número de cliente ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mercaderias = model.ObtenerMercaderiaPorCliente(clienteNumero);
            ActualizarListaMercaderias(mercaderias);

            if (mercaderias.Count > 0)
            {
                numeroCliente.Enabled = false;
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
                item.SubItems.Add(mercaderia.ubicacionMercaderia);
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
                cantidadDisponible = int.Parse(selectedItem.SubItems[2].Text);
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

            if (int.TryParse(TextBoxCantidad.Text, out int cantidadSeleccionada))
            {
                if (cantidadSeleccionada > cantidadDisponible)
                {
                    MessageBox.Show("La cantidad seleccionada no puede exceder la cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cantidadSeleccionada <= 0)
                {
                    MessageBox.Show("La cantidad seleccionada debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var idMercaderia = int.Parse(ListaDatosMercaderia.SelectedItems[0].SubItems[0].Text);
                var nombreMercaderia = ListaDatosMercaderia.SelectedItems[0].SubItems[1].Text;
                var ubicacionMercaderia = ListaDatosMercaderia.SelectedItems[0].SubItems[3].Text;

                // Agregar mercadería al modelo
                model.AgregarMercaderiaAPreparacion(numeroOrden, idMercaderia, nombreMercaderia, ubicacionMercaderia, cantidadSeleccionada);

                // Actualizar la lista de previsualización
                ActualizarListaPrevisualizacion();

                // Actualizar la cantidad disponible en la lista de mercaderías
                cantidadDisponible -= cantidadSeleccionada;
                ListaDatosMercaderia.SelectedItems[0].SubItems[2].Text = cantidadDisponible.ToString();

                MessageBox.Show($"Se agregaron {cantidadSeleccionada} unidades de {nombreMercaderia}.", "Unidades Agregadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaPrevisualizacion()
        {
            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();

            foreach (var orden in model.ObtenerOrdenPreparacion(numeroOrden))
            {
                foreach (var mercaderia in orden.Mercaderias)
                {
                    var listItem = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                    listItem.SubItems.Add(mercaderia.idMercaderia.ToString());
                    listItem.SubItems.Add(mercaderia.nombreMercaderia);
                    listItem.SubItems.Add(mercaderia.cantidadMercaderia.ToString());
                    listItem.SubItems.Add(mercaderia.ubicacionMercaderia);
                    ListaPrevisualizacionOrdenesPreparacion.Items.Add(listItem);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar número de orden
            if (!int.TryParse(textBoxNroOdenPrevisualizacion.Text, out int numeroOrdenGenerar))
            {
                MessageBox.Show("El número de orden ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar DNI del transportista
            if (!int.TryParse(textBoxDNITransportista.Text, out int dniTransportista))
            {
                MessageBox.Show("El DNI del transportista ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // **Modificación 2: Validar que se haya seleccionado una fecha de despacho**
            if (!PickerFechaDespacho.Checked)
            {
                MessageBox.Show("Debe seleccionar una fecha de despacho.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fechaDespacho = PickerFechaDespacho.Value.Date;

            // **Modificación 3: Validar que la fecha de despacho no sea menor a la fecha actual**
            if (fechaDespacho < DateTime.Today)
            {
                MessageBox.Show("La fecha de despacho no puede ser menor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si hay elementos en la lista de previsualización
            if (ListaPrevisualizacionOrdenesPreparacion.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos en la lista de previsualización. Agrega mercadería antes de generar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // **Obtener detalles de la orden para el MessageBox**
            string detallesMercaderia = "";
            foreach (ListViewItem item in ListaPrevisualizacionOrdenesPreparacion.Items)
            {
                detallesMercaderia += $"ID: {item.SubItems[1].Text}\n" +
                                      $"Nombre: {item.SubItems[2].Text}\n" +
                                      $"Cantidad: {item.SubItems[3].Text}\n" +
                                      $"Ubicación: {item.SubItems[4].Text}\n";
            }

            // Obtener el número de cliente
            string numeroClienteOrden = numeroCliente.Text;

            // Construir el mensaje
            string mensaje = $"N° Orden: {numeroOrdenGenerar}\n" +
                             $"N° Cliente: {numeroClienteOrden}\n" +
                             $"Fecha de Despacho: {fechaDespacho.ToShortDateString()}\n" +
                             $"DNI Transportista: {dniTransportista}\n" +
                             $"Mercadería:\n{detallesMercaderia}";

            // Mostrar el MessageBox con los detalles de la orden
            MessageBox.Show(mensaje, "Orden Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Generar la orden en el modelo
            bool exito = model.GenerarOrdenPreparacion(numeroOrdenGenerar, fechaDespacho, dniTransportista);

            if (exito)
            {
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al generar la orden de preparación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            ListaPrevisualizacionOrdenesPreparacion.Items.Clear();
            ListaDatosMercaderia.Items.Clear();
            TextBoxCantidad.Text = string.Empty;
            TextBoxCantidad.Enabled = false;
            numeroCliente.Enabled = true;
            numeroCliente.Text = string.Empty;
            textBoxNroOdenPrevisualizacion.Text = numeroOrden.ToString(); // Actualizar el TextBox con el número de orden actual
            textBoxDNITransportista.Text = string.Empty;

            // **Modificación 4: Resetear el DateTimePicker a vacío**
            PickerFechaDespacho.CustomFormat = " "; // Vuelve a aparecer vacío
            PickerFechaDespacho.Format = DateTimePickerFormat.Custom;
            PickerFechaDespacho.Checked = false;

            // Incrementar el número de orden
            numeroOrden++;
            textBoxNroOdenPrevisualizacion.Text = numeroOrden.ToString(); // Actualizar el TextBox con el nuevo número de orden
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaPrevisualizacionOrdenesPreparacion.SelectedItems.Count > 0)
            {
                var selectedItem = ListaPrevisualizacionOrdenesPreparacion.SelectedItems[0];
                int idMercaderia = int.Parse(selectedItem.SubItems[1].Text);
                string nombreMercaderia = selectedItem.SubItems[2].Text;
                int cantidadEliminada = int.Parse(selectedItem.SubItems[3].Text);

                var confirmResult = MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Eliminar mercadería de la orden en el modelo
                    model.EliminarMercaderiaDePreparacion(numeroOrden, idMercaderia, cantidadEliminada);

                    // Actualizar la lista de previsualización
                    ActualizarListaPrevisualizacion();

                    // Restaurar la cantidad disponible en la lista de mercaderías
                    foreach (ListViewItem item in ListaDatosMercaderia.Items)
                    {
                        if (item.Text == idMercaderia.ToString())
                        {
                            int cantidadDisponibleActual = int.Parse(item.SubItems[2].Text);
                            item.SubItems[2].Text = (cantidadDisponibleActual + cantidadEliminada).ToString();
                            break;
                        }
                    }

                    MessageBox.Show("Elemento eliminado.", "Elemento Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaPreparacion_Load(object sender, EventArgs e)
        {
            // Inicializaciones adicionales si es necesario
        }
    }
}
