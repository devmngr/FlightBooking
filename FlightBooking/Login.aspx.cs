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
        int customerId;

        private SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;

            ConnectToDb();

            if (LoginExists(username, password))
            {
                customerId = getCustomerId(username, password);

                if (customerId != -1)
                    Response.Redirect("Booking.aspx?customerId=" + customerId);

            }
            else
                error_lbl.Text = "Wrong Username or Password !";
        }

        private void ConnectToDb()
        {
            conn = new SqlConnection("Data Source = HELLO; Initial Catalog = FlightBooking; Integrated Security = True");
        }

        private bool LoginExists(string username, string password)
        {
            string sql = "use FlightBooking select count(*) from Login_info where username = '" + username + "' and password = '" + password + "'";
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

        protected void register_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterCustomer.aspx");
        }

        private int getCustomerId(string username, string password)
        {

            string sql = "use FlightBooking select login_id from Login_info where username = '" + username + "' and password = '" + password + "'";
            int id_login = -1;
            SqlCommand command = new SqlCommand(sql, conn);
            command.Connection.Open();
            try
            {
                id_login = (Int32)command.ExecuteScalar();
            }
            catch (SqlException e)
            {
                //Console.WriteLine(e.ToString());
            }
            command.Connection.Close();


            sql = "use FlightBooking select customer_id from Customer where login_id = '" + id_login + "'";
            int id_cust = -1;
            command = new SqlCommand(sql, conn);
            command.Connection.Open();
            try
            {
                id_cust = (Int32)command.ExecuteScalar();
            }
            catch (SqlException e)
            {
                //Console.WriteLine(e.ToString());
            }
            command.Connection.Close();



            return id_cust;
        }


    }
}