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
    internal class DClientes
    {
        public DataTable GetClienteAll()
        {
            try
            {
                // Crea la instancia del TableAdapter (puedes usar una query SQL personalizada)
                using (var adapter = new DataSet1TableAdapters.ClienteTableAdapter())
                {
                    // Consulta SQL con JOIN para traer nombres de categoría y proveedor
                    string query = @"
                SELECT ID_Cliente, DNI, Nombre, Apellido, Teléfono, Correo FROM Cliente";

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
