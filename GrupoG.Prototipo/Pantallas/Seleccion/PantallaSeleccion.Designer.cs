﻿namespace GrupoG.Prototipo.Pantallas
{
    partial class PantallaOrdenSeleccion
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
            OrdenColumna = new ColumnHeader();
            ClienteColumna = new ColumnHeader();
            EstadoColumna = new ColumnHeader();
            FechaColumna = new ColumnHeader();
            BotonGenerarOS = new Button();
            SuspendLayout();
            // 
            // ListaOrdenSeleccion
            // 
            ListaOrdenSeleccion.Columns.AddRange(new ColumnHeader[] { OrdenColumna, ClienteColumna, EstadoColumna, FechaColumna });
            ListaOrdenSeleccion.Items.AddRange(new ListViewItem[] { listViewItem2 });
            ListaOrdenSeleccion.Location = new Point(12, 12);
            ListaOrdenSeleccion.Name = "ListaOrdenSeleccion";
            ListaOrdenSeleccion.Size = new Size(604, 207);
            ListaOrdenSeleccion.TabIndex = 0;
            ListaOrdenSeleccion.UseCompatibleStateImageBehavior = false;
            ListaOrdenSeleccion.View = View.Details;
            // 
            // OrdenColumna
            // 
            OrdenColumna.Text = "Nro de Orden";
            OrdenColumna.Width = 150;
            // 
            // ClienteColumna
            // 
            ClienteColumna.Text = "Nro de Cliente";
            ClienteColumna.Width = 150;
            // 
            // EstadoColumna
            // 
            EstadoColumna.Text = "Estado";
            EstadoColumna.Width = 150;
            // 
            // FechaColumna
            // 
            FechaColumna.Text = "Fecha de Generación";
            FechaColumna.Width = 150;
            // 
            // BotonGenerarOS
            // 
            BotonGenerarOS.Location = new Point(408, 257);
            BotonGenerarOS.Name = "BotonGenerarOS";
            BotonGenerarOS.Size = new Size(208, 23);
            BotonGenerarOS.TabIndex = 1;
            BotonGenerarOS.Text = "Generar Orden de Seleccion";
            BotonGenerarOS.UseVisualStyleBackColor = true;
            // 
            // PantallaOrdenSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 308);
            Controls.Add(BotonGenerarOS);
            Controls.Add(ListaOrdenSeleccion);
            Name = "PantallaOrdenSeleccion";
            Text = "Orden de Seleccion";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView ListaOrdenSeleccion;
        private ColumnHeader OrdenColumna;
        private ColumnHeader ClienteColumna;
        private ColumnHeader EstadoColumna;
        private ColumnHeader FechaColumna;
        private Button BotonGenerarOS;
    }
}