namespace facturacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            facturacionBTN = new Button();
            productosBTN = new Button();
            clientesBTN = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(facturacionBTN);
            panel1.Controls.Add(productosBTN);
            panel1.Controls.Add(clientesBTN);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 49);
            panel1.TabIndex = 0;
            // 
            // facturacionBTN
            // 
            facturacionBTN.BackColor = Color.White;
            facturacionBTN.Dock = DockStyle.Left;
            facturacionBTN.Location = new Point(240, 0);
            facturacionBTN.Name = "facturacionBTN";
            facturacionBTN.Size = new Size(112, 49);
            facturacionBTN.TabIndex = 2;
            facturacionBTN.Text = "facturacion";
            facturacionBTN.UseVisualStyleBackColor = false;
            facturacionBTN.Click += facturacionBTN_Click;
            // 
            // productosBTN
            // 
            productosBTN.BackColor = Color.White;
            productosBTN.Dock = DockStyle.Left;
            productosBTN.Location = new Point(128, 0);
            productosBTN.Name = "productosBTN";
            productosBTN.Size = new Size(112, 49);
            productosBTN.TabIndex = 1;
            productosBTN.Text = "productos";
            productosBTN.UseVisualStyleBackColor = false;
            productosBTN.Click += productosBTN_Click;
            // 
            // clientesBTN
            // 
            clientesBTN.BackColor = Color.White;
            clientesBTN.Dock = DockStyle.Left;
            clientesBTN.Location = new Point(0, 0);
            clientesBTN.Name = "clientesBTN";
            clientesBTN.Size = new Size(128, 49);
            clientesBTN.TabIndex = 0;
            clientesBTN.Text = "clientes";
            clientesBTN.UseVisualStyleBackColor = false;
            clientesBTN.Click += clientesBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "JuannyPos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button clientesBTN;
        private Button facturacionBTN;
        private Button productosBTN;
    }
}
