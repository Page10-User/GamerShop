using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Gamer_Shop2._0.Excepciones;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DProducto
    {
        DataSet1TableAdapters.ProductoTableAdapter adapter = new DataSet1TableAdapters.ProductoTableAdapter();

        public bool ExisteRegistro (Producto producto)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteProductoPorSerial(producto.Serial) > 0) return true;
                else return false;

            }
        }

        public bool ExisteRegistro(int serial)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteProductoPorSerial(serial) > 0) return true;
                    else return false;

                }
            }
        }

        public Producto getProducto(int serial)
        {
            if (ExisteRegistro(serial) == false)
            {
                throw new ExisteRegistroException("El producto no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if ((context.Producto.FirstOrDefault(p => p.Serial == serial)).Activo == "SI")
                    {
                        return context.Producto.FirstOrDefault(p => p.Serial == serial);
                    } else
                    {
                        throw new Exception("El producto fue eliminado");
                    }
                }
            }
        }

        public void getProductosActivos(DataGridView grid)
        {
            if (grid == null)
            {
                throw new NullReferenceException("Error al cargar la tabla");
            }
            else
            {
                DProductos productos = new DProductos();
                DataView view = new DataView(productos.GetProductoAll());
                view.RowFilter = "Activo = 'SI'";
                grid.DataSource = view;

                
            
            }
        }

        public void getProductosInactivos(DataGridView grid)
        {
            if (grid == null)
            {
                throw new NullReferenceException("Error al cargar la tabla");
            }
            else
            {
                DProductos productos = new DProductos();
                DataView view = new DataView(productos.GetProductoAll());
                view.RowFilter = "Activo = 'NO'";
                grid.DataSource = view;



            }
        }

        public void DAgregarProducto(Producto producto)
        {
            if (ExisteRegistro(producto) == true)
            {
             throw new ExisteRegistroException("El producto ya existe.");
            } else { 
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Producto.Add(producto);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al guardar el producto: {ex.Message}");
                    }
                }
            } 
        }

        public void DModificarProducto(Producto producto)
        {
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (ExisteRegistro(producto) == false)
                {
                    throw new ExisteRegistroException("El producto no existe");
                }
                else
                {
                    try
                    {
                        Producto prod = context.Producto.First(p => p.Serial == producto.Serial);

                        prod.Serial = producto.Serial;
                        prod.Nombre = producto.Nombre;
                        prod.Precio = producto.Precio;
                        prod.Descripcion = producto.Descripcion;
                        prod.Categoría_producto = producto.Categoría_producto;
                        prod.Proveedor = producto.Proveedor;
                        prod.photoFilePath = producto.photoFilePath;

                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al modificar el producto: {ex.Message}");
                    }
                }
            }
        }

        public void DEliminarProducto(int serial)
        {
            if (ExisteRegistro(serial) == false)
            {
                throw new ExisteRegistroException("El producto no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        Producto prod = context.Producto.First(p => p.Serial == serial);

                        prod.Activo = "NO";
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al eliminar el producto: {ex.Message}");
                    }
                }
            }
        }
        //   //----------------------------------------------------------------------------------\\
        //  //------------------------------------------------------------------------------------\\
        //  ||                  Método para obtener todos los productos de la tabla               ||
        //  \\------------------------------------------------------------------------------------//
        //   \\----------------------------------------------------------------------------------//
        public class ProductoViewModel
        {
            public int Serial { get; set; }
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public string Categoria { get; set; }
        }

        public List<ProductoViewModel> ObtenerTodosLosProductos()
        {
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                try
                {
                    // Consulta con LINQ para obtener todos los productos
                    List<ProductoViewModel> productos = context.Producto
                        .Where(p => p.Activo == "SI")
                        .Select(p => new ProductoViewModel
                        {
                            Serial = p.Serial,
                            Nombre = p.Nombre,
                            Precio = p.Precio,
                            Categoria = p.Categoría_producto.Nombre_Categoria
                        })
                        .ToList();

                    return productos;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al obtener productos: {ex.Message}");
                }
            }
        }
        public ProductoViewModel getProductoCr(int serial)
        {
            // Verifica si el producto existe y está activo
            if (ExisteRegistro(serial) == false)
            {
                throw new ExisteRegistroException("El producto no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    // Consulta para obtener solo las propiedades necesarias
                    var producto = context.Producto
                        .Where(p => p.Serial == serial && p.Activo == "SI")
                        .Select(p => new ProductoViewModel
                        {
                            Serial = p.Serial,
                            Nombre = p.Nombre,
                            Precio = p.Precio,
                            Categoria = p.Categoría_producto.Nombre_Categoria
                        })
                        .FirstOrDefault();

                    if (producto == null)
                    {
                        throw new Exception("El producto fue eliminado o no está activo");
                    }

                    return producto;
                }
            }
        }

    }
}
