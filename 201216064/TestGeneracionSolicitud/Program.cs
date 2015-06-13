using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGeneracionSolicitud.ServiceReference1;

namespace TestGeneracionSolicitud
{
    class Program
    {
        static void Main(string[] args)
        {

             //1.Instanciar el artefacto o componente a probar
            ServiceReference1.CrearSolicitudClient proxy = new ServiceReference1.CrearSolicitudClient();

            //2.Invocar el metodo (la funcionalidad (operacion)) que se requiere probar
            int codCliente = 100;
            int codProyecto = 200;
            ICollection<SolicitudDetalle> listaDetalle = new List<SolicitudDetalle>();
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

           
        
        }
    }
}
