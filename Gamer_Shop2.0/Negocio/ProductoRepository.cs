using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer_Shop2._0.Negocio
{
    internal class ProductoRepository
    {
        public void GuardarProducto(Producto producto)
        {
            string connectionString = "Data Source=DESKTOP-2SI2T9J\\SQLEXPRESS;Initial Catalog=ProyectoTallerII;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Producto (Serial, Nombre, Descripcion, Stock, Precio, ID_Categoria) VALUES (@Serial, @Nombre, @Descripcion, @Stock, @Precio, @ID_Categoria)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Serial", producto.Serial);
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    command.Parameters.AddWithValue("@Stock", producto.Stock);
                    command.Parameters.AddWithValue("@Precio", producto.Precio);
                    command.Parameters.AddWithValue("@ID_Categoria", producto.ID_Categoria);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
