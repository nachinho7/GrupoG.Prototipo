using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Seleccion;

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
            CargarOrdenes(); // Carga inicial de órdenes
        }

        private void CargarOrdenes()
        {
            ListaOrdenSeleccion.Items.Clear();
            List<OrdenPreparacion2> ordenes = modelo.ObtenerOrdenes();

            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                item.SubItems.Add(orden.NumeroCliente.ToString());
                item.SubItems.Add(orden.FechaDespacho.ToShortDateString());
                item.Tag = orden;
                ListaOrdenSeleccion.Items.Add(item);
            }
        }

        private void FiltrarOrdenesPorFecha(DateTime fecha)
        {
            ListaOrdenSeleccion.Items.Clear();
            List<OrdenPreparacion2> ordenesFiltradas = modelo.FiltrarOrdenesPorFecha(fecha);

            foreach (var orden in ordenesFiltradas)
            {
                ListViewItem item = new ListViewItem(orden.NumeroOrdenPreparacion.ToString());
                item.SubItems.Add(orden.NumeroCliente.ToString());
                item.SubItems.Add(orden.FechaDespacho.ToShortDateString());
                item.Tag = orden;
                ListaOrdenSeleccion.Items.Add(item);
            }
        }

        private void BotonGenerarOS_Click(object sender, EventArgs e)
        {
            Dictionary<int, List<OrdenPreparacion2>> ordenesPorCliente = new Dictionary<int, List<OrdenPreparacion2>>();

            foreach (ListViewItem item in ListaOrdenSeleccion.SelectedItems)
            {
                OrdenPreparacion2 orden = (OrdenPreparacion2)item.Tag;

                if (!ordenesPorCliente.ContainsKey(orden.NumeroCliente))
                {
                    ordenesPorCliente[orden.NumeroCliente] = new List<OrdenPreparacion2>();
                }
                ordenesPorCliente[orden.NumeroCliente].Add(orden);
            }

            if (ordenesPorCliente.Count > 0)
            {
                foreach (var grupo in ordenesPorCliente)
                {
                    OrdenSeleccion2 nuevaSeleccion = modelo.GenerarOrdenDeSeleccion(grupo.Value);
                    MessageBox.Show($"Se generó una orden de selección con ID {nuevaSeleccion.numeroOrdenSeleccion} que incluye {grupo.Value.Count} órdenes para el cliente {grupo.Key}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FiltrarOrdenesPorFecha(datetimeDespacho.Value);
        }
    }
}
