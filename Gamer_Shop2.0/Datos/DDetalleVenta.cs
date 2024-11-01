using Gamer_Shop2._0.Excepciones;
using System;
using System.Collections.Generic;
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

        public Venta getDetalle(int idven, int idprod)
        {
            if (ExisteRegistro(idven, idprod) == false)
            {
                throw new ExisteRegistroException("La categoria no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Venta.FirstOrDefault(p => p.ID_Venta == idven);
                }
            }
        }


        public void getDetalles(DataGridView grid)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay ventas");
            }
            else
            {
                DDetalles detalles = new DDetalles();
                grid.DataSource = detalles.GetDetallesAll();


            }
        }

        public void DGuardarDetalle(Detalle_venta detalle)
        {
            if (ExisteRegistro(detalle) == true)
            {
                throw new ExisteRegistroException("El producto ya existe.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Detalle_venta.Add(detalle);
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
