using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gamer_Shop2._0.Datos
{
    internal class DDetalleCompra
    {
        DataSet1TableAdapters.Detalle_compraTableAdapter adapter = new DataSet1TableAdapters.Detalle_compraTableAdapter();

        public bool ExisteRegistro(Detalle_compra detalle)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteDetalleCompra(detalle.ID_Compra, detalle.ID_Producto) > 0) return true;
                else return false;

            }
        }

        public bool ExisteRegistro(int idcom, int idprod)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteDetalleCompra(idcom, idprod) > 0) return true;
                    else return false;

                }
            }
        }

        public Detalle_compra DGenerarDetalle(Detalle_compra detalle)
        {
            if (ExisteRegistro(detalle) == true)
            {
                throw new ExisteRegistroException("Este detalle ya existe");
            }
            else return detalle;
        }
        public DataTable DGuardarDetalles(List<Detalle_compra> detallesCompra)
        {
            try
            {
                DataTable detalleCompraTable = new DataTable();
                detalleCompraTable.Columns.Add("ID_Producto", typeof(int));
                detalleCompraTable.Columns.Add("ID_Compra", typeof(int));
                detalleCompraTable.Columns.Add("Subtotal", typeof(float));
                detalleCompraTable.Columns.Add("Cantidad", typeof(int));
                detalleCompraTable.Columns.Add("Precio_actual", typeof(float));

                // Llenar el DataTable con los datos de la lista de detalles de venta
                foreach (var detalle in detallesCompra)
                {
                    detalleCompraTable.Rows.Add(detalle.ID_Producto, detalle.ID_Compra, detalle.Subtotal, detalle.Cantidad, detalle.Precio_actual);
                }

                return detalleCompraTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Detalle_compra getDetalle(int idcom, int idprod)
        {
            if (ExisteRegistro(idcom, idprod) == false)
            {
                throw new ExisteRegistroException("La categoria no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Detalle_compra.FirstOrDefault(p => p.ID_Compra == idcom);
                }
            }
        }


        public void getDetalles(DataGridView grid)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay compras");
            }
            else
            {
                DDetallesCompra detalles = new DDetallesCompra();
                grid.DataSource = detalles.GetDetallesAll();


            }
        }

        public void getDetallesCompra(DataGridView grid, int idven)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay compras");
            }
            else
            {
                try
                {
                    Gamer_Shop2._0.Datos.DDetallesCompra detalles = new Gamer_Shop2._0.Datos.DDetallesCompra();

                    DataView view = new DataView(detalles.GetDetallesAll());
                    view.RowFilter = $"ID_Compra = {idven}";
                    grid.DataSource = view;
                }
                catch (Exception ex)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se puede mostrar el detalle" + ex.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        public void DGuardarDetalle(Detalle_compra detalle)
        {
            if (ExisteRegistro(detalle) == true)
            {
                throw new ExisteRegistroException("El detalle ya existe.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Detalle_compra.Add(detalle);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al guardar la categoria: {ex.Message}");
                    }
                }
            }
        }
    }
}
