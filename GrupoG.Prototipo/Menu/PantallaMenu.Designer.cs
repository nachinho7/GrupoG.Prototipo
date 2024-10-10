namespace GrupoG.Prototipo.Pantallas.Menu
{
    partial class PantallaMenu
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
            BotonPreparacion = new Button();
            BotonSeleccion = new Button();
            BotonEntrega = new Button();
            BotonDespacho = new Button();
            BotonEmpaquetar = new Button();
            BotonRetiroStock = new Button();
            SuspendLayout();
            // 
            // BotonPreparacion
            // 
            BotonPreparacion.Location = new Point(128, 76);
            BotonPreparacion.Margin = new Padding(3, 4, 3, 4);
            BotonPreparacion.Name = "BotonPreparacion";
            BotonPreparacion.Size = new Size(185, 59);
            BotonPreparacion.TabIndex = 1;
            BotonPreparacion.Text = "Orden de Preparación";
            BotonPreparacion.UseVisualStyleBackColor = true;
            BotonPreparacion.Click += BotonPreparacion_Click;
            // 
            // BotonSeleccion
            // 
            BotonSeleccion.Location = new Point(128, 164);
            BotonSeleccion.Margin = new Padding(3, 4, 3, 4);
            BotonSeleccion.Name = "BotonSeleccion";
            BotonSeleccion.Size = new Size(185, 59);
            BotonSeleccion.TabIndex = 2;
            BotonSeleccion.Text = "Orden de Selección";
            BotonSeleccion.UseVisualStyleBackColor = true;
            BotonSeleccion.Click += BotonSeleccion_Click;
            // 
            // BotonEntrega
            // 
            BotonEntrega.Location = new Point(128, 420);
            BotonEntrega.Margin = new Padding(3, 4, 3, 4);
            BotonEntrega.Name = "BotonEntrega";
            BotonEntrega.Size = new Size(185, 59);
            BotonEntrega.TabIndex = 3;
            BotonEntrega.Text = "Orden de Entrega";
            BotonEntrega.UseVisualStyleBackColor = true;
            BotonEntrega.Click += BotonEntrega_Click;
            // 
            // BotonDespacho
            // 
            BotonDespacho.Location = new Point(128, 508);
            BotonDespacho.Margin = new Padding(3, 4, 3, 4);
            BotonDespacho.Name = "BotonDespacho";
            BotonDespacho.Size = new Size(185, 59);
            BotonDespacho.TabIndex = 4;
            BotonDespacho.Text = "Orden de Despacho";
            BotonDespacho.UseVisualStyleBackColor = true;
            BotonDespacho.Click += BotonDespacho_Click;
            // 
            // BotonEmpaquetar
            // 
            BotonEmpaquetar.Location = new Point(128, 339);
            BotonEmpaquetar.Margin = new Padding(3, 4, 3, 4);
            BotonEmpaquetar.Name = "BotonEmpaquetar";
            BotonEmpaquetar.Size = new Size(185, 59);
            BotonEmpaquetar.TabIndex = 5;
            BotonEmpaquetar.Text = "Empaquetar";
            BotonEmpaquetar.UseVisualStyleBackColor = true;
            BotonEmpaquetar.Click += BotonEmpaquetar_Click;
            // 
            // BotonRetiroStock
            // 
            BotonRetiroStock.Location = new Point(128, 253);
            BotonRetiroStock.Margin = new Padding(3, 4, 3, 4);
            BotonRetiroStock.Name = "BotonRetiroStock";
            BotonRetiroStock.Size = new Size(185, 59);
            BotonRetiroStock.TabIndex = 6;
            BotonRetiroStock.Text = "Retiro Stock";
            BotonRetiroStock.UseVisualStyleBackColor = true;
            BotonRetiroStock.Click += BotonRetiroStock_Click;
            // 
            // PantallaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(421, 617);
            Controls.Add(BotonRetiroStock);
            Controls.Add(BotonEmpaquetar);
            Controls.Add(BotonDespacho);
            Controls.Add(BotonEntrega);
            Controls.Add(BotonSeleccion);
            Controls.Add(BotonPreparacion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            ResumeLayout(false);
        }

        #endregion
        private Button BotonPreparacion;
        private Button BotonSeleccion;
        private Button BotonEntrega;
        private Button BotonDespacho;
        private Button BotonEmpaquetar;
        private Button BotonRetiroStock;
    }
}
