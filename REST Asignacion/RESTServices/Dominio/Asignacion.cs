using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Asignacion
    {
        [DataMember]
        public int codAsignacion { get; set; }
        [DataMember]
        public int codConsultor { get; set; }
        [DataMember]
        public int codProyecto { get; set; }
    }
}