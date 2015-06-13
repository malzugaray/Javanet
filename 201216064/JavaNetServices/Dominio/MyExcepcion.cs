using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SolicitudService.Dominio
{
    [DataContract] 
    public class MyExcepcion
    {
        [DataMember]
        public string Messsage { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}