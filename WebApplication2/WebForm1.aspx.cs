using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ServiceReference1.FlightsWebServiceSoapClient a = new ServiceReference1.FlightsWebServiceSoapClient();

            // string[][] bbb = getFlights();
            ServiceReference1.FlightsWebServiceSoapClient a = new ServiceReference1.FlightsWebServiceSoapClient();
            List<string> temp = a.getAllFlights();
            //  List<string> flights = a.getAllFlights();


            string str = "";
            for (int i = 0; i < temp.Count; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    ListBox1.Items.Add(str);
                    str = "";
                }
                str += "" + temp[i];
            }
        }


        public string[][] getFlights()
        {
            ServiceReference1.FlightsWebServiceSoapClient a = new ServiceReference1.FlightsWebServiceSoapClient();
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


    }
}