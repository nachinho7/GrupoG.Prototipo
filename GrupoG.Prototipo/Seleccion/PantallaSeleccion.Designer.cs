namespace GrupoG.Prototipo.Pantallas
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
            mostrartTodasOrdenes = new Button();
            listView1 = new ListView();
            numeroOrdenPreparacion = new ColumnHeader();
            groupBoxOrdenes.SuspendLayout();
            SuspendLayout();
            // 
            // BotonGenerarOS
            // 
            BotonGenerarOS.Location = new Point(32, 560);
            BotonGenerarOS.Margin = new Padding(3, 4, 3, 4);
            BotonGenerarOS.Name = "BotonGenerarOS";
            BotonGenerarOS.Size = new Size(126, 51);
            BotonGenerarOS.TabIndex = 1;
            BotonGenerarOS.Text = "Generar Orden de Seleccion";
            BotonGenerarOS.UseVisualStyleBackColor = true;
            BotonGenerarOS.Click += BotonGenerarOS_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(177, 560);
            VolverAlMenu.Margin = new Padding(3, 4, 3, 4);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(129, 51);
            VolverAlMenu.TabIndex = 5;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // datetimeDespacho
            // 
            datetimeDespacho.Format = DateTimePickerFormat.Short;
            datetimeDespacho.Location = new Point(165, 31);
            datetimeDespacho.Margin = new Padding(3, 4, 3, 4);
            datetimeDespacho.Name = "datetimeDespacho";
            datetimeDespacho.Size = new Size(126, 27);
            datetimeDespacho.TabIndex = 6;
            datetimeDespacho.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // fechaDespacho
            // 
            fechaDespacho.AutoSize = true;
            fechaDespacho.Location = new Point(18, 39);
            fechaDespacho.Name = "fechaDespacho";
            fechaDespacho.Size = new Size(138, 20);
            fechaDespacho.TabIndex = 7;
            fechaDespacho.Text = "Fecha de Despacho";
            // 
            // groupBoxOrdenes
            // 
            groupBoxOrdenes.Controls.Add(mostrartTodasOrdenes);
            groupBoxOrdenes.Controls.Add(listView1);
            groupBoxOrdenes.Controls.Add(fechaDespacho);
            groupBoxOrdenes.Controls.Add(datetimeDespacho);
            groupBoxOrdenes.Location = new Point(14, 16);
            groupBoxOrdenes.Margin = new Padding(3, 4, 3, 4);
            groupBoxOrdenes.Name = "groupBoxOrdenes";
            groupBoxOrdenes.Padding = new Padding(3, 4, 3, 4);
            groupBoxOrdenes.Size = new Size(314, 523);
            groupBoxOrdenes.TabIndex = 8;
            groupBoxOrdenes.TabStop = false;
            groupBoxOrdenes.Text = "Ordenes de Preparación a seleccionar:";
            // 
            // mostrartTodasOrdenes
            // 
            mostrartTodasOrdenes.Location = new Point(42, 69);
            mostrartTodasOrdenes.Margin = new Padding(3, 4, 3, 4);
            mostrartTodasOrdenes.Name = "mostrartTodasOrdenes";
            mostrartTodasOrdenes.Size = new Size(217, 32);
            mostrartTodasOrdenes.TabIndex = 9;
            mostrartTodasOrdenes.Text = "Mostrar todas las ordenes";
            mostrartTodasOrdenes.UseVisualStyleBackColor = true;
            mostrartTodasOrdenes.Click += BotonMostrarTodas_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { numeroOrdenPreparacion });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(17, 109);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(274, 381);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // numeroOrdenPreparacion
            // 
            numeroOrdenPreparacion.Text = "N° Orden";
            numeroOrdenPreparacion.Width = 210;
            // 
            // PantallaSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(349, 648);
            Controls.Add(groupBoxOrdenes);
            Controls.Add(VolverAlMenu);
            Controls.Add(BotonGenerarOS);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}