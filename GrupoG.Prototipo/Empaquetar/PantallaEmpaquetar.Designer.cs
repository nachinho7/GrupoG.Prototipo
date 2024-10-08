namespace GrupoG.Prototipo.Empaquetar
{
    partial class PantallaEmpaquetar
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
            numeroOrdenPreparacion = new Label();
            listView1 = new ListView();
            idMercaderia = new ColumnHeader();
            nombreMercaderia = new ColumnHeader();
            cantidadMercaderia = new ColumnHeader();
            btnEmpaquetar = new Button();
            VolverAlMenu = new Button();
            ComboBoxOrdenesPreparacion = new ComboBox();
            SuspendLayout();
            // 
            // numeroOrdenPreparacion
            // 
            numeroOrdenPreparacion.AutoSize = true;
            numeroOrdenPreparacion.Location = new Point(12, 36);
            numeroOrdenPreparacion.Name = "numeroOrdenPreparacion";
            numeroOrdenPreparacion.Size = new Size(142, 15);
            numeroOrdenPreparacion.TabIndex = 0;
            numeroOrdenPreparacion.Text = "N° Orden de Preparación:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idMercaderia, nombreMercaderia, cantidadMercaderia });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 66);
            listView1.Name = "listView1";
            listView1.Size = new Size(307, 161);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // idMercaderia
            // 
            idMercaderia.Text = "ID Mercadería";
            idMercaderia.Width = 100;
            // 
            // nombreMercaderia
            // 
            nombreMercaderia.Text = "Nombre";
            nombreMercaderia.Width = 100;
            // 
            // cantidadMercaderia
            // 
            cantidadMercaderia.Text = "Cantidad";
            cantidadMercaderia.Width = 100;
            // 
            // btnEmpaquetar
            // 
            btnEmpaquetar.Location = new Point(100, 255);
            btnEmpaquetar.Name = "btnEmpaquetar";
            btnEmpaquetar.Size = new Size(106, 38);
            btnEmpaquetar.TabIndex = 2;
            btnEmpaquetar.Text = "Empaquetar";
            btnEmpaquetar.UseVisualStyleBackColor = true;
            btnEmpaquetar.Click += btnEmpaquetar_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(212, 255);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(107, 38);
            VolverAlMenu.TabIndex = 31;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // ComboBoxOrdenesPreparacion
            // 
            ComboBoxOrdenesPreparacion.FormattingEnabled = true;
            ComboBoxOrdenesPreparacion.Location = new Point(173, 34);
            ComboBoxOrdenesPreparacion.Margin = new Padding(3, 2, 3, 2);
            ComboBoxOrdenesPreparacion.Name = "ComboBoxOrdenesPreparacion";
            ComboBoxOrdenesPreparacion.Size = new Size(133, 23);
            ComboBoxOrdenesPreparacion.TabIndex = 32;
            // 
            // PantallaEmpaquetar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 312);
            Controls.Add(ComboBoxOrdenesPreparacion);
            Controls.Add(VolverAlMenu);
            Controls.Add(btnEmpaquetar);
            Controls.Add(listView1);
            Controls.Add(numeroOrdenPreparacion);
            Name = "PantallaEmpaquetar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla Empaquetar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numeroOrdenPreparacion;
        private ListView listView1;
        private ColumnHeader idMercaderia;
        private ColumnHeader nombreMercaderia;
        private ColumnHeader cantidadMercaderia;
        private Button btnEmpaquetar;
        private Button VolverAlMenu;
        private ComboBox ComboBoxOrdenesPreparacion;
    }
}