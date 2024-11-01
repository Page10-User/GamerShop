using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Negocio
{
    internal class NDetalleCompra
    {
        DDetalleCompra ddcompra = new DDetalleCompra();
        public void NGuardarDetalleCompra(int id_compra, int id_producto, float subtotal, int cantidad, float precioactual)
        {

            Detalle_compra dcompra = new Detalle_compra()
            {
                ID_Compra = id_compra,
                ID_Producto = id_producto,
                Subtotal = subtotal,
                Cantidad = cantidad,
                Precio_actual = precioactual
            };

            if (ddcompra == null)
            {
                throw new NullReferenceException("El objeto 'dventa' no se pudo inicializar.");
            }
            else
            {
                ddcompra.DGuardarDetalle(dcompra);
            }
        }

        public void getDetallesCompras(DataGridView grid)
        {
            if (ddcompra == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                ddcompra.getDetalles(grid);
            }
        }

        public Venta GetDetalle(int idcom, int idprod)
        {
            if (ddcompra == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return ddcompra.getDetalle(idcom, idprod);
            }
        }
    }
}
