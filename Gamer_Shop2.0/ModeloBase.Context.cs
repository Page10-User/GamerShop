﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gamer_Shop2._0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProyectoTallerIIEntities1 : DbContext
    {
        public ProyectoTallerIIEntities1()
            : base("name=ProyectoTallerIIEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoría_producto> Categoría_producto { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Detalle_compra> Detalle_compra { get; set; }
        public virtual DbSet<Detalle_venta> Detalle_venta { get; set; }
        public virtual DbSet<Método_pago> Método_pago { get; set; }
        public virtual DbSet<Tipo_usuario> Tipo_usuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
    }
}
