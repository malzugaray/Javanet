using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SolicitudService.Dominio
{
    [DataContract]
    public class Solicitud
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public int codProyecto { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public List<SolicitudDetalle> detalle { get; set; }
      
    }
}