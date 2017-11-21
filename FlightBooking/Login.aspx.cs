using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace FlightBooking
{
    public partial class Login : System.Web.UI.Page
    {
        private SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;

            ConnectToDb();

            if (LoginExists(username,password))
                username_lbl.Text = "GOOD";
            else
                username_lbl.Text = "BAD";
        }

        private void ConnectToDb()
        {
            conn = new SqlConnection("Data Source = HELLO; Initial Catalog = FlightBooking; Integrated Security = True");
        }

        private bool LoginExists(string username, string password)
        {
            string sql = "use FlightBooking select count(*) from Login_info where username = '"+ username + "' and password = '"+password+"'" ;
            SqlCommand command = new SqlCommand(sql, conn);
            command.Connection.Open();
            int count = 0;

            try
            {
                count = (Int32)command.ExecuteScalar();
            }
            catch (SqlException e)
            {
                //Console.WriteLine(e.ToString());
            }
            command.Connection.Close();
            return count == 1;
        }
    }
}