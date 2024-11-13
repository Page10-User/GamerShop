using System;
using Gamer_Shop2._0.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Negocio
{
    internal class NVenta
    {
        DVenta dventa = new DVenta();
        public void NGuardarVenta(float total, int idusuario, int idcliente, int idmetodo, DataTable detallesVenta)
        {

            Venta venta = new Venta()
            {
                Fecha = DateTime.Today,
                Total = total,
                ID_Usuario = idusuario,
                ID_Cliente = idcliente,
                ID_Método = idmetodo
            };

            if (dventa == null)
            {
                throw new NullReferenceException("El objeto 'dventa' no se pudo inicializar.");
            }
            else
            {
                // Aquí se podrían realizar validaciones adicionales si es necesario

                dventa.DGuardarVenta(venta, detallesVenta);
            }

        }

        public void getVentas(DataGridView grid)
        {
            if (dventa == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dventa.getVentas(grid);
            }
        }

        public Venta GetVenta(int id)
        {
            if (dventa == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dventa.getVenta(id);
            }
        }

        public DataTable getVentasUltimaSemana()
        {
            if (dventa == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dventa.getVentasUltimaSemana();
            }
        }
    }
}
