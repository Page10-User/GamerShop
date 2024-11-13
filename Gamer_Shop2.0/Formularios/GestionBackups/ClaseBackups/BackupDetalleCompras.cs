using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupDetalleCompras
    {
        public static void ExportarDetalleComprasACSV(string rutaIndicada, int idcompra)
        {
            string rutaCarpetaBackupsCompras;

            // Construir la ruta completa a la carpeta de backups
            if (rutaIndicada != null)
            {
                rutaCarpetaBackupsCompras = rutaIndicada;
            }
            else
            {
                rutaCarpetaBackupsCompras = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveDetalleCompras"));
            }

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackupsCompras))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsCompras);
            }

            // Nombre del archivo con la fecha actual
            string nombreArchivo = $"DetalleCompra_{idcompra}_{DateTime.Now:dd-MM-yyyy_HH-mm-ss}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsCompras, nombreArchivo);

            try
            {
                // Usar el contexto de Entity Framework para obtener los detalles de la compra específica
                using (var context = new ProyectoTallerIIEntities1())
                {
                    var detallesCompra = context.Detalle_compra
                        .Where(d => d.ID_Compra == idcompra)
                        .ToList();

                    ClaseValidacion validador = new ClaseValidacion();

                    if (detallesCompra.Count == 0)
                    {
                        MsgPersonalizado mensajeError = new MsgPersonalizado("No se encontraron detalles para esta compra.", "Error", "Error", null);
                        mensajeError.ShowDialog();
                        return;
                    }

                    using (StreamWriter writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                    {
                        // Escribir la cabecera del CSV
                        writer.WriteLine("\"ID_Producto\";\"ID_Compra\";\"Subtotal\";\"Cantidad\";\"Precio_actual\"");

                        // Escribir cada registro de detalle de compra
                        foreach (var detalle in detallesCompra)
                        {
                            string linea = $"\"{detalle.ID_Producto}\";\"{detalle.ID_Compra}\";\"{detalle.Subtotal}\";\"{detalle.Cantidad}\";\"{detalle.Precio_actual}\"";
                            writer.WriteLine(linea);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup de detalles de compra: {ex.Message}", "Backup Personalizado", "Error", null);
                mensaje.ShowDialog();
            }
        }
    }
}
