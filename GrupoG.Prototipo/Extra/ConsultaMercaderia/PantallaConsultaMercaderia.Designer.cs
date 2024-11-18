namespace GrupoG.Prototipo.Extra.ConsultaMercaderia
{
    partial class PantallaConsultaMercaderia
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
            labelnumeroCliente = new Label();
            textBoxCliente = new TextBox();
            buttonBuscar = new Button();
            buttonClear = new Button();
            listViewMercaderias = new ListView();
            idMercaderia = new ColumnHeader();
            nombreMercadería = new ColumnHeader();
            mercaderiaUbicacion = new ColumnHeader();
            cantidadPorUbicacionMercaderia = new ColumnHeader();
            textBoxCantidad = new TextBox();
            labelAgregarSacarMercaderia = new Label();
            buttonAgregar = new Button();
            buttonSacar = new Button();
            BotonVolverMenu = new Button();
            SuspendLayout();
            // 
            // labelnumeroCliente
            // 
            labelnumeroCliente.AutoSize = true;
            labelnumeroCliente.Location = new Point(12, 25);
            labelnumeroCliente.Name = "labelnumeroCliente";
            labelnumeroCliente.Size = new Size(102, 15);
            labelnumeroCliente.TabIndex = 0;
            labelnumeroCliente.Text = "Ingrese Nº Cliente";
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(120, 22);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(142, 23);
            textBoxCliente.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(286, 22);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(142, 23);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(446, 22);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(142, 23);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // listViewMercaderias
            // 
            listViewMercaderias.CheckBoxes = true;
            listViewMercaderias.Columns.AddRange(new ColumnHeader[] { idMercaderia, nombreMercadería, mercaderiaUbicacion, cantidadPorUbicacionMercaderia });
            listViewMercaderias.GridLines = true;
            listViewMercaderias.Location = new Point(14, 60);
            listViewMercaderias.Name = "listViewMercaderias";
            listViewMercaderias.Size = new Size(727, 252);
            listViewMercaderias.TabIndex = 4;
            listViewMercaderias.UseCompatibleStateImageBehavior = false;
            listViewMercaderias.View = View.Details;
            listViewMercaderias.MultiSelect = false;
            // 
            // idMercaderia
            // 
            idMercaderia.Text = "ID";
            idMercaderia.Width = 150;
            // 
            // nombreMercadería
            // 
            nombreMercadería.Text = "Nombre";
            nombreMercadería.Width = 220;
            // 
            // mercaderiaUbicacion
            // 
            mercaderiaUbicacion.Text = "Ubicación";
            mercaderiaUbicacion.Width = 150;
            // 
            // cantidadPorUbicacionMercaderia
            // 
            cantidadPorUbicacionMercaderia.Text = "Cantidad";
            cantidadPorUbicacionMercaderia.Width = 200;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(188, 354);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(161, 23);
            textBoxCantidad.TabIndex = 5;
            // 
            // labelAgregarSacarMercaderia
            // 
            labelAgregarSacarMercaderia.AutoSize = true;
            labelAgregarSacarMercaderia.Location = new Point(12, 357);
            labelAgregarSacarMercaderia.Name = "labelAgregarSacarMercaderia";
            labelAgregarSacarMercaderia.Size = new Size(155, 15);
            labelAgregarSacarMercaderia.TabIndex = 7;
            labelAgregarSacarMercaderia.Text = "Agregar o Sacar Mercadería:";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(355, 324);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(90, 38);
            buttonAgregar.TabIndex = 9;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonSacar
            // 
            buttonSacar.Location = new Point(355, 368);
            buttonSacar.Name = "buttonSacar";
            buttonSacar.Size = new Size(90, 38);
            buttonSacar.TabIndex = 10;
            buttonSacar.Text = "Sacar";
            buttonSacar.UseVisualStyleBackColor = true;
            buttonSacar.Click += buttonSacar_Click;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(573, 345);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(136, 38);
            BotonVolverMenu.TabIndex = 12;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            BotonVolverMenu.Click += BotonVolverMenu_Click;
            // 
            // PantallaConsultaMercaderia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 416);
            Controls.Add(BotonVolverMenu);
            Controls.Add(buttonSacar);
            Controls.Add(buttonAgregar);
            Controls.Add(labelAgregarSacarMercaderia);
            Controls.Add(textBoxCantidad);
            Controls.Add(listViewMercaderias);
            Controls.Add(buttonClear);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxCliente);
            Controls.Add(labelnumeroCliente);
            Name = "PantallaConsultaMercaderia";
            Text = "Consulta Mercaderia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnumeroCliente;
        private TextBox textBoxCliente;
        private Button buttonBuscar;
        private Button buttonClear;
        private ListView listViewMercaderias;
        private ColumnHeader idMercaderia;
        private ColumnHeader nombreMercadería;
        private ColumnHeader cantidadPorUbicacionMercaderia;
        private TextBox textBoxCantidad;
        private Label labelAgregarSacarMercaderia;
        private Button buttonAgregar;
        private Button buttonSacar;
        private Button BotonVolverMenu;
        private ColumnHeader mercaderiaUbicacion;
    }
}