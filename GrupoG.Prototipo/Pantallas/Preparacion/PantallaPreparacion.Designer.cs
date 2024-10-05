﻿namespace GrupoG.Prototipo
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
            btnLimpiar = new Button();
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
            BotonVolverMenu = new Button();
            numeroCliente = new TextBox();
            BotonObtenerDatos = new Button();
            SuspendLayout();
            // 
            // LabelNumeroCliente
            // 
            LabelNumeroCliente.AutoSize = true;
            LabelNumeroCliente.Location = new Point(46, 43);
            LabelNumeroCliente.Name = "LabelNumeroCliente";
            LabelNumeroCliente.Size = new Size(83, 20);
            LabelNumeroCliente.TabIndex = 0;
            LabelNumeroCliente.Text = "N° Cliente: ";
            LabelNumeroCliente.UseWaitCursor = true;
            // 
            // labelDatosMercaderia
            // 
            labelDatosMercaderia.AutoSize = true;
            labelDatosMercaderia.Location = new Point(46, 100);
            labelDatosMercaderia.Name = "labelDatosMercaderia";
            labelDatosMercaderia.Size = new Size(127, 20);
            labelDatosMercaderia.TabIndex = 2;
            labelDatosMercaderia.Text = "Datos Mercadería";
            // 
            // labelCantidadAgregar
            // 
            labelCantidadAgregar.AutoSize = true;
            labelCantidadAgregar.Location = new Point(46, 327);
            labelCantidadAgregar.Name = "labelCantidadAgregar";
            labelCantidadAgregar.Size = new Size(140, 20);
            labelCantidadAgregar.TabIndex = 6;
            labelCantidadAgregar.Text = "Cantidad a agregar:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(312, 323);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 31);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // labelPrevisualizacionOrden
            // 
            labelPrevisualizacionOrden.AutoSize = true;
            labelPrevisualizacionOrden.Location = new Point(46, 377);
            labelPrevisualizacionOrden.Name = "labelPrevisualizacionOrden";
            labelPrevisualizacionOrden.Size = new Size(263, 20);
            labelPrevisualizacionOrden.TabIndex = 8;
            labelPrevisualizacionOrden.Text = "Previsualización Orden de Preparación";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(251, 631);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 59);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar Datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(394, 631);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(121, 59);
            btnGenerar.TabIndex = 14;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            // 
            // ListaDatosMercaderia
            // 
            ListaDatosMercaderia.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Cantidad });
            ListaDatosMercaderia.Location = new Point(46, 137);
            ListaDatosMercaderia.Margin = new Padding(3, 4, 3, 4);
            ListaDatosMercaderia.Name = "ListaDatosMercaderia";
            ListaDatosMercaderia.Size = new Size(428, 164);
            ListaDatosMercaderia.TabIndex = 15;
            ListaDatosMercaderia.UseCompatibleStateImageBehavior = false;
            ListaDatosMercaderia.View = View.Details;
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
            ListaPrevisualizacionOrdenesPreparacion.Location = new Point(46, 401);
            ListaPrevisualizacionOrdenesPreparacion.Margin = new Padding(3, 4, 3, 4);
            ListaPrevisualizacionOrdenesPreparacion.Name = "ListaPrevisualizacionOrdenesPreparacion";
            ListaPrevisualizacionOrdenesPreparacion.Size = new Size(428, 185);
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
            TextBoxCantidad.Location = new Point(178, 323);
            TextBoxCantidad.Margin = new Padding(3, 4, 3, 4);
            TextBoxCantidad.Name = "TextBoxCantidad";
            TextBoxCantidad.Size = new Size(114, 27);
            TextBoxCantidad.TabIndex = 18;
            ListaDatosMercaderia.SelectedIndexChanged += ListaDatosMercaderia_SelectedIndexChanged;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(46, 631);
            BotonVolverMenu.Margin = new Padding(3, 4, 3, 4);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(113, 59);
            BotonVolverMenu.TabIndex = 26;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            // 
            // numeroCliente
            // 
            numeroCliente.Location = new Point(135, 39);
            numeroCliente.Margin = new Padding(3, 4, 3, 4);
            numeroCliente.Name = "numeroCliente";
            numeroCliente.Size = new Size(114, 27);
            numeroCliente.TabIndex = 28;
            // 
            // BotonObtenerDatos
            // 
            BotonObtenerDatos.Location = new Point(312, 37);
            BotonObtenerDatos.Margin = new Padding(3, 4, 3, 4);
            BotonObtenerDatos.Name = "BotonObtenerDatos";
            BotonObtenerDatos.Size = new Size(162, 31);
            BotonObtenerDatos.TabIndex = 29;
            BotonObtenerDatos.Text = "Obtener Datos";
            BotonObtenerDatos.UseVisualStyleBackColor = true;
            BotonObtenerDatos.Click += BotonObtenerDatos_Click;
            // 
            // PantallaPreparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 705);
            Controls.Add(BotonObtenerDatos);
            Controls.Add(numeroCliente);
            Controls.Add(BotonVolverMenu);
            Controls.Add(TextBoxCantidad);
            Controls.Add(ListaPrevisualizacionOrdenesPreparacion);
            Controls.Add(ListaDatosMercaderia);
            Controls.Add(btnGenerar);
            Controls.Add(btnLimpiar);
            Controls.Add(labelPrevisualizacionOrden);
            Controls.Add(btnAgregar);
            Controls.Add(labelCantidadAgregar);
            Controls.Add(labelDatosMercaderia);
            Controls.Add(LabelNumeroCliente);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnLimpiar;
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
        private Button BotonVolverMenu;
        private TextBox numeroCliente;
        private Button BotonObtenerDatos;
    }
}
