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
            labelDatosMercaderia = new Label();
            labelCantidadAgregar = new Label();
            btnAgregar = new Button();
            labelPrevisualizacionOrden = new Label();
            btnGenerar = new Button();
            ListaDatosMercaderia = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            Cantidad = new ColumnHeader();
            ListaPrevisualizacionOrdenesPreparacion = new ListView();
            NumeroOrden = new ColumnHeader();
            Id1 = new ColumnHeader();
            Nombre1 = new ColumnHeader();
            Cantidad1 = new ColumnHeader();
            TextBoxCantidad = new TextBox();
            numeroCliente = new TextBox();
            BotonObtenerDatos = new Button();
            VolverAlMenu = new Button();
            btnEliminar = new Button();
            BotonLimpiarCliente = new Button();
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
            // labelDatosMercaderia
            // 
            labelDatosMercaderia.AutoSize = true;
            labelDatosMercaderia.Location = new Point(40, 85);
            labelDatosMercaderia.Name = "labelDatosMercaderia";
            labelDatosMercaderia.Size = new Size(99, 15);
            labelDatosMercaderia.TabIndex = 2;
            labelDatosMercaderia.Text = "Datos Mercadería";
            // 
            // labelCantidadAgregar
            // 
            labelCantidadAgregar.AutoSize = true;
            labelCantidadAgregar.Location = new Point(40, 245);
            labelCantidadAgregar.Name = "labelCantidadAgregar";
            labelCantidadAgregar.Size = new Size(110, 15);
            labelCantidadAgregar.TabIndex = 6;
            labelCantidadAgregar.Text = "Cantidad a agregar:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(273, 242);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 38);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // labelPrevisualizacionOrden
            // 
            labelPrevisualizacionOrden.AutoSize = true;
            labelPrevisualizacionOrden.Location = new Point(40, 283);
            labelPrevisualizacionOrden.Name = "labelPrevisualizacionOrden";
            labelPrevisualizacionOrden.Size = new Size(209, 15);
            labelPrevisualizacionOrden.TabIndex = 8;
            labelPrevisualizacionOrden.Text = "Previsualización Orden de Preparación";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(352, 471);
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
            ListaDatosMercaderia.Location = new Point(40, 103);
            ListaDatosMercaderia.Name = "ListaDatosMercaderia";
            ListaDatosMercaderia.Size = new Size(375, 124);
            ListaDatosMercaderia.TabIndex = 15;
            ListaDatosMercaderia.UseCompatibleStateImageBehavior = false;
            ListaDatosMercaderia.View = View.Details;
            ListaDatosMercaderia.SelectedIndexChanged += ListaDatosMercaderia_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // ListaPrevisualizacionOrdenesPreparacion
            // 
            ListaPrevisualizacionOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { NumeroOrden, Id1, Nombre1, Cantidad1 });
            ListaPrevisualizacionOrdenesPreparacion.Location = new Point(40, 301);
            ListaPrevisualizacionOrdenesPreparacion.Name = "ListaPrevisualizacionOrdenesPreparacion";
            ListaPrevisualizacionOrdenesPreparacion.Size = new Size(375, 140);
            ListaPrevisualizacionOrdenesPreparacion.TabIndex = 16;
            ListaPrevisualizacionOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            ListaPrevisualizacionOrdenesPreparacion.View = View.Details;
            // 
            // NumeroOrden
            // 
            NumeroOrden.Text = "N° Orden";
            NumeroOrden.Width = 100;
            // 
            // Id1
            // 
            Id1.Text = "Id";
            // 
            // Nombre1
            // 
            Nombre1.Text = "Nombre";
            // 
            // Cantidad1
            // 
            Cantidad1.Text = "Cantidad";
            // 
            // TextBoxCantidad
            // 
            TextBoxCantidad.Location = new Point(156, 242);
            TextBoxCantidad.Name = "TextBoxCantidad";
            TextBoxCantidad.Size = new Size(100, 23);
            TextBoxCantidad.TabIndex = 18;
            // 
            // numeroCliente
            // 
            numeroCliente.Location = new Point(118, 29);
            numeroCliente.Name = "numeroCliente";
            numeroCliente.Size = new Size(100, 23);
            numeroCliente.TabIndex = 28;
            // 
            // BotonObtenerDatos
            // 
            BotonObtenerDatos.Location = new Point(246, 20);
            BotonObtenerDatos.Name = "BotonObtenerDatos";
            BotonObtenerDatos.Size = new Size(107, 38);
            BotonObtenerDatos.TabIndex = 29;
            BotonObtenerDatos.Text = "Obtener Datos";
            BotonObtenerDatos.UseVisualStyleBackColor = true;
            BotonObtenerDatos.Click += BotonObtenerDatos_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(12, 471);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(107, 38);
            VolverAlMenu.TabIndex = 30;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(210, 471);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 38);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Limpiar Dato Seleccionado";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // BotonLimpiarCliente
            // 
            BotonLimpiarCliente.Location = new Point(363, 20);
            BotonLimpiarCliente.Name = "BotonLimpiarCliente";
            BotonLimpiarCliente.Size = new Size(107, 38);
            BotonLimpiarCliente.TabIndex = 32;
            BotonLimpiarCliente.Text = "Nueva Busqueda";
            BotonLimpiarCliente.UseVisualStyleBackColor = true;
            BotonLimpiarCliente.Click += BotonLimpiarCliente_Click;
            // 
            // PantallaPreparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 529);
            Controls.Add(BotonLimpiarCliente);
            Controls.Add(btnEliminar);
            Controls.Add(VolverAlMenu);
            Controls.Add(BotonObtenerDatos);
            Controls.Add(numeroCliente);
            Controls.Add(TextBoxCantidad);
            Controls.Add(ListaPrevisualizacionOrdenesPreparacion);
            Controls.Add(ListaDatosMercaderia);
            Controls.Add(btnGenerar);
            Controls.Add(labelPrevisualizacionOrden);
            Controls.Add(btnAgregar);
            Controls.Add(labelCantidadAgregar);
            Controls.Add(labelDatosMercaderia);
            Controls.Add(LabelNumeroCliente);
            Name = "PantallaPreparacion";
            Text = "Orden de Preparación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNumeroCliente;
        private Label labelDatosMercaderia;
        private Label labelCantidadAgregar;
        private Button btnAgregar;
        private Label labelPrevisualizacionOrden;
        private Button btnGenerar;
        private ListView ListaDatosMercaderia;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private ColumnHeader Cantidad;
        private ListView ListaPrevisualizacionOrdenesPreparacion;
        private ColumnHeader NumeroOrden;
        private ColumnHeader Id1;
        private ColumnHeader Nombre1;
        private ColumnHeader Cantidad1;
        private TextBox TextBoxCantidad;
        private TextBox numeroCliente;
        private Button BotonObtenerDatos;
        private Button VolverAlMenu;
        private Button btnEliminar;
        private Button BotonLimpiarCliente;
    }
}
