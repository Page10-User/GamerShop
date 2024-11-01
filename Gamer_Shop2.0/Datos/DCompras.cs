using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DCompras
    {
        public DataTable GetComprasAll()
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.CompraTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT c.ID_Compra, c.Fecha, c.Total,
                        p.Razon_social AS Proveedor,
                        u.Nombre_usuario AS Usuario,
                FROM Compra
                JOIN Proveedor p ON c.ID_Proveedor = p.ID_Proveedor
                JOIN Usuario u ON c.ID_Usuario = u.ID_Usuario
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
    }
}
