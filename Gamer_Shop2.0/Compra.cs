
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
    
public partial class Compra
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Compra()
    {

        this.Detalle_compra = new HashSet<Detalle_compra>();

    }


    public int ID_Compra { get; set; }

    public System.DateTime Fecha { get; set; }

    public double Total { get; set; }

    public int ID_Proveedor { get; set; }

    public int ID_Usuario { get; set; }



    public virtual Proveedor Proveedor { get; set; }

    public virtual Usuario Usuario { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Detalle_compra> Detalle_compra { get; set; }

}

}
