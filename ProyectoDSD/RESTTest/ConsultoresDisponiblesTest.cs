using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Messaging;

namespace RESTTest
{
    [TestClass]
    public class ConsultoresDisponiblesTest
    {
        [TestMethod]
        public void Listar()
        {
            string postdata = "{\"Consultor\":\"Marina Segovia\",\"Especialidad\":\"Analista de Sistemas\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:58823/ConsultoresDisponibles.svc/ListarConsultorDisponible");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string ConsultorDisponibleJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<ConsultorDisponible> listarConsultorDisponible = js.Deserialize<List<ConsultorDisponible>>(ConsultorDisponibleJson);
            Assert.AreEqual(1, listarConsultorDisponible.Count);
        } 
    }
}
