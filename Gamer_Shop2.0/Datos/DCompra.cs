using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DCompra
    {
        DataSet1TableAdapters.CompraTableAdapter adapter = new DataSet1TableAdapters.CompraTableAdapter();

        public bool ExisteRegistro(Compra compra)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteCompra(compra.ID_Compra) > 0) return true;
                else return false;

            }
        }

        public bool ExisteRegistro(int id)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    if (adapter.ExisteCompra(id) > 0) return true;
                    else return false;

                }
            }
        }

        public Compra getCompra(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("La compra no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Compra.FirstOrDefault(p => p.ID_Compra == id);
                }
            }
        }

        public void getCompras(DataGridView grid)
        {
            try
            {
               
                
                    DCompras compras = new DCompras();

                   DataTable listacompras = compras.GetComprasAll();
                    listacompras.BeginLoadData(); // Desactiva temporalmente las restricciones
                    grid.DataSource = listacompras;
                    listacompras.EndLoadData();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public void DGuardarCompra(Compra compra, DataTable detallesCompra)
        {
            if (ExisteRegistro(compra) == true)
            {
                throw new ExisteRegistroException("Ya existe una compra con estos datos");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    using (var connection = context.Database.Connection)
                    {
                        try
                        {
                            connection.Open();
                            using (var command = new SqlCommand("REGISTRARCOMPRA", (SqlConnection)connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Agregar parámetros simples
                                command.Parameters.AddWithValue("@ID_Usuario", compra.ID_Usuario);
                                command.Parameters.AddWithValue("@ID_Proveedor", compra.ID_Proveedor);
                                command.Parameters.AddWithValue("@Fecha", compra.Fecha);
                                command.Parameters.AddWithValue("@Total", compra.Total);

                                // Agregar parámetro de tipo tabla
                                SqlParameter detalleParam = command.Parameters.AddWithValue("@Detalle_compra", detallesCompra);
                                detalleParam.SqlDbType = SqlDbType.Structured;
                                detalleParam.TypeName = "dbo.EDetalle_compra";

                                // Ejecutar el procedimiento almacenado
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Manejo de errores y rollback
                            throw new Exception($"Error al registrar la compra: {ex.Message}");
                            // Opcional: relanzar la excepción para manejarla en otro lugar
                        }
                    }
                }
            }
        }
    }
}
