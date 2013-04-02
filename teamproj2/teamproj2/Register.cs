using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    public class Register
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Register(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
        public void EnterIntoDB()
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Customers (Username,Password) values('" + this.Username + "','" + this.Password + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}