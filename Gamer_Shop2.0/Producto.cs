//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int Serial { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Producto { get; set; }
    
        public virtual Categoría_producto Categoría_producto { get; set; }
    }
}
