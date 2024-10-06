using GrupoG.Prototipo.Pantallas.ConsultaTransportista;
using System;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Pantallas
{
    public partial class PantallaTransportista : Form
    {
        private PantallaTransportistaModel _model;

        public PantallaTransportista()
        {
            InitializeComponent(); // Asegúrate de que InitializeComponent esté correctamente definido
            _model = new PantallaTransportistaModel(); // Inicializar el modelo
        }

        // Método que se ejecuta cuando el formulario se carga
        private void PantallaConsultaTransportista_Load(object sender, EventArgs e)
        {
        }

        // Método para buscar transportista cuando se hace click en "Buscar Transportista"
        private void BuscarTransportista_Click(object sender, EventArgs e)
        {
            // Obtener el DNI ingresado en dniTextBox
            if (int.TryParse(dniTextBox.Text, out int dni))
            {
                // Validar que el DNI esté entre 1.000.000 y 99.999.999
                if (dni < 1000000 || dni > 99999999)
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir si el DNI no es válido
                }

                // Buscar transportista en el modelo
                var transportista = _model.Clientes.Find(t => t.dniTransportista == dni);

                // Si se encuentra el transportista, mostrar sus datos en listView1
                if (transportista != null)
                {
                    listView1.Items.Clear(); // Limpiar la lista
                    ListViewItem item = new ListViewItem(transportista.Clientes[0].NumeroCliente.ToString());
                    item.SubItems.Add(transportista.habilitadoTransportista ? "Habilitado" : "No habilitado");
                    item.SubItems.Add(transportista.patente);
                    listView1.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("No se encontró el transportista con ese DNI.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.");
            }
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
