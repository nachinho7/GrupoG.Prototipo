namespace GrupoG.Prototipo.Extra.Estados
{
    partial class PantallaConsultaEstados
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
            labelSeleccioneEstado = new Label();
            comboBoxEstados = new ComboBox();
            listViewConsultaEstados = new ListView();
            numeroOrden = new ColumnHeader();
            numeroCliente = new ColumnHeader();
            groupBoxEstados = new GroupBox();
            ClearEstados = new Button();
            groupBoxOrden = new GroupBox();
            BuscarOrden = new Button();
            ClearOrden = new Button();
            textBoxEstadoOrden = new TextBox();
            labelEstadoOrden = new Label();
            labelOrden = new Label();
            textBoxOrden = new TextBox();
            BotonVolverMenu = new Button();
            groupBoxEstados.SuspendLayout();
            groupBoxOrden.SuspendLayout();
            SuspendLayout();
            // 
            // labelSeleccioneEstado
            // 
            labelSeleccioneEstado.AutoSize = true;
            labelSeleccioneEstado.Location = new Point(19, 37);
            labelSeleccioneEstado.Name = "labelSeleccioneEstado";
            labelSeleccioneEstado.Size = new Size(101, 15);
            labelSeleccioneEstado.TabIndex = 0;
            labelSeleccioneEstado.Text = "Seleccione Estado";
            // 
            // comboBoxEstados
            // 
            comboBoxEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstados.FormattingEnabled = true;
            comboBoxEstados.Location = new Point(126, 34);
            comboBoxEstados.Name = "comboBoxEstados";
            comboBoxEstados.Size = new Size(121, 23);
            comboBoxEstados.TabIndex = 1;
            comboBoxEstados.SelectedIndexChanged += comboBoxEstados_SelectedIndexChanged;
            // 
            // listViewConsultaEstados
            // 
            listViewConsultaEstados.Columns.AddRange(new ColumnHeader[] { numeroOrden, numeroCliente });
            listViewConsultaEstados.GridLines = true;
            listViewConsultaEstados.Location = new Point(19, 63);
            listViewConsultaEstados.Name = "listViewConsultaEstados";
            listViewConsultaEstados.Size = new Size(307, 223);
            listViewConsultaEstados.TabIndex = 2;
            listViewConsultaEstados.UseCompatibleStateImageBehavior = false;
            listViewConsultaEstados.View = View.Details;
            // 
            // numeroOrden
            // 
            numeroOrden.Text = "Nº Orden";
            numeroOrden.Width = 150;
            // 
            // numeroCliente
            // 
            numeroCliente.Text = "Nº Cliente";
            numeroCliente.Width = 150;
            // 
            // groupBoxEstados
            // 
            groupBoxEstados.Controls.Add(ClearEstados);
            groupBoxEstados.Controls.Add(listViewConsultaEstados);
            groupBoxEstados.Controls.Add(labelSeleccioneEstado);
            groupBoxEstados.Controls.Add(comboBoxEstados);
            groupBoxEstados.Location = new Point(12, 12);
            groupBoxEstados.Name = "groupBoxEstados";
            groupBoxEstados.Size = new Size(344, 326);
            groupBoxEstados.TabIndex = 3;
            groupBoxEstados.TabStop = false;
            groupBoxEstados.Text = "Busque por Estados";
            // 
            // ClearEstados
            // 
            ClearEstados.Location = new Point(199, 292);
            ClearEstados.Name = "ClearEstados";
            ClearEstados.Size = new Size(127, 23);
            ClearEstados.TabIndex = 3;
            ClearEstados.Text = "Limpiar Datos";
            ClearEstados.UseVisualStyleBackColor = true;
            ClearEstados.Click += ClearEstados_Click;
            // 
            // groupBoxOrden
            // 
            groupBoxOrden.Controls.Add(BuscarOrden);
            groupBoxOrden.Controls.Add(ClearOrden);
            groupBoxOrden.Controls.Add(textBoxEstadoOrden);
            groupBoxOrden.Controls.Add(labelEstadoOrden);
            groupBoxOrden.Controls.Add(labelOrden);
            groupBoxOrden.Controls.Add(textBoxOrden);
            groupBoxOrden.Location = new Point(12, 355);
            groupBoxOrden.Name = "groupBoxOrden";
            groupBoxOrden.Size = new Size(344, 135);
            groupBoxOrden.TabIndex = 4;
            groupBoxOrden.TabStop = false;
            groupBoxOrden.Text = "Busque por Orden";
            // 
            // BuscarOrden
            // 
            BuscarOrden.Location = new Point(165, 106);
            BuscarOrden.Name = "BuscarOrden";
            BuscarOrden.Size = new Size(68, 23);
            BuscarOrden.TabIndex = 5;
            BuscarOrden.Text = "Buscar";
            BuscarOrden.UseVisualStyleBackColor = true;
            BuscarOrden.Click += BuscarOrden_Click;
            // 
            // ClearOrden
            // 
            ClearOrden.Location = new Point(243, 106);
            ClearOrden.Name = "ClearOrden";
            ClearOrden.Size = new Size(95, 23);
            ClearOrden.TabIndex = 4;
            ClearOrden.Text = "Limpiar Datos";
            ClearOrden.UseVisualStyleBackColor = true;
            ClearOrden.Click += ClearOrden_Click;
            // 
            // textBoxEstadoOrden
            // 
            textBoxEstadoOrden.Location = new Point(165, 66);
            textBoxEstadoOrden.Name = "textBoxEstadoOrden";
            textBoxEstadoOrden.ReadOnly = true;
            textBoxEstadoOrden.Size = new Size(146, 23);
            textBoxEstadoOrden.TabIndex = 3;
            // 
            // labelEstadoOrden
            // 
            labelEstadoOrden.AutoSize = true;
            labelEstadoOrden.Location = new Point(35, 69);
            labelEstadoOrden.Name = "labelEstadoOrden";
            labelEstadoOrden.Size = new Size(94, 15);
            labelEstadoOrden.TabIndex = 2;
            labelEstadoOrden.Text = "Estado de Orden";
            // 
            // labelOrden
            // 
            labelOrden.AutoSize = true;
            labelOrden.Location = new Point(35, 34);
            labelOrden.Name = "labelOrden";
            labelOrden.Size = new Size(98, 15);
            labelOrden.TabIndex = 1;
            labelOrden.Text = "Ingrese Nº Orden";
            // 
            // textBoxOrden
            // 
            textBoxOrden.Location = new Point(165, 31);
            textBoxOrden.Name = "textBoxOrden";
            textBoxOrden.Size = new Size(146, 23);
            textBoxOrden.TabIndex = 0;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(220, 505);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(136, 38);
            BotonVolverMenu.TabIndex = 11;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            BotonVolverMenu.Click += BotonVolverMenu_Click;
            // 
            // PantallaConsultaEstados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 555);
            Controls.Add(BotonVolverMenu);
            Controls.Add(groupBoxOrden);
            Controls.Add(groupBoxEstados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PantallaConsultaEstados";
            Text = " ";
            groupBoxEstados.ResumeLayout(false);
            groupBoxEstados.PerformLayout();
            groupBoxOrden.ResumeLayout(false);
            groupBoxOrden.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelSeleccioneEstado;
        private ComboBox comboBoxEstados;
        private ListView listViewConsultaEstados;
        private ColumnHeader numeroOrden;
        private ColumnHeader numeroCliente;
        private GroupBox groupBoxEstados;
        private GroupBox groupBoxOrden;
        private Label labelOrden;
        private TextBox textBoxOrden;
        private TextBox textBoxEstadoOrden;
        private Label labelEstadoOrden;
        private Button ClearEstados;
        private Button ClearOrden;
        private Button BotonVolverMenu;
        private Button BuscarOrden;
    }
}