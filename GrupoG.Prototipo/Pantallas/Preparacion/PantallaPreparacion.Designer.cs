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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            btnAgregar = new Button();
            label8 = new Label();
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
            Mercaderia = new ListBox();
            numeroCliente = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "N° Cliente: ";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 81);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Mercadería: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 127);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Datos Mercadería";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 248);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 6;
            label7.Text = "Cantidad a agregar:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(271, 248);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 283);
            label8.Name = "label8";
            label8.Size = new Size(209, 15);
            label8.TabIndex = 8;
            label8.Text = "Previsualización Orden de Preparación";
            label8.Click += label8_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(220, 473);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 44);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar Datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(345, 473);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(106, 44);
            btnGenerar.TabIndex = 14;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += button3_Click;
            // 
            // ListaDatosMercaderia
            // 
            ListaDatosMercaderia.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Cantidad });
            ListaDatosMercaderia.Location = new Point(40, 145);
            ListaDatosMercaderia.Name = "ListaDatosMercaderia";
            ListaDatosMercaderia.Size = new Size(375, 94);
            ListaDatosMercaderia.TabIndex = 15;
            ListaDatosMercaderia.UseCompatibleStateImageBehavior = false;
            ListaDatosMercaderia.View = View.Details;
            ListaDatosMercaderia.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            TextBoxCantidad.Location = new Point(156, 245);
            TextBoxCantidad.Name = "TextBoxCantidad";
            TextBoxCantidad.Size = new Size(100, 23);
            TextBoxCantidad.TabIndex = 18;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(40, 473);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(99, 44);
            BotonVolverMenu.TabIndex = 26;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            // 
            // Mercaderia
            // 
            Mercaderia.FormattingEnabled = true;
            Mercaderia.ItemHeight = 15;
            Mercaderia.Location = new Point(118, 81);
            Mercaderia.Name = "Mercaderia";
            Mercaderia.Size = new Size(109, 34);
            Mercaderia.TabIndex = 27;
            // 
            // numeroCliente
            // 
            numeroCliente.Location = new Point(118, 29);
            numeroCliente.Name = "numeroCliente";
            numeroCliente.Size = new Size(100, 23);
            numeroCliente.TabIndex = 28;
            // 
            // PantallaPreparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 529);
            Controls.Add(numeroCliente);
            Controls.Add(Mercaderia);
            Controls.Add(BotonVolverMenu);
            Controls.Add(TextBoxCantidad);
            Controls.Add(ListaPrevisualizacionOrdenesPreparacion);
            Controls.Add(ListaDatosMercaderia);
            Controls.Add(btnGenerar);
            Controls.Add(btnLimpiar);
            Controls.Add(label8);
            Controls.Add(btnAgregar);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PantallaPreparacion";
            Text = "Orden de Preparación";
            Load += PantallaPreparacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Button btnAgregar;
        private Label label8;
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
        private ListBox Mercaderia;
        private TextBox numeroCliente;
    }
}
