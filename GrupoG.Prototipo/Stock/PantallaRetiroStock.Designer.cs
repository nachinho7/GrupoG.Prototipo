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
            ubicacionMercaderia = new ColumnHeader();
            cantidadMercaderia = new ColumnHeader();
            nombreMercaderia = new ColumnHeader();
            VolverAlMenu = new Button();
            btnRetirarStock = new Button();
            DepositoTxtBox = new TextBox();
            DepositoLabel = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 0;
            // 
            // labelOrdenSeleccion
            // 
            labelOrdenSeleccion.AutoSize = true;
            labelOrdenSeleccion.Location = new Point(23, 20);
            labelOrdenSeleccion.Name = "labelOrdenSeleccion";
            labelOrdenSeleccion.Size = new Size(129, 15);
            labelOrdenSeleccion.TabIndex = 1;
            labelOrdenSeleccion.Text = "Orden de Selección N°:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idMercaderia, ubicacionMercaderia, cantidadMercaderia, nombreMercaderia });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(23, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(804, 301);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // idMercaderia
            // 
            idMercaderia.Text = "ID";
            idMercaderia.Width = 200;
            // 
            // ubicacionMercaderia
            // 
            ubicacionMercaderia.Text = "Ubicacion";
            ubicacionMercaderia.Width = 200;
            // 
            // cantidadMercaderia
            // 
            cantidadMercaderia.Text = "Cantidad";
            cantidadMercaderia.Width = 200;
            // 
            // nombreMercaderia
            // 
            nombreMercaderia.Text = "Nombre";
            nombreMercaderia.Width = 200;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(691, 392);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(136, 38);
            VolverAlMenu.TabIndex = 6;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // btnRetirarStock
            // 
            btnRetirarStock.Location = new Point(534, 392);
            btnRetirarStock.Name = "btnRetirarStock";
            btnRetirarStock.Size = new Size(136, 38);
            btnRetirarStock.TabIndex = 7;
            btnRetirarStock.Text = "Retirar Stock";
            btnRetirarStock.UseVisualStyleBackColor = true;
            btnRetirarStock.Click += btnRetirarStock_Click;
            // 
            // DepositoTxtBox
            // 
            DepositoTxtBox.Location = new Point(685, 38);
            DepositoTxtBox.Margin = new Padding(3, 2, 3, 2);
            DepositoTxtBox.Name = "DepositoTxtBox";
            DepositoTxtBox.ReadOnly = true;
            DepositoTxtBox.Size = new Size(142, 23);
            DepositoTxtBox.TabIndex = 8;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Location = new Point(685, 20);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(117, 15);
            DepositoLabel.TabIndex = 9;
            DepositoLabel.Text = "Numero de Deposito";
            // 
            // PantallaRetiroStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(848, 440);
            Controls.Add(DepositoLabel);
            Controls.Add(DepositoTxtBox);
            Controls.Add(btnRetirarStock);
            Controls.Add(VolverAlMenu);
            Controls.Add(listView1);
            Controls.Add(labelOrdenSeleccion);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PantallaRetiroStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retiro de Stock";
            Load += PantallaRetiroStock_Load;
            Shown += PantallaRetiroStock_Shown;
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
        private TextBox DepositoTxtBox;
        private Label DepositoLabel;
    }
}