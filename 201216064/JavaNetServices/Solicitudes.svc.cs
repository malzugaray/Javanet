using SolicitudService.Dominio;
using SolicitudService.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Diagnostics;

namespace SolicitudService
{
   
    public class Solicitudes : ISolicitudes
    {
    
        private SolicitudDAO solicitudDAO = null;
        private SolicitudDAO SolicitudDAO {
            get
                {
                    if (solicitudDAO == null)
                        solicitudDAO = new Persistencia.SolicitudDAO();
                    return solicitudDAO;
                }
         }

        private SolicitudDetalleDAO solicitudDetalleDAO = null;
        private SolicitudDetalleDAO SolicitudDetalleDAO
        {
            get
            {
                if (solicitudDetalleDAO == null)
                    solicitudDetalleDAO = new Persistencia.SolicitudDetalleDAO();
                return solicitudDetalleDAO;
            }
        }

        private ClienteDAO clienteDAO = null;
        private ClienteDAO ClienteDAO
        {

            get
            {
                if (clienteDAO == null)
                    clienteDAO = new Persistencia.ClienteDAO();
                return clienteDAO;
            }
        }

        private ProyectoDAO proyectoDAO = null;
        private ProyectoDAO ProyectoDAO
        {
        
            get
            {
                if (proyectoDAO == null)
                    proyectoDAO = new Persistencia.ProyectoDAO();
                return proyectoDAO;
            }
        }

        private PerfilDAO perfilDAO = null;
        private PerfilDAO PerfilDAO
        {
            get
            {
                if (perfilDAO == null)
                    perfilDAO = new Persistencia.PerfilDAO();
                return perfilDAO;
            }
        }

        private TecnologiaDAO tecnologiaDAO = null;
        private TecnologiaDAO TecnologiaDAO
        {
            get
            {
                if (tecnologiaDAO == null)
                    tecnologiaDAO = new Persistencia.TecnologiaDAO();
                return tecnologiaDAO;
            }
        }

        private ExperienciaDAO experienciaDAO = null;
        private ExperienciaDAO ExperienciaDAO
        {
            get
            {
                if (experienciaDAO == null)
                    experienciaDAO = new Persistencia.ExperienciaDAO();
                return experienciaDAO;
            }
        }

        public Solicitud CrearSolicitud(int codProyecto)
        {
            //Proyecto proyectoExistente = ProyectoDAO.Obtener(codProyecto);
            Debug.WriteLine("CREAR SOLICITUD - CODIGO PROYECTO : " + codProyecto);
            Console.WriteLine("CREAR SOLICITUD");
            Solicitud solicitudACrear = null;
            try{
                solicitudACrear= new Solicitud
                {
                    codProyecto = codProyecto,
                    Estado = "Activo"

                };

                Solicitud solicitudCreada = SolicitudDAO.Crear(solicitudACrear);
                return solicitudCreada;
            }
            catch (Exception e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Message;
                exceptionDetails.Description = "Error al crear la Solicitud";
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }
           
        }

        public SolicitudDetalle CrearSolicitudDetalle(int codigo, int cantidadColabor, string codPerfil, string codTecnologia, string codExperienciaRubro, string comentario)
        {
            //Perfil perfilExistente = PerfilDAO.Obtener(codPerfil);
            //Tecnologia tecnologiaExistente = TecnologiaDAO.Obtener(codTecnologia);
            //ExperienciaRubro experienciaExistente = ExperienciaDAO.Obtener(codExperienciaRubro);
            SolicitudDetalle solicitudDetalleACrear = null;
            try{
                solicitudDetalleACrear = new SolicitudDetalle()
                {
                    Codigo = codigo,
                    CantidadColabor = cantidadColabor,
                    codPerfil = codPerfil,
                    codTecnologia = codTecnologia,
                    codExperienciaRubro = codExperienciaRubro,
                    Comentario = comentario
                };
                return SolicitudDetalleDAO.Crear(solicitudDetalleACrear);

            }
            catch (Exception e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Message;
                //exceptionDetails.Description = e.StackTrace;
                exceptionDetails.Description = "Error al crear el detalle de la Solicitud";
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }
     
        }


        

        public Solicitud ObtenerSolicitud(int codigo)
        {
            try
            {
                Solicitud solicitudObtenida = new Solicitud();
                solicitudObtenida = SolicitudDAO.Obtener(codigo);
                if (solicitudObtenida != null){
                    //SolicitudDetalle solicitudDetalleObtenida = new SolicitudDetalle();

                    ICollection<SolicitudDetalle> iCollectionDetalleSolicitud = (ICollection<SolicitudDetalle>)SolicitudDAO.ObtenerDetalleSolicitud(codigo);
                    //List<SolicitudDetalle> iCollectionDetalleSolicitud = SolicitudDAO.ObtenerDetalleSolicitud(codigo);
                    Debug.WriteLine("Cantidad de Detalle Solicitud DEBUG: " + iCollectionDetalleSolicitud.Count);
                    Console.WriteLine("Cantidad de Detalle Solicitud : " + iCollectionDetalleSolicitud.Count);

                    solicitudObtenida.detalle = iCollectionDetalleSolicitud;
                }

                return solicitudObtenida;
            }
            catch (Exception e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Message;
                exceptionDetails.Description = "Error al obtener la Solicitud " + codigo;
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }
            
        }

        public Cliente ObtenerCliente(int codigo)
        {
            try
            {
                return ClienteDAO.Obtener(codigo);
                
            }
            catch (Exception e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Message;
                exceptionDetails.Description = e.StackTrace;
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }

        }

        public Proyecto ObtenerProyecto(int codigo)
        {
            try
            {
                return ProyectoDAO.Obtener(codigo);
            }
            catch (Exception e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Message;
                exceptionDetails.Description = e.StackTrace;
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }

        }


        public Solicitud ModificarSolicitud(int codigo, int codProyecto)
        {
            
            //Proyecto proyectoExistente = ProyectoDAO.Obtener(codProyecto);
            //Perfil perfilExistente = PerfilDAO.Obtener(codPerfil);
            //Tecnologia tecnologiaExistente = TecnologiaDAO.Obtener(codTecnologia);
            //ExperienciaRubro experienciaExistente = ExperienciaDAO.Obtener(codExperienciaRubro);
            Solicitud solicitudAModificar = null;
            try
            {
                solicitudAModificar = new Solicitud
                {
                    Codigo = codigo,
                    codProyecto = codProyecto

                };
                return SolicitudDAO.Modificar(solicitudAModificar);
            }
            catch (Exception e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Message;
                exceptionDetails.Description = e.StackTrace;
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }
            
           
        }

        
        public void EliminarSolicitud(int codigo)
        {
            try
            {
                Solicitud solicitudExistente = SolicitudDAO.Obtener(codigo);
                SolicitudDAO.Eliminar(solicitudExistente);
            }
            catch (Exception e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Message;
                exceptionDetails.Description = e.StackTrace;
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }

        }

        public List<Solicitud> ListarSolicitudes()
        {
            try
            {
                return SolicitudDAO.ListarTodos().ToList();
            }
            catch (Exception e)
            {
                MyExcepcion exceptionDetails = new MyExcepcion();
                exceptionDetails.Messsage = e.Message;
                exceptionDetails.Description = e.StackTrace;
                throw new FaultException<MyExcepcion>(exceptionDetails);
            }
          
        }

    }
}
 