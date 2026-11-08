using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using facturacion.Conexion;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using static facturacion.Conexion.Conexion;


namespace facturacion.Controladores
{
    internal class Controles
    {
        public void Crear(Button BotonInabilitar, TextBox BarritaID, Button ModificarInabilitar, Button BorrarInabilitar)
        {
            BotonInabilitar.Enabled = false;
            BarritaID.Enabled = false;
            ModificarInabilitar.Enabled = false;
            BorrarInabilitar.Enabled = false;

        }

        public void Modificar(Button BotonInabilitar, TextBox BarritaID, Button CancelarInabilitar)
        {
            BotonInabilitar.Enabled = false;
            BarritaID.Enabled = false;
            CancelarInabilitar.Enabled = false;


        }
        public void Traer(Panel Agrupador, TextBox BarritaID) {


            try
            {
                if (BarritaID.Text != null)
                {

                    //string GuardarID = BarritaID.Text;

                    Conexion.Conexion.CConexion Conexxion = new Conexion.Conexion.CConexion();

                    MySqlConnection AbrirConexion= new MySqlConnection();
                    AbrirConexion = Conexxion.estableceConexion();
                    
                    MySqlCommand consulta = new MySqlCommand("SELECT Nombre, Telefono, Direccion FROM Cliente WHERE IDcliente = @id");
                    consulta.Parameters.AddWithValue("@id", BarritaID.Text);
                    consulta.Connection = AbrirConexion;
                    MySqlDataAdapter Traedor = new MySqlDataAdapter(consulta);
                    DataTable tabla = new DataTable();
                    Traedor.Fill(tabla);
                    DataRow fila = tabla.Rows[0];
                    foreach (Control row in Agrupador.Controls)
                    {
                        if (row is TextBox texto)
                        {
                            string columna = texto.Tag?.ToString();

                            if (!string.IsNullOrWhiteSpace(columna)
                            && tabla.Columns.Contains(columna))
                            {
                                texto.Text = fila[columna].ToString();
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha pasado:" + e);
            }


                //string consulta = "SELECT Nombre, Telefono, Direccion FROM cliente WHERE IdCliente = @id";





            }
        


        public void LimpiarSI(Panel Agrupador)
        {
            foreach (Control control in Agrupador.Controls)
            {
                if (control is TextBox texto)
                {
                    texto.Clear();
                }
            }
        }

        public void Guardar(Panel Agrupador,Panel Agrupador2, MySqlCommand consulta, params MySqlParameter[] parametros)
        {
            {
                try
                {
                    Conexion.Conexion.CConexion conexion = new Conexion.Conexion.CConexion();


                    consulta.Parameters.AddRange(parametros);
                    consulta.Connection = conexion.estableceConexion();
                    consulta.ExecuteNonQuery();
                    foreach (Control control in Agrupador.Controls)
                    {
                        if (control is TextBox texto)
                        {
                            texto.Clear();
                            texto.Enabled = true;
                        }
                        foreach (Control controll in Agrupador2.Controls)
                         {
                             if (controll is Button boton)
                             {
                                 boton.Enabled = true;
                             }

                         }
                        


                    }  
                }
                catch (Exception e)
                {

                    MessageBox.Show("Esto paso:" + e);
                }
                

                }
            }
        }
    }



