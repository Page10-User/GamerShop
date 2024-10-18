using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Excepciones;

namespace Gamer_Shop2._0.Negocio
{
    internal class NProducto
    {
        DProducto dproducto = new DProducto();
        public void NAgregarProducto(int serial, string nombre, string descripcion, int stock, string activo, float precio, int categoria, int proveedor)
        {
           
                Producto nuevoProducto = new Producto()
                {
                    Serial = serial,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Stock = stock,
                    Activo = activo,
                    Precio = precio,
                    ID_Categoria = categoria,
                    ID_Proveedor = proveedor
                };

            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.DAgregarProducto(nuevoProducto);
            }
        }

        public void listaProductosActivos (DataGridView grid)
        {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.getProductosActivos(grid);
            }
        }

        public void NModificarProducto (int serial, string nombre, string descripcion, float precio, int categoria, int proveedor)
        {
            Producto producto = new Producto()
            {
                Serial = serial,
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                ID_Categoria = categoria,
                ID_Proveedor = proveedor
            };
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.DModificarProducto(producto);
            }
        }

        public Producto GetProducto(int serial) {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dproducto.getProducto(serial);
            }
        }

        public void NEliminarProducto(int serial)
        {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.DEliminarProducto(serial);
            }
        }
    }
}
