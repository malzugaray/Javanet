using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOAPServicesTest.GeneracionSolicitudWS;
using System.Collections.Generic;

namespace SOAPServicesTest
{
    [TestClass]
    public class UnitTest_Solicitudes
    {
       [TestMethod]
        public void T1_Crear()
        {
            //1.Instanciar el artefacto o componente a probar
            GeneracionSolicitudWS.CrearSolicitudClient proxy = new GeneracionSolicitudWS.CrearSolicitudClient();

            //2.Invocar el metodo (la funcionalidad (operacion)) que se requiere probar
            int codCliente = 100;
            int codProyecto = 200;
            List<SolicitudDetalle> listaDetalle = new List<SolicitudDetalle>();
            SolicitudDetalle detalleSolicitud_1 = new SolicitudDetalle()
                {
                    Codigo = 200,
                    CantidadColabor = 2,
                    codPerfil = "Senior",
                    codTecnologia = "Java",
                    codExperienciaRubro = "Financiero",
                    Comentario = "comentario"
                };
            listaDetalle.Add(detalleSolicitud_1);

            SolicitudDetalle detalleSolicitud_2 = new SolicitudDetalle()
            {
                Codigo = 200,
                CantidadColabor = 1,
                codPerfil = "Junior",
                codTecnologia = "Java",
                codExperienciaRubro = "Financiero",
                Comentario = "comentario 2"
            };
            listaDetalle.Add(detalleSolicitud_2);
      

            int resultado = proxy.GenerarSolicitud(codCliente, codProyecto, listaDetalle);

            //3.Verificar/validar los resultados
            Assert.AreEqual(1, resultado);
        }

       /* [TestMethod]
        public void T1_Modificar()
        {
            //1.Instanciar el artefacto o componente a probar
            SolicitudesWS.SolicitudesClient proxy = new SolicitudesWS.SolicitudesClient();

            //2.Invocar el metodo (la funcionalidad (operacion)) que se requiere probar
            Solicitud solicitud = proxy.ModificarSolicitud(7,1,3,1,1,1,"comentario de ejemplo actualizado");
            string mensaje = "";
            if (solicitud != null)
            {
                if (solicitud.Codigo == 7)
                {
                    if (solicitud.Proyecto.CodProyecto==1)
                    {
                        if (solicitud.CantidadColabor==3)
                        {
                            if (solicitud.Perfil.CodPerfil == 1)
                               {
                                    if (solicitud.Tecnologia.CodTecnologia == 1)
                                    {
                                        if (solicitud.CodExperienciaRubro == 1)
                                        {
                                           if (solicitud.Comentario.Equals("comentario de ejemplo actualizado"))
                                            {
                                                mensaje = "modificacion con exito";
                                            }
                                        }
                                    }
                                }
                           }
                     }
                }
                
            }
              
            //3.Verificar/validar los resultados
            Assert.AreEqual("modificacion con exito", mensaje);
        }

        [TestMethod]
        public void T1_Eliminar()
        {
            //1.Instanciar el artefacto o componente a probar
            SolicitudesWS.SolicitudesClient proxy = new SolicitudesWS.SolicitudesClient();

            //2.Invocar el metodo (la funcionalidad (operacion)) que se requiere probar
            proxy.EliminarSolicitud(7);

            Solicitud solicitudEliminada = proxy.ObtenerSolicitud(7);
            string mensaje = "";
            if (solicitudEliminada == null)
            {
                mensaje = "eliminacion con exito";
            }
            //3.Verificar/validar los resultados
            Assert.AreEqual("eliminacion con exito", mensaje);
        }*/
    }
}
