
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
    
public partial class Usp_ConsultarDatosCliente_Result
{

    public int cliente_id { get; set; }

    public string nombre { get; set; }

    public string apellido { get; set; }

    public string correo_electronico { get; set; }

    public string direccion { get; set; }

    public string Dni { get; set; }

    public string telefono { get; set; }

    public Nullable<System.DateTime> FechaCreacion { get; set; }

    public string CreadoPor { get; set; }

    public System.DateTime FechaActualizacion { get; set; }

    public string ActualizadoPor { get; set; }

    public Nullable<int> EsEmpresa { get; set; }

    public string RazonSocial { get; set; }

    public string RUC { get; set; }

    public Nullable<int> estado { get; set; }

    public string Id_Ubigeo { get; set; }

    public string Departamento { get; set; }

    public string Provincia { get; set; }

    public string Distrito { get; set; }

}

}