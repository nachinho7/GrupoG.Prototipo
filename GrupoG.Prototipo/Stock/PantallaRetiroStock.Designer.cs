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
            ubicacionMercaderia = new ColumnHeader();
            idMercaderia = new ColumnHeader();
            nombreMercaderia = new ColumnHeader();
            cantidadMercaderia = new ColumnHeader();
            VolverAlMenu = new Button();
            btnRetirarStock = new Button();
            cantidadUbicacion = new ColumnHeader();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 23);
            comboBox1.TabIndex = 0;
            // 
            // labelOrdenSeleccion
            // 
            labelOrdenSeleccion.AutoSize = true;
            labelOrdenSeleccion.Location = new Point(23, 33);
            labelOrdenSeleccion.Name = "labelOrdenSeleccion";
            labelOrdenSeleccion.Size = new Size(129, 15);
            labelOrdenSeleccion.TabIndex = 1;
            labelOrdenSeleccion.Text = "Orden de Selección N°:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ubicacionMercaderia, cantidadUbicacion, idMercaderia, nombreMercaderia, cantidadMercaderia });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(23, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 301);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ubicacionMercaderia
            // 
            ubicacionMercaderia.Text = "Ubicacion";
            ubicacionMercaderia.Width = 200;
            // 
            // idMercaderia
            // 
            idMercaderia.Text = "ID";
            idMercaderia.Width = 70;
            // 
            // nombreMercaderia
            // 
            nombreMercaderia.Text = "Nombre";
            nombreMercaderia.Width = 250;
            // 
            // cantidadMercaderia
            // 
            cantidadMercaderia.Text = "Cantidad";
            cantidadMercaderia.Width = 120;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(693, 406);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(113, 38);
            VolverAlMenu.TabIndex = 6;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // btnRetirarStock
            // 
            btnRetirarStock.Location = new Point(570, 406);
            btnRetirarStock.Name = "btnRetirarStock";
            btnRetirarStock.Size = new Size(98, 38);
            btnRetirarStock.TabIndex = 7;
            btnRetirarStock.Text = "Retirar Stock";
            btnRetirarStock.UseVisualStyleBackColor = true;
            btnRetirarStock.Click += btnRetirarStock_Click;
            // 
            // cantidadUbicacion
            // 
            cantidadUbicacion.Text = "Cantidad por Ubicación";
            cantidadUbicacion.Width = 150;
            // 
            // PantallaRetiroStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(856, 456);
            Controls.Add(btnRetirarStock);
            Controls.Add(VolverAlMenu);
            Controls.Add(listView1);
            Controls.Add(labelOrdenSeleccion);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PantallaRetiroStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retiro de Stock";
            Shown += PantallaRetiroStock_Shown;
            Load += PantallaRetiroStock_Load;
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
        private ColumnHeader cantidadUbicacion;
    }
}