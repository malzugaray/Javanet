using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    [ServiceContract]
    public interface IAsignaciones
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Asignaciones", ResponseFormat = WebMessageFormat.Json)]
        Asignacion CrearAsignacion(Asignacion consultorACrear);

        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "Asignaciones/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        //Asignacion ObtenerConsultor(string codigo);
    }
}
