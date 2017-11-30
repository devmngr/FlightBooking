using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace FlightBooking
{
    public partial class FlightBooking : System.Web.UI.Page
    {
        private string departure, destination;
        private bool oneWay;
        private DateTime departureDate, arrivalDate;

        protected void search_flight_btn_Click(object sender, EventArgs e)
        {
            departure = departure_txt.Text;
            destination = destination_txt.Text;
            oneWay = one_way_ceckbox.Checked;
            departureDate = departure_calendar.SelectedDate;
            arrivalDate = arrival_calendar.SelectedDate;


            ServiceReference.FlightsWebServiceSoapClient a = new FlightsWebService.FlightsWebServiceSoapClient();


            string[] arr = a.getOneFlight();



            //TextBox1.Text = strResponse;

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
    }



}