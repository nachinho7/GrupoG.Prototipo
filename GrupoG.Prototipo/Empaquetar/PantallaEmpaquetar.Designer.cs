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
            ComboBoxDeposito = new ComboBox();
            DepositoLabel = new Label();
            SuspendLayout();
            // 
            // numeroOrdenPreparacion
            // 
            numeroOrdenPreparacion.AutoSize = true;
            numeroOrdenPreparacion.Location = new Point(329, 15);
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
            listView1.Location = new Point(12, 68);
            listView1.Name = "listView1";
            listView1.Size = new Size(709, 243);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // idMercaderia
            // 
            idMercaderia.Text = "ID Mercadería";
            idMercaderia.Width = 200;
            // 
            // nombreMercaderia
            // 
            nombreMercaderia.Text = "Nombre";
            nombreMercaderia.Width = 300;
            // 
            // cantidadMercaderia
            // 
            cantidadMercaderia.Text = "Cantidad";
            cantidadMercaderia.Width = 200;
            // 
            // btnEmpaquetar
            // 
            btnEmpaquetar.Location = new Point(434, 331);
            btnEmpaquetar.Name = "btnEmpaquetar";
            btnEmpaquetar.Size = new Size(136, 38);
            btnEmpaquetar.TabIndex = 2;
            btnEmpaquetar.Text = "Empaquetar";
            btnEmpaquetar.UseVisualStyleBackColor = true;
            btnEmpaquetar.Click += btnEmpaquetar_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(585, 331);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(136, 38);
            VolverAlMenu.TabIndex = 31;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // ComboBoxOrdenesPreparacion
            // 
            ComboBoxOrdenesPreparacion.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxOrdenesPreparacion.FormattingEnabled = true;
            ComboBoxOrdenesPreparacion.Location = new Point(329, 40);
            ComboBoxOrdenesPreparacion.Margin = new Padding(3, 2, 3, 2);
            ComboBoxOrdenesPreparacion.Name = "ComboBoxOrdenesPreparacion";
            ComboBoxOrdenesPreparacion.Size = new Size(284, 23);
            ComboBoxOrdenesPreparacion.TabIndex = 32;
            ComboBoxOrdenesPreparacion.SelectedIndexChanged += ComboBoxOrdenesPreparacion_SelectedIndexChanged;

            // 
            // ComboBoxDeposito
            // 
            ComboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxDeposito.FormattingEnabled = true;
            ComboBoxDeposito.Location = new Point(12, 40);
            ComboBoxDeposito.Margin = new Padding(3, 2, 3, 2);
            ComboBoxDeposito.Name = "ComboBoxDeposito";
            ComboBoxDeposito.Size = new Size(284, 23);
            ComboBoxDeposito.TabIndex = 33;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Location = new Point(12, 15);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(120, 15);
            DepositoLabel.TabIndex = 34;
            DepositoLabel.Text = "Numero de Deposito:";
            // 
            // PantallaEmpaquetar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(739, 381);
            Controls.Add(DepositoLabel);
            Controls.Add(ComboBoxDeposito);
            Controls.Add(ComboBoxOrdenesPreparacion);
            Controls.Add(VolverAlMenu);
            Controls.Add(btnEmpaquetar);
            Controls.Add(listView1);
            Controls.Add(numeroOrdenPreparacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PantallaEmpaquetar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla Empaquetar";
            Shown += PantallaEmpaquetar_Shown;
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
        private ComboBox ComboBoxDeposito;
        private Label DepositoLabel;
    }
}