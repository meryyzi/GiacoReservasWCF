
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
    
public partial class Tb_Invitados
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tb_Invitados()
    {

        this.Tb_ListaInvitados = new HashSet<Tb_ListaInvitados>();

    }


    public int Invitado_id { get; set; }

    public string nombre { get; set; }

    public string apellido { get; set; }

    public string dni { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_ListaInvitados> Tb_ListaInvitados { get; set; }

}

}