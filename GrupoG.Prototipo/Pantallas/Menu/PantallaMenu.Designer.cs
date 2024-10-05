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
            BotonTransportista = new Button();
            BotonPreparacion = new Button();
            BotonSeleccion = new Button();
            BotonEntrega = new Button();
            BotonDespacho = new Button();
            SuspendLayout();
            // 
            // BotonTransportista
            // 
            BotonTransportista.Location = new Point(112, 46);
            BotonTransportista.Name = "BotonTransportista";
            BotonTransportista.Size = new Size(162, 44);
            BotonTransportista.TabIndex = 0;
            BotonTransportista.Text = "Transportista";
            BotonTransportista.UseVisualStyleBackColor = true;
            BotonTransportista.Click += this.BotonTransportista_Click;
            // 
            // BotonPreparacion
            // 
            BotonPreparacion.Location = new Point(112, 117);
            BotonPreparacion.Name = "BotonPreparacion";
            BotonPreparacion.Size = new Size(162, 44);
            BotonPreparacion.TabIndex = 1;
            BotonPreparacion.Text = "Preparación";
            BotonPreparacion.UseVisualStyleBackColor = true;
            BotonPreparacion.Click += this.button2_Click;
            // 
            // BotonSeleccion
            // 
            BotonSeleccion.Location = new Point(112, 193);
            BotonSeleccion.Name = "BotonSeleccion";
            BotonSeleccion.Size = new Size(162, 44);
            BotonSeleccion.TabIndex = 2;
            BotonSeleccion.Text = "Selección";
            BotonSeleccion.UseVisualStyleBackColor = true;
            // 
            // BotonEntrega
            // 
            BotonEntrega.Location = new Point(112, 269);
            BotonEntrega.Name = "BotonEntrega";
            BotonEntrega.Size = new Size(162, 44);
            BotonEntrega.TabIndex = 3;
            BotonEntrega.Text = "Entrega";
            BotonEntrega.UseVisualStyleBackColor = true;
            BotonEntrega.Click += this.button4_Click;
            // 
            // BotonDespacho
            // 
            BotonDespacho.Location = new Point(112, 347);
            BotonDespacho.Name = "BotonDespacho";
            BotonDespacho.Size = new Size(162, 44);
            BotonDespacho.TabIndex = 4;
            BotonDespacho.Text = "Despacho";
            BotonDespacho.UseVisualStyleBackColor = true;
            BotonDespacho.Click += this.BotonDespacho_Click;
            // 
            // PantallaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 428);
            Controls.Add(BotonDespacho);
            Controls.Add(BotonEntrega);
            Controls.Add(BotonSeleccion);
            Controls.Add(BotonPreparacion);
            Controls.Add(BotonTransportista);
            Name = "PantallaMenu";
            Text = "Menú";
            ResumeLayout(false);
        }

        #endregion

        private Button BotonTransportista;
        private Button BotonPreparacion;
        private Button BotonSeleccion;
        private Button BotonEntrega;
        private Button BotonDespacho;
    }
}