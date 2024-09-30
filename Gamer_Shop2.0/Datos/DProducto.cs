using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Datos.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamer_Shop2._0.Excepciones;

namespace Gamer_Shop2._0.Datos
{
    internal class DProducto
    {
        public bool ExisteRegistro (Producto producto)
        { 
           DataSet1TableAdapters.ProductoTableAdapter adapter = new DataSet1TableAdapters.ProductoTableAdapter();
           if  (adapter.ExisteProductoPorSerial(producto.Serial) > 0) return true;
           else return false;
        }


        public void DAgregarProducto(Producto producto)
        {
            if (ExisteRegistro(producto) == true)
            {
             throw new ExisteRegistroException();
            } else { 
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                { 
                context.Producto.Add(producto);
                context.SaveChanges();
                }
            } 
        }
    }
}
