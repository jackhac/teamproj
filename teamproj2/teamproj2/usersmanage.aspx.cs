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
    public partial class usersmanage : System.Web.UI.Page
    {
        private string add, del, edit;
        private int add2, del2, edit2;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ausername"] == null)
            {
                Response.Redirect("adminlogin.aspx");
            }

            add = Request.QueryString["add"];
            add2 = Convert.ToInt32(add);
            del = Request.QueryString["del"];
            del2 = Convert.ToInt32(del);
            edit = Request.QueryString["edit"];
            edit2 = Convert.ToInt32(edit);
        }
        protected void loadUsers()
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Customers ORDER BY ID ASC", con);
            Response.Write("<h3>User Manage</h3>");
            if (Request.Form["cusername"] != null)
            {
                string ausername = Request.Form["cusername"];
                string apassword = Request.Form["cpassword"];
                //string price = Request.Form["aprice"];
                //int aprice = Convert.ToInt32(price);
                //string apicture = Request.Form["apicture"];
                //string mcat = Request.Form["amcat"];
                //int amcat = Convert.ToInt32(mcat);
                //string scat = Request.Form["ascat"];
                //int ascat = Convert.ToInt32(scat);
                SqlCommand cmd2 = new SqlCommand("insert into Customers (Username,Password) values('" + ausername + "','" + apassword + "')", con);
                cmd2.ExecuteNonQuery();
            }
            if (add2 == 1)
            {
                Response.Write("<form action='usersmanage.aspx' method='post'>");
                Response.Write("Username: <input type='text' name='cusername'/><br>");
                Response.Write("Password: <input type='password' name='cpassword'/><br>");
                // Response.Write("Price: <input type='text' name='aprice'/><br>");
                // Response.Write("Picture: <input type='text' name='apicture'/><br>");
                // Response.Write("Main Category: <input type='text' name='amcat'/><br>");
                // Response.Write("Sub Category: <input type='text' name='ascat'/><br>");
                Response.Write("<input type='submit' value='Submit' />");
                Response.Write("</form>");
            }
            else if (del2 > 0)
            {
                SqlCommand cmd3 = new SqlCommand("delete from Customers where ID=" + del2, con);
                int num2 = cmd3.ExecuteNonQuery();
                Response.Write("<a href='usersmanage.aspx?add=1' class='btn btn-success'>Add New Record</a>");
                Response.Redirect("usersmanage.aspx");
            }
            else
            {
                Response.Write("<a href='adminsmanage.aspx?add=1' class='btn btn-success'>Add New Record</a>");
            }
            
            Response.Write("<table class='table'>");
            SqlDataReader rdr = cmd.ExecuteReader();
            int num = rdr.FieldCount;
            if (num > 0)
            {
                Response.Write("<tr>");
                Response.Write("<th>");
                Response.Write("ID");
                Response.Write("</th>");
                Response.Write("<th>");
                Response.Write("Username");
                Response.Write("</th>");
                Response.Write("<th>");
                Response.Write("Password");
                Response.Write("</th>");
                Response.Write("<th>");
                Response.Write("Action");
                Response.Write("</th>");
                Response.Write("<tr>");
            }
            //for (int i = 0; i < num; i++)
            while (rdr.Read())
            {
                //rdr.Read();
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write((int)rdr[0]);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write((string)rdr[1]);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write((string)rdr[2]);
                Response.Write("</td>");
                Response.Write("<td>");
                int id4 = (int)rdr[0];
                Response.Write("<a href='usersmanage.aspx?del=" + id4 + "' class='btn btn-danger'>Delete</a>");
                Response.Write("</td>");
                Response.Write("</tr>");
            }
            con.Close();
            Response.Write("</table>");
        }
    }
}