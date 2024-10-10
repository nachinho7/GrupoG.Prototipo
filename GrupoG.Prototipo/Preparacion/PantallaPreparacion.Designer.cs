namespace GrupoG.Prototipo
{
    partial class PantallaPreparacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            LabelNumeroCliente = new Label();
            labelCantidadAgregar = new Label();
            btnAgregar = new Button();
            btnGenerar = new Button();
            ListaDatosMercaderia = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            Cantidad = new ColumnHeader();
            ListaPrevisualizacionOrdenesPreparacion = new ListView();
            Id1 = new ColumnHeader();
            Nombre1 = new ColumnHeader();
            Cantidad1 = new ColumnHeader();
            TextBoxCantidad = new TextBox();
            numeroCliente = new TextBox();
            BotonObtenerDatos = new Button();
            VolverAlMenu = new Button();
            btnEliminar = new Button();
            BotonLimpiarCliente = new Button();
            labelNroOrden = new Label();
            textBoxNroOdenPrevisualizacion = new TextBox();
            labelFecha = new Label();
            PickerFechaDespacho = new DateTimePicker();
            labelTransportista = new Label();
            textBoxDNITransportista = new TextBox();
            GroupBoxPrevisualizacion = new GroupBox();
            groupBoxDatosMercaderia = new GroupBox();
            GroupBoxPrevisualizacion.SuspendLayout();
            groupBoxDatosMercaderia.SuspendLayout();
            SuspendLayout();
            // 
            // LabelNumeroCliente
            // 
            LabelNumeroCliente.AutoSize = true;
            LabelNumeroCliente.Location = new Point(46, 51);
            LabelNumeroCliente.Name = "LabelNumeroCliente";
            LabelNumeroCliente.Size = new Size(83, 20);
            LabelNumeroCliente.TabIndex = 0;
            LabelNumeroCliente.Text = "N° Cliente: ";
            LabelNumeroCliente.UseWaitCursor = true;
            // 
            // labelCantidadAgregar
            // 
            labelCantidadAgregar.AutoSize = true;
            labelCantidadAgregar.Location = new Point(7, 231);
            labelCantidadAgregar.Name = "labelCantidadAgregar";
            labelCantidadAgregar.Size = new Size(140, 20);
            labelCantidadAgregar.TabIndex = 6;
            labelCantidadAgregar.Text = "Cantidad a agregar:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(355, 215);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 51);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(305, 988);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(122, 51);
            btnGenerar.TabIndex = 14;
            btnGenerar.Text = "Generar Orden";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // ListaDatosMercaderia
            // 
            ListaDatosMercaderia.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Cantidad });
            ListaDatosMercaderia.FullRowSelect = true;
            ListaDatosMercaderia.GridLines = true;
            ListaDatosMercaderia.Location = new Point(7, 29);
            ListaDatosMercaderia.Margin = new Padding(3, 4, 3, 4);
            ListaDatosMercaderia.Name = "ListaDatosMercaderia";
            ListaDatosMercaderia.Size = new Size(511, 164);
            ListaDatosMercaderia.TabIndex = 15;
            ListaDatosMercaderia.UseCompatibleStateImageBehavior = false;
            ListaDatosMercaderia.View = View.Details;
            ListaDatosMercaderia.SelectedIndexChanged += ListaDatosMercaderia_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 120;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // ListaPrevisualizacionOrdenesPreparacion
            // 
            ListaPrevisualizacionOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { Id1, Nombre1, Cantidad1 });
            ListaPrevisualizacionOrdenesPreparacion.FullRowSelect = true;
            ListaPrevisualizacionOrdenesPreparacion.GridLines = true;
            ListaPrevisualizacionOrdenesPreparacion.Location = new Point(18, 196);
            ListaPrevisualizacionOrdenesPreparacion.Margin = new Padding(3, 4, 3, 4);
            ListaPrevisualizacionOrdenesPreparacion.Name = "ListaPrevisualizacionOrdenesPreparacion";
            ListaPrevisualizacionOrdenesPreparacion.Size = new Size(500, 185);
            ListaPrevisualizacionOrdenesPreparacion.TabIndex = 16;
            ListaPrevisualizacionOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            ListaPrevisualizacionOrdenesPreparacion.View = View.Details;
            // 
            // Id1
            // 
            Id1.Text = "Id";
            // 
            // Nombre1
            // 
            Nombre1.Text = "Nombre";
            Nombre1.Width = 120;
            // 
            // Cantidad1
            // 
            Cantidad1.Text = "Cantidad";
            Cantidad1.Width = 120;
            // 
            // TextBoxCantidad
            // 
            TextBoxCantidad.Location = new Point(139, 227);
            TextBoxCantidad.Margin = new Padding(3, 4, 3, 4);
            TextBoxCantidad.Name = "TextBoxCantidad";
            TextBoxCantidad.Size = new Size(191, 27);
            TextBoxCantidad.TabIndex = 18;
            // 
            // numeroCliente
            // 
            numeroCliente.Location = new Point(135, 47);
            numeroCliente.Margin = new Padding(3, 4, 3, 4);
            numeroCliente.Name = "numeroCliente";
            numeroCliente.Size = new Size(149, 27);
            numeroCliente.TabIndex = 28;
            // 
            // BotonObtenerDatos
            // 
            BotonObtenerDatos.Location = new Point(305, 35);
            BotonObtenerDatos.Margin = new Padding(3, 4, 3, 4);
            BotonObtenerDatos.Name = "BotonObtenerDatos";
            BotonObtenerDatos.Size = new Size(122, 51);
            BotonObtenerDatos.TabIndex = 29;
            BotonObtenerDatos.Text = "Obtener Datos";
            BotonObtenerDatos.UseVisualStyleBackColor = true;
            BotonObtenerDatos.Click += BotonObtenerDatos_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(453, 988);
            VolverAlMenu.Margin = new Padding(3, 4, 3, 4);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(122, 51);
            VolverAlMenu.TabIndex = 30;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(226, 421);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(227, 51);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Limpiar Dato Seleccionado";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // BotonLimpiarCliente
            // 
            BotonLimpiarCliente.Location = new Point(442, 35);
            BotonLimpiarCliente.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiarCliente.Name = "BotonLimpiarCliente";
            BotonLimpiarCliente.Size = new Size(122, 51);
            BotonLimpiarCliente.TabIndex = 32;
            BotonLimpiarCliente.Text = "Nueva Busqueda";
            BotonLimpiarCliente.UseVisualStyleBackColor = true;
            BotonLimpiarCliente.Click += BotonLimpiarCliente_Click;
            // 
            // labelNroOrden
            // 
            labelNroOrden.AutoSize = true;
            labelNroOrden.Location = new Point(7, 37);
            labelNroOrden.Name = "labelNroOrden";
            labelNroOrden.Size = new Size(92, 20);
            labelNroOrden.TabIndex = 33;
            labelNroOrden.Text = "N° de Orden";
            // 
            // textBoxNroOdenPrevisualizacion
            // 
            textBoxNroOdenPrevisualizacion.Location = new Point(139, 33);
            textBoxNroOdenPrevisualizacion.Margin = new Padding(3, 4, 3, 4);
            textBoxNroOdenPrevisualizacion.Name = "textBoxNroOdenPrevisualizacion";
            textBoxNroOdenPrevisualizacion.ReadOnly = true;
            textBoxNroOdenPrevisualizacion.Size = new Size(242, 27);
            textBoxNroOdenPrevisualizacion.TabIndex = 34;
            textBoxNroOdenPrevisualizacion.Text = "1";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(7, 84);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(138, 20);
            labelFecha.TabIndex = 35;
            labelFecha.Text = "Fecha de Despacho";
            // 
            // PickerFechaDespacho
            // 
            PickerFechaDespacho.Checked = false;
            PickerFechaDespacho.CustomFormat = " ";
            PickerFechaDespacho.Format = DateTimePickerFormat.Short;
            PickerFechaDespacho.Location = new Point(139, 76);
            PickerFechaDespacho.Margin = new Padding(3, 4, 3, 4);
            PickerFechaDespacho.Name = "PickerFechaDespacho";
            PickerFechaDespacho.Size = new Size(242, 27);
            PickerFechaDespacho.TabIndex = 36;
            // 
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(7, 131);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(124, 20);
            labelTransportista.TabIndex = 37;
            labelTransportista.Text = "DNI Transportista";
            // 
            // textBoxDNITransportista
            // 
            textBoxDNITransportista.Location = new Point(139, 127);
            textBoxDNITransportista.Margin = new Padding(3, 4, 3, 4);
            textBoxDNITransportista.Name = "textBoxDNITransportista";
            textBoxDNITransportista.Size = new Size(242, 27);
            textBoxDNITransportista.TabIndex = 38;
            // 
            // GroupBoxPrevisualizacion
            // 
            GroupBoxPrevisualizacion.Controls.Add(textBoxDNITransportista);
            GroupBoxPrevisualizacion.Controls.Add(labelNroOrden);
            GroupBoxPrevisualizacion.Controls.Add(labelTransportista);
            GroupBoxPrevisualizacion.Controls.Add(ListaPrevisualizacionOrdenesPreparacion);
            GroupBoxPrevisualizacion.Controls.Add(PickerFechaDespacho);
            GroupBoxPrevisualizacion.Controls.Add(btnEliminar);
            GroupBoxPrevisualizacion.Controls.Add(labelFecha);
            GroupBoxPrevisualizacion.Controls.Add(textBoxNroOdenPrevisualizacion);
            GroupBoxPrevisualizacion.Location = new Point(46, 459);
            GroupBoxPrevisualizacion.Margin = new Padding(3, 4, 3, 4);
            GroupBoxPrevisualizacion.Name = "GroupBoxPrevisualizacion";
            GroupBoxPrevisualizacion.Padding = new Padding(3, 4, 3, 4);
            GroupBoxPrevisualizacion.Size = new Size(529, 507);
            GroupBoxPrevisualizacion.TabIndex = 39;
            GroupBoxPrevisualizacion.TabStop = false;
            GroupBoxPrevisualizacion.Text = "Previsualización Orden de Preparación";
            // 
            // groupBoxDatosMercaderia
            // 
            groupBoxDatosMercaderia.Controls.Add(ListaDatosMercaderia);
            groupBoxDatosMercaderia.Controls.Add(labelCantidadAgregar);
            groupBoxDatosMercaderia.Controls.Add(btnAgregar);
            groupBoxDatosMercaderia.Controls.Add(TextBoxCantidad);
            groupBoxDatosMercaderia.Location = new Point(46, 115);
            groupBoxDatosMercaderia.Margin = new Padding(3, 4, 3, 4);
            groupBoxDatosMercaderia.Name = "groupBoxDatosMercaderia";
            groupBoxDatosMercaderia.Padding = new Padding(3, 4, 3, 4);
            groupBoxDatosMercaderia.Size = new Size(529, 316);
            groupBoxDatosMercaderia.TabIndex = 40;
            groupBoxDatosMercaderia.TabStop = false;
            groupBoxDatosMercaderia.Text = "Datos de Mercadería";
            // 
            // PantallaPreparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(616, 1055);
            Controls.Add(groupBoxDatosMercaderia);
            Controls.Add(GroupBoxPrevisualizacion);
            Controls.Add(BotonLimpiarCliente);
            Controls.Add(VolverAlMenu);
            Controls.Add(BotonObtenerDatos);
            Controls.Add(numeroCliente);
            Controls.Add(btnGenerar);
            Controls.Add(LabelNumeroCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaPreparacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orden de Preparación";
            Load += PantallaPreparacion_Load;
            GroupBoxPrevisualizacion.ResumeLayout(false);
            GroupBoxPrevisualizacion.PerformLayout();
            groupBoxDatosMercaderia.ResumeLayout(false);
            groupBoxDatosMercaderia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNumeroCliente;
        private Label labelCantidadAgregar;
        private Button btnAgregar;
        private Button btnGenerar;
        private ListView ListaDatosMercaderia;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private ColumnHeader Cantidad;
        private ListView ListaPrevisualizacionOrdenesPreparacion;
        private ColumnHeader Id1;
        private ColumnHeader Nombre1;
        private ColumnHeader Cantidad1;
        private TextBox TextBoxCantidad;
        private TextBox numeroCliente;
        private Button BotonObtenerDatos;
        private Button VolverAlMenu;
        private Button btnEliminar;
        private Button BotonLimpiarCliente;
        private Label labelNroOrden;
        private TextBox textBoxNroOdenPrevisualizacion;
        private Label labelFecha;
        private DateTimePicker PickerFechaDespacho;
        private Label labelTransportista;
        private TextBox textBoxDNITransportista;
        private GroupBox GroupBoxPrevisualizacion;
        private GroupBox groupBoxDatosMercaderia;
    }
}
