using System;
using System.Data;
using System.Linq;
using Gamer_Shop2._0.Excepciones;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DUsuario
    {
        DataSet1TableAdapters.UsuarioTableAdapter adapter = new DataSet1TableAdapters.UsuarioTableAdapter();

        public bool ExisteRegistro(Usuario Usuario)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteUsuarioPorCUIL(Usuario.CUIL) > 0) return true;
                    else return false;

                }
            }
        }

        public bool ExisteRegistro(string cuil)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteUsuarioPorCUIL(cuil) > 0) return true;
                    else return false;

                }
            }
        }

        public Usuario getUsuario(string cuil)
        {
            if (ExisteRegistro(cuil) == false)
            {
                throw new ExisteRegistroException("El Usuario no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    return context.Usuario.FirstOrDefault(p => p.CUIL == cuil);
                }
            }
        }

        public DataTable getUsuariosActivos(DataGridView grid)
        {
            if (grid == null)
            {
                throw new NullReferenceException("Error al cargar la tabla");
            }
            else
            {
                DUsuarios Usuarios = new DUsuarios();
                return Usuarios.GetUsuarioAll();
            }
        }

        public void getUsuariosActivosEyA(DataGridView grid)
        {
            if (grid == null)
            {
                throw new NullReferenceException("Error al cargar la tabla");
            }
            else
            {
                DUsuarios Usuarios = new DUsuarios();
                DataView view = new DataView(Usuarios.GetUsuariosTipoEmpleadoYAdmin());
                view.RowFilter = "Activo = 'SI'";
                grid.DataSource = view;
            }
        }

        public void DAgregarUsuario(Usuario Usuario)
        {
            if (ExisteRegistro(Usuario) == true)
            {
                throw new ExisteRegistroException("El número de cuil de Usuario ya existe.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Usuario.Add(Usuario);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al guardar el Usuario: {ex.Message}");
                    }
                }
            }
        }

        public void DModificarUsuario(string cuilActual, Usuario Usuario)
        {
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (ExisteRegistro(cuilActual) == false)
                {
                    throw new ExisteRegistroException("El Usuario no existe");
                }
                else
                {
                    try
                    {
                        Usuario user = context.Usuario.First(p => p.CUIL == cuilActual);

                        user.Nombre = Usuario.Nombre;
                        user.Apellido = Usuario.Apellido;
                        user.Nombre_usuario = Usuario.Nombre_usuario;
                        user.Contraseña = Usuario.Contraseña;
                        user.Correo = Usuario.Correo;
                        user.photoFilePath = Usuario.photoFilePath;
                        user.ID_TipoUsuario = Usuario.ID_TipoUsuario;
                        user.Activo = Usuario.Activo;

                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al modificar el Usuario: {ex.Message}");
                    }
                }
            }
        }

        //Propia para perfiles
        public void DModificarPerfil(string cuilActual, Usuario Usuario)
        {
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (ExisteRegistro(cuilActual) == false)
                {
                    throw new ExisteRegistroException("El Usuario no existe");
                }
                else
                {
                    try
                    {
                        Usuario user = context.Usuario.First(p => p.CUIL == cuilActual);

                        user.Nombre = Usuario.Nombre;
                        user.Apellido = Usuario.Apellido;
                        user.Nombre_usuario = Usuario.Nombre_usuario;
                        user.Contraseña = Usuario.Contraseña;
                        user.Correo = Usuario.Correo;
                        user.photoFilePath = Usuario.photoFilePath;
                        user.ID_TipoUsuario = user.ID_TipoUsuario;
                        user.Activo = user.Activo;

                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al modificar el Usuario: {ex.Message}");
                    }
                }
            }
        }

        public void DEliminarUsuario(string cuil)
        {
            if (ExisteRegistro(cuil) == false)
            {
                throw new ExisteRegistroException("El Usuario no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        Usuario user = context.Usuario.First(p => p.CUIL == cuil);

                        user.Activo = "NO";
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al eliminar el Usuario: {ex.Message}");
                    }
                }
            }
        }
        //   //----------------------------------------------------------------------------------\\
        //  //------------------------------------------------------------------------------------\\
        //  ||                     Método para obtener la cuenta del usuario                      ||
        //  \\------------------------------------------------------------------------------------//
        //   \\----------------------------------------------------------------------------------//
        
        public Usuario getCuentaUsuario(string NombreUsuario, string Contraseña)
        {
            if (ExisteCuenta(NombreUsuario, Contraseña) == false)
            {
                throw new ExisteRegistroException("El Usuario no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    return context.Usuario.FirstOrDefault(p => p.Nombre_usuario == NombreUsuario);
                }
            }
        }

        public bool ExisteCuenta(string NombreUsuario, string Contraseña)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteUsuarioPorCuenta(NombreUsuario, Contraseña) > 0) return true;
                    else return false;
                }
            }
        }
    }
}