using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class ConsultorDisponible
    {
        [DataMember]
        public string Consultor { get; set; }
        [DataMember]
        public string Especialidad { get; set; }
    }
}