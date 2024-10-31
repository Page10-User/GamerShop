using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups
{
    internal class BackupProductos
    {
        public static void ExportarProductosACSV()
        {
            // Construir la ruta completa a la carpeta de backups
            string rutaCarpetaBackupsProductos = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Formularios\GestionBackups\BackupsGuardados\SaveProductos"));

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpetaBackupsProductos))
            {
                Directory.CreateDirectory(rutaCarpetaBackupsProductos);
            }

            // Nombre del archivo con la fecha actual
            string nombreArchivo = $"Productos_{DateTime.Now:dd-MM-yyyy}.csv";
            string rutaArchivo = Path.Combine(rutaCarpetaBackupsProductos, nombreArchivo);

            try
            {
                // Usar el contexto de Entity Framework para obtener los productos
                using (var context = new ProyectoTallerIIEntities1())
                {
                    var productos = context.Producto.ToList();
                    ClaseValidacion validador = new ClaseValidacion(); // Crear una instancia de ClaseValidacion

                    using (StreamWriter writer = new StreamWriter(rutaArchivo, false, System.Text.Encoding.UTF8))
                    {
                        // Escribir la cabecera del CSV
                        writer.WriteLine("\"ID_Producto\";\"Serial\";\"Nombre\";\"Descripción\";\"Stock\";\"Precio\";\"ID_Categoria\";\"ID_Proveedor\";\"Estado\";\"Foto\"");

                        // Escribir cada registro de la tabla
                        foreach (var producto in productos)
                        {
                            string linea = $"\"{producto.ID_Producto}\";\"{producto.Serial}\";\"{producto.Nombre}\";\"{producto.Descripcion}\";\"{producto.Stock}\";\"{producto.Precio}\";\"{producto.Categoría_producto.ID_Categoria}\";\"{producto.Proveedor.ID_Proveedor}\";\"{producto.Activo}\";\"{producto.photoFilePath}\"";
                            writer.WriteLine(linea);
                        }
                    }
                }
                MsgPersonalizado mensaje = new MsgPersonalizado("Backup de productos completado exitosamente en SaveProductos.", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
            catch (Exception ex)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado($"Error al realizar el backup de productos: {ex.Message}", "Backup Personalizado", "Informacion", null);
                mensaje.ShowDialog();
            }
        }
        public static string ObtenerProductos()
        {
            using (var context = new ProyectoTallerIIEntities1())
            {
                var productos = context.Producto.ToList();
                StringBuilder datos = new StringBuilder();

                datos.AppendLine("\"ID_Producto\";\"Serial\";\"Nombre\";\"Descripción\";\"Stock\";\"Precio\";\"ID_Categoria\";\"ID_Proveedor\";\"Estado\";\"Foto\"");

                foreach (var producto in productos)
                {
                    datos.AppendLine($"\"{producto.ID_Producto}\";\"{producto.Serial}\";\"{producto.Nombre}\";\"{producto.Descripcion}\";" +
                                     $"\"{producto.Stock}\";\"{producto.Precio}\";\"{producto.Categoría_producto.ID_Categoria}\";" +
                                     $"\"{producto.Proveedor.ID_Proveedor}\";\"{producto.Activo}\";\"{producto.photoFilePath}\"");
                }

                return datos.ToString();
            }
        }

    }
}
