using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System.Data;
using System.Data.SqlClient;

namespace Gamer_Shop2._0.Datos
{
    internal class DProductos
    {
        public DataTable GetProductoAll()
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.ProductoTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT p.ID_Producto, p.Serial, p.Nombre, p.Descripcion, p.Stock, p.Precio, p.Activo, p.photoFilePath,
                       c.Nombre_Categoria AS Categoria, 
                       pr.Razon_social AS Proveedor
                FROM Producto p
                JOIN Categoría_Producto c ON p.ID_Categoria = c.ID_Categoria
                JOIN Proveedor pr ON p.ID_Proveedor = pr.ID_Proveedor";

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
                string errorMessage = $"Error SQL: {ex.Message}\nDetalle: {ex.InnerException?.Message}";
                return null;
            }
        }

        public DataTable buscarProductos(string text, string dato)
        {
            using (var adapter = new DataSet1TableAdapters.ProductoTableAdapter())
            {
                string query = @"
            SELECT p.ID_Producto, p.Serial, p.Nombre, p.Descripcion, p.Stock, p.Precio, p.Activo, p.photoFilePath,
                   c.Nombre_Categoria AS Categoria, 
                   pr.Razon_social AS Proveedor
            FROM Producto p
            JOIN Categoría_Producto c ON p.ID_Categoria = c.ID_Categoria
            JOIN Proveedor pr ON p.ID_Proveedor = pr.ID_Proveedor
        ";

                if (dato == "Nombre")
                {
                    query += "WHERE p.Nombre LIKE @text";
                    text = "%" + text + "%";
                }
                else if (dato == "Serial")
                {
                    query += "WHERE p.Serial = @text";
                }
                else
                {
                    return null;
                }

                var dataTable = new DataTable();
                using (var connection = adapter.Connection)
                {
                    connection.Open();
                    using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        // Agregar el parámetro 'text' a la consulta
                        command.Parameters.AddWithValue("@text", text);

                        var reader = command.ExecuteReader();
                        dataTable.Load(reader);
                    }
                }
                return dataTable;
            }
        }
    }
}
