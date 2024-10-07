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
            LabelNumeroCliente.Location = new Point(40, 32);
            LabelNumeroCliente.Name = "LabelNumeroCliente";
            LabelNumeroCliente.Size = new Size(67, 15);
            LabelNumeroCliente.TabIndex = 0;
            LabelNumeroCliente.Text = "N° Cliente: ";
            LabelNumeroCliente.UseWaitCursor = true;
            // 
            // labelCantidadAgregar
            // 
            labelCantidadAgregar.AutoSize = true;
            labelCantidadAgregar.Location = new Point(6, 173);
            labelCantidadAgregar.Name = "labelCantidadAgregar";
            labelCantidadAgregar.Size = new Size(110, 15);
            labelCantidadAgregar.TabIndex = 6;
            labelCantidadAgregar.Text = "Cantidad a agregar:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(311, 161);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 38);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(402, 751);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(107, 38);
            btnGenerar.TabIndex = 14;
            btnGenerar.Text = "Generar Orden";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // ListaDatosMercaderia
            // 
            ListaDatosMercaderia.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Cantidad });
            ListaDatosMercaderia.Location = new Point(6, 22);
            ListaDatosMercaderia.Name = "ListaDatosMercaderia";
            ListaDatosMercaderia.Size = new Size(561, 124);
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
            ListaPrevisualizacionOrdenesPreparacion.Location = new Point(16, 147);
            ListaPrevisualizacionOrdenesPreparacion.Name = "ListaPrevisualizacionOrdenesPreparacion";
            ListaPrevisualizacionOrdenesPreparacion.Size = new Size(551, 140);
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
            TextBoxCantidad.Location = new Point(122, 170);
            TextBoxCantidad.Name = "TextBoxCantidad";
            TextBoxCantidad.Size = new Size(168, 23);
            TextBoxCantidad.TabIndex = 18;
            // 
            // numeroCliente
            // 
            numeroCliente.Location = new Point(118, 29);
            numeroCliente.Name = "numeroCliente";
            numeroCliente.Size = new Size(221, 23);
            numeroCliente.TabIndex = 28;
            // 
            // BotonObtenerDatos
            // 
            BotonObtenerDatos.Location = new Point(351, 20);
            BotonObtenerDatos.Name = "BotonObtenerDatos";
            BotonObtenerDatos.Size = new Size(128, 38);
            BotonObtenerDatos.TabIndex = 29;
            BotonObtenerDatos.Text = "Obtener Datos";
            BotonObtenerDatos.UseVisualStyleBackColor = true;
            BotonObtenerDatos.Click += BotonObtenerDatos_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(515, 751);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(107, 38);
            VolverAlMenu.TabIndex = 30;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(368, 318);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(199, 38);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Limpiar Dato Seleccionado";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // BotonLimpiarCliente
            // 
            BotonLimpiarCliente.Location = new Point(494, 20);
            BotonLimpiarCliente.Name = "BotonLimpiarCliente";
            BotonLimpiarCliente.Size = new Size(128, 38);
            BotonLimpiarCliente.TabIndex = 32;
            BotonLimpiarCliente.Text = "Nueva Busqueda";
            BotonLimpiarCliente.UseVisualStyleBackColor = true;
            BotonLimpiarCliente.Click += BotonLimpiarCliente_Click;
            // 
            // labelNroOrden
            // 
            labelNroOrden.AutoSize = true;
            labelNroOrden.Location = new Point(6, 28);
            labelNroOrden.Name = "labelNroOrden";
            labelNroOrden.Size = new Size(73, 15);
            labelNroOrden.TabIndex = 33;
            labelNroOrden.Text = "N° de Orden";
            // 
            // textBoxNroOdenPrevisualizacion
            // 
            textBoxNroOdenPrevisualizacion.Location = new Point(122, 25);
            textBoxNroOdenPrevisualizacion.Name = "textBoxNroOdenPrevisualizacion";
            textBoxNroOdenPrevisualizacion.ReadOnly = true;
            textBoxNroOdenPrevisualizacion.Size = new Size(212, 23);
            textBoxNroOdenPrevisualizacion.TabIndex = 34;
            textBoxNroOdenPrevisualizacion.Text = "1";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(6, 63);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(109, 15);
            labelFecha.TabIndex = 35;
            labelFecha.Text = "Fecha de Despacho";
            // 
            // PickerFechaDespacho
            // 
            PickerFechaDespacho.Checked = false;
            PickerFechaDespacho.CustomFormat = " ";
            PickerFechaDespacho.Format = DateTimePickerFormat.Short;
            PickerFechaDespacho.Location = new Point(122, 57);
            PickerFechaDespacho.Name = "PickerFechaDespacho";
            PickerFechaDespacho.Size = new Size(212, 23);
            PickerFechaDespacho.TabIndex = 36;
            // 
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(6, 98);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(97, 15);
            labelTransportista.TabIndex = 37;
            labelTransportista.Text = "DNI Transportista";
            // 
            // textBoxDNITransportista
            // 
            textBoxDNITransportista.Location = new Point(122, 95);
            textBoxDNITransportista.Name = "textBoxDNITransportista";
            textBoxDNITransportista.Size = new Size(212, 23);
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
            GroupBoxPrevisualizacion.Location = new Point(40, 344);
            GroupBoxPrevisualizacion.Name = "GroupBoxPrevisualizacion";
            GroupBoxPrevisualizacion.Size = new Size(579, 380);
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
            groupBoxDatosMercaderia.Location = new Point(40, 86);
            groupBoxDatosMercaderia.Name = "groupBoxDatosMercaderia";
            groupBoxDatosMercaderia.Size = new Size(579, 237);
            groupBoxDatosMercaderia.TabIndex = 40;
            groupBoxDatosMercaderia.TabStop = false;
            groupBoxDatosMercaderia.Text = "Datos de Mercadería";
            // 
            // PantallaPreparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 802);
            Controls.Add(groupBoxDatosMercaderia);
            Controls.Add(GroupBoxPrevisualizacion);
            Controls.Add(BotonLimpiarCliente);
            Controls.Add(VolverAlMenu);
            Controls.Add(BotonObtenerDatos);
            Controls.Add(numeroCliente);
            Controls.Add(btnGenerar);
            Controls.Add(LabelNumeroCliente);
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
