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
            // Crear un diccionario para agrupar órdenes por número de cliente
            Dictionary<int, List<Orden>> ordenesPorCliente = new Dictionary<int, List<Orden>>();

            foreach (ListViewItem item in ListaOrdenSeleccion.SelectedItems)
            {
                Orden orden = (Orden)item.Tag;

                // Agrupar órdenes por el número de cliente
                if (!ordenesPorCliente.ContainsKey(orden.NroCliente))
                {
                    ordenesPorCliente[orden.NroCliente] = new List<Orden>();
                }
                ordenesPorCliente[orden.NroCliente].Add(orden);
            }

            if (ordenesPorCliente.Count > 0)
            {
                foreach (var grupo in ordenesPorCliente)
                {
                    // Generar la orden de selección a través del modelo para cada grupo de órdenes por cliente
                    OrdenSeleccion nuevaSeleccion = modelo.GenerarOrdenDeSeleccion(grupo.Value);

                    // Mostrar el mensaje de éxito para cada orden de selección creada
                    MessageBox.Show($"Se generó una orden de selección que incluye {grupo.Value.Count} órdenes para el cliente {grupo.Key}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Actualizar la vista
                CargarOrdenes();
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
