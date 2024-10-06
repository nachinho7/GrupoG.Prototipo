﻿namespace GrupoG.Prototipo.Pantallas
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
            BotonEmpaquetar = new Button();
            ListaOrdenesEmpaquetar = new ListView();
            ColumnaNumeroCliente = new ColumnHeader();
            ColumnaCodigo = new ColumnHeader();
            ColumnaUbicacion = new ColumnHeader();
            ColumnaTipo = new ColumnHeader();
            BotonVolverAlMenu = new Button();
            ColumnaNumeroOrden = new ColumnHeader();
            SuspendLayout();
            // 
            // BotonEmpaquetar
            // 
            BotonEmpaquetar.Location = new Point(672, 274);
            BotonEmpaquetar.Margin = new Padding(3, 2, 3, 2);
            BotonEmpaquetar.Name = "BotonEmpaquetar";
            BotonEmpaquetar.Size = new Size(103, 38);
            BotonEmpaquetar.TabIndex = 7;
            BotonEmpaquetar.Text = "Empaquetar\r\n";
            BotonEmpaquetar.UseVisualStyleBackColor = true;
            BotonEmpaquetar.Click += Empaquetar_Click;
            // 
            // ListaOrdenesEmpaquetar
            // 
            ListaOrdenesEmpaquetar.Columns.AddRange(new ColumnHeader[] { ColumnaNumeroOrden, ColumnaNumeroCliente, ColumnaCodigo, ColumnaUbicacion, ColumnaTipo });
            ListaOrdenesEmpaquetar.Location = new Point(53, 35);
            ListaOrdenesEmpaquetar.Margin = new Padding(3, 2, 3, 2);
            ListaOrdenesEmpaquetar.Name = "ListaOrdenesEmpaquetar";
            ListaOrdenesEmpaquetar.Size = new Size(755, 210);
            ListaOrdenesEmpaquetar.TabIndex = 9;
            ListaOrdenesEmpaquetar.UseCompatibleStateImageBehavior = false;
            ListaOrdenesEmpaquetar.View = View.Details;
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
            // BotonVolverAlMenu
            // 
            BotonVolverAlMenu.Location = new Point(87, 274);
            BotonVolverAlMenu.Name = "BotonVolverAlMenu";
            BotonVolverAlMenu.Size = new Size(103, 38);
            BotonVolverAlMenu.TabIndex = 10;
            BotonVolverAlMenu.Text = "Volver al Menú";
            BotonVolverAlMenu.UseVisualStyleBackColor = true;
            BotonVolverAlMenu.Click += VolverAlMenu_Click;
            // 
            // ColumnaNumeroOrden
            // 
            ColumnaNumeroOrden.Text = "Numero de Órden";
            ColumnaNumeroOrden.Width = 150;
            // 
            // PantallaEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 349);
            Controls.Add(BotonVolverAlMenu);
            Controls.Add(ListaOrdenesEmpaquetar);
            Controls.Add(BotonEmpaquetar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PantallaEntrega";
            Text = "Órden de Entrega";
            ResumeLayout(false);
        }

        #endregion
        private Button BotonEmpaquetar;
        private ListView ListaOrdenesEmpaquetar;
        private ColumnHeader ColumnaNumeroCliente;
        private ColumnHeader ColumnaCodigo;
        private ColumnHeader ColumnaUbicacion;
        private ColumnHeader ColumnaTipo;
        private Button BotonVolverMenu;
        private Button BotonVolverAlMenu;
        private ColumnHeader ColumnaNumeroOrden;
    }
}