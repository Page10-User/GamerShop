using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupProveedores
    {
        public static void ExportarProveedoresACSV()
        {
            // Construir la ruta completa a la carpeta de backups
            string rutaCarpetaBackupsProveedores = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveProveedores"));

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackupsProveedores))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsProveedores);
            }

            // Nombre del archivo con la fecha actual
            string nombreArchivo = $"Proveedores_{DateTime.Now:dd-MM-yyyy}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsProveedores, nombreArchivo);

            try
            {
                // Usar el contexto de Entity Framework para obtener los proveedores
                using (var context = new ProyectoTallerIIEntities1())
                {
                    var proveedores = context.Proveedor.ToList();
                    ClaseValidacion validador = new ClaseValidacion(); // Crear una instancia de ClaseValidacion

                    using (StreamWriter writer = new StreamWriter(rutaArchivo, false, System.Text.Encoding.UTF8))
                    {
                        // Escribir la cabecera del CSV
                        writer.WriteLine("\"ID_Proveedor\";\"Razón Social\";\"Nombre Representante\";\"Telefono\";\"Correo\";\"Dirección\";\"Activo\";\"Categoria de Productos\"");

                        // Escribir cada registro de la tabla
                        foreach (var proveedor in proveedores)
                        {
                            string telefonoFormateado = validador.AplicarFormatoTelefonico(proveedor.Telefono);
                            string linea = $"\"{proveedor.ID_Proveedor}\";\"{proveedor.Razon_social}\";\"{proveedor.Nombre_representante}\";\"{telefonoFormateado}\";\"{proveedor.Correo}\";\"{proveedor.Dirección}\";\"{proveedor.Activo}\";\"{proveedor.Categoría_producto.ID_Categoria}\"";
                            writer.WriteLine(linea);
                        }
                    }
                }
                MsgPersonalizado mensaje = new MsgPersonalizado("Backup de proveedores completado exitosamente en SaveProveedores.", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup de provedoores: {ex.Message}", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
        }
        public static string ObtenerProveedores()
        {
            using (var context = new ProyectoTallerIIEntities1())
            {
                var proveedores = context.Proveedor.ToList();
                ClaseValidacion validador = new ClaseValidacion();
                StringBuilder datos = new StringBuilder();

                datos.AppendLine("\"ID_Proveedor\";\"Razón Social\";\"Nombre Representante\";\"Telefono\";\"Correo\";\"Dirección\";\"Activo\";\"Categoria de Productos\"");

                foreach (var proveedor in proveedores)
                {
                    string telefonoFormateado = validador.AplicarFormatoTelefonico(proveedor.Telefono);
                    datos.AppendLine($"\"{proveedor.ID_Proveedor}\";\"{proveedor.Razon_social}\";\"{proveedor.Nombre_representante}\";" +
                                     $"\"{telefonoFormateado}\";\"{proveedor.Correo}\";\"{proveedor.Dirección}\";\"{proveedor.Activo}\";" +
                                     $"\"{proveedor.Categoría_producto.ID_Categoria}\"");
                }

                return datos.ToString();
            }
        }

    }
}
