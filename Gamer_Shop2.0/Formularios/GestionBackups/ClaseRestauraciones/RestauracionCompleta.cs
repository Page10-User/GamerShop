using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseRestauraciones
{
    internal class RestauracionCompleta
    {
        public static void HacerRestauracion(string rutaBackup)
        {
            // Obtener la cadena de conexión automáticamente desde el App.config
            string connectionString = ConfigurationManager.ConnectionStrings["Gamer_Shop2._0.Properties.Settings.ProyectoTallerIIConnectionString"].ConnectionString;

            // Consulta SQL para la restauración de la base de datos
            string query = $"USE master; ALTER DATABASE [ProyectoTallerII] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                           $"RESTORE DATABASE [ProyectoTallerII] FROM DISK = '{rutaBackup}' WITH REPLACE; " +
                           $"ALTER DATABASE [ProyectoTallerII] SET MULTI_USER;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MsgPersonalizado mensaje = new MsgPersonalizado("Restauración completa realizada con éxito.", "Éxito", "Informacion", null);
                    mensaje.ShowDialog();
                }
                catch (Exception ex)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar la restauración: {ex.Message}", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }
    }
}
