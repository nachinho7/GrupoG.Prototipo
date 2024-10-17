namespace GrupoG.Prototipo.Entrega
{
    partial class PantallaEntrega
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEntregar = new Button();
            ListaOrdenesEmpaquetar = new ListView();
            ColumnaNumeroOrden = new ColumnHeader();
            ColumnaNCliente = new ColumnHeader();
            ColumnaProductos = new ColumnHeader();
            ColumnaDniTransportista = new ColumnHeader();
            ColumnaFecha = new ColumnHeader();
            BotonVolverMenu = new Button();
            SuspendLayout();
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(820, 346);
            btnEntregar.Margin = new Padding(3, 2, 3, 2);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(107, 38);
            btnEntregar.TabIndex = 7;
            btnEntregar.Text = "Generar Orden de Entrega";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += BotonEmpaquetar_Click;
            // 
            // ListaOrdenesEmpaquetar
            // 
            ListaOrdenesEmpaquetar.Columns.AddRange(new ColumnHeader[] { ColumnaNumeroOrden, ColumnaNCliente, ColumnaProductos, ColumnaDniTransportista, ColumnaFecha });
            ListaOrdenesEmpaquetar.FullRowSelect = true;
            ListaOrdenesEmpaquetar.GridLines = true;
            ListaOrdenesEmpaquetar.Location = new Point(23, 53);
            ListaOrdenesEmpaquetar.Margin = new Padding(3, 2, 3, 2);
            ListaOrdenesEmpaquetar.Name = "ListaOrdenesEmpaquetar";
            ListaOrdenesEmpaquetar.Size = new Size(904, 258);
            ListaOrdenesEmpaquetar.TabIndex = 9;
            ListaOrdenesEmpaquetar.UseCompatibleStateImageBehavior = false;
            ListaOrdenesEmpaquetar.View = View.Details;
            // 
            // ColumnaNumeroOrden
            // 
            ColumnaNumeroOrden.Text = "Nº de Orden";
            ColumnaNumeroOrden.Width = 140;
            // 
            // ColumnaNCliente
            // 
            ColumnaNCliente.Text = "N° Cliente";
            ColumnaNCliente.Width = 140;
            // 
            // ColumnaProductos
            // 
            ColumnaProductos.Text = "Cantidad Productos";
            ColumnaProductos.Width = 200;
            // 
            // ColumnaDniTransportista
            // 
            ColumnaDniTransportista.Text = "Dni Transportista";
            ColumnaDniTransportista.Width = 140;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.Text = "Fecha Despacho";
            ColumnaFecha.Width = 260;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(938, 346);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(107, 38);
            BotonVolverMenu.TabIndex = 10;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            BotonVolverMenu.Click += VolverAlMenu_Click;
            // 
            // PantallaEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1057, 408);
            Controls.Add(BotonVolverMenu);
            Controls.Add(ListaOrdenesEmpaquetar);
            Controls.Add(btnEntregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PantallaEntrega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orden de Entrega";
            Load += PantallaEntrega_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnEntregar;
        private ListView ListaOrdenesEmpaquetar;
        private Button BotonVolverMenu;
        private ColumnHeader ColumnaNumeroOrden;
        private ColumnHeader ColumnaNCliente;
        private ColumnHeader ColumnaProductos;
        private ColumnHeader ColumnaDniTransportista;
        private ColumnHeader ColumnaFecha;
    }
}