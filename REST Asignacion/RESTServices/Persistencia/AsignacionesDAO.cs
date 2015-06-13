using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class AsignacionesDAO
    {
        public Asignacion Crear(Asignacion asignacionACrear)
        {
            Asignacion asignacionCreado = null;
            string sql = "INSERT INTO t_consultor_proyecto VALUES (@codAsignacion, @codConsultor, @codProyecto)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@codAsignacion", asignacionACrear.codAsignacion));
                    com.Parameters.Add(new SqlParameter("@codConsultor", asignacionACrear.codConsultor));
                    com.Parameters.Add(new SqlParameter("@codProyecto", asignacionACrear.codProyecto));
                    com.ExecuteNonQuery();
                }
            }
            //asignacionCreado = Obtener(asignacionACrear.Codigo);
            return asignacionCreado;
        }


        //public Asignacion Obtener(string codigo)
        //{
        //    Asignacion alumnoEncontrado = null;
        //    string sql = "SELECT * FROM t_asignacion WHERE codigo=@cod";
        //    using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
        //    {
        //        con.Open();
        //        using (SqlCommand com = new SqlCommand(sql, con))
        //        {
        //            com.Parameters.Add(new SqlParameter("@cod", codigo));
        //            using (SqlDataReader resultado = com.ExecuteReader())
        //            {
        //                if (resultado.Read())
        //                {
        //                    alumnoEncontrado = new Asignacion()
        //                    {
        //                        Codigo = (string)resultado["codigo"],
        //                        Nombre = (string)resultado["nombre"]
        //                    };
        //                }
        //            }
        //        }
        //    }
        //    return alumnoEncontrado;
        //}
    }
}