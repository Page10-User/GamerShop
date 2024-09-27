using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer_Shop2._0.Negocio
{
    internal class Producto
    {
        public int ID_Producto { get; set; }
        public int Serial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public float Precio { get; set; }
        public int ID_Categoria { get; set; }

        
    }
}
