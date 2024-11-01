﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFGiacoReservas
{
    [ServiceContract]
    public interface IServicioConsultas
    {
        [OperationContract]
        List<ClienteDC> ListarClienteEmpresas();

        [OperationContract]
        List<ClienteDC> ListarClientesPorEstado(string estado);

        [OperationContract]
        List<EventoDC> ConsultarEventoEntreFechas(DateTime fechaInicio, DateTime fechaFin);

        [OperationContract]
        List<PersonalDC> ConsultarPersonalPorTipo(string tipo);
    }
}
