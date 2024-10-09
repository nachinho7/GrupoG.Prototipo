using System;
using System.Linq;
using System.Windows.Forms;

namespace GrupoG.Prototipo.Stock
{
    public partial class PantallaRetiroStock : Form
    {
        private PantallaRetiroStockModel modelo;

        public PantallaRetiroStock()
        {
            InitializeComponent();
            modelo = new PantallaRetiroStockModel();
            Load += PantallaRetiroStock_Load;
        }

       
        private void PantallaRetiroStock_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        
        private void CargarOrdenes()
        {
            var ordenes = modelo.ObtenerOrdenesSeleccionadas();
            comboBox1.Items.Clear(); 

            
            foreach (var orden in ordenes)
            {
                comboBox1.Items.Add($"Orden N° {orden.numeroOrdenSeleccion}"); 
            }

            
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            
            if (comboBox1.Items.Count > 0)
            {
                ComboBox1_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (comboBox1.SelectedIndex == -1) return;

            int indiceOrdenSeleccionada = comboBox1.SelectedIndex;
            var ordenSeleccionada = modelo.ObtenerOrdenesSeleccionadas()[indiceOrdenSeleccionada];

            
            if (ordenSeleccionada != null)
            {
                foreach (var mercaderia in ordenSeleccionada.Mercaderias)
                {
                    var item = new ListViewItem(mercaderia.idMercaderia.ToString()); 
                    item.SubItems.Add(mercaderia.nombreMercaderia); 
                    item.SubItems.Add(mercaderia.cantidadMercaderia.ToString()); 
                    item.SubItems.Add(mercaderia.ubicacionMercaderia.ToString()); 
                    listView1.Items.Add(item);
                }
            }
        }

        
        private void btnRetirarStock_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos una mercadería para retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indiceOrdenSeleccionada = comboBox1.SelectedIndex;
            var ordenSeleccionada = modelo.ObtenerOrdenesSeleccionadas()[indiceOrdenSeleccionada];

            
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                int idMercaderia = int.Parse(selectedItem.Text);
                var mercaderia = ordenSeleccionada.Mercaderias.FirstOrDefault(m => m.idMercaderia == idMercaderia);

                if (mercaderia != null)
                {
                    modelo.RemoverMercaderiaDeOrden(ordenSeleccionada, mercaderia);
                }
            }

            
            if (ordenSeleccionada.Mercaderias.Count == 0)
            {
                modelo.RemoverOrdenSeleccionada(ordenSeleccionada);
                MessageBox.Show("La orden seleccionada ha sido completamente retirada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            CargarOrdenes();

            
            if (modelo.ObtenerOrdenesSeleccionadas().Count == 0)
            {
                MessageBox.Show("No quedan órdenes de selección.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
               
                if (indiceOrdenSeleccionada < comboBox1.Items.Count)
                {
                    comboBox1.SelectedIndex = indiceOrdenSeleccionada;
                }
                else
                {
                    comboBox1.SelectedIndex = 0;
                }

                ComboBox1_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
