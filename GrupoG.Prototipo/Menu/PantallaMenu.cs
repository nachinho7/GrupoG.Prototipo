using GrupoG.Prototipo.Preparacion;
using GrupoG.Prototipo.Seleccion;
using GrupoG.Prototipo.Stock;
using GrupoG.Prototipo.Entrega;
using GrupoG.Prototipo.Empaquetar;
using GrupoG.Prototipo.Despacho;

using System;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Menu
{
    public partial class PantallaMenu : Form
    {
        public PantallaMenu()
        {
            InitializeComponent();
        }
        private void BotonPreparacion_Click(object sender, EventArgs e)
        {
            PantallaPreparacion ordenpreparacion = new PantallaPreparacion();
            ordenpreparacion.StartPosition = FormStartPosition.CenterScreen;
            ordenpreparacion.Location = this.Location;
            ordenpreparacion.ShowDialog();
        }

        private void BotonSeleccion_Click(object sender, EventArgs e)
        {
            PantallaSeleccion ordenseleccion = new PantallaSeleccion();
            ordenseleccion.StartPosition = FormStartPosition.CenterScreen;
            ordenseleccion.Location = this.Location;
            ordenseleccion.ShowDialog();
        }

        private void BotonRetiroStock_Click(object sender, EventArgs e)
        {
            PantallaRetiroStock retirostock = new PantallaRetiroStock();
            retirostock.StartPosition = FormStartPosition.CenterScreen;
            retirostock.Location = this.Location;
            retirostock.ShowDialog();
        }

        private void BotonEntrega_Click(object sender, EventArgs e)
        {
            PantallaEntrega ordenentrega = new PantallaEntrega();
            ordenentrega.StartPosition = FormStartPosition.CenterScreen;
            ordenentrega.Location = this.Location;
            ordenentrega.ShowDialog();
        }
        private void BotonEmpaquetar_Click(object sender, EventArgs e)
        {
            PantallaEmpaquetar empaquetar = new PantallaEmpaquetar();
            empaquetar.StartPosition = FormStartPosition.CenterScreen;
            empaquetar.Location = this.Location;
            empaquetar.ShowDialog();
        }

        private void BotonDespacho_Click(object sender, EventArgs e)
        {
            PantallaDespacho ordendespacho = new PantallaDespacho();
            ordendespacho.StartPosition = FormStartPosition.CenterScreen;
            ordendespacho.Location = this.Location;
            ordendespacho.ShowDialog();
        }

        private void PantallaMenu_Load(object sender, EventArgs e)
        {

        }


    }
}