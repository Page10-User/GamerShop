using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DProveedores
    {
        public DataTable GetProveedoresAll()
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.ProveedorTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"SELECT p.ID_Proveedor, p.Razon_social, p.Nombre_representante, p.Telefono, p.Correo, p.Dirección, p.Activo,
                       c.Nombre_Categoria AS Categoria
                FROM Proveedor p
                JOIN Categoría_Producto c ON p.ID_CategoriaProducto = c.ID_Categoria";

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

    public DataTable getProveedoresActivos()
    {
        try
        {
            // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
            using (var adapter = new DataSet1TableAdapters.ProveedorTableAdapter())
            {
                // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                string query = @"SELECT p.Razon_social
                FROM Proveedor p
                JOIN Categoría_Producto c ON p.ID_CategoriaProducto = c.ID_Categoria
                WHERE Activo = 'SI'";

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
