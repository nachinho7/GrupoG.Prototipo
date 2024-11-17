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
            ComboBoxDeposito = new ComboBox();
            DepositoLabel = new Label();
            SuspendLayout();
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(721, 448);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(156, 51);
            btnEntregar.TabIndex = 7;
            btnEntregar.Text = "Generar Orden de Entrega";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += BotonEntregar_Click;
            // 
            // ListaOrdenesEmpaquetar
            // 
            ListaOrdenesEmpaquetar.Columns.AddRange(new ColumnHeader[] { ColumnaNumeroOrden, ColumnaNCliente, ColumnaProductos, ColumnaDniTransportista, ColumnaFecha });
            ListaOrdenesEmpaquetar.FullRowSelect = true;
            ListaOrdenesEmpaquetar.GridLines = true;
            ListaOrdenesEmpaquetar.Location = new Point(26, 95);
            ListaOrdenesEmpaquetar.Name = "ListaOrdenesEmpaquetar";
            ListaOrdenesEmpaquetar.Size = new Size(1047, 346);
            ListaOrdenesEmpaquetar.TabIndex = 9;
            ListaOrdenesEmpaquetar.UseCompatibleStateImageBehavior = false;
            ListaOrdenesEmpaquetar.View = View.Details;
            // 
            // ColumnaNumeroOrden
            // 
            ColumnaNumeroOrden.Text = "Nº de Orden";
            ColumnaNumeroOrden.Width = 200;
            // 
            // ColumnaNCliente
            // 
            ColumnaNCliente.Text = "N° Cliente";
            ColumnaNCliente.Width = 200;
            // 
            // ColumnaProductos
            // 
            ColumnaProductos.Text = "Cantidad Productos";
            ColumnaProductos.Width = 200;
            // 
            // ColumnaDniTransportista
            // 
            ColumnaDniTransportista.Text = "Dni Transportista";
            ColumnaDniTransportista.Width = 200;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.Text = "Fecha Despacho";
            ColumnaFecha.Width = 240;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(906, 448);
            BotonVolverMenu.Margin = new Padding(3, 4, 3, 4);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(156, 51);
            BotonVolverMenu.TabIndex = 10;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            BotonVolverMenu.Click += VolverAlMenu_Click;
            // 
            // ComboBoxDeposito
            // 
            ComboBoxDeposito.FormattingEnabled = true;
            ComboBoxDeposito.Location = new Point(26, 46);
            ComboBoxDeposito.Name = "ComboBoxDeposito";
            ComboBoxDeposito.Size = new Size(416, 28);
            ComboBoxDeposito.TabIndex = 11;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Location = new Point(26, 23);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(151, 20);
            DepositoLabel.TabIndex = 12;
            DepositoLabel.Text = "Numero De Deposito";
            // 
            // PantallaEntrega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1098, 511);
            Controls.Add(DepositoLabel);
            Controls.Add(ComboBoxDeposito);
            Controls.Add(BotonVolverMenu);
            Controls.Add(ListaOrdenesEmpaquetar);
            Controls.Add(btnEntregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PantallaEntrega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orden de Entrega";
            Load += PantallaEntrega_Load;
            Shown += PantallaEntrega_Shown;
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox ComboBoxDeposito;
        private Label DepositoLabel;
    }
}