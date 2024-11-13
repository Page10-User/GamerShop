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
    internal class RestauracionProductos
    {
        public static void RestaurarProductosDesdeCSV(string rutaArchivoCSV)
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
                    context.Database.ExecuteSqlCommand("ALTER TABLE Detalle_venta NOCHECK CONSTRAINT FK_ProductoDV");
                    context.Database.ExecuteSqlCommand("ALTER TABLE Detalle_compra NOCHECK CONSTRAINT FK_ProductoDC");

                    // Vaciar la tabla de productos antes de restaurar
                    context.Producto.RemoveRange(context.Producto);
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
                        string telefonoSinFormato = validador.RemoverFormatoTelefonico(columnas[4].Trim('"'));

                        // Creamos un nuevo objeto Cliente y asignamos los valores
                        var cliente = new Cliente
                        {
                            ID_Cliente = int.Parse(columnas[0].Trim('"')),
                            DNI = columnas[1].Trim('"'),
                            Nombre = columnas[2].Trim('"'),
                            Apellido = columnas[3].Trim('"'),
                            Teléfono = telefonoSinFormato,
                            Correo = columnas[5].Trim('"')
                        };

                        // Agregamos el nuevo cliente directamente
                        context.Cliente.Add(cliente);
                    }

                    // Guardamos los cambios
                    context.SaveChanges();

                    // Reactivar las claves foráneas en las tablas dependientes
                    context.Database.ExecuteSqlCommand("ALTER TABLE Detalle_venta CHECK CONSTRAINT FK_ProductoDV");
                    context.Database.ExecuteSqlCommand("ALTER TABLE Detalle_compra CHECK CONSTRAINT FK_ProductoDC");

                    MsgPersonalizado mensaje = new MsgPersonalizado("Restauración de clientes completada exitosamente.", "Restauración exitosa", "Informacion", null);
                    mensaje.ShowDialog();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var mensajeErrores = new StringBuilder("Error al restaurar los clientes:\n");
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
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al restaurar los clientes: {ex.Message}", "Restauración fallida", "Error", null);
                mensaje.ShowDialog();
            }
        }
    }
}
