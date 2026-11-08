namespace facturacion
{
    partial class ProductoFRM
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
            BuscarProdBTN = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Descripcion = new Label();
            Precio = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // BuscarProdBTN
            // 
            BuscarProdBTN.Location = new Point(550, 15);
            BuscarProdBTN.Name = "BuscarProdBTN";
            BuscarProdBTN.Size = new Size(112, 34);
            BuscarProdBTN.TabIndex = 1;
            BuscarProdBTN.Text = "Buscar";
            BuscarProdBTN.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(397, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 291);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(28, 233);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(104, 25);
            Descripcion.TabIndex = 5;
            Descripcion.Text = "Descripcion";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(39, 297);
            Precio.Name = "Precio";
            Precio.Size = new Size(60, 25);
            Precio.TabIndex = 6;
            Precio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 7;
            label1.Text = "ID producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 357);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 10;
            label3.Text = "Cantidad";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(149, 351);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(28, 92);
            button1.Name = "button1";
            button1.Size = new Size(112, 70);
            button1.TabIndex = 12;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(441, 92);
            button2.Name = "button2";
            button2.Size = new Size(112, 70);
            button2.TabIndex = 13;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(170, 92);
            button3.Name = "button3";
            button3.Size = new Size(112, 70);
            button3.TabIndex = 14;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(307, 92);
            button4.Name = "button4";
            button4.Size = new Size(112, 70);
            button4.TabIndex = 15;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(588, 92);
            button5.Name = "button5";
            button5.Size = new Size(112, 70);
            button5.TabIndex = 16;
            button5.Text = "Guardar";
            button5.UseVisualStyleBackColor = true;
            // 
            // ProductoFRM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(974, 552);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Precio);
            Controls.Add(Descripcion);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BuscarProdBTN);
            Name = "ProductoFRM";
            Text = "Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BuscarProdBTN;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Descripcion;
        private Label Precio;
        private Label label1;
        private Label label3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}