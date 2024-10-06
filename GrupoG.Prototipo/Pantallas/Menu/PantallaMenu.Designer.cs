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
            SuspendLayout();
            // 
            // BotonPreparacion
            // 
            BotonPreparacion.Location = new Point(160, 95);
            BotonPreparacion.Margin = new Padding(4, 5, 4, 5);
            BotonPreparacion.Name = "BotonPreparacion";
            BotonPreparacion.Size = new Size(231, 73);
            BotonPreparacion.TabIndex = 1;
            BotonPreparacion.Text = "Orden de Preparación";
            BotonPreparacion.UseVisualStyleBackColor = true;
            BotonPreparacion.Click += BotonPreparacion_Click;
            // 
            // BotonSeleccion
            // 
            BotonSeleccion.Location = new Point(160, 233);
            BotonSeleccion.Margin = new Padding(4, 5, 4, 5);
            BotonSeleccion.Name = "BotonSeleccion";
            BotonSeleccion.Size = new Size(231, 73);
            BotonSeleccion.TabIndex = 2;
            BotonSeleccion.Text = "Orden de Selección";
            BotonSeleccion.UseVisualStyleBackColor = true;
            BotonSeleccion.Click += BotonSeleccion_Click;
            // 
            // BotonEntrega
            // 
            BotonEntrega.Location = new Point(160, 370);
            BotonEntrega.Margin = new Padding(4, 5, 4, 5);
            BotonEntrega.Name = "BotonEntrega";
            BotonEntrega.Size = new Size(231, 73);
            BotonEntrega.TabIndex = 3;
            BotonEntrega.Text = "Orden de Entrega";
            BotonEntrega.UseVisualStyleBackColor = true;
            BotonEntrega.Click += BotonEntrega_Click;
            // 
            // BotonDespacho
            // 
            BotonDespacho.Location = new Point(160, 508);
            BotonDespacho.Margin = new Padding(4, 5, 4, 5);
            BotonDespacho.Name = "BotonDespacho";
            BotonDespacho.Size = new Size(231, 73);
            BotonDespacho.TabIndex = 4;
            BotonDespacho.Text = "Orden de Despacho";
            BotonDespacho.UseVisualStyleBackColor = true;
            BotonDespacho.Click += BotonDespacho_Click;
            // 
            // PantallaMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 668);
            Controls.Add(BotonDespacho);
            Controls.Add(BotonEntrega);
            Controls.Add(BotonSeleccion);
            Controls.Add(BotonPreparacion);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PantallaMenu";
            Text = "Menú";
            ResumeLayout(false);
        }

        #endregion
        private Button BotonPreparacion;
        private Button BotonSeleccion;
        private Button BotonEntrega;
        private Button BotonDespacho;
    }
}
