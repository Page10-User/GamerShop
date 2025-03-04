﻿using Gamer_Shop2._0.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static Gamer_Shop2._0.Datos.DProducto;

namespace Gamer_Shop2._0.Negocio
{
    internal class NProducto
    {
        DProducto dproducto = new DProducto();
        public void NAgregarProducto(int serial, string nombre, string descripcion, int stock, string activo, float precio, int categoria,string prov, string photoFilePath)
        {
            NProveedor proveedor = new NProveedor();
            int idproveedor = proveedor.GetProveedor(prov).ID_Proveedor;
            Producto nuevoProducto = new Producto()
                {
                    Serial = serial,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Stock = stock,
                    Activo = activo,
                    Precio = precio,
                    ID_Categoria = categoria,
                    ID_Proveedor = idproveedor,
                    photoFilePath = photoFilePath
                };

            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.DAgregarProducto(nuevoProducto);
            }
        }

        

        public DataTable listaProductosActivos (DataGridView grid)
        {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dproducto.getProductosActivos(grid);
            }
        }

        public void listaProductosInactivos(DataGridView grid)
        {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.getProductosInactivos(grid);
            }
        }

        public void NModificarProducto (int serialact, int serial, string nombre, string descripcion, float precio, int categoria, int proveedor, string photoFilePath, string activo)
        {
            Producto producto = new Producto()
            {
                Serial = serial,
                Nombre = nombre,
                Descripcion = descripcion, 
                Precio = precio,
                ID_Categoria = categoria,
                ID_Proveedor = proveedor,
                photoFilePath = photoFilePath,
                Activo = activo
            };
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.DModificarProducto(serialact, producto);
            }
        }

        public void actualizarStock (int id, int stock)
        {
            Producto producto = new Producto()
            {
                
                ID_Producto = id,
                Stock = stock
            };
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.DActualizarStock(producto);
            }
        }

        public Producto GetProducto(int serial) {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dproducto.getProducto(serial);
            }
        }

        public Producto GetProductoID(int id)
        {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dproducto.getProductoID(id);
            }
        }

        
        //   //----------------------------------------------------------------------------------\\
        //  //------------------------------------------------------------------------------------\\
        //  ||                  Método para obtener todos los productos activos                   ||
        //  \\------------------------------------------------------------------------------------//
        //   \\----------------------------------------------------------------------------------//
        public List<ProductoViewModel> ObtenerProductosActivos()
        {
            DProducto dproducto = new DProducto();
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dproducto.ObtenerTodosLosProductos();
            }
        }
        public ProductoViewModel GetProductoCr(int serial)
        {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                return dproducto.getProductoCr(serial);
            }
        }

        public void buscarProductoLista(DataGridView grid, string texts, string atributo)
        {
            if (dproducto == null)
            {
                throw new NullReferenceException("El objeto 'dproducto' no se pudo inicializar.");
            }
            else
            {
                dproducto.getProductosLista(grid, texts, atributo);
            }
        }
    }
}
