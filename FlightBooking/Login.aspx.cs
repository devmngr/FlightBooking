using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == "A" && password_txt.Text == "A")
                username_lbl.Text = "GOOD";
            else
                username_lbl.Text = "BAD";
        }
    }
}