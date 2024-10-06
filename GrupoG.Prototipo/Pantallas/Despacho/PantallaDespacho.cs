using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoG.Prototipo.Objetos; // Asegúrate de tener la referencia a la clase Clientes y OrdenEntrega
using GrupoG.Prototipo.Pantallas.Despacho; // Para acceder a PantallaDespachoModel

namespace GrupoG.Prototipo.Pantallas
{
    public partial class PantallaDespacho : Form
    {
        private PantallaDespachoModel model;

        public PantallaDespacho()
        {
            InitializeComponent();
            model = new PantallaDespachoModel();
        }

        private void PantallaDespacho_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar cualquier dato necesario al cargar la pantalla
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonObtenerDatos_Click(object sender, EventArgs e)
        {
            // Verificar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(numeroCliente.Text) || !int.TryParse(numeroCliente.Text, out int numero))
            {
                MessageBox.Show("Por favor, ingrese un número de cliente válido.");
                return;
            }

            // Obtener las órdenes relacionadas al número de cliente
            var ordenes = model.ObtenerOrdenesPorCliente(numero);

            // Limpiar el ListView antes de agregar nuevas filas
            listviewOrdenEntrega.Items.Clear();

            // Agregar las órdenes al ListView
            foreach (var orden in ordenes)
            {
                var item = new ListViewItem(orden.IdDespacho.ToString());
                item.SubItems.Add(orden.Estado);
                item.SubItems.Add(orden.NroCliente.ToString());
                listviewOrdenEntrega.Items.Add(item);
            }
        }
    }
}
