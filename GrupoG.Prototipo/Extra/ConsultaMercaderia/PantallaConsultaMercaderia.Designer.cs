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
            labelNumDeposito = new Label();
            textBoxNumDeposito = new TextBox();
            SuspendLayout();
            // 
            // labelnumeroCliente
            // 
            labelnumeroCliente.AutoSize = true;
            labelnumeroCliente.Location = new Point(14, 40);
            labelnumeroCliente.Name = "labelnumeroCliente";
            labelnumeroCliente.Size = new Size(131, 20);
            labelnumeroCliente.TabIndex = 0;
            labelnumeroCliente.Text = "Ingrese Nº Cliente:";
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(155, 36);
            textBoxCliente.Margin = new Padding(3, 4, 3, 4);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(266, 27);
            textBoxCliente.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(565, 29);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(179, 80);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(776, 29);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(179, 80);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Limpiar Datos";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // listViewMercaderias
            // 
            listViewMercaderias.CheckBoxes = true;
            listViewMercaderias.Columns.AddRange(new ColumnHeader[] { idMercaderia, nombreMercadería, mercaderiaUbicacion, cantidadPorUbicacionMercaderia });
            listViewMercaderias.GridLines = true;
            listViewMercaderias.Location = new Point(14, 132);
            listViewMercaderias.Margin = new Padding(3, 4, 3, 4);
            listViewMercaderias.MultiSelect = false;
            listViewMercaderias.Name = "listViewMercaderias";
            listViewMercaderias.Size = new Size(1077, 335);
            listViewMercaderias.TabIndex = 4;
            listViewMercaderias.UseCompatibleStateImageBehavior = false;
            listViewMercaderias.View = View.Details;
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
            textBoxCantidad.Location = new Point(215, 516);
            textBoxCantidad.Margin = new Padding(3, 4, 3, 4);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(183, 27);
            textBoxCantidad.TabIndex = 5;
            // 
            // labelAgregarSacarMercaderia
            // 
            labelAgregarSacarMercaderia.AutoSize = true;
            labelAgregarSacarMercaderia.Location = new Point(14, 520);
            labelAgregarSacarMercaderia.Name = "labelAgregarSacarMercaderia";
            labelAgregarSacarMercaderia.Size = new Size(198, 20);
            labelAgregarSacarMercaderia.TabIndex = 7;
            labelAgregarSacarMercaderia.Text = "Agregar o Sacar Mercadería:";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(565, 505);
            buttonAgregar.Margin = new Padding(3, 4, 3, 4);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(179, 51);
            buttonAgregar.TabIndex = 9;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonSacar
            // 
            buttonSacar.Location = new Point(776, 504);
            buttonSacar.Margin = new Padding(3, 4, 3, 4);
            buttonSacar.Name = "buttonSacar";
            buttonSacar.Size = new Size(179, 51);
            buttonSacar.TabIndex = 10;
            buttonSacar.Text = "Sacar";
            buttonSacar.UseVisualStyleBackColor = true;
            buttonSacar.Click += buttonSacar_Click;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(927, 580);
            BotonVolverMenu.Margin = new Padding(3, 4, 3, 4);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(155, 51);
            BotonVolverMenu.TabIndex = 12;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            BotonVolverMenu.Click += BotonVolverMenu_Click;
            // 
            // labelNumDeposito
            // 
            labelNumDeposito.AutoSize = true;
            labelNumDeposito.Location = new Point(14, 89);
            labelNumDeposito.Name = "labelNumDeposito";
            labelNumDeposito.Size = new Size(94, 20);
            labelNumDeposito.TabIndex = 13;
            labelNumDeposito.Text = "N° Deposito:";
            // 
            // textBoxNumDeposito
            // 
            textBoxNumDeposito.Location = new Point(155, 91);
            textBoxNumDeposito.Margin = new Padding(3, 4, 3, 4);
            textBoxNumDeposito.Name = "textBoxNumDeposito";
            textBoxNumDeposito.ReadOnly = true;
            textBoxNumDeposito.Size = new Size(266, 27);
            textBoxNumDeposito.TabIndex = 14;
            // 
            // PantallaConsultaMercaderia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 644);
            Controls.Add(textBoxNumDeposito);
            Controls.Add(labelNumDeposito);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
        private Label labelNumDeposito;
        private TextBox textBoxNumDeposito;
    }
}