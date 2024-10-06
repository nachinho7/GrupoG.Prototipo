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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            ColumnaUbicacion = new ColumnHeader();
            labelNroOrden = new Label();
            textBox1 = new TextBox();
            labelFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            columnUbicacion = new ColumnHeader();
            labelTransportista = new Label();
            textBox2 = new TextBox();
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
            btnGenerar.Location = new Point(400, 740);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(107, 38);
            btnGenerar.TabIndex = 14;
            btnGenerar.Text = "Generar Orden";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // ListaDatosMercaderia
            // 
            ListaDatosMercaderia.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Cantidad, ColumnaUbicacion });
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
            ListaPrevisualizacionOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { Id1, Nombre1, Cantidad1, columnUbicacion });
            ListaPrevisualizacionOrdenesPreparacion.Location = new Point(16, 144);
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
            VolverAlMenu.Location = new Point(513, 740);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(107, 38);
            VolverAlMenu.TabIndex = 30;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(360, 304);
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
            // ColumnaUbicacion
            // 
            ColumnaUbicacion.Text = "Ubicacion";
            ColumnaUbicacion.Width = 100;
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
            // textBox1
            // 
            textBox1.Location = new Point(122, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 34;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // columnUbicacion
            // 
            columnUbicacion.Text = "Ubicacion";
            columnUbicacion.Width = 120;
            // 
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(6, 101);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(97, 15);
            labelTransportista.TabIndex = 37;
            labelTransportista.Text = "DNI Transportista";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 38;
            // 
            // GroupBoxPrevisualizacion
            // 
            GroupBoxPrevisualizacion.Controls.Add(textBox2);
            GroupBoxPrevisualizacion.Controls.Add(labelNroOrden);
            GroupBoxPrevisualizacion.Controls.Add(labelTransportista);
            GroupBoxPrevisualizacion.Controls.Add(ListaPrevisualizacionOrdenesPreparacion);
            GroupBoxPrevisualizacion.Controls.Add(dateTimePicker1);
            GroupBoxPrevisualizacion.Controls.Add(btnEliminar);
            GroupBoxPrevisualizacion.Controls.Add(labelFecha);
            GroupBoxPrevisualizacion.Controls.Add(textBox1);
            GroupBoxPrevisualizacion.Location = new Point(40, 344);
            GroupBoxPrevisualizacion.Name = "GroupBoxPrevisualizacion";
            GroupBoxPrevisualizacion.Size = new Size(579, 377);
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
            ClientSize = new Size(659, 794);
            Controls.Add(groupBoxDatosMercaderia);
            Controls.Add(GroupBoxPrevisualizacion);
            Controls.Add(BotonLimpiarCliente);
            Controls.Add(VolverAlMenu);
            Controls.Add(BotonObtenerDatos);
            Controls.Add(numeroCliente);
            Controls.Add(btnGenerar);
            Controls.Add(LabelNumeroCliente);
            Name = "PantallaPreparacion";
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
        private ColumnHeader ColumnaUbicacion;
        private Label labelNroOrden;
        private TextBox textBox1;
        private Label labelFecha;
        private DateTimePicker dateTimePicker1;
        private ColumnHeader columnUbicacion;
        private Label labelTransportista;
        private TextBox textBox2;
        private GroupBox GroupBoxPrevisualizacion;
        private GroupBox groupBoxDatosMercaderia;
    }
}
