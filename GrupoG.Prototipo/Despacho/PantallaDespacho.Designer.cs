namespace GrupoG.Prototipo.Despacho
{
    partial class PantallaDespacho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            btnGenerarRemito = new Button();
            VolverAlMenu = new Button();
            listviewTransportista = new ListView();
            ColumnaIdOrden = new ColumnHeader();
            ColumnaCliente = new ColumnHeader();
            btnBuscarTransportista = new Button();
            dniTransportista = new TextBox();
            labelTransportista = new Label();
            nroclienteLabel = new Label();
            comboBoxClientes = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnGenerarRemito
            // 
            btnGenerarRemito.Location = new Point(396, 504);
            btnGenerarRemito.Margin = new Padding(3, 4, 3, 4);
            btnGenerarRemito.Name = "btnGenerarRemito";
            btnGenerarRemito.Size = new Size(156, 51);
            btnGenerarRemito.TabIndex = 5;
            btnGenerarRemito.Text = "Generar Remito";
            btnGenerarRemito.UseVisualStyleBackColor = true;
            btnGenerarRemito.Click += btnGenerarRemito_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(622, 504);
            VolverAlMenu.Margin = new Padding(3, 4, 3, 4);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(158, 51);
            VolverAlMenu.TabIndex = 25;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // listviewTransportista
            // 
            listviewTransportista.Columns.AddRange(new ColumnHeader[] { ColumnaIdOrden, ColumnaCliente });
            listviewTransportista.FullRowSelect = true;
            listviewTransportista.GridLines = true;
            listviewTransportista.Location = new Point(14, 147);
            listviewTransportista.Margin = new Padding(3, 4, 3, 4);
            listviewTransportista.Name = "listviewTransportista";
            listviewTransportista.Size = new Size(766, 339);
            listviewTransportista.TabIndex = 29;
            listviewTransportista.UseCompatibleStateImageBehavior = false;
            listviewTransportista.View = View.Details;
            // 
            // ColumnaIdOrden
            // 
            ColumnaIdOrden.Text = "Nro de Orden";
            ColumnaIdOrden.Width = 380;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.Text = "Nro de Cliente";
            ColumnaCliente.Width = 380;
            // 
            // btnBuscarTransportista
            // 
            btnBuscarTransportista.Enabled = false;
            btnBuscarTransportista.Location = new Point(396, 37);
            btnBuscarTransportista.Margin = new Padding(3, 4, 3, 4);
            btnBuscarTransportista.Name = "btnBuscarTransportista";
            btnBuscarTransportista.Size = new Size(156, 93);
            btnBuscarTransportista.TabIndex = 28;
            btnBuscarTransportista.Text = "Buscar Transportista";
            btnBuscarTransportista.UseVisualStyleBackColor = true;
            btnBuscarTransportista.Click += btnBuscarTransportista_Click;
            // 
            // dniTransportista
            // 
            dniTransportista.Enabled = false;
            dniTransportista.Location = new Point(14, 37);
            dniTransportista.Margin = new Padding(3, 4, 3, 4);
            dniTransportista.Name = "dniTransportista";
            dniTransportista.Size = new Size(302, 27);
            dniTransportista.TabIndex = 27;
            // 
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(12, 13);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(201, 20);
            labelTransportista.TabIndex = 26;
            labelTransportista.Text = "Ingrese DNI del Transportista";
            // 
            // nroclienteLabel
            // 
            nroclienteLabel.AutoSize = true;
            nroclienteLabel.Location = new Point(12, 78);
            nroclienteLabel.Name = "nroclienteLabel";
            nroclienteLabel.Size = new Size(147, 20);
            nroclienteLabel.TabIndex = 30;
            nroclienteLabel.Text = "Seleccione N°Cliente";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(14, 102);
            comboBoxClientes.Margin = new Padding(3, 4, 3, 4);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(302, 28);
            comboBoxClientes.TabIndex = 31;
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(622, 37);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 93);
            button1.TabIndex = 32;
            button1.Text = "Nueva Busqueda";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNuevaBusqueda;
            // 
            // PantallaDespacho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 570);
            Controls.Add(button1);
            Controls.Add(comboBoxClientes);
            Controls.Add(nroclienteLabel);
            Controls.Add(listviewTransportista);
            Controls.Add(btnBuscarTransportista);
            Controls.Add(dniTransportista);
            Controls.Add(labelTransportista);
            Controls.Add(VolverAlMenu);
            Controls.Add(btnGenerarRemito);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaDespacho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orden de Despacho";
            Load += PantallaDespacho_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGenerarRemito;
        private Button VolverAlMenu;
        private ListView listviewTransportista;
        private Button btnBuscarTransportista;
        private TextBox dniTransportista;
        private Label labelTransportista;
        private ColumnHeader ColumnaIdOrden;
        private ColumnHeader ColumnaCliente;
        private Label nroclienteLabel;
        private ComboBox comboBoxClientes;
        private Button button1;
    }
}