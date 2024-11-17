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
            btnEntregar.Location = new Point(672, 336);
            btnEntregar.Margin = new Padding(3, 2, 3, 2);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(136, 38);
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
            ListaOrdenesEmpaquetar.Location = new Point(23, 71);
            ListaOrdenesEmpaquetar.Margin = new Padding(3, 2, 3, 2);
            ListaOrdenesEmpaquetar.Name = "ListaOrdenesEmpaquetar";
            ListaOrdenesEmpaquetar.Size = new Size(946, 260);
            ListaOrdenesEmpaquetar.TabIndex = 9;
            ListaOrdenesEmpaquetar.UseCompatibleStateImageBehavior = false;
            ListaOrdenesEmpaquetar.View = View.Details;
            // 
            // ColumnaNumeroOrden
            // 
            ColumnaNumeroOrden.Text = "Nº de Orden";
            ColumnaNumeroOrden.Width = 150;
            // 
            // ColumnaNCliente
            // 
            ColumnaNCliente.Text = "N° Cliente";
            ColumnaNCliente.Width = 150;
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
            BotonVolverMenu.Location = new Point(833, 336);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(136, 38);
            BotonVolverMenu.TabIndex = 10;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            BotonVolverMenu.Click += VolverAlMenu_Click;
            // 
            // ComboBoxDeposito
            // 
            ComboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxDeposito.FormattingEnabled = true;
            ComboBoxDeposito.Location = new Point(23, 34);
            ComboBoxDeposito.Margin = new Padding(3, 2, 3, 2);
            ComboBoxDeposito.Name = "ComboBoxDeposito";
            ComboBoxDeposito.Size = new Size(364, 23);
            ComboBoxDeposito.TabIndex = 11;
            ComboBoxDeposito.SelectedIndexChanged += ComboBoxDeposito_SelectedIndexChanged;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Location = new Point(23, 17);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(118, 15);
            DepositoLabel.TabIndex = 12;
            DepositoLabel.Text = "Numero De Deposito";
            // 
            // PantallaEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(992, 383);
            Controls.Add(DepositoLabel);
            Controls.Add(ComboBoxDeposito);
            Controls.Add(BotonVolverMenu);
            Controls.Add(ListaOrdenesEmpaquetar);
            Controls.Add(btnEntregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PantallaEntrega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orden de Entrega";
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