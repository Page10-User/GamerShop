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
using Gamer_Shop2._0.Formularios.MSGPersonalizado;

namespace Gamer_Shop2._0.Datos
{
    internal class DProductos
    {
        public DataTable GetProductoAll()
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.ProductoTableAdapter() )
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT p.ID_Producto, p.Serial, p.Nombre, p.Descripcion, p.Stock, p.Precio, p.Activo,
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
                MsgPersonalizado mensaje = new MsgPersonalizado(errorMessage, "Error","Error",null);
                mensaje.ShowDialog();
                return null;
            }
        }
    }
}
