namespace GrupoG.Prototipo.Pantallas
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
            label1 = new Label();
            numeroCliente = new TextBox();
            btnGenerarRemito = new Button();
            listviewOrdenEntrega = new ListView();
            OrdenEntrega = new ColumnHeader();
            labelDatosAdicionales = new Label();
            textboxDatosAdicionales = new RichTextBox();
            VolverAlMenu = new Button();
            listviewTransportista = new ListView();
            EstadoTransportista = new ColumnHeader();
            Patente = new ColumnHeader();
            btnBuscarTransportista = new Button();
            dniTransportista = new TextBox();
            labelTransportista = new Label();
            BotonObtenerDatos = new Button();
            btnLimpiarCliente = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "N° Cliente";
            // 
            // numeroCliente
            // 
            numeroCliente.Location = new Point(133, 31);
            numeroCliente.Margin = new Padding(3, 4, 3, 4);
            numeroCliente.Name = "numeroCliente";
            numeroCliente.Size = new Size(114, 27);
            numeroCliente.TabIndex = 1;
            // 
            // btnGenerarRemito
            // 
            btnGenerarRemito.Location = new Point(110, 787);
            btnGenerarRemito.Margin = new Padding(3, 4, 3, 4);
            btnGenerarRemito.Name = "btnGenerarRemito";
            btnGenerarRemito.Size = new Size(122, 51);
            btnGenerarRemito.TabIndex = 5;
            btnGenerarRemito.Text = "Generar Remito";
            btnGenerarRemito.UseVisualStyleBackColor = true;
            btnGenerarRemito.Click += btnGenerarRemito_Click;
            // 
            // listviewOrdenEntrega
            // 
            listviewOrdenEntrega.Columns.AddRange(new ColumnHeader[] { OrdenEntrega });
            listviewOrdenEntrega.FullRowSelect = true;
            listviewOrdenEntrega.GridLines = true;
            listviewOrdenEntrega.Location = new Point(9, 29);
            listviewOrdenEntrega.Margin = new Padding(3, 4, 3, 4);
            listviewOrdenEntrega.Name = "listviewOrdenEntrega";
            listviewOrdenEntrega.Size = new Size(322, 152);
            listviewOrdenEntrega.TabIndex = 6;
            listviewOrdenEntrega.UseCompatibleStateImageBehavior = false;
            listviewOrdenEntrega.View = View.Details;
            // 
            // OrdenEntrega
            // 
            OrdenEntrega.Text = "N° Orden";
            OrdenEntrega.Width = 225;
            // 
            // labelDatosAdicionales
            // 
            labelDatosAdicionales.AutoSize = true;
            labelDatosAdicionales.Location = new Point(9, 200);
            labelDatosAdicionales.Name = "labelDatosAdicionales";
            labelDatosAdicionales.Size = new Size(129, 20);
            labelDatosAdicionales.TabIndex = 21;
            labelDatosAdicionales.Text = "Datos Adicionales";
            // 
            // textboxDatosAdicionales
            // 
            textboxDatosAdicionales.Location = new Point(9, 243);
            textboxDatosAdicionales.Margin = new Padding(3, 4, 3, 4);
            textboxDatosAdicionales.Name = "textboxDatosAdicionales";
            textboxDatosAdicionales.Size = new Size(322, 99);
            textboxDatosAdicionales.TabIndex = 23;
            textboxDatosAdicionales.Text = "";
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(250, 787);
            VolverAlMenu.Margin = new Padding(3, 4, 3, 4);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(122, 51);
            VolverAlMenu.TabIndex = 25;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // listviewTransportista
            // 
            listviewTransportista.Columns.AddRange(new ColumnHeader[] { EstadoTransportista, Patente });
            listviewTransportista.FullRowSelect = true;
            listviewTransportista.GridLines = true;
            listviewTransportista.Location = new Point(41, 579);
            listviewTransportista.Margin = new Padding(3, 4, 3, 4);
            listviewTransportista.Name = "listviewTransportista";
            listviewTransportista.Size = new Size(322, 155);
            listviewTransportista.TabIndex = 29;
            listviewTransportista.UseCompatibleStateImageBehavior = false;
            listviewTransportista.View = View.Details;
            // 
            // EstadoTransportista
            // 
            EstadoTransportista.Text = "Estado Transportista";
            EstadoTransportista.Width = 150;
            // 
            // Patente
            // 
            Patente.Text = "Patente";
            Patente.Width = 120;
            // 
            // btnBuscarTransportista
            // 
            btnBuscarTransportista.Enabled = false;
            btnBuscarTransportista.Location = new Point(241, 499);
            btnBuscarTransportista.Margin = new Padding(3, 4, 3, 4);
            btnBuscarTransportista.Name = "btnBuscarTransportista";
            btnBuscarTransportista.Size = new Size(122, 51);
            btnBuscarTransportista.TabIndex = 28;
            btnBuscarTransportista.Text = "Buscar Transportista";
            btnBuscarTransportista.UseVisualStyleBackColor = true;
            btnBuscarTransportista.Click += btnBuscarTransportista_Click;
            // 
            // dniTransportista
            // 
            dniTransportista.Enabled = false;
            dniTransportista.Location = new Point(53, 519);
            dniTransportista.Margin = new Padding(3, 4, 3, 4);
            dniTransportista.Name = "dniTransportista";
            dniTransportista.Size = new Size(157, 27);
            dniTransportista.TabIndex = 27;
            // 
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(41, 495);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(201, 20);
            labelTransportista.TabIndex = 26;
            labelTransportista.Text = "Ingrese DNI del Transportista";
            // 
            // BotonObtenerDatos
            // 
            BotonObtenerDatos.Location = new Point(257, 25);
            BotonObtenerDatos.Margin = new Padding(3, 4, 3, 4);
            BotonObtenerDatos.Name = "BotonObtenerDatos";
            BotonObtenerDatos.Size = new Size(106, 37);
            BotonObtenerDatos.TabIndex = 30;
            BotonObtenerDatos.Text = "Obtener Datos";
            BotonObtenerDatos.UseVisualStyleBackColor = true;
            BotonObtenerDatos.Click += BotonObtenerDatos_Click;
            // 
            // btnLimpiarCliente
            // 
            btnLimpiarCliente.Location = new Point(257, 71);
            btnLimpiarCliente.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarCliente.Name = "btnLimpiarCliente";
            btnLimpiarCliente.Size = new Size(115, 32);
            btnLimpiarCliente.TabIndex = 31;
            btnLimpiarCliente.Text = "Limpiar Cliente";
            btnLimpiarCliente.UseVisualStyleBackColor = true;
            btnLimpiarCliente.Click += btnlimpiarCliente_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listviewOrdenEntrega);
            groupBox1.Controls.Add(labelDatosAdicionales);
            groupBox1.Controls.Add(textboxDatosAdicionales);
            groupBox1.Location = new Point(41, 111);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(338, 363);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orden/es de Preparación";
            // 
            // PantallaDespacho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(417, 861);
            Controls.Add(groupBox1);
            Controls.Add(btnLimpiarCliente);
            Controls.Add(BotonObtenerDatos);
            Controls.Add(listviewTransportista);
            Controls.Add(btnBuscarTransportista);
            Controls.Add(dniTransportista);
            Controls.Add(labelTransportista);
            Controls.Add(VolverAlMenu);
            Controls.Add(btnGenerarRemito);
            Controls.Add(numeroCliente);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaDespacho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orden de Despacho";
            Load += PantallaDespacho_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numeroCliente;
        private Button btnGenerarRemito;
        private ListView listviewOrdenEntrega;
        private Label labelDatosAdicionales;
        private RichTextBox textboxDatosAdicionales;
        private Button VolverAlMenu;
        private ListView listviewTransportista;
        private ColumnHeader EstadoTransportista;
        private ColumnHeader Patente;
        private Button btnBuscarTransportista;
        private TextBox dniTransportista;
        private Label labelTransportista;
        private ColumnHeader OrdenEntrega;
        private Button BotonObtenerDatos;
        private Button btnLimpiarCliente;
        private GroupBox groupBox1;
    }
}