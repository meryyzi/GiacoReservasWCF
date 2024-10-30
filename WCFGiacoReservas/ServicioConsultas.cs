using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;

namespace WCFGiacoReservas
{
    public class ServicioConsultas : IServicioConsultas
    {
        public List<ClienteDC> ListarClienteEmpresas()
        {
            try
            {
                GiacoReservaEntities MisReservas = new GiacoReservaEntities();

                List<ClienteDC> objLista = new List<ClienteDC>();

                // Ejecutamos el procedimiento almacenado para obtener clientes que son empresas
                var consulta = MisReservas.usp_ConsultarClienteEmpresa().ToList();

                foreach (var resultado in consulta)
                {
                    ClienteDC objclienteDC = new ClienteDC();
                    objclienteDC.cliente_id = Convert.ToInt16(resultado.cliente_id);
                    objclienteDC.nombre = resultado.nombre;
                    objclienteDC.apellido = resultado.apellido;
                    objclienteDC.Dni = resultado.Dni;
                    objclienteDC.RUC = resultado.RUC;
                    objclienteDC.RazonSocial = resultado.RazonSocial;
                    objclienteDC.correo_electronico = resultado.correo_electronico;
                    objclienteDC.telefono = resultado.telefono;
                    objclienteDC.direccion = resultado.direccion;
                    objclienteDC.Id_Ubigeo = resultado.Id_Ubigeo;
                    objclienteDC.creadoPor = resultado.CreadoPor;
                    objclienteDC.estado = resultado.estado; // Mapeamos la columna 'estado'

                    // Si el RUC o la RazonSocial son nulos, asignamos valores por defecto
                    if (string.IsNullOrEmpty(objclienteDC.RUC))
                    {
                        objclienteDC.RUC = "Sin RUC";
                        objclienteDC.RazonSocial = "Sin Razon Social";
                    }

                    // Asignamos el valor de 'Estado' dependiendo del valor de 'estado'
                    if (objclienteDC.estado == 1)
                    {
                        objclienteDC.Estado = "Activo";
                    }
                    else
                    {
                        objclienteDC.Estado = "Inactivo";
                    }

                    // Añadimos el objeto a la lista
                    objLista.Add(objclienteDC);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al consultar cliente empresas: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado: {ex.Message}");
            }
        }

        public List<ClienteDC> ListarClientesPorEstado(string estado)
        {
            try
            {
                using (GiacoReservaEntities MisReservas = new GiacoReservaEntities())
                {
                    List<ClienteDC> objLista = new List<ClienteDC>();

                    // Ejecutamos el procedimiento almacenado y pasamos el parámetro 'estado'
                    var consulta = MisReservas.sp_ConsultarClientesPorEstado(estado).ToList();

                    foreach (var resultado in consulta)
                    {
                        ClienteDC objclienteDC = new ClienteDC();
                        objclienteDC.cliente_id = Convert.ToInt16(resultado.cliente_id);
                        objclienteDC.nombre = resultado.nombre;
                        objclienteDC.apellido = resultado.apellido;
                        objclienteDC.Dni = resultado.Dni;
                        objclienteDC.RUC = resultado.RUC;
                        objclienteDC.RazonSocial = resultado.RazonSocial;
                        objclienteDC.correo_electronico = resultado.correo_electronico;
                        objclienteDC.telefono = resultado.telefono;
                        objclienteDC.direccion = resultado.direccion;
                        objclienteDC.Id_Ubigeo = resultado.Id_Ubigeo;
                        objclienteDC.creadoPor = resultado.CreadoPor;
                        objclienteDC.estado = resultado.estado; 

                        if (string.IsNullOrEmpty(objclienteDC.RUC))
                        {
                            objclienteDC.RUC = "Sin RUC";
                            objclienteDC.RazonSocial = "Sin Razon Social";
                        }
                        if (objclienteDC.estado == 1)
                        {
                            objclienteDC.Estado = "Activo";
                        }
                        else
                        {
                            objclienteDC.Estado = "Inactivo";
                        }
                        objLista.Add(objclienteDC);
                    }
                    return objLista;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al consultar clientes por estado: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado: {ex.Message}");
            }
        }

        public List<EventoDC> ConsultarEventoEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (GiacoReservaEntities MisReservas = new GiacoReservaEntities())
                {
                    var consulta = MisReservas.usp_ConsultarEventoEntreFechas(fechaInicio, fechaFin).ToList();

                    List<EventoDC> objLista = new List<EventoDC>();

                    foreach (var resultado in consulta)
                    {
                        EventoDC objEventoDC = new EventoDC
                        {
                            evento_id = Convert.ToInt16(resultado.evento_id),
                            nombre_evento = resultado.nombre_evento,
                            fecha_evento = resultado.fecha_evento,
                            hora_inicio = resultado.hora_inicio,
                            hora_finalizacion = resultado.hora_finalizacion,
                            sala_id = Convert.ToInt16(resultado.sala_id),
                            cliente_id = Convert.ToInt16(resultado.cliente_id),
                            tipo_id = Convert.ToInt16(resultado.tipo_id),
                            CreadoPor = resultado.CreadoPor,
                            ActualizadoPor = resultado.ActualizadoPor,
                            FechaCreacion = resultado.FechaCreacion,
                            FechaActualizacion = resultado.FechaActualizacion,
                        };
                        objLista.Add(objEventoDC);
                    }
                    return objLista;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al consultar eventos entre fechas: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado: {ex.Message}");
            }
        }

        public List<PersonalDC> ConsultarPersonalPorTipo(string tipo)
        {
            try
            {
                using (GiacoReservaEntities MisReservas = new GiacoReservaEntities())
                {
                    // Ejecutar el procedimiento almacenado
                    var consulta = MisReservas.usp_ConsultarPersonalTipo(tipo).ToList();

                    // Crear una lista para almacenar los resultados
                    List<PersonalDC> listaPersonal = new List<PersonalDC>();

                    foreach (var resultado in consulta)
                    {
                        // Crear un nuevo objeto PersonalDC
                        PersonalDC personalDc = new PersonalDC
                        {
                            personal_id = Convert.ToInt16(resultado.personal_id),
                            nombre = resultado.nombre,
                            apellido = resultado.apellido,
                            dni = resultado.dni,
                            costo_hora = resultado.costo_hora,
                            Foto = resultado.Foto,
                            Telefono = resultado.Telefono,
                            Correo = resultado.Correo,
                            Tipo = Convert.ToInt16(resultado.Tipo),
                            FechaCreacion = resultado.FechaCreacion,
                            CreadoPor = resultado.CreadoPor,
                            FechaActualizacion = resultado.FechaActualizacion,
                            ActualizadoPor = resultado.ActualizadoPor,
                            estado = Convert.ToInt16(resultado.estado)
                        };
                        listaPersonal.Add(personalDc);
                    }
                    return listaPersonal;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al consultar personal por tipo: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado: {ex.Message}");
            }
        }


    }
}
