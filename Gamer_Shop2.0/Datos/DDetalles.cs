using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DDetalles
    {
        public DataTable GetDetallesAll()
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.Detalle_ventaTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT d.ID_Venta, p.Nombre AS 'Producto', d.Subtotal, d.Cantidad, d.Precio_actual
                FROM Detalle_venta d
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
                MessageBox.Show($"Error SQL: {ex.Message}\nDetalle: {ex.InnerException?.Message}");
                return null;
            }

        }

        public DataTable getProductosMasVendidos(string filtrofecha)
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.Detalle_ventaTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT TOP 5 p.Nombre, SUM(d.Cantidad) AS TotalVendidos 
                FROM Detalle_venta d
                JOIN Producto p ON d.ID_Producto = p.ID_Producto
                JOIN Venta v ON d.ID_Venta = d.ID_Venta
                WHERE v.Fecha >= {filtrofecha}
                GROUP BY p.Nombre 
                ORDER BY TotalVendidos DESC
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
                MessageBox.Show($"Error SQL: {ex.Message}\nDetalle: {ex.InnerException?.Message}");
                return null;
            }

        }

        public DataTable getTotalVendidosPorCategoria(string periodo)
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.Detalle_ventaTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT c.Nombre_Categoria, SUM(Cantidad) AS TotalCantidad 
                FROM Detalle_venta d
                JOIN Producto p ON p.ID_Producto = d.ID_Producto
                JOIN Categoría_producto c ON p.ID_Categoria = c.ID_Categoria
                JOIN Venta v ON d.ID_Venta = v.ID_Venta
                WHERE Fecha >= {periodo}
                GROUP BY c.Nombre_Categoria
                        ";
                    Debug.WriteLine(query);
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
