using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Negocio
{
    internal class NDetalleVenta
    {
        DDetalleVenta ddventa = new DDetalleVenta();
        public void NGuardarDetalle(int id_venta, int id_producto, float subtotal, int cantidad, float precioactual)
        {

            Detalle_venta dventa = new Detalle_venta()
            {
               ID_Venta = id_venta,
               ID_Producto = id_producto,
               Subtotal = subtotal,
               Cantidad = cantidad,
               Precio_actual = precioactual
            };

            if (ddventa == null)
            {
                throw new NullReferenceException("El objeto 'dventa' no se pudo inicializar.");
            }
            else
            {
                ddventa.DGuardarDetalle(dventa);
            }
        }

        public void getVentas(DataGridView grid)
        {
            if (ddventa == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                ddventa.getDetalles(grid);
            }
        }

        public Venta GetDetalle(int idven, int idprod)
        {
            if (ddventa == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return ddventa.getDetalle(idven, idprod);
            }
        }
    }
}
