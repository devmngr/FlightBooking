using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking
{
    public partial class Booking : System.Web.UI.Page
    {
        SqlConnection conn;
        int customerId = 11;
        protected void Page_Load(object sender, EventArgs e)
        {
            // customerId = Request.QueryString["customerId"];

            string s = Request.QueryString["customerId"];
            customerId = Int32.Parse(s);
            loadFlights();



        }

        protected void book_flight_btn_Click(object sender, EventArgs e)
        {
            bookFlight();
            info_lbl.Text = "Flight booked successfully !";
        }

        private string[][] getFlights()
        {
            WebServerReference.FlightsWebServiceSoapClient a = new WebServerReference.FlightsWebServiceSoapClient();
            List<string> temp = a.getAllFlights();
            string[][] arr = new string[temp.Count / 5][];
            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i][j] = temp.ElementAt(i);
                }
            }
            return arr;

        }
        private void loadFlights()
        {
            WebServerReference.FlightsWebServiceSoapClient a = new WebServerReference.FlightsWebServiceSoapClient();
            List<string> temp = a.getAllFlights();

            string str = "";
            for (int i = 0; i < temp.Count; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    flights_list_box.Items.Add(str);
                    str = "";
                }
                str += "\t" + temp[i];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }


        private void bookFlight()
        {

            string str = flights_list_box.SelectedItem.ToString();

            string[] temp = str.Split();

            string departure = temp[1];
            string destination = temp[2];
            string tripType = temp[3];
            DateTime departureDate = Convert.ToDateTime(temp[4]);
            DateTime arrivalDate = Convert.ToDateTime(temp[5]);

            ConnectToDb();
            string sql = "use FlightBooking insert into Confirmation values ( next value for sqKey,'" + departure + "','" + destination + "','" + tripType + "','" + departureDate + "','" + arrivalDate + "'," + customerId + ")";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

        }
        private void ConnectToDb()
        {
            conn = new SqlConnection("Data Source = HELLO; Initial Catalog = FlightBooking; Integrated Security = True");
        }


    }
}