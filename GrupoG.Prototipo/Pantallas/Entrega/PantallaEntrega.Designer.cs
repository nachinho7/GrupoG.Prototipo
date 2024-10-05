namespace GrupoG.Prototipo.Pantallas
{
    partial class PantallaEntrega
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
            comboBox1 = new ComboBox();
            Empaquetar = new Button();
            button2 = new Button();
            listView1 = new ListView();
            ColumnaNumeroCliente = new ColumnHeader();
            ColumnaCodigo = new ColumnHeader();
            ColumnaUbicacion = new ColumnHeader();
            ColumnaTipo = new ColumnHeader();
            VolverAlMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro de Orden";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nro de orden" });
            comboBox1.Location = new Point(166, 28);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 2;
            // 
            // Empaquetar
            // 
            Empaquetar.Location = new Point(506, 274);
            Empaquetar.Margin = new Padding(3, 2, 3, 2);
            Empaquetar.Name = "Empaquetar";
            Empaquetar.Size = new Size(103, 38);
            Empaquetar.TabIndex = 7;
            Empaquetar.Text = "Empaquetar\r\n";
            Empaquetar.UseVisualStyleBackColor = true;
            Empaquetar.Click += Empaquetar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(373, 274);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 8;
            button2.Text = "Limpiar datos";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaNumeroCliente, ColumnaCodigo, ColumnaUbicacion, ColumnaTipo });
            listView1.Location = new Point(87, 100);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(522, 137);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnaNumeroCliente
            // 
            ColumnaNumeroCliente.Text = "Nro de Cliente";
            ColumnaNumeroCliente.Width = 150;
            // 
            // ColumnaCodigo
            // 
            ColumnaCodigo.Text = "Código";
            ColumnaCodigo.Width = 150;
            // 
            // ColumnaUbicacion
            // 
            ColumnaUbicacion.Text = "Ubicación";
            ColumnaUbicacion.Width = 150;
            // 
            // ColumnaTipo
            // 
            ColumnaTipo.Text = "Tipo";
            ColumnaTipo.Width = 150;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(87, 274);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(75, 39);
            VolverAlMenu.TabIndex = 10;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // PantallaEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(VolverAlMenu);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(Empaquetar);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PantallaEntrega";
            Text = "Orden de Entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button Empaquetar;
        private Button button2;
        private ListView listView1;
        private ColumnHeader ColumnaNumeroCliente;
        private ColumnHeader ColumnaCodigo;
        private ColumnHeader ColumnaUbicacion;
        private ColumnHeader ColumnaTipo;
        private Button BotonVolverMenu;
        private Button VolverAlMenu;
    }
}