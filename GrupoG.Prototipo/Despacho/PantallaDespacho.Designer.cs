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
            SuspendLayout();
            // 
            // btnGenerarRemito
            // 
            btnGenerarRemito.Location = new Point(446, 437);
            btnGenerarRemito.Name = "btnGenerarRemito";
            btnGenerarRemito.Size = new Size(107, 38);
            btnGenerarRemito.TabIndex = 5;
            btnGenerarRemito.Text = "Generar Remito";
            btnGenerarRemito.UseVisualStyleBackColor = true;
            btnGenerarRemito.Click += btnGenerarRemito_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(578, 437);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(107, 38);
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
            listviewTransportista.Location = new Point(12, 160);
            listviewTransportista.Name = "listviewTransportista";
            listviewTransportista.Size = new Size(671, 255);
            listviewTransportista.TabIndex = 29;
            listviewTransportista.UseCompatibleStateImageBehavior = false;
            listviewTransportista.View = View.Details;
            // 
            // ColumnaIdOrden
            // 
            ColumnaIdOrden.Text = "Nro de Orden";
            ColumnaIdOrden.Width = 250;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.Text = "Nro de Cliente";
            ColumnaCliente.Width = 250;
            // 
            // btnBuscarTransportista
            // 
            btnBuscarTransportista.Enabled = false;
            btnBuscarTransportista.Location = new Point(478, 19);
            btnBuscarTransportista.Name = "btnBuscarTransportista";
            btnBuscarTransportista.Size = new Size(205, 38);
            btnBuscarTransportista.TabIndex = 28;
            btnBuscarTransportista.Text = "Buscar Transportista";
            btnBuscarTransportista.UseVisualStyleBackColor = true;
            btnBuscarTransportista.Click += btnBuscarTransportista_Click;
            // 
            // dniTransportista
            // 
            dniTransportista.Enabled = false;
            dniTransportista.Location = new Point(188, 28);
            dniTransportista.Name = "dniTransportista";
            dniTransportista.Size = new Size(257, 23);
            dniTransportista.TabIndex = 27;
            // 
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(12, 31);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(157, 15);
            labelTransportista.TabIndex = 26;
            labelTransportista.Text = "Ingrese DNI del Transportista";
            // 
            // nroclienteLabel
            // 
            nroclienteLabel.AutoSize = true;
            nroclienteLabel.Location = new Point(12, 94);
            nroclienteLabel.Name = "nroclienteLabel";
            nroclienteLabel.Size = new Size(99, 15);
            nroclienteLabel.TabIndex = 30;
            nroclienteLabel.Text = "Ingrese N°Cliente";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(156, 91);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(130, 23);
            comboBoxClientes.TabIndex = 31;
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // PantallaDespacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(746, 497);
            Controls.Add(comboBoxClientes);
            Controls.Add(nroclienteLabel);
            Controls.Add(listviewTransportista);
            Controls.Add(btnBuscarTransportista);
            Controls.Add(dniTransportista);
            Controls.Add(labelTransportista);
            Controls.Add(VolverAlMenu);
            Controls.Add(btnGenerarRemito);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
    }
}