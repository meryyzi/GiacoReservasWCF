
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WCFGiacoReservas
{

using System;
    using System.Collections.Generic;
    
public partial class Tb_Personal
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tb_Personal()
    {

        this.Tb_EventoPersonal = new HashSet<Tb_EventoPersonal>();

    }


    public int personal_id { get; set; }

    public string nombre { get; set; }

    public string apellido { get; set; }

    public string dni { get; set; }

    public decimal costo_hora { get; set; }

    public byte[] Foto { get; set; }

    public string Telefono { get; set; }

    public string Correo { get; set; }

    public Nullable<int> Tipo { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public string CreadoPor { get; set; }

    public Nullable<System.DateTime> FechaActualizacion { get; set; }

    public string ActualizadoPor { get; set; }

    public Nullable<int> estado { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_EventoPersonal> Tb_EventoPersonal { get; set; }

}

}
