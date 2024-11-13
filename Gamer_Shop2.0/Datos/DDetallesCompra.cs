using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DDetallesCompra
    {
        public DataTable GetDetallesAll()
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.Detalle_compraTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT d.ID_Compra, p.Nombre AS 'Producto', d.Subtotal, d.Cantidad, d.Precio_actual
                FROM Detalle_compra d
                JOIN Producto p ON d.ID_Producto = p.ID_Producto
                        ";

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
                MessageBox.Show($"Error SQL: {ex.Message}\nDetalle: {ex.Message}");
                return null;
            }

        }
    }
}
