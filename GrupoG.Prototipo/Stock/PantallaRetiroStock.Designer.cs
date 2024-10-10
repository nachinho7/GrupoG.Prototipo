namespace GrupoG.Prototipo.Stock
{
    partial class PantallaRetiroStock
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
            comboBox1 = new ComboBox();
            labelOrdenSeleccion = new Label();
            listView1 = new ListView();
            idMercaderia = new ColumnHeader();
            nombreMercaderia = new ColumnHeader();
            cantidadMercaderia = new ColumnHeader();
            ubicacionMercaderia = new ColumnHeader();
            VolverAlMenu = new Button();
            btnRetirarStock = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 64);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 0;
            // 
            // labelOrdenSeleccion
            // 
            labelOrdenSeleccion.AutoSize = true;
            labelOrdenSeleccion.Location = new Point(26, 68);
            labelOrdenSeleccion.Name = "labelOrdenSeleccion";
            labelOrdenSeleccion.Size = new Size(141, 20);
            labelOrdenSeleccion.TabIndex = 1;
            labelOrdenSeleccion.Text = "Orden de Selección:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idMercaderia, nombreMercaderia, cantidadMercaderia, ubicacionMercaderia });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(26, 119);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(418, 257);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // idMercaderia
            // 
            idMercaderia.Text = "ID";
            idMercaderia.Width = 50;
            // 
            // nombreMercaderia
            // 
            nombreMercaderia.Text = "Nombre";
            nombreMercaderia.Width = 110;
            // 
            // cantidadMercaderia
            // 
            cantidadMercaderia.Text = "Cantidad";
            cantidadMercaderia.Width = 90;
            // 
            // ubicacionMercaderia
            // 
            ubicacionMercaderia.Text = "Ubicacion";
            ubicacionMercaderia.Width = 110;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(315, 413);
            VolverAlMenu.Margin = new Padding(3, 4, 3, 4);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(129, 51);
            VolverAlMenu.TabIndex = 6;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // btnRetirarStock
            // 
            btnRetirarStock.Location = new Point(185, 413);
            btnRetirarStock.Margin = new Padding(3, 4, 3, 4);
            btnRetirarStock.Name = "btnRetirarStock";
            btnRetirarStock.Size = new Size(112, 51);
            btnRetirarStock.TabIndex = 7;
            btnRetirarStock.Text = "Retirar Stock";
            btnRetirarStock.UseVisualStyleBackColor = true;
            btnRetirarStock.Click += btnRetirarStock_Click;
            // 
            // PantallaRetiroStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(491, 496);
            Controls.Add(btnRetirarStock);
            Controls.Add(VolverAlMenu);
            Controls.Add(listView1);
            Controls.Add(labelOrdenSeleccion);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaRetiroStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaRetiroStock";
            Load += PantallaRetiroStock_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label labelOrdenSeleccion;
        private ListView listView1;
        private ColumnHeader idMercaderia;
        private ColumnHeader nombreMercaderia;
        private ColumnHeader cantidadMercaderia;
        private ColumnHeader ubicacionMercaderia;
        private Button VolverAlMenu;
        private Button btnRetirarStock;
    }
}