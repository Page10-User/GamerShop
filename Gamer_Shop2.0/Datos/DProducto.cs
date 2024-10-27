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
using System.Windows.Forms;
using Gamer_Shop2._0.Formularios.GestionProducto;
using System.DirectoryServices.ActiveDirectory;
using Gamer_Shop2._0.Negocio;
using Gamer_Shop2._0.Properties;
using System.CodeDom;

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
    }
}
