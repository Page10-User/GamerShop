using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DVenta
    {
        DataSet1TableAdapters.VentaTableAdapter adapter = new DataSet1TableAdapters.VentaTableAdapter();

        public bool ExisteRegistro(Venta venta)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteVenta(venta.ID_Venta) > 0) return true;
                else return false;

            }
        }

        public bool ExisteRegistro(int id)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteVenta(id) > 0) return true;
                    else return false;

                }
            }
        }

        public Venta getVenta(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("La categoria no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Venta.FirstOrDefault(p => p.ID_Venta == id);
                }
            }
        }


        public void getVentas(DataGridView grid)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay ventas");
            }
            else
            {
                DVentas ventas = new DVentas();

                grid.DataSource = ventas.GetVentasAll();


            }
        }

        public void DGuardarVenta(Venta venta)
        {
            if (ExisteRegistro(venta) == true)
            {
                throw new ExisteRegistroException("El producto ya existe.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Venta.Add(venta);
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
