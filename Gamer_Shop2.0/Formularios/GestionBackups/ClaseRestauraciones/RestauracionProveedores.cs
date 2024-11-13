using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseRestauraciones
{
    internal class RestauracionProveedores
    {
        public static void RestaurarProveedoresDesdeCSV(string rutaArchivoCSV)
        {
            // Verifica que el archivo existe
            if (!File.Exists(rutaArchivoCSV))
            {
                MsgPersonalizado mensajeError = new MsgPersonalizado("El archivo de backup especificado no existe.", "Error", "Error", null);
                mensajeError.ShowDialog();
                return;
            }

            try
            {
                using (var context = new ProyectoTallerIIEntities1())
                {
                    // Desactivar las claves foráneas en las tablas dependientes
                    context.Database.ExecuteSqlCommand("ALTER TABLE Compra NOCHECK CONSTRAINT FK_ProveedorCompra");
                    context.Database.ExecuteSqlCommand("ALTER TABLE Producto NOCHECK CONSTRAINT FK_ProveedorProducto");

                    // Vaciar la tabla de proveedores antes de restaurar
                    context.Proveedor.RemoveRange(context.Proveedor);
                    context.SaveChanges();

                    var lineas = File.ReadAllLines(rutaArchivoCSV, System.Text.Encoding.UTF8);

                    if (lineas.Length <= 1) // Saltamos la cabecera.
                    {
                        MsgPersonalizado mensajeError = new MsgPersonalizado("El archivo de backup está vacío o solo contiene cabeceras.", "Error", "Error", null);
                        mensajeError.ShowDialog();
                        return;
                    }

                    foreach (var linea in lineas.Skip(1))
                    {
                        var columnas = linea.Split(';');

                        // Removemos el formato del teléfono
                        ClaseValidacion validador = new ClaseValidacion();
                        string telefonoSinFormato = validador.RemoverFormatoTelefonico(columnas[3].Trim('"'));

                        // Creamos un nuevo objeto Proveedores y asignamos los valores
                        var proveedor = new Proveedor
                        {
                            ID_Proveedor = int.Parse(columnas[0].Trim('"')),
                            Razon_social = columnas[1].Trim('"'),
                            Nombre_representante = columnas[2].Trim('"'),
                            Telefono = telefonoSinFormato,
                            Correo = columnas[4].Trim('"'),
                            Dirección = columnas[5].Trim('"'),
                            Activo = columnas[6].Trim('"'),
                            ID_CategoriaProducto = int.Parse(columnas[7].Trim('"'))
                        };

                        // Agregamos el nuevo Proveedores directamente
                        context.Proveedor.Add(proveedor);
                    }

                    // Guardamos los cambios
                    context.SaveChanges();

                    // Reactivar las claves foráneas en las tablas dependientes
                    context.Database.ExecuteSqlCommand("ALTER TABLE Compra CHECK CONSTRAINT FK_ProveedorCompra");
                    context.Database.ExecuteSqlCommand("ALTER TABLE Producto CHECK CONSTRAINT FK_ProveedorProducto");

                    MsgPersonalizado mensaje = new MsgPersonalizado("Restauración de proveedores completada exitosamente.", "Restauración exitosa", "Informacion", null);
                    mensaje.ShowDialog();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var mensajeErrores = new StringBuilder("Error al restaurar los proveedores:\n");
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        mensajeErrores.AppendLine($"- Propiedad: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                    }
                }
                MsgPersonalizado mensaje = new MsgPersonalizado(mensajeErrores.ToString(), "Restauración fallida", "Error", null);
                mensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al restaurar los proveedores: {ex.Message}", "Restauración fallida", "Error", null);
                mensaje.ShowDialog();
            }
        }
    }
}
