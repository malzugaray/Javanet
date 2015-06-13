using GenerarSolicitud.SolicitudWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GenerarSolicitud
{
    [ServiceContract]
    public interface ICrearSolicitud
    {
        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        int GenerarSolicitud(int codCliente, int codProyecto, List<SolicitudDetalle> detalleSolicitud);
    }
}
