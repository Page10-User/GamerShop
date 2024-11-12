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
    internal class NDetalleVenta
    {
        DDetalleVenta ddventa = new DDetalleVenta();

        public Detalle_venta NGenerarDetalle(int id_producto, float subtotal, int cantidad, float precioactual)
        {
            Detalle_venta dventa = new Detalle_venta()
            {
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
                return ddventa.DGenerarDetalle(dventa);
            }
        }

        public DataTable NGuardarDetalles (List<Detalle_venta> detallesVenta)
        {
            if (ddventa == null)
            {
                throw new NullReferenceException("El objeto 'dventa' no se pudo inicializar.");
            }
            else
            {
                return ddventa.DGuardarDetalles(detallesVenta);
            }
        }
        public void getDetalles(DataGridView grid,int idven)
        {
            if (ddventa == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                ddventa.getDetalles(grid, idven);
            }
        }

        public Detalle_venta GetDetalle(int idven, int idprod)
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
