using System;
using System.Windows.Forms;
using Gamer_Shop2._0.Datos;

namespace Gamer_Shop2._0.Negocio
{
    internal class NUsuario
    {
        DUsuario dUsuario = new DUsuario();
        public void NAgregarUsuario(string nombre, string apellido, string cuil, string user, string password, string email, int tipoUsuario, string photoFilePath)
        {

            Usuario nuevoUsuario = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                CUIL = cuil,
                Nombre_usuario = user,
                Contraseña = password,
                Correo = email,
                photoFilePath = photoFilePath,
                ID_TipoUsuario = tipoUsuario,
                Activo = "SI"
    };

            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.DAgregarUsuario(nuevoUsuario);
            }
        }

        public void listaUsuariosActivos(DataGridView grid)
        {
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.getUsuariosActivos(grid);
            }
        }

        public void listaUsuariosActivosEyA(DataGridView grid)
        {
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.getUsuariosActivosEyA(grid);
            }
        }

        public void NModificarUsuario(string nombre, string apellido, string cuilActual, string user, string password, string email, int tipoUsuario, string activo)
        {
            Usuario Usuario = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                Nombre_usuario = user,
                Contraseña = password,
                Correo = email,
                ID_TipoUsuario = tipoUsuario,
                Activo = activo
            };
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.DModificarUsuario(cuilActual,Usuario);
            }
        }

        public void NModificarPerfil(string nombre, string apellido,  string user, string password, string email, string photoPath, string cuilActual)
        {
            Usuario Usuario = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                Nombre_usuario = user,
                Contraseña = password,
                Correo = email,
                photoFilePath = photoPath
            };
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.DModificarPerfil(cuilActual, Usuario);
            }
        }

        public Usuario GetUsuario(string cuil)
        {
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                return dUsuario.getUsuario(cuil);
            }
        }

        public void NEliminarUsuario(string cuil)
        {
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                dUsuario.DEliminarUsuario(cuil);
            }
        }

        //   //----------------------------------------------------------------------------------\\
        //  //------------------------------------------------------------------------------------\\
        //  ||                     Método para obtener la cuenta del usuario                      ||
        //  \\------------------------------------------------------------------------------------//
        //   \\----------------------------------------------------------------------------------//

        public Usuario GetCuentaUsuario(string NombreUsuario, string Contraseña)
        {
            if (dUsuario == null)
            {
                throw new NullReferenceException("El objeto 'dUsuario' no se pudo inicializar.");
            }
            else
            {
                return dUsuario.getCuentaUsuario(NombreUsuario, Contraseña);
            }
        }
    }
}
