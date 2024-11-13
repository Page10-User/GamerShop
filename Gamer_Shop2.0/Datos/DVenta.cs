using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Datos
{
    internal class DVenta
    {
        DataSet1TableAdapters.VentaTableAdapter adapter = new DataSet1TableAdapters.VentaTableAdapter();

        public bool ExisteRegistro(Venta venta)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteVenta(venta.ID_Venta) > 0) return true;
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
                    if (adapter.ExisteVenta(id) > 0) return true;
                    else return false;

                }
            }
        }

        public Venta getVenta(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("La categoria no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {

                    return context.Venta.FirstOrDefault(p => p.ID_Venta == id);
                }
            }
        }


        public void getVentas(DataGridView grid)
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay ventas");
            }
            else
            {
                DVentas ventas = new DVentas();

                grid.DataSource = ventas.GetVentasAll();


            }
        }

        public DataTable getVentasUltimaSemana()
        {
            if (adapter.GetData() == null)
            {
                throw new NullReferenceException("No hay ventas");
            }
            else
            {
                DVentas ventas = new DVentas();

                return ventas.getTotalSemana();
            }
        }

        public void DGuardarVenta(Venta venta, DataTable detallesVenta)
        {
            if (ExisteRegistro(venta) == true)
            {
                throw new ExisteRegistroException("El ID de venta ya existe.");
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
                            using (var command = new SqlCommand("REGISTRARVENTA", (SqlConnection)connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Agregar parámetros simples
                                command.Parameters.AddWithValue("@ID_Usuario", venta.ID_Usuario);
                                command.Parameters.AddWithValue("@ID_Cliente", venta.ID_Cliente);
                                command.Parameters.AddWithValue("@ID_Método", venta.ID_Método);
                                command.Parameters.AddWithValue("@Fecha", venta.Fecha);
                                command.Parameters.AddWithValue("@Total", venta.Total);

                                // Agregar parámetro de tipo tabla
                                SqlParameter detalleParam = command.Parameters.AddWithValue("@Detalle_venta", detallesVenta);
                                detalleParam.SqlDbType = SqlDbType.Structured;
                                detalleParam.TypeName = "dbo.EDetalle_venta";

                                // Ejecutar el procedimiento almacenado
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            // Manejo de errores y rollback
                            throw new Exception($"Error al registrar la venta: {ex.Message}");
                            // Opcional: relanzar la excepción para manejarla en otro lugar
                        }
                    }
                }
            }
        }
        
    }
}
