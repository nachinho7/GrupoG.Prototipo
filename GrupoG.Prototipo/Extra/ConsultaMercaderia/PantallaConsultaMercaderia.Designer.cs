namespace GrupoG.Prototipo.Extra.ConsultaStock
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
            textBoxNumeroCliente = new TextBox();
            buttonBuscar = new Button();
            buttonClear = new Button();
            listViewMercaderias = new ListView();
            idMercaderia = new ColumnHeader();
            nombreMercadería = new ColumnHeader();
            cantidadMercaderia = new ColumnHeader();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelAgregarMercaderia = new Label();
            labelSacarMercaderia = new Label();
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
            // textBoxNumeroCliente
            // 
            textBoxNumeroCliente.Location = new Point(120, 22);
            textBoxNumeroCliente.Name = "textBoxNumeroCliente";
            textBoxNumeroCliente.Size = new Size(142, 23);
            textBoxNumeroCliente.TabIndex = 1;
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
            listViewMercaderias.Columns.AddRange(new ColumnHeader[] { idMercaderia, nombreMercadería, cantidadMercaderia });
            listViewMercaderias.GridLines = true;
            listViewMercaderias.Location = new Point(14, 60);
            listViewMercaderias.Name = "listViewMercaderias";
            listViewMercaderias.Size = new Size(574, 252);
            listViewMercaderias.TabIndex = 4;
            listViewMercaderias.UseCompatibleStateImageBehavior = false;
            listViewMercaderias.View = View.Details;
            listViewMercaderias.SelectedIndexChanged += listViewMercaderias_SelectedIndexChanged;
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
            // cantidadMercaderia
            // 
            cantidadMercaderia.Text = "Cantidad";
            cantidadMercaderia.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 321);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 359);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 6;
            // 
            // labelAgregarMercaderia
            // 
            labelAgregarMercaderia.AutoSize = true;
            labelAgregarMercaderia.Location = new Point(14, 324);
            labelAgregarMercaderia.Name = "labelAgregarMercaderia";
            labelAgregarMercaderia.Size = new Size(114, 15);
            labelAgregarMercaderia.TabIndex = 7;
            labelAgregarMercaderia.Text = "Agregar Mercadería:";
            // 
            // labelSacarMercaderia
            // 
            labelSacarMercaderia.AutoSize = true;
            labelSacarMercaderia.Location = new Point(14, 362);
            labelSacarMercaderia.Name = "labelSacarMercaderia";
            labelSacarMercaderia.Size = new Size(100, 15);
            labelSacarMercaderia.TabIndex = 8;
            labelSacarMercaderia.Text = "Sacar Mercadería:";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(331, 321);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 9;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonSacar
            // 
            buttonSacar.Location = new Point(331, 362);
            buttonSacar.Name = "buttonSacar";
            buttonSacar.Size = new Size(75, 23);
            buttonSacar.TabIndex = 10;
            buttonSacar.Text = "Sacar";
            buttonSacar.UseVisualStyleBackColor = true;
            buttonSacar.Click += buttonSacar_Click;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(452, 405);
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
            ClientSize = new Size(607, 455);
            Controls.Add(BotonVolverMenu);
            Controls.Add(buttonSacar);
            Controls.Add(buttonAgregar);
            Controls.Add(labelSacarMercaderia);
            Controls.Add(labelAgregarMercaderia);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listViewMercaderias);
            Controls.Add(buttonClear);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxNumeroCliente);
            Controls.Add(labelnumeroCliente);
            Name = "PantallaConsultaMercaderia";
            Text = "Consulta Mercaderia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnumeroCliente;
        private TextBox textBoxNumeroCliente;
        private Button buttonBuscar;
        private Button buttonClear;
        private ListView listViewMercaderias;
        private ColumnHeader idMercaderia;
        private ColumnHeader nombreMercadería;
        private ColumnHeader cantidadMercaderia;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelAgregarMercaderia;
        private Label labelSacarMercaderia;
        private Button buttonAgregar;
        private Button buttonSacar;
        private Button BotonVolverMenu;
    }
}