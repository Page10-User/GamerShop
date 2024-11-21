using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable listaProveedores(DataGridView grid)
        {
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproveedor' no se pudo inicializar.");
            }
            else
            {
                return dProveedor.getProveedores(grid);
            }
        }

        public DataTable getProveedoresActivos ()
        {
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproveedor' no se pudo inicializar.");
            }
            else
            {
                return dProveedor.getProveedoresActivos();
            }
        }

        public void NModificarProveedor(string razonactual, string razonsocial, string nomrep, string telefono, string correo, string direccion, int catprod, string activo)
        {
            Proveedor proveedor = new Proveedor()
            {
                Razon_social = razonsocial,
                Nombre_representante = nomrep,
                Telefono = telefono,
                Correo = correo,
                Dirección = direccion,
                ID_CategoriaProducto = catprod,
                Activo = activo
            };
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproveedor' no se pudo inicializar.");
            }
            else
            {
                dProveedor.DModificarProveedor(razonactual, proveedor);
            }
        }

        public Proveedor GetProveedor(string prov)
        {
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproveedor' no se pudo inicializar.");
            }
            else
            {
                return dProveedor.getProveedor(prov);
            }
        }

        public Proveedor GetProveedor(int id)
        {
            if (dProveedor == null)
            {
                throw new NullReferenceException("El objeto 'dproveedor' no se pudo inicializar.");
            }
            else
            {
                return dProveedor.getProveedor(id);
            }
        }

    }
}

