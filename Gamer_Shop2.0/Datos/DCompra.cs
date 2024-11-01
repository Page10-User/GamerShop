using Gamer_Shop2._0.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DCompra
    {
        DataSet1TableAdapters.CompraTableAdapter adapter = new DataSet1TableAdapters.CompraTableAdapter();

        public bool ExisteRegistro(Compra compra)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteCompra(compra.ID_Compra) > 0) return true;
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
                    if (adapter.ExisteCompra(id) > 0) return true;
                    else return false;

                }
            }
        }

        public Compra getCompra(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("La categoria no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Compra.FirstOrDefault(p => p.ID_Compra == id);
                }
            }
        }

        public void getCompras(DataGridView grid)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay ventas");
            }
            else
            {
                DCompras compras = new DCompras();

                grid.DataSource = compras.GetComprasAll();


            }
        }

        public void DGuardarCompra(Compra compra)
        {
            if (ExisteRegistro(compra) == true)
            {
                throw new ExisteRegistroException("El producto ya existe.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Compra.Add(compra);
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
