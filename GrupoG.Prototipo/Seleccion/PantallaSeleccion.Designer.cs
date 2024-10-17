namespace GrupoG.Prototipo.Seleccion
{
    partial class PantallaSeleccion
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
            BotonGenerarOS = new Button();
            VolverAlMenu = new Button();
            datetimeDespacho = new DateTimePicker();
            fechaDespacho = new Label();
            groupBoxOrdenes = new GroupBox();
            comboBoxTransportista = new ComboBox();
            labelTransportista = new Label();
            labelCliente = new Label();
            comboBoxCliente = new ComboBox();
            mostrartTodasOrdenes = new Button();
            listView1 = new ListView();
            numeroOrdenPreparacion = new ColumnHeader();
            columnaCliente = new ColumnHeader();
            columnaFecha = new ColumnHeader();
            columnaTransportista = new ColumnHeader();
            groupBoxOrdenes.SuspendLayout();
            SuspendLayout();
            // 
            // BotonGenerarOS
            // 
            BotonGenerarOS.Location = new Point(829, 436);
            BotonGenerarOS.Name = "BotonGenerarOS";
            BotonGenerarOS.Size = new Size(110, 38);
            BotonGenerarOS.TabIndex = 1;
            BotonGenerarOS.Text = "Generar Orden de Seleccion";
            BotonGenerarOS.UseVisualStyleBackColor = true;
            BotonGenerarOS.Click += BotonGenerarOS_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(971, 436);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(113, 38);
            VolverAlMenu.TabIndex = 5;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // datetimeDespacho
            // 
            datetimeDespacho.Format = DateTimePickerFormat.Short;
            datetimeDespacho.Location = new Point(143, 25);
            datetimeDespacho.Name = "datetimeDespacho";
            datetimeDespacho.Size = new Size(140, 23);
            datetimeDespacho.TabIndex = 6;
            datetimeDespacho.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // fechaDespacho
            // 
            fechaDespacho.AutoSize = true;
            fechaDespacho.Location = new Point(16, 27);
            fechaDespacho.Name = "fechaDespacho";
            fechaDespacho.Size = new Size(109, 15);
            fechaDespacho.TabIndex = 7;
            fechaDespacho.Text = "Fecha de Despacho";
            // 
            // groupBoxOrdenes
            // 
            groupBoxOrdenes.Controls.Add(comboBoxTransportista);
            groupBoxOrdenes.Controls.Add(labelTransportista);
            groupBoxOrdenes.Controls.Add(labelCliente);
            groupBoxOrdenes.Controls.Add(comboBoxCliente);
            groupBoxOrdenes.Controls.Add(mostrartTodasOrdenes);
            groupBoxOrdenes.Controls.Add(listView1);
            groupBoxOrdenes.Controls.Add(fechaDespacho);
            groupBoxOrdenes.Controls.Add(datetimeDespacho);
            groupBoxOrdenes.Location = new Point(12, 12);
            groupBoxOrdenes.Name = "groupBoxOrdenes";
            groupBoxOrdenes.Size = new Size(1072, 392);
            groupBoxOrdenes.TabIndex = 8;
            groupBoxOrdenes.TabStop = false;
            groupBoxOrdenes.Text = "Ordenes de Preparación a seleccionar:";
            // 
            // comboBoxTransportista
            // 
            comboBoxTransportista.ForeColor = SystemColors.WindowText;
            comboBoxTransportista.FormattingEnabled = true;
            comboBoxTransportista.Location = new Point(690, 24);
            comboBoxTransportista.Margin = new Padding(3, 2, 3, 2);
            comboBoxTransportista.Name = "comboBoxTransportista";
            comboBoxTransportista.Size = new Size(140, 23);
            comboBoxTransportista.TabIndex = 13;
            // 
            // labelTransportista
            // 
            labelTransportista.AutoSize = true;
            labelTransportista.Location = new Point(576, 27);
            labelTransportista.Name = "labelTransportista";
            labelTransportista.Size = new Size(98, 15);
            labelTransportista.TabIndex = 12;
            labelTransportista.Text = "Dni Transportista:";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(332, 27);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(64, 15);
            labelCliente.TabIndex = 11;
            labelCliente.Text = "N° Cliente:";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(406, 24);
            comboBoxCliente.Margin = new Padding(3, 2, 3, 2);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(140, 23);
            comboBoxCliente.TabIndex = 10;
            // 
            // mostrartTodasOrdenes
            // 
            mostrartTodasOrdenes.Location = new Point(870, 24);
            mostrartTodasOrdenes.Name = "mostrartTodasOrdenes";
            mostrartTodasOrdenes.Size = new Size(190, 24);
            mostrartTodasOrdenes.TabIndex = 9;
            mostrartTodasOrdenes.Text = "Mostrar todas las ordenes";
            mostrartTodasOrdenes.UseVisualStyleBackColor = true;
            mostrartTodasOrdenes.Click += BotonMostrarTodas_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { numeroOrdenPreparacion, columnaCliente, columnaFecha, columnaTransportista });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(16, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(927, 314);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // numeroOrdenPreparacion
            // 
            numeroOrdenPreparacion.Text = "N° Orden";
            numeroOrdenPreparacion.Width = 210;
            // 
            // columnaCliente
            // 
            columnaCliente.Text = "N° Cliente";
            columnaCliente.Width = 210;
            // 
            // columnaFecha
            // 
            columnaFecha.Text = "Fecha Despacho";
            columnaFecha.Width = 240;
            // 
            // columnaTransportista
            // 
            columnaTransportista.Text = "Dni Transportista";
            columnaTransportista.Width = 240;
            // 
            // PantallaSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1107, 486);
            Controls.Add(groupBoxOrdenes);
            Controls.Add(VolverAlMenu);
            Controls.Add(BotonGenerarOS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PantallaSeleccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orden de Seleccion";
            Load += PantallaSeleccion_Load;
            groupBoxOrdenes.ResumeLayout(false);
            groupBoxOrdenes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader FechaDespach;
        private Button BotonGenerarOS;
        private Button VolverAlMenu;
        private DateTimePicker datetimeDespacho;
        private Label fechaDespacho;
        private GroupBox groupBoxOrdenes;
        private ListView listView1;
        private ColumnHeader numeroOrdenPreparacion;
        private Button mostrartTodasOrdenes;
        private ColumnHeader columnaCliente;
        private ColumnHeader columnaFecha;
        private ColumnHeader columnaTransportista;
        private Label labelCliente;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxTransportista;
        private Label labelTransportista;
    }
}