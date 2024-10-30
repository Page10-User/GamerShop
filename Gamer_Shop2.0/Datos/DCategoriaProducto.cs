using Gamer_Shop2._0.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DCategoriaProducto
    {
        DataSet1TableAdapters.Categoría_productoTableAdapter adapter = new DataSet1TableAdapters.Categoría_productoTableAdapter();

        public bool ExisteRegistro(Categoría_producto categoría)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteCategoriaPorID(categoría.ID_Categoria) > 0) return true;
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
                    if (adapter.ExisteCategoriaPorID(id) > 0) return true;
                    else return false;

                }
            }
        }

        public Categoría_producto getCategoria(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("La categoria no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Categoría_producto.FirstOrDefault(p => p.ID_Categoria == id);
                }
            }
        }


        public List<DataSet1.Categoría_productoRow> getCategorias()
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay categorias");
            }
            else
            {
                List<DataSet1.Categoría_productoRow> categorías = adapter.GetData().ToList<DataSet1.Categoría_productoRow>();
                return categorías;


            }
        }

        public void DAgregarCategoria(Categoría_producto cat)
        {
            if (ExisteRegistro(cat) == true)
            {
                throw new ExisteRegistroException("El producto ya existe.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Categoría_producto.Add(cat);
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


