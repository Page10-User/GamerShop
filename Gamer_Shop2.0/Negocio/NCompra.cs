using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Negocio
{
    internal class NCompra
    {
        DCompra dcompra = new DCompra();
        public void NGuardarCompra(float total, int idusuario, string prov, DataTable detallesCompra)
        {
            NProveedor proveedor = new NProveedor();

            int idproveedor = proveedor.GetProveedor(prov).ID_Proveedor;
            Debug.WriteLine(idproveedor);
            Compra compra = new Compra()
            {
                Fecha = DateTime.Today,
                Total = total,
                ID_Usuario = idusuario,
                ID_Proveedor = idproveedor
            };

            if (dcompra == null)
            {
                throw new NullReferenceException("El objeto 'dcompra' no se pudo inicializar.");
            }
            else
            {
                dcompra.DGuardarCompra(compra, detallesCompra);
            }
        }

        public void getCompras(DataGridView grid)
        {
            if (dcompra == null)
            {
                throw new NullReferenceException("El objeto 'dcompra' no se pudo inicializar.");
            }
            else
            {
                dcompra.getCompras(grid);
            }
        }

        public Compra GetCompra(int id)
        {
            if (dcompra == null)
            {
                throw new NullReferenceException("El objeto 'dcompra' no se pudo inicializar.");
            }
            else
            {
                return dcompra.getCompra(id);
            }
        }
    }
}
