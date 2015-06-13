using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class ConsultorDisponibleDAO
    {
        public List<ConsultorDisponible> ListarConsultorDisponible()
        {
            List<ConsultorDisponible> todos = new List<ConsultorDisponible>();
            ConsultorDisponible encontrado = null;
            string sql = "select (Nombre + ' ' + Apellido) AS Consultor,Especialidad from t_consultor";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {

                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            encontrado = new ConsultorDisponible()
                            {
                                Consultor = (string)resultado["Consultor"],
                                Especialidad = (string)resultado["Especialidad"]
                            };
                            todos.Add(encontrado);
                        }
                    }

                }
            }

            Mensajeria.Mensajeria mens = new Mensajeria.Mensajeria();
            mens.EliminarMensaje();
            foreach (ConsultorDisponible cd in todos)
            {
                mens.EnviarMensaje(cd);
            }
            return todos;
        }
    }
}