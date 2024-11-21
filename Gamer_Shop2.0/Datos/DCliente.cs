using System;
using System.Linq;
using Gamer_Shop2._0.Excepciones;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;


namespace Gamer_Shop2._0.Datos
{
    internal class DCliente
    {
        DataSet1TableAdapters.ClienteTableAdapter adapter = new DataSet1TableAdapters.ClienteTableAdapter();

        public bool ExisteRegistro(Cliente Cliente)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (adapter.ExisteClientePorDNI(Cliente.DNI) > 0) return true;
                else return false;

            }
        }

        public bool ExisteRegistro(int id)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if ((context.Cliente.FirstOrDefault(p => p.ID_Cliente == id) != null)) return true;
                else return false;
            }
        }

        public bool ExisteRegistro(string dni)
        {

            if (adapter == null)
            {
                throw new NullReferenceException("El TableAdapter no fue inicializado.");
            }
            else
            {
                
            {
                if (adapter.ExisteClientePorDNI(dni) > 0) return true;
                else return false;

            }
            }
        }

        public Cliente getCliente(string dni)
        {
            if (ExisteRegistro(dni) == false)
            {
                throw new ExisteRegistroException("El Cliente no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    return context.Cliente.First(p => p.DNI == dni);
                }
            }
        }

        public Cliente getCliente(int id)
        {
            if (ExisteRegistro(id) == false)
            {
                throw new ExisteRegistroException("El Cliente no existe");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    return context.Cliente.First(p => p.ID_Cliente == id);
                }
            }
        }

        public DataTable getClientes(DataGridView grid)
        {
            if (grid == null)
            {
                throw new NullReferenceException("Error al cargar la tabla");
            }
            else
            {
                DClientes Clientes = new DClientes();
               
                return Clientes.GetClienteAll();
            }
        }

        public void DAgregarCliente(Cliente cliente)
        {
            if (ExisteRegistro(cliente))
            {
                throw new ExisteRegistroException("El número de dni de Cliente ya existe.");
            }
            else
            {
                using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
                {
                    try
                    {
                        context.Cliente.Add(cliente);
                        context.SaveChanges();
                    }
                    catch (DbUpdateException dbEx)
                    {
                        if (dbEx.InnerException?.InnerException is SqlException sqlEx && sqlEx.Number == 2627)
                        {
                            string mensajeError = sqlEx.Message;

                            if (mensajeError.Contains("UQ_TelefonoCliente"))
                            {
                                throw new ExisteRegistroException("El Teléfono ya se encuentra registrado!");
                            }
                            else if (mensajeError.Contains("UQ_CorreoCliente"))
                            {
                                throw new ExisteRegistroException("El Correo Electrónico ya se encuentra registrado!");
                            }
                            else
                            {
                                throw new ExisteRegistroException("El Dni, Teléfono o Gmail ya se encuentra registrado!");
                            }
                        }
                        throw new Exception($"Error al guardar el cliente: {dbEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al guardar el cliente: {ex.Message}");
                    }
                }
            }
        }

        public void DModificarCliente(Cliente Cliente)
        {
            using (ProyectoTallerIIEntities1 context = new ProyectoTallerIIEntities1())
            {
                if (ExisteRegistro(Cliente) == false)
                {
                    throw new ExisteRegistroException("El Cliente no existe");
                }
                else
                {
                    try
                    {
                        Cliente cli = context.Cliente.First(p => p.DNI == Cliente.DNI);

                        cli.Nombre = Cliente.Nombre;
                        cli.Apellido = Cliente.Apellido;
                        cli.Teléfono = Cliente.Teléfono;
                        cli.Correo = Cliente.Correo;


                        context.SaveChanges();
                    }
                    catch (DbUpdateException dbEx)
                    {
                        if (dbEx.InnerException?.InnerException is SqlException sqlEx && sqlEx.Number == 2627)
                        {
                            string mensajeError = sqlEx.Message;

                            if (mensajeError.Contains("UQ_TelefonoCliente"))
                            {
                                throw new ExisteRegistroException("El Teléfono ya se encuentra registrado!");
                            }
                            else if (mensajeError.Contains("UQ_CorreoCliente"))
                            {
                                throw new ExisteRegistroException("El Correo Electrónico ya se encuentra registrado!");
                            }
                            else
                            {
                                throw new ExisteRegistroException("El Dni, Teléfono o Gmail ya se encuentra registrado!");
                            }
                        }
                        throw new Exception($"Error al guardar el cliente: {dbEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al modificar el Cliente: {ex.Message}");
                    }
                }
            }
        }
    }
}