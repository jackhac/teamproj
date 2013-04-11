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
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ausername"] != null)
            {
                Response.Redirect("admin.aspx");
            }
        }
        protected void submit(Object sender, EventArgs e)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Admins", con);

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
                        Session["ausername"] = username.Text;
                        Response.Redirect("admin.aspx");
                    }
                    else
                    {
                        Response.Write("Bad Password!");
                        Session["ausername"] = null;
                    }
                }
                else
                {
                    Response.Write("Bad Username!");
                    Session["ausername"] = null;
                }
            }

            con.Close();
        }
    }
}