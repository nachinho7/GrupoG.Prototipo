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
            this.Hide();
            ordenpreparacion.StartPosition = FormStartPosition.CenterScreen;
            ordenpreparacion.Location = this.Location;
            ordenpreparacion.Show();
        }

        private void BotonSeleccion_Click(object sender, EventArgs e)
        {
            PantallaSeleccion ordenseleccion = new PantallaSeleccion();
            this.Hide();
            ordenseleccion.StartPosition = FormStartPosition.CenterScreen;
            ordenseleccion.Location = this.Location;
            ordenseleccion.Show();
        }

        private void BotonRetiroStock_Click(object sender, EventArgs e)
        {
            PantallaRetiroStock retirostock = new PantallaRetiroStock();
            this.Hide();
            retirostock.StartPosition = FormStartPosition.CenterScreen;
            retirostock.Location = this.Location;
            retirostock.Show();
        }

        private void BotonEntrega_Click(object sender, EventArgs e)
        {
            PantallaEntrega ordenentrega = new PantallaEntrega();
            this.Hide();
            ordenentrega.StartPosition = FormStartPosition.CenterScreen;
            ordenentrega.Location = this.Location;
            ordenentrega.Show();
        }
        private void BotonEmpaquetar_Click(object sender, EventArgs e)
        {
            PantallaEmpaquetar empaquetar = new PantallaEmpaquetar();
            this.Hide();
            empaquetar.StartPosition = FormStartPosition.CenterScreen;
            empaquetar.Location = this.Location;
            empaquetar.Show();
        }

        private void BotonDespacho_Click(object sender, EventArgs e)
        {
            PantallaDespacho ordendespacho = new PantallaDespacho();
            this.Hide();
            ordendespacho.StartPosition = FormStartPosition.CenterScreen;
            ordendespacho.Location = this.Location;
            ordendespacho.Show();
        }

        private void PantallaMenu_Load(object sender, EventArgs e)
        {

        }


    }
}