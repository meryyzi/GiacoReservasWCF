
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
    
public partial class usp_ConsultarEventoEntreFechas_Result
{

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

}

}