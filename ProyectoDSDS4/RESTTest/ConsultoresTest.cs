using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace RESTTest
{

    [TestClass]
    public class ConsultoresTest
    {

        [TestMethod]
        public void CRUDTest()

        {
            
            //Prueba de creación de consultor via HTTP POST
            string postdata = "{\"Codigo\":\"1\",\"Nombre\":\"Juan\",\"Apellido\":\"Gordillo\",\"Especialidad\":\"RRHH\",\"Categoria\":\"Junior\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:58823/Consultores.svc/Consultores");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string consultorjson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Consultor consultorCreado = js.Deserialize<Consultor>(consultorjson);
                Assert.AreEqual("1", consultorCreado.Codigo);
                Assert.AreEqual("Juan", consultorCreado.Nombre);
                Assert.AreEqual("Gordillo", consultorCreado.Apellido);
                Assert.AreEqual("RRHH", consultorCreado.Especialidad);
                Assert.AreEqual("Junior", consultorCreado.Categoria);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                Assert.AreEqual("Agregar Consultor ERROR!", mensaje);
            }
            
            //Prueba obtencion de Consultor HTTP GET.
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:58823/Consultores.svc/Consultores/1");
            req2.Method = "GET";
            HttpWebResponse res2 = null;

            try
            {
                res2 = (HttpWebResponse)req2.GetResponse();
                StreamReader reader2 = new StreamReader(res2.GetResponseStream());
                string consultorJson2 = reader2.ReadToEnd();
                JavaScriptSerializer js2 = new JavaScriptSerializer();
                Consultor consultorObtenido = js2.Deserialize<Consultor>(consultorJson2);
                Assert.AreEqual("1", consultorObtenido.Codigo);
                Assert.AreEqual("Juan", consultorObtenido.Nombre);
                Assert.AreEqual("Gordillo", consultorObtenido.Apellido);
                Assert.AreEqual("RRHH", consultorObtenido.Especialidad);
                Assert.AreEqual("Junior", consultorObtenido.Categoria);
            }
            catch (WebException e)
            {
               HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js2 = new JavaScriptSerializer();
                string mensaje = js2.Deserialize<string>(error);
                Assert.AreEqual("Obtener Consultor ERROR!", mensaje); 
            }
            
            
            //Prueba de modificacion de consultor via HTTP PUT
            string postdata3 = "{\"Nombre\":\"Jorge\",\"Apellido\":\"Gordillo\",\"Especialidad\":\"Visual\",\"Categoria\":\"Junior\",\"Codigo\":\"1\"}"; //JSON
            byte[] data3 = Encoding.UTF8.GetBytes(postdata3);

            HttpWebRequest req3 = (HttpWebRequest)WebRequest.Create("http://localhost:58823/Consultores.svc/Consultores");
            req3.Method = "PUT";
            req3.ContentLength = data3.Length;
            req3.ContentType = "application/json";
            var reqStream3 = req3.GetRequestStream();
            reqStream3.Write(data3, 0, data3.Length);
            HttpWebResponse res3 = null;
            try
            {
                res3 = (HttpWebResponse)req3.GetResponse();
                StreamReader reader = new StreamReader(res3.GetResponseStream());
                string consultorjson = reader.ReadToEnd();
                JavaScriptSerializer js3 = new JavaScriptSerializer();
                Consultor consultorModificado = js3.Deserialize<Consultor>(consultorjson);
                Assert.AreEqual("Jorge", consultorModificado.Nombre);
                Assert.AreEqual("Gordillo", consultorModificado.Apellido);
                Assert.AreEqual("Visual", consultorModificado.Especialidad);
                Assert.AreEqual("Junior", consultorModificado.Categoria);

            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js3 = new JavaScriptSerializer();
                string mensaje = js3.Deserialize<string>(error);
                Assert.AreEqual("Modificar Consultor ERROR!", mensaje);
            }
          
             

            //Prueba de Eliminacion de consultor via HTTP DELETE

            string postdata4 = "{\"Codigo\":\"1\"}"; //Json
            byte[] data4 = Encoding.UTF8.GetBytes(postdata4);
            HttpWebRequest req4 = (HttpWebRequest)WebRequest.Create("http://localhost:58823/Consultores.svc/Consultores/1");
            req4.Method = "DELETE";
            req4.ContentLength = data4.Length;
            req4.ContentType = "application/json";

            var reqStream4 = req4.GetRequestStream();
            reqStream4.Write(data4, 0, data4.Length);
            var res4 = (HttpWebResponse)req4.GetResponse();
            StreamReader reader4 = new StreamReader(res4.GetResponseStream());
            string tareaJson4 = reader4.ReadToEnd();
            JavaScriptSerializer js4 = new JavaScriptSerializer();
            Consultor consultorEliminado = js4.Deserialize<Consultor>(tareaJson4);

            HttpWebRequest req5 = (HttpWebRequest)WebRequest.Create("http://localhost:58823/Consultores.svc/Consultores/1");
            req5.Method = "GET";
            HttpWebResponse res5 = (HttpWebResponse)req5.GetResponse();
            StreamReader reader5 = new StreamReader(res5.GetResponseStream());
            string tareaJson5 = reader5.ReadToEnd();
            JavaScriptSerializer js5 = new JavaScriptSerializer();
            Consultor consultorObtenido5 = js5.Deserialize<Consultor>(tareaJson5);
            Assert.IsNull(consultorObtenido5);
            /*
           
         
         
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:58823/Consultores.svc/Consultores");
            req.Method = "POST";
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string consultorjson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Consultor consultorCreado = js.Deserialize<Consultor>(consultorjson);
                Assert.AreEqual("1", consultorCreado.Codigo);
                Assert.AreEqual("Juan", consultorCreado.Nombre);
                Assert.AreEqual("Gordillo", consultorCreado.Apellido);
                Assert.AreEqual("RRHH", consultorCreado.Especialidad);
                Assert.AreEqual("Junior", consultorCreado.Categoria);
            }
         
             */

            //Prueba de listar tareas via HTTP GET
            HttpWebRequest req6 = (HttpWebRequest)WebRequest.Create("http://localhost:58823/Consultores.svc/Consultores");
            req6.Method = "GET";
            HttpWebResponse res6 = (HttpWebResponse)req6.GetResponse();
            StreamReader reader6 = new StreamReader(res6.GetResponseStream());
            string tareaJson6 = reader6.ReadToEnd();
            JavaScriptSerializer js6 = new JavaScriptSerializer();
            List<Consultor> consultorObtenido6 = js6.Deserialize<List<Consultor>>(tareaJson6);
            Assert.AreEqual(2, consultorObtenido6.Count);
            
        }
    }
}
