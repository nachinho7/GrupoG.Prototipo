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

        /*private void BotonTransportista_Click(object sender, EventArgs e)
        {
            PantallaTransportista form = new(); 
            form.ShowDialog();
        }*/

        private void BotonPreparacion_Click(object sender, EventArgs e)
        {
            PantallaPreparacion form = new(); 
            form.ShowDialog();
        }

        private void BotonSeleccion_Click(object sender, EventArgs e)
        {
            PantallaSeleccion form = new();
            form.ShowDialog();
        }

        private void BotonEntrega_Click(object sender, EventArgs e)
        {
            PantallaEntrega form = new();
            form.ShowDialog(); 
        }

        private void BotonDespacho_Click(object sender, EventArgs e)
        {
            PantallaDespacho form = new(); 
            form.ShowDialog(); 
        }

        private void PantallaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
