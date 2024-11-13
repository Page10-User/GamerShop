using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Gamer_Shop2._0.Excepciones;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gamer_Shop2._0.Datos
{
    internal class DProducto
    {
        DataSet1TableAdapters.ProductoTableAdapter adapter = new DataSet1TableAdapters.ProductoTableAdapter();

        public bool ExisteRegistro(Producto producto)
        {
            Debug.WriteLine($" ID=aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaENTRO");
            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                Debug.WriteLine($" ID=aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaRETORNO");
                if (adapter.ExisteProductoPorSerial(producto.Serial) > 0) return true;
                
                else return false;
            }
        }

        public bool ExisteRegistroID(int id)
        {
            Debug.WriteLine($" ID=aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaENTRO");
            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                Debug.WriteLine($" ID=aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaRETORNO");
                if (adapter.ExisteProductoPorID(id) > 0) return true;

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
                    return context.Producto.FirstOrDefault(p => p.Serial == serial);
                }
            }
        }

        public Producto getProductoID(int id)
        {
            if (ExisteRegistroID(id) == false)
            {
                Debug.WriteLine($" ID={id}aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaRETORNO 2");
                throw new ExisteRegistroException("El producto no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if ((context.Producto.FirstOrDefault(p => p.ID_Producto == id)).Activo == "SI")
                    {
                        return context.Producto.FirstOrDefault(p => p.ID_Producto == id);
                        Debug.WriteLine($" ID=aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaRETORN 2O");
                    }
                    else
                    {
                        throw new Exception("El producto fue eliminado");
                    }
                }
            }
        }

        public DataTable getProductosActivos(DataGridView grid)
        {
            if (grid == null)
            {
                throw new NullReferenceException("Error al cargar la tabla");
            }
            else
            {
                DProductos productos = new DProductos();
               

                return productos.GetProductoAll();

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
                        prod.ID_Categoria = producto.ID_Categoria;
                        prod.ID_Proveedor = producto.ID_Proveedor;
                        prod.photoFilePath = producto.photoFilePath;
                        prod.Activo = producto.Activo;

                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al modificar el producto: {ex.Message}");
                    }
                }
            }
        }

        public void DActualizarStock(Producto producto)
        {
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (ExisteRegistroID(producto.ID_Producto) == false)
                {
                    throw new ExisteRegistroException("El producto no existe");
                }
                else
                {
                    try
                    {
                        Producto prod = context.Producto.First(p => p.ID_Producto == producto.ID_Producto);

                        prod.Stock  = producto.Stock;
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al actualizar el stock: {ex.Message}");
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
            public int ID { get; set; } 
            public int Serial { get; set; }
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public string Categoria { get; set; }
            public string photoFilePath { get; set; }
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
                            ID = p.ID_Producto,
                            Serial = p.Serial,
                            Nombre = p.Nombre,
                            Precio = p.Precio,
                            Categoria = p.Categoría_producto.Nombre_Categoria,
                            photoFilePath = p.photoFilePath
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
                            ID = p.ID_Producto,
                            Serial = p.Serial,
                            Nombre = p.Nombre,
                            Precio = p.Precio,
                            Categoria = p.Categoría_producto.Nombre_Categoria,
                            photoFilePath = p.photoFilePath
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

        public void getProductosLista(DataGridView grid, string text, string atributo)
        {
            DProductos dproductos = new DProductos();
            grid.DataSource = dproductos.buscarProductos(text, atributo);
        }
    }
}
