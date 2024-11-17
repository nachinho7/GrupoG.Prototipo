using GrupoG.Prototipo.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Extra.ConsultaStock
{
    public partial class PantallaConsultaMercaderia : Form
    {
        public PantallaConsultaMercaderia()
        {
            InitializeComponent();
        }

        public void buttonBuscar_Click(object sender, EventArgs e)
        {
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {

        }

        private void BotonVolverMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu menu = new PantallaMenu();
            this.Hide();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Location = this.Location;
        }

        private void listViewMercaderias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
