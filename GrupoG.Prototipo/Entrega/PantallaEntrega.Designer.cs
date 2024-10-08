namespace GrupoG.Prototipo.Pantallas
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
            BotonVolverAlMenu = new Button();
            SuspendLayout();
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(23, 297);
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
            ListaOrdenesEmpaquetar.Columns.AddRange(new ColumnHeader[] { ColumnaNumeroOrden });
            ListaOrdenesEmpaquetar.FullRowSelect = true;
            ListaOrdenesEmpaquetar.GridLines = true;
            ListaOrdenesEmpaquetar.Location = new Point(23, 53);
            ListaOrdenesEmpaquetar.Margin = new Padding(3, 2, 3, 2);
            ListaOrdenesEmpaquetar.Name = "ListaOrdenesEmpaquetar";
            ListaOrdenesEmpaquetar.Size = new Size(220, 222);
            ListaOrdenesEmpaquetar.TabIndex = 9;
            ListaOrdenesEmpaquetar.UseCompatibleStateImageBehavior = false;
            ListaOrdenesEmpaquetar.View = View.Details;
            // 
            // ColumnaNumeroOrden
            // 
            ColumnaNumeroOrden.Text = "Nº de Orden";
            ColumnaNumeroOrden.Width = 200;
            // 
            // BotonVolverAlMenu
            // 
            BotonVolverAlMenu.Location = new Point(136, 297);
            BotonVolverAlMenu.Name = "BotonVolverAlMenu";
            BotonVolverAlMenu.Size = new Size(107, 38);
            BotonVolverAlMenu.TabIndex = 10;
            BotonVolverAlMenu.Text = "Volver al Menú";
            BotonVolverAlMenu.UseVisualStyleBackColor = true;
            BotonVolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // PantallaEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 357);
            Controls.Add(BotonVolverAlMenu);
            Controls.Add(ListaOrdenesEmpaquetar);
            Controls.Add(btnEntregar);
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
        private Button BotonVolverAlMenu;
        private ColumnHeader ColumnaNumeroOrden;
    }
}