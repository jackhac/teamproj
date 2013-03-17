using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Request.Write(Request["username"]);
           // Session.Add(
        }

        protected void submit(Object sender, EventArgs e)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Customers", con);

            //
            // 4. Use the connection
            //
           
            // get query results
            SqlDataReader rdr = cmd.ExecuteReader();

            // print the CustomerID of each record
            while (rdr.Read())
            {
                if (username.Text == (string)rdr[1])
                {
                    if (password.Text == (string)rdr[2])
                    {
                        Session["username"] = username.Text;
                        Response.Redirect("default.aspx");
                    }
                    else
                    {
                        Response.Write("Bad Password!");
                        Session["username"] = null;
                    }
                }
                else
                {
                    Response.Write("Bad Username!");
                    Session["username"] = null;
                }
            }

            con.Close();
        }
    }
}