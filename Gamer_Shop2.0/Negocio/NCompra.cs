using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Negocio
{
    internal class NCompra
    {
        DCompra dcompra = new DCompra();
        public void NGuardarCompra(float total, int idusuario, int idcompra, int idproveedor)
        {

            Compra compra = new Compra()
            {
                Fecha = DateTime.Today,
                Total = total,
                ID_Usuario = idusuario,
                ID_Compra = idcompra,
                ID_Proveedor = idproveedor
            };

            if (dcompra == null)
            {
                throw new NullReferenceException("El objeto 'dcompra' no se pudo inicializar.");
            }
            else
            {
                dcompra.DGuardarCompra(compra);
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
