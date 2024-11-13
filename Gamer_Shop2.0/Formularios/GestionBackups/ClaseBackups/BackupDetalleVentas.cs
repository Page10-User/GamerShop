using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupDetalleVentas
    {
        public static void ExportarDetalleVentasACSV(string rutaIndicada, int idventa)
        {
            string rutaCarpetaBackupsVentas;

            // Construir la ruta completa a la carpeta de backups
            if (rutaIndicada != null)
            {
                rutaCarpetaBackupsVentas = rutaIndicada;
            }
            else
            {
                rutaCarpetaBackupsVentas = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveDetalleVentas"));
            }

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackupsVentas))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsVentas);
            }

            // Nombre del archivo con la fecha actual
            string nombreArchivo = $"DetalleVenta_{idventa}_{DateTime.Now:dd-MM-yyyy_HH-mm-ss}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsVentas, nombreArchivo);

            try
            {
                // Usar el contexto de Entity Framework para obtener los detalles de la venta específica
                using (var context = new ProyectoTallerIIEntities1())
                {
                    var detallesVenta = context.Detalle_venta
                        .Where(d => d.ID_Venta == idventa)
                        .ToList();

                    ClaseValidacion validador = new ClaseValidacion();

                    if (detallesVenta.Count == 0)
                    {
                        MsgPersonalizado mensajeError = new MsgPersonalizado("No se encontraron detalles para esta venta.", "Error", "Error", null);
                        mensajeError.ShowDialog();
                        return;
                    }

                    using (StreamWriter writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                    {
                        // Escribir la cabecera del CSV
                        writer.WriteLine("\"ID_Producto\";\"ID_Venta\";\"Subtotal\";\"Cantidad\";\"Precio_actual\"");

                        // Escribir cada registro de detalle de venta
                        foreach (var detalle in detallesVenta)
                        {
                            string linea = $"\"{detalle.ID_Producto}\";\"{detalle.ID_Venta}\";\"{detalle.Subtotal}\";\"{detalle.Cantidad}\";\"{detalle.Precio_actual}\"";
                            writer.WriteLine(linea);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup de detalles de venta: {ex.Message}", "Backup Personalizado", "Error", null);
                mensaje.ShowDialog();
            }
        }
    }
}
