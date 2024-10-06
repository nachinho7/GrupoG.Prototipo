namespace GrupoG.Prototipo.Pantallas
{
    partial class PantallaTransportista
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox dniTextBox; // Definir el TextBox para ingresar DNI
        private Button VolverAlMenu;
        private Button button3;
        private ListView listView1;
        private ColumnHeader ClienteTransportista;
        private ColumnHeader EstadoTransportista;
        private ColumnHeader Patente;

        // Método Dispose correctamente sobrescrito
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Inicializar los componentes del formulario
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dniTextBox = new System.Windows.Forms.TextBox(); // Instanciar dniTextBox
            this.VolverAlMenu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ClienteTransportista = new System.Windows.Forms.ColumnHeader();
            this.EstadoTransportista = new System.Windows.Forms.ColumnHeader();
            this.Patente = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese DNI del Transportista";

            // dniTextBox
            this.dniTextBox.Location = new System.Drawing.Point(209, 100);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(157, 23);
            this.dniTextBox.TabIndex = 1;

            // VolverAlMenu
            this.VolverAlMenu.Location = new System.Drawing.Point(118, 253);
            this.VolverAlMenu.Name = "VolverAlMenu";
            this.VolverAlMenu.Size = new System.Drawing.Size(75, 39);
            this.VolverAlMenu.TabIndex = 4;
            this.VolverAlMenu.Text = "Volver al Menú";
            this.VolverAlMenu.UseVisualStyleBackColor = true;
            this.VolverAlMenu.Click += new System.EventHandler(this.VolverAlMenu_Click);

            // button3
            this.button3.Location = new System.Drawing.Point(375, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Buscar Transportista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BuscarTransportista_Click); // Vincular el evento

            // listView1
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.ClienteTransportista,
                this.EstadoTransportista,
                this.Patente});
            this.listView1.Location = new System.Drawing.Point(101, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 104);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;

            // ClienteTransportista
            this.ClienteTransportista.Text = "Cliente vinculado al transportista";
            this.ClienteTransportista.Width = 190;

            // EstadoTransportista
            this.EstadoTransportista.Text = "Estado Transportista";
            this.EstadoTransportista.Width = 120;

            // Patente
            this.Patente.Text = "Patente";

            // PantallaTransportista
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 389);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.VolverAlMenu);
            this.Controls.Add(this.dniTextBox); // Agregar dniTextBox a los controles
            this.Controls.Add(this.label1);
            this.Name = "PantallaTransportista";
            this.Text = "Transportista";
            this.Load += new System.EventHandler(this.PantallaConsultaTransportista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
