using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gamer_Shop2._0.Datos
{
    internal class DDetalleVenta
    {
        DataSet1TableAdapters.Detalle_ventaTableAdapter adapter = new DataSet1TableAdapters.Detalle_ventaTableAdapter();

        public bool ExisteRegistro(Detalle_venta detalle)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteDetalle(detalle.ID_Venta, detalle.ID_Producto) > 0) return true;
                else return false;

            }
        }

        public bool ExisteRegistro(int idven, int idprod)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteDetalle(idven, idprod) > 0) return true;
                    else return false;

                }
            }
        }

        public Detalle_venta getDetalle(int idven, int idprod)
        {
            if (ExisteRegistro(idven, idprod) == false)
            {
                throw new ExisteRegistroException("La categoria no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Detalle_venta.FirstOrDefault(p => p.ID_Venta == idven);
                }
            }
        }


        public void getDetalles(DataGridView grid, int idven)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay ventas");
            }
            else
            {
                try
                {
                    DDetalles detalles = new DDetalles();
                    
                    DataView view = new DataView(detalles.GetDetallesAll());
                    view.RowFilter = $"ID_Venta = {idven}";
                    grid.DataSource = view;
                }
                catch (Exception ex) {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se puede mostrar el detalle" + ex.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        public Detalle_venta DGenerarDetalle(Detalle_venta detalle)
        {
            if (ExisteRegistro(detalle) == true)
            {
                throw new ExisteRegistroException("Este detalle ya existe");
            }
            else return detalle;
        }

        public DataTable getProductosMasVendidos (string periodo)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay ventas");
                
            }
            else
            {
                try
                {
                    DDetalles detalles = new DDetalles();

                    return detalles.getProductosMasVendidos(periodo);
                }
                catch (Exception ex)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se puede mostrar el detalle" + ex.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                    return null;
                }
            }
        }

        public DataTable getTotalVendidosPorCategoria(string periodo)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay ventas");

            }
            else
            {
                try
                {
                    DDetalles detalles = new DDetalles();

                    return detalles.getTotalVendidosPorCategoria(periodo);
                }
                catch (Exception ex)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se puede mostrar el detalle" + ex.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                    return null;
                }
            }
        }


        public DataTable DGuardarDetalles(List<Detalle_venta> detallesVenta) {

            DataTable detalleVentaTable = new DataTable();
            detalleVentaTable.Columns.Add("ID_Producto", typeof(int));
            detalleVentaTable.Columns.Add("ID_Venta", typeof(int));
            detalleVentaTable.Columns.Add("Subtotal", typeof(float));
            detalleVentaTable.Columns.Add("Cantidad", typeof(int));
            detalleVentaTable.Columns.Add("Precio_actual", typeof(float));

            // Llenar el DataTable con los datos de la lista de detalles de venta
            foreach (var detalle in detallesVenta)
            {
                detalleVentaTable.Rows.Add(detalle.ID_Producto, detalle.ID_Venta, detalle.Subtotal, detalle.Cantidad, detalle.Precio_actual);
            }

            return detalleVentaTable;
        }

    }
}
