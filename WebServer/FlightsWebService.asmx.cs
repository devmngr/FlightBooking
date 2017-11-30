using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServer
{
    /// <summary>
    /// Summary description for FlightsWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FlightsWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public string[][] getFlights()
        {
            Flights flights = new Flights();
            string[][] arr = flights.getAllFlights();
            return arr;
        }

        [WebMethod]
        public string[] getAllFlights()
        {
            Flights flights = new Flights();
            string[] arr = flights.getFlights();
            // List<string> list = arr.ToList<String>();



            return arr;
        }
    }
}
