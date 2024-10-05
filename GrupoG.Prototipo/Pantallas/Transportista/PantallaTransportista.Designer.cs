namespace GrupoG.Prototipo.Pantallas
{
    partial class PantallaTransportista
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
            VolverAlMenu = new Button();
            button2 = new Button();
            button3 = new Button();
            listView1 = new ListView();
            ClienteTransportista = new ColumnHeader();
            EstadoTransportista = new ColumnHeader();
            Patente = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 83);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese DNI del Transportista";
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(118, 253);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(75, 39);
            VolverAlMenu.TabIndex = 4;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // button2
            // 
            button2.Location = new Point(226, 253);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 5;
            button2.Text = "Limpiar Datos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(375, 253);
            button3.Name = "button3";
            button3.Size = new Size(87, 39);
            button3.TabIndex = 6;
            button3.Text = "Buscar Transportista";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ClienteTransportista, EstadoTransportista, Patente });
            listView1.Location = new Point(102, 119);
            listView1.Name = "listView1";
            listView1.Size = new Size(374, 104);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ClienteTransportista
            // 
            ClienteTransportista.Text = "Cliente vinculado al transportista";
            ClienteTransportista.Width = 190;
            // 
            // EstadoTransportista
            // 
            EstadoTransportista.Text = "Estado Transportista";
            EstadoTransportista.Width = 120;
            // 
            // Patente
            // 
            Patente.Text = "Patente";
            // 
            // PantallaTransportista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 389);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(VolverAlMenu);
            Controls.Add(label1);
            Name = "PantallaTransportista";
            Text = "Transportista";
            Load += PantallaConsultaTransportista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button VolverAlMenu;
        private Button button2;
        private Button button3;
        private ListView listView1;
        private ColumnHeader ClienteTransportista;
        private ColumnHeader EstadoTransportista;
        private ColumnHeader Patente;
    }
}