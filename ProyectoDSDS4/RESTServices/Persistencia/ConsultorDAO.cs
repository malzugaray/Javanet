using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class ConsultorDAO
    {
        public Consultor Crear(Consultor consultorACrear)
        {
            Consultor consultorCreado = null;
            string sql = "INSERT INTO t_empleado VALUES (@cod, @nom, @ape, @esp, @cat)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", consultorACrear.Codigo));
                    com.Parameters.Add(new SqlParameter("@nom", consultorACrear.Nombre));
                    com.Parameters.Add(new SqlParameter("@ape", consultorACrear.Apellido));
                    com.Parameters.Add(new SqlParameter("@esp", consultorACrear.Especialidad));
                    com.Parameters.Add(new SqlParameter("@cat", consultorACrear.Categoria));
                    com.ExecuteNonQuery();
                }
            }
            consultorCreado = Obtener(consultorACrear.Codigo);
            return consultorCreado;
        }

        public Consultor Obtener(string codigo)
        {
            Consultor consultorEncontrado = null;
            string sql = "SELECT * FROM t_empleado WHERE codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            consultorEncontrado = new Consultor()
                            {
                                Codigo = (string)resultado["codigo"],
                                Nombre = (string)resultado["nombre"],
                                Apellido=(string)resultado["apellido"],
                                Especialidad=(string)resultado["especialidad"],
                                Categoria=(string)resultado["categoria"]
                            };
                        }
                    }
                }
            }
            return consultorEncontrado;

        }
        public Consultor Modificar(Consultor consultorAModificar)
        {
            Consultor consultorModificado = null;
            string sql = "UPDATE t_empleado SET Nombre=@nom, Apellido=@ape, Especialidad=@esp, Categoria=@cat WHERE Codigo = @cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                   
                    com.Parameters.Add(new SqlParameter("@nom", consultorAModificar.Nombre));
                    com.Parameters.Add(new SqlParameter("@ape", consultorAModificar.Apellido));
                    com.Parameters.Add(new SqlParameter("@esp", consultorAModificar.Especialidad));
                    com.Parameters.Add(new SqlParameter("@cat", consultorAModificar.Categoria));
                    com.Parameters.Add(new SqlParameter("@cod", consultorAModificar.Codigo));
                    com.ExecuteNonQuery();
                }
            }
            consultorModificado = Obtener(consultorAModificar.Codigo);
            return consultorModificado;
        }

        public  void  Eliminar(string codigo)
        {

            
            string sql = "DELETE FROM t_empleado WHERE Codigo = @cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    com.ExecuteNonQuery();
                       }
            }
            
            
        }

        public List<Consultor> ListarTodosConsultores()
        {
            List<Consultor> consultores = new List<Consultor>();
            Consultor consultorEncontrado = null;
            string sql = "SELECT * FROM t_empleado";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            consultorEncontrado = new Consultor()
                            {
                                Codigo = (string)resultado["codigo"],
                                Nombre = (string)resultado["nombre"],
                                Apellido = (string)resultado["apellido"],
                                Especialidad = (string)resultado["especialidad"],
                                Categoria = (string)resultado["categoria"]
                            };
                            consultores.Add(consultorEncontrado);
                        }
                    }
                }
            }
            return consultores;
        }

    }
}