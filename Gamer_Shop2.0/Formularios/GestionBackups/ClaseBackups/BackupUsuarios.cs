using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupUsuarios
    {
        public static void ExportarUsuariosACSV(string rutaIndicada)
        {
            string rutaCarpetaBackupsUsuarios;
            // Construir la ruta completa a la carpeta de backups
            if (rutaIndicada != null)
            {
                rutaCarpetaBackupsUsuarios = rutaIndicada;
            }
            else
            {
                rutaCarpetaBackupsUsuarios = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveUsuarios"));
            }

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackupsUsuarios))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsUsuarios);
            }

            // Nombre del archivo con la fecha actual
            string nombreArchivo = $"Usuarios_{DateTime.Now:dd-MM-yyyy_HH-mm-ss}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsUsuarios, nombreArchivo);

            try
            {
                // Usar el contexto de Entity Framework para obtener los usuarios
                using (var context = new ProyectoTallerIIEntities1())
                {
                    var usuarios = context.Usuario.ToList();
                    ClaseValidacion validador = new ClaseValidacion(); // Crear una instancia de ClaseValidacion

                    if (usuarios.Count == 0)
                    {
                        MsgPersonalizado mensajeError = new MsgPersonalizado("La tabla usuarios actualmente se encuentra vacia.", "Error", "Error", null);
                        mensajeError.ShowDialog();
                        return;
                    }

                    using (StreamWriter writer = new StreamWriter(rutaArchivo, false, System.Text.Encoding.UTF8))
                    {
                        // Escribir la cabecera del CSV
                        writer.WriteLine("\"ID_Usuario\";\"Nombre\";\"Apellido\";\"CUIL\";\"Nombre de Usuario\";\"Contraseña\";\"Correo\";\"Foto\";\"Tipo de Usuario\";\"Estado\"");

                        // Escribir cada registro de la tabla
                        foreach (var usuario in usuarios)
                        {
                            string cuilFormateado = validador.AplicarFormatoCuil(usuario.CUIL);
                            string linea = $"\"{usuario.ID_Usuario}\";\"{usuario.Nombre}\";\"{usuario.Apellido}\";\"{cuilFormateado}\";\"{usuario.Nombre_usuario}\";\"{usuario.Contraseña}\";\"{usuario.Correo}\";\"{usuario.photoFilePath}\";\"{usuario.ID_TipoUsuario}\";\"{usuario.Activo}\"";
                            writer.WriteLine(linea);
                        }
                    }
                }
                MsgPersonalizado mensaje = new MsgPersonalizado("Backup de usuarios completado exitosamente", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup de usuarios: {ex.Message}", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
        }
        public static string ObtenerUsuarios()
        {
            using (var context = new ProyectoTallerIIEntities1())
            {
                var usuarios = context.Usuario.ToList();
                ClaseValidacion validador = new ClaseValidacion();
                StringBuilder datos = new StringBuilder();

                datos.AppendLine("\"ID_Usuario\";\"Nombre\";\"Apellido\";\"CUIL\";\"Nombre de Usuario\";\"Contraseña\";\"Correo\";\"Foto\";\"Tipo de Usuario\";\"Estado\"");

                foreach (var usuario in usuarios)
                {
                    string cuilFormateado = validador.AplicarFormatoCuil(usuario.CUIL);
                    datos.AppendLine($"\"{usuario.ID_Usuario}\";\"{usuario.Nombre}\";\"{usuario.Apellido}\";\"{cuilFormateado}\";" +
                                     $"\"{usuario.Nombre_usuario}\";\"{usuario.Contraseña}\";\"{usuario.Correo}\";\"{usuario.photoFilePath}\";" +
                                     $"\"{usuario.ID_TipoUsuario}\";\"{usuario.Activo}\"");
                }

                return datos.ToString();
            }
        }

    }
}
