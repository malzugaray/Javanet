using SolicitudService.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SolicitudService
{
    [ServiceContract]
    [XmlSerializerFormat(Style = OperationFormatStyle.Rpc, Use = OperationFormatUse.Encoded)]
    public interface ISolicitudes
    {

        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        Solicitud CrearSolicitud(int codProyecto);

        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        SolicitudDetalle CrearSolicitudDetalle(int codigo, int cantidadColabor, string codPerfil, string codTecnologia, string codExperienciaRubro, string comentario);

        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        Solicitud ObtenerSolicitud(int codigo);

        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        Cliente ObtenerCliente(int codigo);

        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        Proyecto ObtenerProyecto(int codigo);


        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        Solicitud ModificarSolicitud(int codigo, int codProyecto);

        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        void EliminarSolicitud(int codigo);

        [FaultContract(typeof(MyExcepcion))]
        [OperationContract]
        List<Solicitud> ListarSolicitudes();
        
    }

}
