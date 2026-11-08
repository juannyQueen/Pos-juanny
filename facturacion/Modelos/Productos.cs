using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Modelos
{
    internal class Productos
    {
        public int IdProducto{ get; set; }
        public string Descripcion { get; set; } = "";
        public int Stock{ get; set; } = 0;
        
    }
}
