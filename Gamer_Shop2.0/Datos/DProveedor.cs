using Gamer_Shop2._0.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DProveedor
    {
        DataSet1TableAdapters.ProveedorTableAdapter adapter = new DataSet1TableAdapters.ProveedorTableAdapter();

        public bool ExisteRegistro(Proveedor prov)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteProveedorPorRazonSocial(prov.Razon_social) > 0) return true;
                else return false;

            }
        }

        public bool ExisteRegistro(int id)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if ((context.Proveedor.FirstOrDefault(p => p.ID_Proveedor == id) != null)) return true;
                else return false;

            }
        }

        public bool ExisteRegistro(string razon_social)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteProveedorPorRazonSocial(razon_social) > 0) return true;
                    else return false;

                }
            }
        }
        public Proveedor getProveedor(string razon)
        {
            if (ExisteRegistro(razon) == false)
            {
                throw new ExisteRegistroException("El producto no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if ((context.Proveedor.FirstOrDefault(p => p.Razon_social == razon)).Activo == "SI")
                    {
                        return context.Proveedor.FirstOrDefault(p => p.Razon_social == razon);
                    }
                    else
                    {
                        throw new Exception("El producto fue eliminado");
                    }
                }
            }
        }

        public Proveedor getProveedor(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("El producto no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    return context.Proveedor.FirstOrDefault(p => p.ID_Proveedor == id);
                }
            }
        }

        public DataTable getProveedores(DataGridView grid)
        {
            if (grid == null)
            {
                throw new NullReferenceException("Error al cargar la tabla");
            }
            else
            {
                DProveedores proveedores = new DProveedores();
                return proveedores.GetProveedoresAll();
            }
        }

        public void getProveedoresInactivos(DataGridView grid)
        {
            if (grid == null)
            {
                throw new NullReferenceException("Error al cargar la tabla");
            }
            else
            {
                DProveedores proveedores = new DProveedores();
                DataView view = new DataView(proveedores.GetProveedoresAll());
                view.RowFilter = "Activo = 'NO'";
                grid.DataSource = view;



            }
        }

        public void DAgregarProveedor(Proveedor prov)
        {
            if (ExisteRegistro(prov) == true)
            {
                throw new ExisteRegistroException("El producto ya existe.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Proveedor.Add(prov);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al guardar el producto: {ex.Message}");
                    }
                }
            }
        }

        public void DModificarProveedor(string razonactual, Proveedor prov)
        {
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (ExisteRegistro(razonactual) == false)
                {
                    throw new ExisteRegistroException("El producto no existe");
                }
                else
                {
                    try
                    {
                        Proveedor proveedor = context.Proveedor.First(p => p.Razon_social == razonactual);

                        proveedor.Razon_social= prov.Razon_social;
                        proveedor.Nombre_representante = prov.Nombre_representante;
                        proveedor.Telefono = prov.Telefono;
                        proveedor.Dirección = prov.Dirección;
                        proveedor.Correo = prov.Correo;
                        proveedor.ID_CategoriaProducto = prov.ID_CategoriaProducto;
                        proveedor.Activo = prov.Activo;

                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al modificar el producto: {ex.Message}");
                    }
                }
            }
        }

        public void DEliminarProveedor(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("El producto no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        Proveedor proveedor = context.Proveedor.First(p => p.ID_Proveedor == id);

                        proveedor.Activo = "NO";
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

