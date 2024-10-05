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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            btnAgregar = new Button();
            label8 = new Label();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            listView1 = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            Cantidad = new ColumnHeader();
            listView2 = new ListView();
            NumeroOrden = new ColumnHeader();
            Id1 = new ColumnHeader();
            Nombre1 = new ColumnHeader();
            Cantidad1 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            boxCantidad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 31);
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
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Mercadería: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 113);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Datos Mercadería";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 208);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 6;
            label7.Text = "Cantidad a agregar:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(271, 208);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 255);
            label8.Name = "label8";
            label8.Size = new Size(209, 15);
            label8.TabIndex = 8;
            label8.Text = "Previsualización Orden de Preparación";
            label8.Click += label8_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(246, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 23);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar Datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(403, 415);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(87, 23);
            btnGenerar.TabIndex = 14;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Cantidad });
            listView1.Location = new Point(40, 145);
            listView1.Name = "listView1";
            listView1.Size = new Size(327, 53);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { NumeroOrden, Id1, Nombre1, Cantidad1 });
            listView2.Location = new Point(40, 273);
            listView2.Name = "listView2";
            listView2.Size = new Size(360, 68);
            listView2.TabIndex = 16;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // boxCantidad
            // 
            boxCantidad.Location = new Point(156, 205);
            boxCantidad.Name = "boxCantidad";
            boxCantidad.Size = new Size(100, 23);
            boxCantidad.TabIndex = 18;
            // 
            // PantallaPreparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(boxCantidad);
            Controls.Add(listView2);
            Controls.Add(listView1);
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
        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private ColumnHeader Cantidad;
        private ListView listView2;
        private ColumnHeader NumeroOrden;
        private ColumnHeader Id1;
        private ColumnHeader Nombre1;
        private ColumnHeader Cantidad1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox boxCantidad;
    }
}
