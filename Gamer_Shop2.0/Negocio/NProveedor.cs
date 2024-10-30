using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Negocio
{
    internal class NProveedor
    {

        DProveedor dProveedor = new DProveedor();
        public void NAgregarProveedor(string razon_social, string nomrep, string telefono, string correo, string direccion, int catprod)
        {

            Proveedor proveedor = new Proveedor()
            {
                Razon_social = razon_social,
                Nombre_representante = nomrep,
                Telefono = telefono,
                Correo = correo,
                Dirección = direccion,
                ID_CategoriaProducto = catprod,
                Activo = "SI"
            };

            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproveedor' no se pudo inicializar.");
            }
            else
            {
                dProveedor.DAgregarProveedor(proveedor);
            }
        }

        public void listaProveedoresActivos(DataGridView grid)
        {
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproveedor' no se pudo inicializar.");
            }
            else
            {
                dProveedor.getProveedoresActivos(grid);
            }
        }

        public void listaProveedoresInactivos(DataGridView grid)
        {
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproveedor' no se pudo inicializar.");
            }
            else
            {
                dProveedor.getProveedoresInactivos(grid);
            }
        }

        public void NModificarProveedor(string razonactual, string razonsocial, string nomrep, string telefono, string correo, string direccion, int catprod)
        {
            Proveedor proveedor = new Proveedor()
            {
                Razon_social = razonsocial,
                Nombre_representante = nomrep,
                Telefono = telefono,
                Correo = correo,
                Dirección = direccion,
                ID_CategoriaProducto = catprod
            };
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dProveedor.DModificarProveedor(razonactual, proveedor);
            }
        }

        public Proveedor GetProveedor(int id)
        {
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dProveedor.getProveedor(id);
            }
        }

        public void NEliminarProveedor(int id)
        {
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dProveedor.DEliminarProveedor(id);
            }
        }
    }
}

