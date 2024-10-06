using System;
using System.Collections.Generic;
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
            ListaOrdenSeleccion.Items.Clear();
            List<Orden> ordenes = modelo.ObtenerOrdenes();

            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.NroOrden.ToString());
                item.SubItems.Add(orden.NroCliente.ToString());
                item.SubItems.Add(orden.Estado);
                item.SubItems.Add(orden.FechaGeneracion.ToShortDateString());
                item.Tag = orden;
                ListaOrdenSeleccion.Items.Add(item);
            }
        }

        private void BotonGenerarOS_Click(object sender, EventArgs e)
        {
            // Diccionario para agrupar órdenes por número de cliente
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
                    //OrdenSeleccion nuevaSeleccion = modelo.GenerarOrdenDeSeleccion(grupo.Value);

                    MessageBox.Show($"Se generó una orden de selección que incluye {grupo.Value.Count} órdenes para el cliente {grupo.Key}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
