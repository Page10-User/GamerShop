using Gamer_Shop2._0.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer_Shop2._0.Datos
{
    internal class DMetodoPago
    {
        DataSet1TableAdapters.Método_pagoTableAdapter adapter = new DataSet1TableAdapters.Método_pagoTableAdapter();

        public bool ExisteRegistro(Método_pago metodo)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteMetodoPorID(metodo.ID_Método) > 0) return true;
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
                    if (adapter.ExisteMetodoPorID(id) > 0) return true;
                    else return false;

                }
            }
        }

        public Método_pago getMetodo(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("La categoria no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Método_pago.FirstOrDefault(p => p.ID_Método == id);
                }
            }
        }


        public List<DataSet1.Método_pagoRow> getMetodos()
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay categorias");
            }
            else
            {
                List<DataSet1.Método_pagoRow> métodos = adapter.GetData().ToList<DataSet1.Método_pagoRow>();
                return métodos;


            }
        }
    }
}
