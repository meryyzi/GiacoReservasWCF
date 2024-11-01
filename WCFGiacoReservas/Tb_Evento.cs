
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
    
public partial class Tb_Evento
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tb_Evento()
    {

        this.Tb_EventoArtista = new HashSet<Tb_EventoArtista>();

        this.Tb_EventoPersonal = new HashSet<Tb_EventoPersonal>();

        this.Tb_ListaInvitados = new HashSet<Tb_ListaInvitados>();

    }


    public int evento_id { get; set; }

    public System.DateTime fecha_evento { get; set; }

    public System.TimeSpan hora_inicio { get; set; }

    public System.TimeSpan hora_finalizacion { get; set; }

    public int sala_id { get; set; }

    public Nullable<int> cliente_id { get; set; }

    public Nullable<int> tipo_id { get; set; }

    public Nullable<System.DateTime> fecha_eliminacion { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public string CreadoPor { get; set; }

    public Nullable<System.DateTime> FechaActualizacion { get; set; }

    public string ActualizadoPor { get; set; }

    public Nullable<int> estado { get; set; }

    public string nombre_evento { get; set; }



    public virtual Tb_Cliente Tb_Cliente { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_EventoArtista> Tb_EventoArtista { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_EventoPersonal> Tb_EventoPersonal { get; set; }

    public virtual Tb_Sala Tb_Sala { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tb_ListaInvitados> Tb_ListaInvitados { get; set; }

    public virtual Tb_TipoEventos Tb_TipoEventos { get; set; }

    public virtual Tb_TipoEventos Tb_TipoEventos1 { get; set; }

}

}
