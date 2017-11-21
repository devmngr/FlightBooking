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
    public partial class RegisterCustomer : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e){
        }

        protected void register_btn_Click(object sender, EventArgs e)
        {
            string name = register_name_txt.Text;
            string username = register_username_txt.Text;
            string password = register_password_txt.Text;
            ConnectToDb();
            if(String.IsNullOrEmpty(name.Trim()) || String.IsNullOrEmpty(username.Trim()) || String.IsNullOrEmpty(password.Trim())){
                error_lbl.Text = "All fields are mandatory !";
            }
            else if (CustomerExists(name)){
                error_lbl.Text = "Customer already exists !";
            }

            else if (LoginExists(username)){
                error_lbl.Text = "Username already exists !";
            }
            else{
                AddCustomer(name, username, password);
                error_lbl.Text = "User successfully registered !";
            }
        }
        private void ConnectToDb(){
            conn = new SqlConnection("Data Source = HELLO; Initial Catalog = FlightBooking; Integrated Security = True");
        }
        private bool AddCustomer(string name, string username, string password)
        {
            int id = CreateLogin(username, password);
            string sql = "use FlightBooking insert into customer values ( next value for sqKey,'" + name + "'," + id + ")";
           SqlCommand command = new SqlCommand(sql, conn);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            return true;
        }
        private int CreateLogin(string username, string password)
        {
            string sql = "USE FlightBooking  insert into Login_info (login_id,username, password) values ( next value for sqKey,'" + username + "','" + password + "') ";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Connection.Open();
            command.ExecuteNonQuery();
            sql = " use FlightBooking SELECT current_value FROM sys.sequences WHERE name = 'sqKey'";
            command = new SqlCommand(sql, conn);
            int key = (Int32)command.ExecuteScalar();
            command.Connection.Close();
            return key;
        }
        private bool LoginExists(string username)
        {
            string sql = "use FlightBooking select count(*) from login_info where username = '" + username + "'";
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
            return count != 0;
        }
        private bool CustomerExists(string name)
        {
            string sql = "use FlightBooking select count(*) from customer where name = '" + name + "'";
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
            return count != 0;
        }
    }
}