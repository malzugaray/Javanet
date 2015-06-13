using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SolicitudService.Dominio
{
    [DataContract]
    public class SolicitudDetalle
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
      
        public int CantidadColabor { get; set; }
        [DataMember]
        public string codPerfil { get; set; }
        [DataMember]
        public string codTecnologia { get; set; }
        [DataMember]
        public string codExperienciaRubro { get; set; }
        [DataMember]
        public string Comentario { get; set; }
    }
}