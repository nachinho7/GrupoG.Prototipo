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
            BotonGenerarOS.Location = new Point(28, 420);
            BotonGenerarOS.Name = "BotonGenerarOS";
            BotonGenerarOS.Size = new Size(110, 38);
            BotonGenerarOS.TabIndex = 1;
            BotonGenerarOS.Text = "Generar Orden de Seleccion";
            BotonGenerarOS.UseVisualStyleBackColor = true;
            BotonGenerarOS.Click += BotonGenerarOS_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(155, 420);
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
            datetimeDespacho.Location = new Point(144, 23);
            datetimeDespacho.Name = "datetimeDespacho";
            datetimeDespacho.Size = new Size(111, 23);
            datetimeDespacho.TabIndex = 6;
            datetimeDespacho.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // fechaDespacho
            // 
            fechaDespacho.AutoSize = true;
            fechaDespacho.Location = new Point(16, 29);
            fechaDespacho.Name = "fechaDespacho";
            fechaDespacho.Size = new Size(109, 15);
            fechaDespacho.TabIndex = 7;
            fechaDespacho.Text = "Fecha de Despacho";
            // 
            // groupBoxOrdenes
            // 
            groupBoxOrdenes.Controls.Add(mostrartTodasOrdenes);
            groupBoxOrdenes.Controls.Add(listView1);
            groupBoxOrdenes.Controls.Add(fechaDespacho);
            groupBoxOrdenes.Controls.Add(datetimeDespacho);
            groupBoxOrdenes.Location = new Point(12, 12);
            groupBoxOrdenes.Name = "groupBoxOrdenes";
            groupBoxOrdenes.Size = new Size(275, 392);
            groupBoxOrdenes.TabIndex = 8;
            groupBoxOrdenes.TabStop = false;
            groupBoxOrdenes.Text = "Ordenes de Preparación a seleccionar:";
            // 
            // mostrartTodasOrdenes
            // 
            mostrartTodasOrdenes.Location = new Point(37, 52);
            mostrartTodasOrdenes.Name = "mostrartTodasOrdenes";
            mostrartTodasOrdenes.Size = new Size(190, 24);
            mostrartTodasOrdenes.TabIndex = 9;
            mostrartTodasOrdenes.Text = "Mostrar todas las ordenes";
            mostrartTodasOrdenes.UseVisualStyleBackColor = true;
            mostrartTodasOrdenes.Click += BotonMostrarTodas_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { numeroOrdenPreparacion });
            listView1.Location = new Point(15, 82);
            listView1.Name = "listView1";
            listView1.Size = new Size(240, 287);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 486);
            Controls.Add(groupBoxOrdenes);
            Controls.Add(VolverAlMenu);
            Controls.Add(BotonGenerarOS);
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