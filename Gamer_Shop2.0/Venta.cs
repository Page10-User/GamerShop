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
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.Detalle_venta = new HashSet<Detalle_venta>();
        }
    
        public int ID_Venta { get; set; }
        public System.DateTime Fecha { get; set; }
        public double Total { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Método { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_venta> Detalle_venta { get; set; }
        public virtual Método_pago Método_pago { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}