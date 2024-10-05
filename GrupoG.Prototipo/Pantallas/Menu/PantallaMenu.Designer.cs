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
            this.BotonTransportista = new System.Windows.Forms.Button();
            this.BotonPreparacion = new System.Windows.Forms.Button();
            this.BotonSeleccion = new System.Windows.Forms.Button();
            this.BotonEntrega = new System.Windows.Forms.Button();
            this.BotonDespacho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonTransportista
            // 
            this.BotonTransportista.Location = new System.Drawing.Point(112, 46);
            this.BotonTransportista.Name = "BotonTransportista";
            this.BotonTransportista.Size = new System.Drawing.Size(162, 44);
            this.BotonTransportista.TabIndex = 0;
            this.BotonTransportista.Text = "Transportista";
            this.BotonTransportista.UseVisualStyleBackColor = true;
            this.BotonTransportista.Click += new System.EventHandler(this.BotonTransportista_Click);
            // 
            // BotonPreparacion
            // 
            this.BotonPreparacion.Location = new System.Drawing.Point(112, 117);
            this.BotonPreparacion.Name = "BotonPreparacion";
            this.BotonPreparacion.Size = new System.Drawing.Size(162, 44);
            this.BotonPreparacion.TabIndex = 1;
            this.BotonPreparacion.Text = "Preparación";
            this.BotonPreparacion.UseVisualStyleBackColor = true;
            this.BotonPreparacion.Click += new System.EventHandler(this.BotonPreparacion_Click);
            // 
            // BotonSeleccion
            // 
            this.BotonSeleccion.Location = new System.Drawing.Point(112, 193);
            this.BotonSeleccion.Name = "BotonSeleccion";
            this.BotonSeleccion.Size = new System.Drawing.Size(162, 44);
            this.BotonSeleccion.TabIndex = 2;
            this.BotonSeleccion.Text = "Selección";
            this.BotonSeleccion.UseVisualStyleBackColor = true;
            this.BotonSeleccion.Click += new System.EventHandler(this.BotonSeleccion_Click);
            // 
            // BotonEntrega
            // 
            this.BotonEntrega.Location = new System.Drawing.Point(112, 269);
            this.BotonEntrega.Name = "BotonEntrega";
            this.BotonEntrega.Size = new System.Drawing.Size(162, 44);
            this.BotonEntrega.TabIndex = 3;
            this.BotonEntrega.Text = "Entrega";
            this.BotonEntrega.UseVisualStyleBackColor = true;
            this.BotonEntrega.Click += new System.EventHandler(this.BotonEntrega_Click);
            // 
            // BotonDespacho
            // 
            this.BotonDespacho.Location = new System.Drawing.Point(112, 347);
            this.BotonDespacho.Name = "BotonDespacho";
            this.BotonDespacho.Size = new System.Drawing.Size(162, 44);
            this.BotonDespacho.TabIndex = 4;
            this.BotonDespacho.Text = "Despacho";
            this.BotonDespacho.UseVisualStyleBackColor = true;
            this.BotonDespacho.Click += new System.EventHandler(this.BotonDespacho_Click);
            // 
            // PantallaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 428);
            this.Controls.Add(this.BotonDespacho);
            this.Controls.Add(this.BotonEntrega);
            this.Controls.Add(this.BotonSeleccion);
            this.Controls.Add(this.BotonPreparacion);
            this.Controls.Add(this.BotonTransportista);
            this.Name = "PantallaMenu";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BotonTransportista;
        private Button BotonPreparacion;
        private Button BotonSeleccion;
        private Button BotonEntrega;
        private Button BotonDespacho;
    }
}
