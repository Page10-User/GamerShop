using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gamer_Shop2._0.Negocio
{
    internal class NCliente
    {
        DCliente dCliente = new DCliente();
        public void NAgregarCliente(string nombre, string apellido, string dni, string telefono, string email)
        {

            Cliente nuevoCliente = new Cliente()
            {
                Nombre = nombre,
                Apellido = apellido,
                DNI = dni,
                Teléfono = telefono,
                Correo = email
            };

            if (dCliente == null)
            {
                throw new NullReferenceException("El objeto 'dCliente' no se pudo inicializar.");
            }
            else
            {
                dCliente.DAgregarCliente(nuevoCliente);
            }
        }

        public void listaClientesActivos(DataGridView grid)
        {
            if (dCliente == null)
            {
                throw new NullReferenceException("El objeto 'dCliente' no se pudo inicializar.");
            }
            else
            {
                dCliente.getClientesActivos(grid);
            }
        }

        public void NModificarCliente(string nombre, string apellido, string telefono, string email)
        {
            Cliente Cliente = new Cliente()
            {
                Nombre = nombre,
                Apellido = apellido,
                Teléfono = telefono,
                Correo = email
            };
            if (dCliente == null)
            {
                throw new NullReferenceException("El objeto 'dCliente' no se pudo inicializar.");
            }
            else
            {
                dCliente.DModificarCliente(Cliente);
            }
        }

        public Cliente GetCliente(string dni)
        {
            if (dCliente == null)
            {
                throw new NullReferenceException("El objeto 'dCliente' no se pudo inicializar.");
            }
            else
            {
                return dCliente.getCliente(dni);
            }
        }
    }
}
