using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServices.Dominio;
using System.Messaging;

namespace RESTServices.Mensajeria
{
    public class Mensajeria
    {
        public List<ConsultorDisponible> LeerMensajes()
        {
            List<ConsultorDisponible> car = new List<ConsultorDisponible>(); 
            string rutaColaOut = @".\private$\msegovia";
            if (!MessageQueue.Exists(rutaColaOut))
                MessageQueue.Create(rutaColaOut);
            MessageQueue colaOut = new MessageQueue(rutaColaOut);
            colaOut.Formatter = new XmlMessageFormatter(new Type[] { typeof(ConsultorDisponible) });
            int contador=colaOut.GetAllMessages().Count();    
            while (contador >0)
            {
                 Message mensajeOut = colaOut.Receive();
                 car.Add((ConsultorDisponible)mensajeOut.Body); 
                contador = contador - 1;
            }
            return car;

        }

        public string EnviarMensaje(ConsultorDisponible registra)
        {
            try
            {
                string rutaColaIn = @".\private$\msegovia";
                if (!MessageQueue.Exists(rutaColaIn))
                    MessageQueue.Create(rutaColaIn);
                MessageQueue colaIn = new MessageQueue(rutaColaIn);
                Message mensajeIn = new Message();
                mensajeIn.Label = "Consultor Disponible";
                mensajeIn.Body = registra;
                colaIn.Send(mensajeIn);
                return "OK";
            }
            catch (MessageQueueException mex)
            {
                return "Error";
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }

        public string EliminarMensaje()
        {
            try
            {
                string rutaColaIn = @".\private$\msegovia";
                if (!MessageQueue.Exists(rutaColaIn))
                    MessageQueue.Delete(rutaColaIn);
                MessageQueue colaIn = new MessageQueue(rutaColaIn);
                Message mensajeIn = new Message();
                mensajeIn.Label = "Consultor Disponible";
                mensajeIn.Body = "";
                colaIn.Send(mensajeIn);
                return "OK";
            }
            catch (MessageQueueException mex)
            {
                return "Error";
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }
    }
}