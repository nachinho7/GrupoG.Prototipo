using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GrupoG.Prototipo.Pantallas.Seleccion;

namespace GrupoG.Prototipo.Pantallas
{
    public partial class PantallaSeleccion : Form
    {
        private PantallaSeleccionModel modelo;

        public PantallaSeleccion()
        {
            InitializeComponent();
            modelo = new PantallaSeleccionModel();
        }

        private void PantallaSeleccion_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        // Método para cargar las órdenes en el ListView desde el modelo
        private void CargarOrdenes()
        {
            ListaOrdenSeleccion.Items.Clear();
            List<Orden> ordenes = modelo.ObtenerOrdenes();

            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.NroOrden.ToString());
                item.SubItems.Add(orden.NroCliente.ToString());
                item.SubItems.Add(orden.Estado);
                item.SubItems.Add(orden.FechaGeneracion.ToShortDateString());
                item.Tag = orden; // Asociar el modelo de orden al ListViewItem
                ListaOrdenSeleccion.Items.Add(item);
            }
        }

        private void BotonGenerarOS_Click(object sender, EventArgs e)
        {
            List<Orden> ordenesSeleccionadas = new List<Orden>();

            foreach (ListViewItem item in ListaOrdenSeleccion.SelectedItems)
            {
                Orden orden = (Orden)item.Tag;
                ordenesSeleccionadas.Add(orden);
            }

            if (ordenesSeleccionadas.Count > 0)
            {
                // Generar la orden de selección a través del modelo
                OrdenSeleccion nuevaSeleccion = modelo.GenerarOrdenDeSeleccion(ordenesSeleccionadas);

                // Actualizar la vista
                CargarOrdenes();

                // Mostrar el mensaje de una sola orden de selección creada
                MessageBox.Show($"Se generó una orden de selección que incluye {ordenesSeleccionadas.Count} órden/es.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se seleccionaron órdenes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
