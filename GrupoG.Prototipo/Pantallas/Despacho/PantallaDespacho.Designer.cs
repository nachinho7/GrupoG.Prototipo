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
            Estado = new ColumnHeader();
            labelOrdenEntrega = new Label();
            labelDatosAdicionales = new Label();
            textboxDatosAdicionales = new RichTextBox();
            VolverAlMenu = new Button();
            listviewTransportista = new ListView();
            ClienteTransportista = new ColumnHeader();
            EstadoTransportista = new ColumnHeader();
            Patente = new ColumnHeader();
            btnBuscarTransportista = new Button();
            dniTransportista = new TextBox();
            labelTransportista = new Label();
            BotonObtenerDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "N° Cliente";
            // 
            // numeroCliente
            // 
            numeroCliente.Location = new Point(190, 37);
            numeroCliente.Margin = new Padding(4, 5, 4, 5);
            numeroCliente.Name = "numeroCliente";
            numeroCliente.Size = new Size(141, 31);
            numeroCliente.TabIndex = 1;
            // 
            // btnGenerarRemito
            // 
            btnGenerarRemito.Location = new Point(481, 932);
            btnGenerarRemito.Margin = new Padding(4, 5, 4, 5);
            btnGenerarRemito.Name = "btnGenerarRemito";
            btnGenerarRemito.Size = new Size(153, 63);
            btnGenerarRemito.TabIndex = 5;
            btnGenerarRemito.Text = "Generar Remito";
            btnGenerarRemito.UseVisualStyleBackColor = true;
            // 
            // listviewOrdenEntrega
            // 
            listviewOrdenEntrega.Columns.AddRange(new ColumnHeader[] { OrdenEntrega, Estado });
            listviewOrdenEntrega.Location = new Point(51, 154);
            listviewOrdenEntrega.Margin = new Padding(4, 5, 4, 5);
            listviewOrdenEntrega.Name = "listviewOrdenEntrega";
            listviewOrdenEntrega.Size = new Size(587, 189);
            listviewOrdenEntrega.TabIndex = 6;
            listviewOrdenEntrega.UseCompatibleStateImageBehavior = false;
            listviewOrdenEntrega.View = View.Details;
            // 
            // OrdenEntrega
            // 
            OrdenEntrega.Text = "N° Orden";
            OrdenEntrega.Width = 150;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 150;
            // 
            // labelOrdenEntrega
            // 
            labelOrdenEntrega.AutoSize = true;
            labelOrdenEntrega.Location = new Point(57, 108);
            labelOrdenEntrega.Margin = new Padding(4, 0, 4, 0);
            labelOrdenEntrega.Name = "labelOrdenEntrega";
            labelOrdenEntrega.Size = new Size(176, 25);
            labelOrdenEntrega.TabIndex = 7;
            labelOrdenEntrega.Text = "Orden/es de Entrega";
            // 
            // labelDatosAdicionales
            // 
            labelDatosAdicionales.AutoSize = true;
            labelDatosAdicionales.Location = new Point(60, 348);
            labelDatosAdicionales.Margin = new Padding(4, 0, 4, 0);
            labelDatosAdicionales.Name = "labelDatosAdicionales";
            labelDatosAdicionales.Size = new Size(154, 25);
            labelDatosAdicionales.TabIndex = 21;
            labelDatosAdicionales.Text = "Datos Adicionales";
            // 
            // textboxDatosAdicionales
            // 
            textboxDatosAdicionales.Location = new Point(61, 392);
            textboxDatosAdicionales.Margin = new Padding(4, 5, 4, 5);
            textboxDatosAdicionales.Name = "textboxDatosAdicionales";
            textboxDatosAdicionales.Size = new Size(577, 122);
            textboxDatosAdicionales.TabIndex = 23;
            textboxDatosAdicionales.Text = "";
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(51, 932);
            VolverAlMenu.Margin = new Padding(4, 5, 4, 5);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(153, 63);
            VolverAlMenu.TabIndex = 25;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // listviewTransportista
            // 
            listviewTransportista.Columns.AddRange(new ColumnHeader[] { ClienteTransportista, EstadoTransportista, Patente });
            listviewTransportista.Location = new Point(51, 673);
            listviewTransportista.Margin = new Padding(4, 5, 4, 5);
            listviewTransportista.Name = "listviewTransportista";
            listviewTransportista.Size = new Size(575, 192);
            listviewTransportista.TabIndex = 29;
            listviewTransportista.UseCompatibleStateImageBehavior = false;
            listviewTransportista.View = View.Details;
            // 
            // ClienteTransportista
            // 
            ClienteTransportista.Text = "N° Cliente";
            ClienteTransportista.Width = 120;
            // 
            // EstadoTransportista
            // 
            EstadoTransportista.Text = "Transportista habilitado?";
            EstadoTransportista.Width = 230;
            // 
            // Patente
            // 
            Patente.Text = "Patente";
            Patente.Width = 95;
            // 
            // btnBuscarTransportista
            // 
            btnBuscarTransportista.Location = new Point(434, 575);
            btnBuscarTransportista.Margin = new Padding(4, 5, 4, 5);
            btnBuscarTransportista.Name = "btnBuscarTransportista";
            btnBuscarTransportista.Size = new Size(153, 63);
            btnBuscarTransportista.TabIndex = 28;
            btnBuscarTransportista.Text = "Buscar Transportista";
            btnBuscarTransportista.UseVisualStyleBackColor = true;
            // 
            // dniTransportista
            // 
            dniTransportista.Location = new Point(160, 608);
            dniTransportista.Margin = new Padding(4, 5, 4, 5);
            dniTransportista.Name = "dniTransportista";
            dniTransportista.Size = new Size(204, 31);
            dniTransportista.TabIndex = 27;
            // 
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(140, 565);
            labelTransportista.Margin = new Padding(4, 0, 4, 0);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(241, 25);
            labelTransportista.TabIndex = 26;
            labelTransportista.Text = "Ingrese DNI del Transportista";
            // 
            // BotonObtenerDatos
            // 
            BotonObtenerDatos.Location = new Point(407, 33);
            BotonObtenerDatos.Margin = new Padding(4, 5, 4, 5);
            BotonObtenerDatos.Name = "BotonObtenerDatos";
            BotonObtenerDatos.Size = new Size(153, 63);
            BotonObtenerDatos.TabIndex = 30;
            BotonObtenerDatos.Text = "Obtener Datos";
            BotonObtenerDatos.UseVisualStyleBackColor = true;
            BotonObtenerDatos.Click += BotonObtenerDatos_Click;
            // 
            // PantallaDespacho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 1018);
            Controls.Add(BotonObtenerDatos);
            Controls.Add(listviewTransportista);
            Controls.Add(btnBuscarTransportista);
            Controls.Add(dniTransportista);
            Controls.Add(labelTransportista);
            Controls.Add(VolverAlMenu);
            Controls.Add(textboxDatosAdicionales);
            Controls.Add(labelDatosAdicionales);
            Controls.Add(labelOrdenEntrega);
            Controls.Add(listviewOrdenEntrega);
            Controls.Add(btnGenerarRemito);
            Controls.Add(numeroCliente);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PantallaDespacho";
            Text = "Orden de Despacho";
            Load += PantallaDespacho_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numeroCliente;
        private Button btnGenerarRemito;
        private ListView listviewOrdenEntrega;
        private ColumnHeader Estado;
        private Label labelOrdenEntrega;
        private Label labelDatosAdicionales;
        private RichTextBox textboxDatosAdicionales;
        private Button VolverAlMenu;
        private ListView listviewTransportista;
        private ColumnHeader ClienteTransportista;
        private ColumnHeader EstadoTransportista;
        private ColumnHeader Patente;
        private Button btnBuscarTransportista;
        private TextBox dniTransportista;
        private Label labelTransportista;
        private ColumnHeader OrdenEntrega;
        private Button BotonObtenerDatos;
    }
}