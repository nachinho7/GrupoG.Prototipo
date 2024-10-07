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
            ListViewItem listViewItem2 = new ListViewItem("");
            ListaOrdenSeleccion = new ListView();
            numeroOrden = new ColumnHeader();
            numeroCliente = new ColumnHeader();
            Estado = new ColumnHeader();
            BotonGenerarOS = new Button();
            VolverAlMenu = new Button();
            datetimeDespacho = new DateTimePicker();
            fechaDespacho = new Label();
            SuspendLayout();
            // 
            // ListaOrdenSeleccion
            // 
            ListaOrdenSeleccion.Columns.AddRange(new ColumnHeader[] { numeroOrden, numeroCliente, Estado });
            ListaOrdenSeleccion.Items.AddRange(new ListViewItem[] { listViewItem2 });
            ListaOrdenSeleccion.Location = new Point(43, 106);
            ListaOrdenSeleccion.Name = "ListaOrdenSeleccion";
            ListaOrdenSeleccion.Size = new Size(457, 316);
            ListaOrdenSeleccion.TabIndex = 0;
            ListaOrdenSeleccion.UseCompatibleStateImageBehavior = false;
            ListaOrdenSeleccion.View = View.Details;
            // 
            // numeroOrden
            // 
            numeroOrden.Text = "Nº Orden";
            numeroOrden.Width = 150;
            // 
            // numeroCliente
            // 
            numeroCliente.Text = "Nº de Cliente";
            numeroCliente.Width = 150;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 150;
            // 
            // BotonGenerarOS
            // 
            BotonGenerarOS.Location = new Point(264, 475);
            BotonGenerarOS.Name = "BotonGenerarOS";
            BotonGenerarOS.Size = new Size(107, 38);
            BotonGenerarOS.TabIndex = 1;
            BotonGenerarOS.Text = "Generar Orden de Seleccion";
            BotonGenerarOS.UseVisualStyleBackColor = true;
            BotonGenerarOS.Click += BotonGenerarOS_Click;
            // 
            // VolverAlMenu
            // 
            VolverAlMenu.Location = new Point(393, 475);
            VolverAlMenu.Name = "VolverAlMenu";
            VolverAlMenu.Size = new Size(107, 38);
            VolverAlMenu.TabIndex = 5;
            VolverAlMenu.Text = "Volver al Menú";
            VolverAlMenu.UseVisualStyleBackColor = true;
            VolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // datetimeDespacho
            // 
            datetimeDespacho.Location = new Point(157, 54);
            datetimeDespacho.Name = "datetimeDespacho";
            datetimeDespacho.Size = new Size(200, 23);
            datetimeDespacho.TabIndex = 6;
            // 
            // fechaDespacho
            // 
            fechaDespacho.AutoSize = true;
            fechaDespacho.Location = new Point(43, 60);
            fechaDespacho.Name = "fechaDespacho";
            fechaDespacho.Size = new Size(109, 15);
            fechaDespacho.TabIndex = 7;
            fechaDespacho.Text = "Fecha de Despacho";
            // 
            // PantallaSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 537);
            Controls.Add(fechaDespacho);
            Controls.Add(datetimeDespacho);
            Controls.Add(VolverAlMenu);
            Controls.Add(BotonGenerarOS);
            Controls.Add(ListaOrdenSeleccion);
            Name = "PantallaSeleccion";
            Text = "Orden de Seleccion";
            Load += PantallaSeleccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListaOrdenSeleccion;
        private ColumnHeader numeroOrden;
        private ColumnHeader numeroCliente;
        private ColumnHeader FechaDespach;
        private ColumnHeader Estado;
        private Button BotonGenerarOS;
        private Button VolverAlMenu;
        private DateTimePicker datetimeDespacho;
        private Label fechaDespacho;
    }
}