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

    public class CrearSolicitud : ICrearSolicitud
    {
        SolicitudWS.SolicitudesClient proxy = new SolicitudWS.SolicitudesClient();

        public int GenerarSolicitud(int codCliente, int codProyecto, List<SolicitudDetalle> detalleSolicitud)
        {

            try
            {
                //validar estado de cliente
                Cliente cliente = proxy.ObtenerCliente(codCliente);
                if ("ACTIVO".Equals(cliente.Estado))
                {
                    Console.WriteLine("Paso");
                    //validar estado de Proyecto
                    Proyecto proyecto = proxy.ObtenerProyecto(codProyecto);
                    if ("ACTIVO".Equals(proyecto.Estado))
                    {

                        //crear solicitud
                        Solicitud solicitudCreada = proxy.CrearSolicitud(proyecto.CodProyecto);
                        if (solicitudCreada != null)
                        {
                            //crear detalle de solicitud
                            SolicitudDetalle solicitudDetalleCreada = new SolicitudDetalle();
                            int indDetalle = 0;
                            foreach (SolicitudDetalle detalle in detalleSolicitud)
                            {
                                solicitudDetalleCreada = proxy.CrearSolicitudDetalle(detalle.Codigo, detalle.CantidadColabor,
                                        detalle.codPerfil, detalle.codTecnologia, detalle.codExperienciaRubro, detalle.Comentario);
                                if (solicitudDetalleCreada != null)
                                {
                                    indDetalle++;
                                }
                                solicitudDetalleCreada = null;
                            }
                            if (indDetalle == detalleSolicitud.Count())
                            {
                                return 1;
                            }
                        }
          
                        
                    }

                }
                return 0;
                
            }
            catch (FaultException<MyExcepcion> e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Detail.Messsage;
                exceptionDetails.Description = e.Detail.Description;
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }

        }
    }
}
