using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace FlightBooking
{
    public partial class RegisterCustomer : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_btn_Click(object sender, EventArgs e)
        {
            string name = register_name_txt.Text;
            string username = register_username_txt.Text;
            string password = register_password_txt.Text;

            connectToDb();

        }

        private void connectToDb()
        {
            conn = new SqlConnection("Data Source = HELLO; Initial Catalog = FlightBooking; Integrated Security = True");
            conn.Open();
        }

     /*   private bool registerCustomer(string name, string username, string password)
        {
            int id = createLogin(username, password);
            string sql = "insert into customer (name, login_id) values ("+ name +","+ id +")";

        }

        private int creteLogin(string username, string password)
        {
            string sql = "insert into login_info (username, password) values (" + username + "," + password + ")";


            sql = "select login_id from login_info where username = " + username;

        }

        private bool loginExists(string username)
        {
            string sql = "select cont(*) from login_info where username = " + username;


        }*/
        private bool customerExists(string name)
        {
            string sql = "select count(*) from customer where customer = " + name;
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            
        }

    




    }
}