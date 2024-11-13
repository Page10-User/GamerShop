using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupCompras
    {
        public static void ExportarComprasACSV(string rutaIndicada)
        {
            string rutaCarpetaBackupsCompras;

            if (rutaIndicada != null)
            {
                rutaCarpetaBackupsCompras = rutaIndicada;
            }
            else
            {
                rutaCarpetaBackupsCompras = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveCompras"));
            }
            // Construir la ruta completa a la carpeta de backups

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackupsCompras))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsCompras);
            }

            // Nombre del archivo con la fecha actual
            string nombreArchivo = $"Compras_{DateTime.Now:dd-MM-yyyy_HH-mm-ss}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsCompras, nombreArchivo);

            try
            {
                // Usar el contexto de Entity Framework para obtener los compras
                using (var context = new ProyectoTallerIIEntities1())
                {
                    var compras = context.Compra.ToList();
                    ClaseValidacion validador = new ClaseValidacion(); // Crear una instancia de ClaseValidacion

                    if (compras.Count == 0)
                    {
                        MsgPersonalizado mensajeError = new MsgPersonalizado("La tabla compras actualmente se encuentra vacia.", "Error", "Error", null);
                        mensajeError.ShowDialog();
                        return;
                    }

                    using (StreamWriter writer = new StreamWriter(rutaArchivo, false, System.Text.Encoding.UTF8))
                    {
                        // Escribir la cabecera del CSV
                        writer.WriteLine("\"ID_Compra\";\"Fecha\";\"Total\";\"ID_Proveedor\";\"ID_Usuario\"");

                        // Escribir cada registro de la tabla
                        foreach (var compra in compras)
                        {
                            string linea = $"\"{compra.ID_Compra}\";\"{compra.Fecha}\";\"{compra.Total}\";\"{compra.ID_Proveedor}\";\"{compra.ID_Usuario}\"";
                            writer.WriteLine(linea);
                        }
                    }
                }
                MsgPersonalizado mensaje = new MsgPersonalizado("Backup de compras completado exitosamente en SaveCompras.", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup de compras: {ex.Message}", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
        }
        public static string ObtenerCompras()
        {
            using (var context = new ProyectoTallerIIEntities1())
            {
                var compras = context.Compra.ToList();
                StringBuilder datos = new StringBuilder();

                datos.AppendLine("\"ID_Compra\";\"Fecha\";\"Total\";\"ID_Proveedor\";\"ID_Usuario\"");

                foreach (var compra in compras)
                {
                    datos.AppendLine($"\"{compra.ID_Compra}\";\"{compra.Fecha}\";\"{compra.Total}\";\"{compra.ID_Proveedor}\";\"{compra.ID_Usuario}\"");
                }

                return datos.ToString();
            }
        }
    }
}
