using System;
using System.IO;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupCompleto
    {
        public static void ExporteCompletoACSV()
        {
            // Crear la ruta para guardar el backup completo
            string rutaCarpetaBackupsCompleto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveAll"));
            if (!Directory.Exists(rutaCarpetaBackupsCompleto))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsCompleto);
            }

            // Crear el archivo de backup completo con la fecha actual en el nombre
            string nombreArchivo = $"BackupCompleto_{DateTime.Now:dd-MM-yyyy}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsCompleto, nombreArchivo);

            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, false, System.Text.Encoding.UTF8))
                {
                    // Llamar a métodos para obtener los datos de cada tabla y escribirlos en el archivo
                    ExportarTabla(writer, "Clientes", BackupClientes.ObtenerClientes());
                    ExportarTabla(writer, "Proveedores", BackupProveedores.ObtenerProveedores());
                    ExportarTabla(writer, "Productos", BackupProductos.ObtenerProductos());
                    ExportarTabla(writer, "Compras", BackupCompras.ObtenerCompras());
                    ExportarTabla(writer, "Ventas", BackupVentas.ObtenerVentas());
                    ExportarTabla(writer, "Usuarios", BackupUsuarios.ObtenerUsuarios());
                }

                MsgPersonalizado mensaje = new MsgPersonalizado("Backup completo realizado con éxito en SaveAll.", "Backup Completo", "Informacion", null);
                mensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup completo: {ex.Message}", "Backup Completo", "Error", null);
                mensaje.ShowDialog();
            }
        }

        private static void ExportarTabla(StreamWriter writer, string nombreTabla, string datosTabla)
        {
            // Escribir la etiqueta de la tabla para distinguir los datos
            writer.WriteLine($"--- {nombreTabla} ---");
            writer.WriteLine(datosTabla);
        }
    }
}
