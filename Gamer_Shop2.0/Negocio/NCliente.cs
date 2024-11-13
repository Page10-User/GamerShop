using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Gamer_Shop2._0.Datos;

namespace Gamer_Shop2._0.Negocio
{
    internal class NCliente
    {
        DCliente dCliente = new DCliente();
        public void NAgregarCliente(string nombre, string apellido, string dni, string telefono, string email)
        {

            Cliente nuevoCliente = new Cliente()
            {
                DNI = dni,
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
                dCliente.DAgregarCliente(nuevoCliente);
            }
        }

        public DataTable listaClientes(DataGridView grid)
        {
            if (dCliente == null)
            {
                throw new NullReferenceException("El objeto 'dCliente' no se pudo inicializar.");
            }
            else
            {
                return dCliente.getClientes(grid);
            }
        }

        public void NModificarCliente(string dni, string nombre, string apellido, string telefono, string email)
        {
            Cliente Cliente = new Cliente()
            {
                DNI = dni,
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

        public Cliente GetCliente(int id)
        {
            if (dCliente == null)
            {
                throw new NullReferenceException("El objeto 'dCliente' no se pudo inicializar.");
            }
            else
            {
                return dCliente.getCliente(id);
            }
        }
    }
}
