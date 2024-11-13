using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupClientes
    {
        public static void ExportarClientesACSV(string rutaIndicada)
        {
            string rutaCarpetaBackupsClientes;

            // Construir la ruta completa a la carpeta de backups
            if (rutaIndicada != null)
            {
                rutaCarpetaBackupsClientes = rutaIndicada;
            }
            else
            {
                rutaCarpetaBackupsClientes = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveClientes"));
            }
            

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackupsClientes))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsClientes);
            }

            // Nombre del archivo con la fecha actual
            string nombreArchivo = $"Clientes_{DateTime.Now:dd-MM-yyyy_HH-mm-ss}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsClientes, nombreArchivo);

            try
            {
                // Usar el contexto de Entity Framework para obtener los clientes
                using (var context = new ProyectoTallerIIEntities1())
                {
                    var clientes = context.Cliente.ToList();
                    ClaseValidacion validador = new ClaseValidacion(); // Crear una instancia de ClaseValidacion

                    if (clientes.Count == 0)
                    {
                        MsgPersonalizado mensajeError = new MsgPersonalizado("La tabla clientes actualmente se encuentra vacia.", "Error", "Error", null);
                        mensajeError.ShowDialog();
                        return;
                    }

                    using (StreamWriter writer = new StreamWriter(rutaArchivo, false, System.Text.Encoding.UTF8))
                    {
                        // Escribir la cabecera del CSV
                        writer.WriteLine("\"ID_Cliente\";\"DNI\";\"Nombre\";\"Apellido\";\"Telefono\";\"Correo\"");

                        // Escribir cada registro de la tabla
                        foreach (var cliente in clientes)
                        {
                            string telefonoFormateado = validador.AplicarFormatoTelefonico(cliente.Teléfono);
                            string linea = $"\"{cliente.ID_Cliente}\";\"{cliente.DNI}\";\"{cliente.Nombre}\";\"{cliente.Apellido}\";\"{telefonoFormateado}\";\"{cliente.Correo}\"";
                            writer.WriteLine(linea);
                        }
                    }
                }

                MsgPersonalizado mensaje = new MsgPersonalizado("Backup de clientes completado exitosamente", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup de clientes: {ex.Message}", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
        }

        public static string ObtenerClientes()
        {
            using (var context = new ProyectoTallerIIEntities1())
            {
                var clientes = context.Cliente.ToList();
                ClaseValidacion validador = new ClaseValidacion();
                StringBuilder datos = new StringBuilder();

                datos.AppendLine("\"ID_Cliente\";\"DNI\";\"Nombre\";\"Apellido\";\"Teléfono\";\"Correo\"");

                foreach (var cliente in clientes)
                {
                    string telefonoFormateado = validador.AplicarFormatoTelefonico(cliente.Teléfono);
                    datos.AppendLine($"\"{cliente.ID_Cliente}\";\"{cliente.DNI}\";\"{cliente.Nombre}\";\"{cliente.Apellido}\";\"{telefonoFormateado}\";\"{cliente.Correo}\"");
                }

                return datos.ToString();
            }
        }
    }
}
