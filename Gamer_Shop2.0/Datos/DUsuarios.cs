using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DUsuarios
    {
        public DataTable GetUsuarioAll()
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.UsuarioTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT u.ID_Usuario, u.Nombre, u.Apellido, u.CUIL, u.Nombre_usuario, u.Contraseña, u.Correo, u.photoFilePath, u.Activo,
                       t.ID_TipoUsuario AS 'Tipo usuario'
                FROM Usuario u
                JOIN Tipo_usuario t ON u.ID_TipoUsuario = t.ID_TipoUsuario";

                    // Ejecuta la consulta y guarda el resultado en un DataTable
                    var dataTable = new DataTable();
                    using (var connection = adapter.Connection)
                    {
                        connection.Open();
                        using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                        {
                            var reader = command.ExecuteReader();
                            dataTable.Load(reader);
                        }
                    }
                    return dataTable;
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show($"Error SQL: {ex.Message}\nDetalle: {ex.InnerException?.Message}");
                return null;
            }

        }
    }
}
