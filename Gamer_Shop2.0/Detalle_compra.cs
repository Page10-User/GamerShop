
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
    
    public partial class Detalle_compra
    {
        public double Subtotal { get; set; }
        public int Cantidad { get; set; }
        public double Precio_actual { get; set; }
        public int ID_Producto { get; set; }
        public int ID_Compra { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
