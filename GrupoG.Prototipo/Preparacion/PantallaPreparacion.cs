using GrupoG.Prototipo.Preparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrupoG.Prototipo
{
    public partial class PantallaPreparacion : Form
    {
        PantallaPreparacionModel model;
        private int numeroOrden;

        public PantallaPreparacion()
        {
            InitializeComponent();
            model = new PantallaPreparacionModel();
            numeroOrden = 1;

            textBoxNroOdenPrevisualizacion.Text = numeroOrden.ToString();
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
                item.SubItems.Add(mercaderia.nombreMercaderia.ToString());
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
            int cantidadDisponible = int.Parse(selectedItem.SubItems[2].Text); // Obtener la cantidad disponible directamente
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

                var idMercaderia = int.Parse(selectedItem.SubItems[0].Text);
                var nombreMercaderia = selectedItem.SubItems[1].Text;
                var ubicacionMercaderia = selectedItem.SubItems[3].Text;

                model.AgregarMercaderiaAPreparacion(numeroOrden, idMercaderia, nombreMercaderia, ubicacionMercaderia, cantidadSeleccionada);

                ActualizarListaPrevisualizacion();

                cantidadDisponible -= cantidadSeleccionada; // Actualizar cantidad disponible
                selectedItem.SubItems[2].Text = cantidadDisponible.ToString(); // Actualizar en la lista

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

            var ordenesPreparacion = model.ObtenerOrdenPreparacion(numeroOrden);

            foreach (var orden in ordenesPreparacion)
            {
                foreach (var mercaderia in orden.Mercaderias)
                {
                    var listItem = new ListViewItem(mercaderia.idMercaderia.ToString());
                    listItem.SubItems.Add(mercaderia.nombreMercaderia);
                    listItem.SubItems.Add(mercaderia.cantidadMercaderia.ToString());
                    listItem.SubItems.Add(mercaderia.ubicacionMercaderia);

                    ListaPrevisualizacionOrdenesPreparacion.Items.Add(listItem);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxNroOdenPrevisualizacion.Text, out int numeroOrdenGenerar))
            {
                MessageBox.Show("El número de orden ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxDNITransportista.Text, out int dniTransportista))
            {
                MessageBox.Show("El DNI del transportista ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!PickerFechaDespacho.Checked)
            {
                MessageBox.Show("Debe seleccionar una fecha de despacho.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fechaDespacho = PickerFechaDespacho.Value.Date;

            if (fechaDespacho < DateTime.Today)
            {
                MessageBox.Show("La fecha de despacho no puede ser menor a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ListaPrevisualizacionOrdenesPreparacion.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos en la lista de previsualización. Agrega mercadería antes de generar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string detallesMercaderia = "";
            foreach (ListViewItem item in ListaPrevisualizacionOrdenesPreparacion.Items)
            {
                detallesMercaderia += $"ID: {item.SubItems[0].Text}\n" +
                                      $"  Nombre: {item.SubItems[1].Text}\n" +
                                      $"  Cantidad: {item.SubItems[2].Text}\n" +
                                      $"  Ubicación: {item.SubItems[3].Text}\n";
            }

            string numeroClienteOrden = numeroCliente.Text;

            string mensaje = $"N° Orden: {numeroOrdenGenerar}\n" +
                             $"N° Cliente: {numeroClienteOrden}\n" +
                             $"Fecha de Despacho: {fechaDespacho.ToShortDateString()}\n" +
                             $"DNI Transportista: {dniTransportista}\n" +
                             $"Mercadería:\n{detallesMercaderia}";

            MessageBox.Show(mensaje, "Orden Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bool exito = model.GenerarOrdenPreparacion(numeroOrdenGenerar, fechaDespacho, dniTransportista);

            if (exito)
            {
                LimpiarFormulario();
                numeroOrden++;
                textBoxNroOdenPrevisualizacion.Text = numeroOrden.ToString();
            }
            else
            {
                MessageBox.Show("Error al generar la orden de preparación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaPrevisualizacionOrdenesPreparacion.SelectedItems.Count > 0)
            {
                var selectedItem = ListaPrevisualizacionOrdenesPreparacion.SelectedItems[0];
                int cantidadEliminada = int.Parse(selectedItem.SubItems[2].Text);
                int idMercaderia = int.Parse(selectedItem.SubItems[0].Text);

                var confirmResult = MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    model.EliminarMercaderiaDePreparacion(numeroOrden, idMercaderia, cantidadEliminada);
                    ListaPrevisualizacionOrdenesPreparacion.Items.Remove(selectedItem);
                    MessageBox.Show($"Se eliminó {cantidadEliminada} unidades de la lista.", "Elemento Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar la lista de mercaderías para reflejar la cantidad
                    foreach (ListViewItem item in ListaDatosMercaderia.Items)
                    {
                        if (item.Text == idMercaderia.ToString())
                        {
                            int cantidadDisponible = int.Parse(item.SubItems[2].Text);
                            cantidadDisponible += cantidadEliminada; // Incrementar cantidad disponible
                            item.SubItems[2].Text = cantidadDisponible.ToString(); // Actualizar en la lista
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento de la lista de previsualización para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBoxNroOdenPrevisualizacion.Text = numeroOrden.ToString();
            textBoxDNITransportista.Text = string.Empty;

            PickerFechaDespacho.CustomFormat = " ";
            PickerFechaDespacho.Format = DateTimePickerFormat.Custom;
            PickerFechaDespacho.Checked = false;

            textBoxNroOdenPrevisualizacion.Text = numeroOrden.ToString();
        }
        private void BotonLimpiarCliente_Click(object sender, EventArgs e)
        {
            model.LimpiarOrdenesPreparacion();
            ActualizarListaPrevisualizacion();
            LimpiarFormulario();
        }


        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaPreparacion_Load(object sender, EventArgs e)
        {
        }
    }
}
