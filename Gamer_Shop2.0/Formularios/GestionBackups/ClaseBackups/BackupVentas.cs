using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupVentas
    {
        public static void ExportarVentasACSV(string rutaIndicada)
        {
            string rutaCarpetaBackupsVentas;

            if (rutaIndicada != null)
            {
                rutaCarpetaBackupsVentas = rutaIndicada;
            }
            else
            {
                rutaCarpetaBackupsVentas = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveVentas"));
            }
            // Construir la ruta completa a la carpeta de backups

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackupsVentas))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsVentas);
            }

            // Nombre del archivo con la fecha actual
            string nombreArchivo = $"Ventas_{DateTime.Now:dd-MM-yyyy_HH-mm-ss}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsVentas, nombreArchivo);

            try
            {
                // Usar el contexto de Entity Framework para obtener los ventas
                using (var context = new ProyectoTallerIIEntities1())
                {
                    var ventas = context.Venta.ToList();
                    ClaseValidacion validador = new ClaseValidacion(); // Crear una instancia de ClaseValidacion

                    if (ventas.Count == 0)
                    {
                        MsgPersonalizado mensajeError = new MsgPersonalizado("La tabla ventas actualmente se encuentra vacia.", "Error", "Error", null);
                        mensajeError.ShowDialog();
                        return;
                    }

                    using (StreamWriter writer = new StreamWriter(rutaArchivo, false, System.Text.Encoding.UTF8))
                    {
                        // Escribir la cabecera del CSV
                        writer.WriteLine("\"ID_Venta\";\"Fecha\";\"Total\";\"ID_Usuario\";\"ID_Cliente\";\"ID_Método\"");

                        // Escribir cada registro de la tabla
                        foreach (var venta in ventas)
                        {
                            string linea = $"\"{venta.ID_Venta}\";\"{venta.Fecha}\";\"{venta.Total}\";\"{venta.ID_Usuario}\";\"{venta.ID_Cliente}\";\"{venta.ID_Método}\"";
                            writer.WriteLine(linea);
                        }
                    }
                }
                MsgPersonalizado mensaje = new MsgPersonalizado("Backup de ventas completado exitosamente", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup de ventas: {ex.Message}", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
        }
        public static string ObtenerVentas()
        {
            using (var context = new ProyectoTallerIIEntities1())
            {
                var ventas = context.Venta.ToList();
                StringBuilder datos = new StringBuilder();

                datos.AppendLine("\"ID_Venta\";\"Fecha\";\"Total\";\"ID_Usuario\";\"ID_Cliente\";\"ID_Método\"");

                foreach (var venta in ventas)
                {
                    datos.AppendLine($"\"{venta.ID_Venta}\";\"{venta.Fecha}\";\"{venta.Total}\";\"{venta.ID_Usuario}\";" +
                                     $"\"{venta.ID_Cliente}\";\"{venta.ID_Método}\"");
                }

                return datos.ToString();
            }
        }

    }
}
