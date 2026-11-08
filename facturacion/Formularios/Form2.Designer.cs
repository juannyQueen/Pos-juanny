namespace facturacion
{
    partial class ClientesFrm
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
            CrearClienteBTN = new Button();
            BorrarClienteBTN = new Button();
            ModificarClienteBTN = new Button();
            BuscarClienteBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextNombreCliente = new TextBox();
            TextTelefono = new TextBox();
            TextDireccionCliente = new TextBox();
            IDcliente = new TextBox();
            CancelarClienteBTN = new Button();
            PanelClientes = new Panel();
            TraerClienteBTN = new Button();
            guardarClienteBTN = new Button();
            PanelClienteMenu = new Panel();
            PanelClientes.SuspendLayout();
            PanelClienteMenu.SuspendLayout();
            SuspendLayout();
            // 
            // CrearClienteBTN
            // 
            CrearClienteBTN.BackColor = Color.White;
            CrearClienteBTN.Location = new Point(10, 3);
            CrearClienteBTN.Name = "CrearClienteBTN";
            CrearClienteBTN.Size = new Size(112, 55);
            CrearClienteBTN.TabIndex = 0;
            CrearClienteBTN.Text = "Crear";
            CrearClienteBTN.UseVisualStyleBackColor = false;
            CrearClienteBTN.Click += CrearClienteBTN_Click;
            // 
            // BorrarClienteBTN
            // 
            BorrarClienteBTN.BackColor = Color.White;
            BorrarClienteBTN.Location = new Point(137, 4);
            BorrarClienteBTN.Name = "BorrarClienteBTN";
            BorrarClienteBTN.Size = new Size(112, 55);
            BorrarClienteBTN.TabIndex = 1;
            BorrarClienteBTN.Text = "Borrar";
            BorrarClienteBTN.UseVisualStyleBackColor = false;
            BorrarClienteBTN.Click += BorrarClienteBTN_Click;
            // 
            // ModificarClienteBTN
            // 
            ModificarClienteBTN.BackColor = Color.White;
            ModificarClienteBTN.Location = new Point(275, 4);
            ModificarClienteBTN.Name = "ModificarClienteBTN";
            ModificarClienteBTN.Size = new Size(112, 55);
            ModificarClienteBTN.TabIndex = 2;
            ModificarClienteBTN.Text = "Modificar";
            ModificarClienteBTN.UseVisualStyleBackColor = false;
            ModificarClienteBTN.Click += ModificarClienteBTN_Click;
            // 
            // BuscarClienteBTN
            // 
            BuscarClienteBTN.Location = new Point(343, 22);
            BuscarClienteBTN.Name = "BuscarClienteBTN";
            BuscarClienteBTN.Size = new Size(112, 31);
            BuscarClienteBTN.TabIndex = 3;
            BuscarClienteBTN.Text = "Buscar";
            BuscarClienteBTN.UseVisualStyleBackColor = true;
            BuscarClienteBTN.Click += BuscarClienteBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 56);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 107);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 149);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // TextNombreCliente
            // 
            TextNombreCliente.Location = new Point(119, 53);
            TextNombreCliente.Name = "TextNombreCliente";
            TextNombreCliente.Size = new Size(150, 31);
            TextNombreCliente.TabIndex = 8;
            TextNombreCliente.Tag = "Nombre";
            // 
            // TextTelefono
            // 
            TextTelefono.Location = new Point(119, 104);
            TextTelefono.Name = "TextTelefono";
            TextTelefono.Size = new Size(150, 31);
            TextTelefono.TabIndex = 9;
            TextTelefono.Tag = "Telefono";
            // 
            // TextDireccionCliente
            // 
            TextDireccionCliente.Location = new Point(119, 149);
            TextDireccionCliente.Name = "TextDireccionCliente";
            TextDireccionCliente.Size = new Size(150, 31);
            TextDireccionCliente.TabIndex = 10;
            TextDireccionCliente.Tag = "Direccion";
            // 
            // IDcliente
            // 
            IDcliente.Location = new Point(119, 19);
            IDcliente.Name = "IDcliente";
            IDcliente.Size = new Size(150, 31);
            IDcliente.TabIndex = 11;
            IDcliente.TextChanged += textBox4_TextChanged;
            // 
            // CancelarClienteBTN
            // 
            CancelarClienteBTN.BackColor = Color.White;
            CancelarClienteBTN.Location = new Point(416, 4);
            CancelarClienteBTN.Name = "CancelarClienteBTN";
            CancelarClienteBTN.Size = new Size(112, 55);
            CancelarClienteBTN.TabIndex = 12;
            CancelarClienteBTN.Text = "Cancelar";
            CancelarClienteBTN.UseVisualStyleBackColor = false;
            // 
            // PanelClientes
            // 
            PanelClientes.Controls.Add(TraerClienteBTN);
            PanelClientes.Controls.Add(label3);
            PanelClientes.Controls.Add(label2);
            PanelClientes.Controls.Add(BuscarClienteBTN);
            PanelClientes.Controls.Add(label1);
            PanelClientes.Controls.Add(IDcliente);
            PanelClientes.Controls.Add(label4);
            PanelClientes.Controls.Add(TextNombreCliente);
            PanelClientes.Controls.Add(TextTelefono);
            PanelClientes.Controls.Add(TextDireccionCliente);
            PanelClientes.Location = new Point(30, 142);
            PanelClientes.Name = "PanelClientes";
            PanelClientes.Size = new Size(473, 222);
            PanelClientes.TabIndex = 13;
            // 
            // TraerClienteBTN
            // 
            TraerClienteBTN.Location = new Point(275, 19);
            TraerClienteBTN.Name = "TraerClienteBTN";
            TraerClienteBTN.Size = new Size(62, 34);
            TraerClienteBTN.TabIndex = 12;
            TraerClienteBTN.Text = "Traer";
            TraerClienteBTN.UseVisualStyleBackColor = true;
            TraerClienteBTN.Click += TraerClienteBTN_Click;
            // 
            // guardarClienteBTN
            // 
            guardarClienteBTN.BackColor = Color.White;
            guardarClienteBTN.Location = new Point(558, 4);
            guardarClienteBTN.Name = "guardarClienteBTN";
            guardarClienteBTN.Size = new Size(112, 55);
            guardarClienteBTN.TabIndex = 14;
            guardarClienteBTN.Text = "Guardar";
            guardarClienteBTN.UseVisualStyleBackColor = false;
            guardarClienteBTN.Click += guardarClienteBTN_Click;
            // 
            // PanelClienteMenu
            // 
            PanelClienteMenu.Controls.Add(guardarClienteBTN);
            PanelClienteMenu.Controls.Add(CancelarClienteBTN);
            PanelClienteMenu.Controls.Add(CrearClienteBTN);
            PanelClienteMenu.Controls.Add(ModificarClienteBTN);
            PanelClienteMenu.Controls.Add(BorrarClienteBTN);
            PanelClienteMenu.Location = new Point(12, 0);
            PanelClienteMenu.Name = "PanelClienteMenu";
            PanelClienteMenu.Size = new Size(683, 78);
            PanelClienteMenu.TabIndex = 15;
            // 
            // ClientesFrm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(PanelClienteMenu);
            Controls.Add(PanelClientes);
            Name = "ClientesFrm";
            Text = "Clientes";
            PanelClientes.ResumeLayout(false);
            PanelClientes.PerformLayout();
            PanelClienteMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CrearClienteBTN;
        private Button BorrarClienteBTN;
        private Button ModificarClienteBTN;
        private Button BuscarClienteBTN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TextNombreCliente;
        private TextBox TextTelefono;
        private TextBox TextDireccionCliente;
        private TextBox IDcliente;
        private Button CancelarClienteBTN;
        private Panel PanelClientes;
        private Button guardarClienteBTN;
        private Panel PanelClienteMenu;
        private Button TraerClienteBTN;
    }
}