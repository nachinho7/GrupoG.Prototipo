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
            BotonVolverMenu = new Button();
            ColumnaFecha = new ColumnHeader();
            SuspendLayout();
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(26, 434);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(122, 51);
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
            ListaOrdenesEmpaquetar.Location = new Point(26, 71);
            ListaOrdenesEmpaquetar.Name = "ListaOrdenesEmpaquetar";
            ListaOrdenesEmpaquetar.Size = new Size(885, 343);
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
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(154, 434);
            BotonVolverMenu.Margin = new Padding(3, 4, 3, 4);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(122, 51);
            BotonVolverMenu.TabIndex = 10;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            BotonVolverMenu.Click += VolverAlMenu_Click;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.Text = "Fecha Despacho";
            ColumnaFecha.Width = 260;
            // 
            // PantallaEntrega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(937, 516);
            Controls.Add(BotonVolverMenu);
            Controls.Add(ListaOrdenesEmpaquetar);
            Controls.Add(btnEntregar);
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