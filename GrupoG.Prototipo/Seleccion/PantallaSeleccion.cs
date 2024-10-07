using System;
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
            CargarOrdenes();
        }

        private void CargarOrdenes()
        {
            listView1.Items.Clear(); // Limpiar elementos existentes
            var ordenes = modelo.ObtenerOrdenes();

            foreach (var orden in ordenes)
            {
                // Crear un nuevo ListViewItem
                var item = new ListViewItem($"Orden N° {orden.NumeroOrdenPreparacion}");
                item.Tag = orden;
                listView1.Items.Add(item); 
            }
        }

        private void FiltrarOrdenesPorFecha(DateTime fecha)
        {
            listView1.Items.Clear();
            var ordenesFiltradas = modelo.FiltrarOrdenesPorFecha(fecha);

            foreach (var orden in ordenesFiltradas)
            {
                var item = new ListViewItem($"Orden N° {orden.NumeroOrdenPreparacion}");
                item.Tag = orden;
                listView1.Items.Add(item);
            }
        }

        private void BotonGenerarOS_Click(object sender, EventArgs e)
        {
            var ordenesSeleccionadas = listView1.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => item.Tag as OrdenPreparacion2)
                .ToList();

            if (ordenesSeleccionadas.Count > 0)
            {
                var nuevaSeleccion = modelo.GenerarOrdenDeSeleccion(ordenesSeleccionadas);
                MessageBox.Show($"Orden de Selección N°{nuevaSeleccion.numeroOrdenSeleccion} generada!\n" +
                                $"Incluye {ordenesSeleccionadas.Count} ordenes de preparación.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (datetimeDespacho.Value.Date == DateTime.Now.Date)
            {
                CargarOrdenes(); 
            }
            else
            {
                FiltrarOrdenesPorFecha(datetimeDespacho.Value); 
            }
        }

        private void BotonMostrarTodas_Click(object sender, EventArgs e)
        {
            datetimeDespacho.Value = DateTime.Now.Date; 
            CargarOrdenes(); 
        }
    }
}
