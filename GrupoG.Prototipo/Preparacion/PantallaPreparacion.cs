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

        public PantallaPreparacion()
        {
            InitializeComponent();
            model = new PantallaPreparacionModel();


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
            int cantidadDisponible = int.Parse(selectedItem.SubItems[2].Text);
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

                int numeroOrdenActual = int.Parse(textBoxNroOdenPrevisualizacion.Text);
                model.AgregarMercaderiaAPreparacion(numeroOrdenActual, idMercaderia, nombreMercaderia, ubicacionMercaderia, cantidadSeleccionada);

                ActualizarListaPrevisualizacion();

                cantidadDisponible -= cantidadSeleccionada;
                selectedItem.SubItems[2].Text = cantidadDisponible.ToString();

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

            int numeroOrdenActual = int.Parse(textBoxNroOdenPrevisualizacion.Text);
            var ordenesPreparacion = model.ObtenerOrdenPreparacion(numeroOrdenActual);

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

                textBoxNroOdenPrevisualizacion.Text = (numeroOrdenGenerar + 1).ToString();
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
                    int numeroOrdenActual = int.Parse(textBoxNroOdenPrevisualizacion.Text);
                    model.EliminarMercaderiaDePreparacion(numeroOrdenActual, idMercaderia, cantidadEliminada);
                    ActualizarListaPrevisualizacion();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
