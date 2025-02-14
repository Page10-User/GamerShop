using System;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupCompleto
    {
        public static void HacerBackup()
        {
            // Obtener la cadena de conexión automáticamente desde el App.config
            string connectionString = ConfigurationManager.ConnectionStrings["Gamer_Shop2._0.Properties.Settings.ProyectoTallerIIConnectionString"].ConnectionString;

            // Ruta de la carpeta donde se guardarán los backups
            //string rutaCarpetaBackups = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveAll"));
            string rutaCarpetaBackups = @"C:\Backups";


            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackups))
            {
                Directory.CreateDirectory(rutaCarpetaBackups);
            }

            // Crear un nombre de archivo con marca de tiempo para el backup
            string nombreBackup = $"BackupCompleto_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.bak";

            string rutaBackup = Path.Combine(rutaCarpetaBackups, nombreBackup);

            string query = $"BACKUP DATABASE [ProyectoTallerII] TO DISK = '{rutaBackup}' WITH FORMAT;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MsgPersonalizado mensaje = new MsgPersonalizado("Backup completo realizado con éxito, guardado en " + rutaBackup, "Backup Completo exitoso","Informacion",null);
                    mensaje.ShowDialog();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al realizar el backup: {ex.Message}");
                    MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup: { ex.Message }", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }
    }
}
