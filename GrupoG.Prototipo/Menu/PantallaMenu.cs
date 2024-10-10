using GrupoG.Prototipo.Preparacion;
using GrupoG.Prototipo.Seleccion;
using GrupoG.Prototipo.Stock;
using GrupoG.Prototipo.Entrega;
using GrupoG.Prototipo.Empaquetar;
using GrupoG.Prototipo.Despacho;

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

        private void BotonRetiroStock_Click(object sender, EventArgs e)
        {
            PantallaRetiroStock form = new();
            form.ShowDialog();
        }

        private void BotonEntrega_Click(object sender, EventArgs e)
        {
            PantallaEntrega form = new();
            form.ShowDialog();
        }
        private void BotonEmpaquetar_Click(object sender, EventArgs e)
        {
            PantallaEmpaquetar form = new();
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
