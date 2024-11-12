using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer_Shop2._0.Negocio
{
    internal class NMetodoPago
    {
        DMetodoPago dmetodo = new DMetodoPago();
        

        public List<Datos.DataSet1.Método_pagoRow> getMetodos()
        {
            if (dmetodo == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dmetodo.getMetodos();
            }
        }

        public Método_pago GetMetodo(int id)
        {
            if (dmetodo == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dmetodo.getMetodo(id);
            }
        }

        //public Método_pago GetMetodo(string desc)
        //{
        //    if (dmetodo == null)
        //    {
        //        throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
        //    }
        //    else
        //    {
        //        return dmetodo.getMetodo(desc);
        //    }
        //}


    }
}