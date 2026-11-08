using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using facturacion.Controladores;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace facturacion
{
    public partial class ClientesFrm : Form
    {
        public ClientesFrm()
        {
            InitializeComponent();
        }

        private bool modificando = false;

        private void CrearClienteBTN_Click(object sender, EventArgs e)
        {
            Controladores.Controles Creacion = new Controladores.Controles();

            Creacion.Crear(BorrarClienteBTN, IDcliente, ModificarClienteBTN, BorrarClienteBTN);

            Creacion.LimpiarSI(PanelClientes);

            modificando |= false;




        }

        private void BorrarClienteBTN_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarClienteBTN_Click(object sender, EventArgs e)
        {

            if (modificando)
            {
                Controladores.Controles Creacion = new Controladores.Controles();
                MySqlCommand comando = new MySqlCommand("UPDATE cliente SET nombre = @nombre, telefono = @telefono, direccion = @direccion WHERE idCliente = @id");
                Creacion.Guardar(PanelClientes, PanelClienteMenu, comando, new MySqlParameter("@id" , IDcliente));
            }
            else
            {
                Controladores.Controles Creacion = new Controladores.Controles();
                MySqlCommand comando = new MySqlCommand("INSERT INTO cliente (nombre, telefono, direccion) VALUES (@nombre, @telefono, @direccion)");
                Creacion.Guardar(PanelClientes, PanelClienteMenu, comando, new MySqlParameter("@nombre", TextNombreCliente.Text), new MySqlParameter("@telefono", TextTelefono.Text), new MySqlParameter("@direccion", TextDireccionCliente.Text));
            }
        }

        private void ModificarClienteBTN_Click(object sender, EventArgs e)
        {
            Controladores.Controles Creacion = new Controladores.Controles();
            Creacion.Modificar(BorrarClienteBTN, IDcliente, CancelarClienteBTN);
            modificando = true;
            
        }

        private void BuscarClienteBTN_Click(object sender, EventArgs e)
        {
            BusquedaFRM Ventana = new BusquedaFRM();
            Ventana.Show();
        }

        private void TraerClienteBTN_Click(object sender, EventArgs e)
        {
            Controladores.Controles Creacion = new Controladores.Controles();
           
            Creacion.Traer(PanelClientes, IDcliente);
        }
    }
    }

