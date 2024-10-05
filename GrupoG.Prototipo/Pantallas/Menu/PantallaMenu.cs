using System;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Pantallas.Menu
{
    public partial class PantallaMenu : Form
    {
        public PantallaMenu()
        {
            InitializeComponent();
        }

        // Método que se llama cuando el botón 'Transportista' es clicado
        private void BotonTransportista_Click(object sender, EventArgs e)
        {
            PantallaTransportista form = new(); 
            form.ShowDialog();
        }

        // Método que se llama cuando el botón 'Preparación' es clicado
        private void BotonPreparacion_Click(object sender, EventArgs e)
        {
            PantallaPreparacion form = new(); 
            form.ShowDialog();
        }

        // Método que se llama cuando el botón 'Selección' es clicado
        private void BotonSeleccion_Click(object sender, EventArgs e)
        {
            PantallaSeleccion form = new();
            form.ShowDialog();
        }

        // Método que se llama cuando el botón 'Entrega' es clicado
        private void BotonEntrega_Click(object sender, EventArgs e)
        {
            PantallaEntrega form = new();
            form.ShowDialog(); 
        }

        // Método que se llama cuando el botón 'Despacho' es clicado
        private void BotonDespacho_Click(object sender, EventArgs e)
        {
            PantallaDespacho form = new(); 
            form.ShowDialog(); 
        }
    }
}
