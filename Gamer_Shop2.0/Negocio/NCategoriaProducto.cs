using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Negocio
{
    internal class NCategoriaProducto
    {
      
            DCategoriaProducto dCategoriaProducto = new DCategoriaProducto();
            public void NAgregarCategoria(string nombre_cat)
            {

                Categoría_producto categoría = new Categoría_producto()
                {
                    Nombre_Categoria = nombre_cat
                };

                if (dCategoriaProducto == null)
                {
                    throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
                }
                else
                {
                    dCategoriaProducto.DAgregarCategoria(categoría);
                }
            }

        public List<Datos.DataSet1.Categoría_productoRow> getCategorías()
        {
            if (dCategoriaProducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dCategoriaProducto.getCategorias();
            }
        }

            public Categoría_producto GetCategoria(int id)
            {
                if (dCategoriaProducto == null)
                {
                    throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
                }
                else
                {
                    return dCategoriaProducto.getCategoria(id);
                }
            }

        
    }
}
