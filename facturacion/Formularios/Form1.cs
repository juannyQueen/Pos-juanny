namespace facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void facturacionBTN_Click(object sender, EventArgs e)
        {
            FacturacionFRM ventana = new FacturacionFRM();
            ventana.Show();
        }

        private void clientesBTN_Click(object sender, EventArgs e)
        {
            ClientesFrm ventana = new ClientesFrm();
            ventana.Show();
        }

        private void productosBTN_Click(object sender, EventArgs e)
        {
            ProductoFRM ventana = new ProductoFRM();
            ventana.Show();
        }
    }
}
