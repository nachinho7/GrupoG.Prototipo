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
            labelSeleccioneEstado.Location = new Point(22, 24);
            labelSeleccioneEstado.Name = "labelSeleccioneEstado";
            labelSeleccioneEstado.Size = new Size(129, 20);
            labelSeleccioneEstado.TabIndex = 0;
            labelSeleccioneEstado.Text = "Seleccione Estado";
            // 
            // comboBoxEstados
            // 
            comboBoxEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstados.FormattingEnabled = true;
            comboBoxEstados.Location = new Point(22, 48);
            comboBoxEstados.Margin = new Padding(3, 4, 3, 4);
            comboBoxEstados.Name = "comboBoxEstados";
            comboBoxEstados.Size = new Size(312, 28);
            comboBoxEstados.TabIndex = 1;
            comboBoxEstados.SelectedIndexChanged += comboBoxEstados_SelectedIndexChanged;
            // 
            // listViewConsultaEstados
            // 
            listViewConsultaEstados.Columns.AddRange(new ColumnHeader[] { numeroOrden, numeroCliente });
            listViewConsultaEstados.GridLines = true;
            listViewConsultaEstados.Location = new Point(22, 84);
            listViewConsultaEstados.Margin = new Padding(3, 4, 3, 4);
            listViewConsultaEstados.Name = "listViewConsultaEstados";
            listViewConsultaEstados.Size = new Size(921, 266);
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
            groupBoxEstados.Location = new Point(14, 16);
            groupBoxEstados.Margin = new Padding(3, 4, 3, 4);
            groupBoxEstados.Name = "groupBoxEstados";
            groupBoxEstados.Padding = new Padding(3, 4, 3, 4);
            groupBoxEstados.Size = new Size(949, 435);
            groupBoxEstados.TabIndex = 3;
            groupBoxEstados.TabStop = false;
            groupBoxEstados.Text = "Busque por Estados";
            // 
            // ClearEstados
            // 
            ClearEstados.Location = new Point(22, 358);
            ClearEstados.Margin = new Padding(3, 4, 3, 4);
            ClearEstados.Name = "ClearEstados";
            ClearEstados.Size = new Size(312, 61);
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
            groupBoxOrden.Location = new Point(14, 473);
            groupBoxOrden.Margin = new Padding(3, 4, 3, 4);
            groupBoxOrden.Name = "groupBoxOrden";
            groupBoxOrden.Padding = new Padding(3, 4, 3, 4);
            groupBoxOrden.Size = new Size(949, 195);
            groupBoxOrden.TabIndex = 4;
            groupBoxOrden.TabStop = false;
            groupBoxOrden.Text = "Busque por Orden";
            // 
            // BuscarOrden
            // 
            BuscarOrden.Location = new Point(189, 138);
            BuscarOrden.Margin = new Padding(3, 4, 3, 4);
            BuscarOrden.Name = "BuscarOrden";
            BuscarOrden.Size = new Size(145, 49);
            BuscarOrden.TabIndex = 5;
            BuscarOrden.Text = "Buscar";
            BuscarOrden.UseVisualStyleBackColor = true;
            BuscarOrden.Click += BuscarOrden_Click;
            // 
            // ClearOrden
            // 
            ClearOrden.Location = new Point(359, 138);
            ClearOrden.Margin = new Padding(3, 4, 3, 4);
            ClearOrden.Name = "ClearOrden";
            ClearOrden.Size = new Size(145, 49);
            ClearOrden.TabIndex = 4;
            ClearOrden.Text = "Limpiar Datos";
            ClearOrden.UseVisualStyleBackColor = true;
            ClearOrden.Click += ClearOrden_Click;
            // 
            // textBoxEstadoOrden
            // 
            textBoxEstadoOrden.Location = new Point(189, 88);
            textBoxEstadoOrden.Margin = new Padding(3, 4, 3, 4);
            textBoxEstadoOrden.Name = "textBoxEstadoOrden";
            textBoxEstadoOrden.ReadOnly = true;
            textBoxEstadoOrden.Size = new Size(362, 27);
            textBoxEstadoOrden.TabIndex = 3;
            // 
            // labelEstadoOrden
            // 
            labelEstadoOrden.AutoSize = true;
            labelEstadoOrden.Location = new Point(40, 92);
            labelEstadoOrden.Name = "labelEstadoOrden";
            labelEstadoOrden.Size = new Size(120, 20);
            labelEstadoOrden.TabIndex = 2;
            labelEstadoOrden.Text = "Estado de Orden";
            // 
            // labelOrden
            // 
            labelOrden.AutoSize = true;
            labelOrden.Location = new Point(40, 45);
            labelOrden.Name = "labelOrden";
            labelOrden.Size = new Size(123, 20);
            labelOrden.TabIndex = 1;
            labelOrden.Text = "Ingrese Nº Orden";
            // 
            // textBoxOrden
            // 
            textBoxOrden.Location = new Point(189, 38);
            textBoxOrden.Margin = new Padding(3, 4, 3, 4);
            textBoxOrden.Name = "textBoxOrden";
            textBoxOrden.Size = new Size(362, 27);
            textBoxOrden.TabIndex = 0;
            // 
            // BotonVolverMenu
            // 
            BotonVolverMenu.Location = new Point(802, 676);
            BotonVolverMenu.Margin = new Padding(3, 4, 3, 4);
            BotonVolverMenu.Name = "BotonVolverMenu";
            BotonVolverMenu.Size = new Size(155, 51);
            BotonVolverMenu.TabIndex = 11;
            BotonVolverMenu.Text = "Volver al Menú";
            BotonVolverMenu.UseVisualStyleBackColor = true;
            BotonVolverMenu.Click += BotonVolverMenu_Click;
            // 
            // PantallaConsultaEstados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 740);
            Controls.Add(BotonVolverMenu);
            Controls.Add(groupBoxOrden);
            Controls.Add(groupBoxEstados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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