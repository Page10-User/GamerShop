
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
    
public partial class Proveedor
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Proveedor()
    {

        this.Compra = new HashSet<Compra>();

        this.Producto = new HashSet<Producto>();

    }


    public int ID_Proveedor { get; set; }

    public string Razon_social { get; set; }

    public string Nombre_representante { get; set; }

    public string Telefono { get; set; }

    public string Correo { get; set; }

    public string Dirección { get; set; }

    public string Activo { get; set; }

    public int ID_CategoriaProducto { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Compra> Compra { get; set; }

    public virtual Categoría_producto Categoría_producto { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Producto> Producto { get; set; }

}

}
