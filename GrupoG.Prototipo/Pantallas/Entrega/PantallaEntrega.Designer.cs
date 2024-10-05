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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 46);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Nro de Orden";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nro de orden" });
            comboBox1.Location = new Point(190, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // Empaquetar
            // 
            Empaquetar.Location = new Point(479, 365);
            Empaquetar.Name = "Empaquetar";
            Empaquetar.Size = new Size(101, 29);
            Empaquetar.TabIndex = 7;
            Empaquetar.Text = "Empaquetar\r\n";
            Empaquetar.UseVisualStyleBackColor = true;
            Empaquetar.Click += Empaquetar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(603, 365);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 8;
            button2.Text = "Limpiar datos";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnaNumeroCliente, ColumnaCodigo, ColumnaUbicacion, ColumnaTipo });
            listView1.Location = new Point(99, 133);
            listView1.Name = "listView1";
            listView1.Size = new Size(596, 181);
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
            // PantallaEntrega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(Empaquetar);
            Controls.Add(comboBox1);
            Controls.Add(label1);
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
    }
}