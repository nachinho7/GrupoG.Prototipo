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

namespace GrupoG.Prototipo.Extra.Estados
{
    public partial class PantallaConsultaEstados : Form
    {
        public PantallaConsultaEstados()
        {
            InitializeComponent();
        }




        public void ClearEstados_Click(object sender, EventArgs e)
        {
        }

        public void ClearOrden_Click(object sender, EventArgs e)
        {
        }

        private void BotonVolverMenu_Click(object sender, EventArgs e)
        {
            PantallaMenu menu = new PantallaMenu();
            this.Hide();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Location = this.Location;
        }

        private void comboBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuscarOrden_Click(object sender, EventArgs e)
        {

        }
    }
}
