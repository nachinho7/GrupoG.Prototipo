namespace GrupoG.Prototipo.Pantallas
{
    partial class PantallaDespacho
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            listView1 = new ListView();
            Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            checkBox1 = new CheckBox();
            button3 = new Button();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "N° Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 66);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "Orden/es de entrega";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(43, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(138, 109);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(472, 492);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 5;
            button1.Text = "Generar Remito";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Mercaderia, Cantidad });
            listView1.Location = new Point(260, 84);
            listView1.Name = "listView1";
            listView1.Size = new Size(319, 119);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Mercaderia
            // 
            Mercaderia.Text = "Mercaderia";
            Mercaderia.Width = 80;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 66);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Mercaderia";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 331);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 389);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 331);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 10;
            label6.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 389);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 11;
            label7.Text = "Patente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 349);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 407);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(95, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(203, 349);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(95, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(203, 407);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(95, 23);
            textBox5.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(378, 410);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Habilitado?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(378, 365);
            button3.Name = "button3";
            button3.Size = new Size(87, 39);
            button3.TabIndex = 20;
            button3.Text = "Buscar Transportista";
            button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 206);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 21;
            label8.Text = "Datos Adicionales";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(40, 234);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(539, 79);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(348, 495);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 24;
            button2.Text = "Limpiar Datos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(10, 496);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 25;
            button4.Text = "Volver al Menú";
            button4.UseVisualStyleBackColor = true;
            // 
            // PantallaDespacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 545);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(checkBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PantallaDespacho";
            Text = "Orden de Despacho";
            Load += PantallaDespacho_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListBox listBox1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Mercaderia;
        private ColumnHeader Cantidad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private Button button3;
        private Label label8;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button4;
    }
}