using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace RESTTest
{
    [TestClass]
    public class AsignacionesTest
    {

        [TestMethod]
        public void CRUDTest()
        {
            // Prueba de creación de asignacion vía HTTP POST
            string postdata = "{\"codAsignacion\":\"2\",\"codasignacion\":\"2\",\"codProyecto\":\"1\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:3364/Asignaciones.svc/Asignaciones");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string asignacionJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Asignacion asignacionCreado = js.Deserialize<Asignacion>(asignacionJson);
            Assert.AreEqual("2", asignacionCreado.codAsignacion);
            Assert.AreEqual("2", asignacionCreado.codConsultor);
            Assert.AreEqual("1", asignacionCreado.codProyecto);

            // Prueba de obtención de asignacion vía HTTP GET
            //HttpWebRequest req2 = (HttpWebRequest)WebRequest
            //    .Create("http://localhost:3364/asignaciones.svc/asignaciones/2");
            //req2.Method = "GET";
            //HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            //StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            //string asignacionJson2 = reader2.ReadToEnd();
            //JavaScriptSerializer js2 = new JavaScriptSerializer();
            //Asignacion asignacionObtenido = js2.Deserialize<Asignacion>(asignacionJson2);
            //Assert.AreEqual("2", asignacionObtenido.Codigo);
            //Assert.AreEqual("Ana", asignacionObtenido.Nombre);

        }
    }
}
