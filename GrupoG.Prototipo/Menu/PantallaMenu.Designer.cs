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
            BotonPreparacion.Location = new Point(112, 57);
            BotonPreparacion.Name = "BotonPreparacion";
            BotonPreparacion.Size = new Size(162, 44);
            BotonPreparacion.TabIndex = 1;
            BotonPreparacion.Text = "Orden de Preparación";
            BotonPreparacion.UseVisualStyleBackColor = true;
            BotonPreparacion.Click += BotonPreparacion_Click;
            // 
            // BotonSeleccion
            // 
            BotonSeleccion.Location = new Point(112, 123);
            BotonSeleccion.Name = "BotonSeleccion";
            BotonSeleccion.Size = new Size(162, 44);
            BotonSeleccion.TabIndex = 2;
            BotonSeleccion.Text = "Orden de Selección";
            BotonSeleccion.UseVisualStyleBackColor = true;
            BotonSeleccion.Click += BotonSeleccion_Click;
            // 
            // BotonEntrega
            // 
            BotonEntrega.Location = new Point(112, 315);
            BotonEntrega.Name = "BotonEntrega";
            BotonEntrega.Size = new Size(162, 44);
            BotonEntrega.TabIndex = 3;
            BotonEntrega.Text = "Orden de Entrega";
            BotonEntrega.UseVisualStyleBackColor = true;
            BotonEntrega.Click += BotonEntrega_Click;
            // 
            // BotonDespacho
            // 
            BotonDespacho.Location = new Point(112, 381);
            BotonDespacho.Name = "BotonDespacho";
            BotonDespacho.Size = new Size(162, 44);
            BotonDespacho.TabIndex = 4;
            BotonDespacho.Text = "Orden de Despacho";
            BotonDespacho.UseVisualStyleBackColor = true;
            BotonDespacho.Click += BotonDespacho_Click;
            // 
            // BotonEmpaquetar
            // 
            BotonEmpaquetar.Location = new Point(112, 254);
            BotonEmpaquetar.Name = "BotonEmpaquetar";
            BotonEmpaquetar.Size = new Size(162, 44);
            BotonEmpaquetar.TabIndex = 5;
            BotonEmpaquetar.Text = "Empaquetar";
            BotonEmpaquetar.UseVisualStyleBackColor = true;
            BotonEmpaquetar.Click += BotonEmpaquetar_Click;
            // 
            // BotonRetiroStock
            // 
            BotonRetiroStock.Location = new Point(112, 190);
            BotonRetiroStock.Name = "BotonRetiroStock";
            BotonRetiroStock.Size = new Size(162, 44);
            BotonRetiroStock.TabIndex = 6;
            BotonRetiroStock.Text = "Retiro Stock";
            BotonRetiroStock.UseVisualStyleBackColor = true;
            BotonRetiroStock.Click += BotonRetiroStock_Click;
            // 
            // PantallaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 463);
            Controls.Add(BotonRetiroStock);
            Controls.Add(BotonEmpaquetar);
            Controls.Add(BotonDespacho);
            Controls.Add(BotonEntrega);
            Controls.Add(BotonSeleccion);
            Controls.Add(BotonPreparacion);
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
