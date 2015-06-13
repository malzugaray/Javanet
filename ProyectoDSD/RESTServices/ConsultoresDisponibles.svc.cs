using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;

namespace RESTServices
{
    public class ConsultoresDisponibles : IConsultoresDisponibles
    {
        private ConsultorDisponibleDAO dao = new ConsultorDisponibleDAO();
        public List<ConsultorDisponible> ListarConsultorDisponible()
        {
            return dao.ListarConsultorDisponible();
        }
    }
}
