using RESTServices.Dominio;
using RESTServices.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTServices
{
    public class Asignaciones : IAsignaciones
    {
        private AsignacionesDAO dao = new AsignacionesDAO();

        public Asignacion CrearAsignacion(Asignacion asignacionACrear)
        {
            return dao.Crear(asignacionACrear);
        }

        //public Asignacion Obtenerasignacion(string codigo)
        //{
        //    return dao.Obtener(codigo);
        //}
    }
}
