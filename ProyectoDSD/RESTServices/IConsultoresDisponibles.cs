using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using RESTServices.Dominio;

namespace RESTServices
{
   [ServiceContract]
    public interface IConsultoresDisponibles
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ConsultorDisponible", ResponseFormat = WebMessageFormat.Json)]
        List<ConsultorDisponible> ListarConsultorDisponible();
    }
}