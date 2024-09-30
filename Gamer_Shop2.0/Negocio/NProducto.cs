using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamer_Shop2._0.Datos;

namespace Gamer_Shop2._0.Negocio
{
    internal class NProducto
    {
        public void NAgregarProducto(int serial, string nombre, string descripcion, int stock, float precio, int categoria)
        {
            try
            {
                Producto nuevoProducto = new Producto()
                {
                    Serial = serial,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Stock = stock,
                    Precio = precio,
                    ID_Categoria = categoria
                };

                DProducto dproducto = new DProducto();

                dproducto.DAgregarProducto(nuevoProducto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el producto: {ex.Message}");
            }
            
        }
    }
}
