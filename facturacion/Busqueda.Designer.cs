namespace facturacion
{
    partial class BusquedaFRM
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
            textBox1 = new TextBox();
            DataGridBuscador = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridBuscador).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(566, 31);
            textBox1.TabIndex = 0;
            // 
            // DataGridBuscador
            // 
            DataGridBuscador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridBuscador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridBuscador.Columns.AddRange(new DataGridViewColumn[] { nombre, Telefono, Direccion });
            DataGridBuscador.Location = new Point(12, 73);
            DataGridBuscador.Name = "DataGridBuscador";
            DataGridBuscador.RowHeadersWidth = 62;
            DataGridBuscador.Size = new Size(776, 333);
            DataGridBuscador.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            // 
            // BusquedaFRM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridBuscador);
            Controls.Add(textBox1);
            Name = "BusquedaFRM";
            Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)DataGridBuscador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView DataGridBuscador;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
    }
}