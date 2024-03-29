﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    public partial class itemsmanage : System.Web.UI.Page
    {
        private string add, del, edit;
        private int add2, del2, edit2;
        protected void Page_Load(object sender, EventArgs e)
        {
            add= Request.QueryString["add"];
            add2 = Convert.ToInt32(add);
            del = Request.QueryString["del"];
            del2 = Convert.ToInt32(del);
            edit = Request.QueryString["edit"];
            edit2 = Convert.ToInt32(edit);

            if (Session["ausername"] == null)
            {
                Response.Redirect("adminlogin.aspx");
            }

        }
        protected void loadItems()
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Items ORDER BY ID ASC", con);
            Response.Write("<h3>Item Manage</h3>");
            if (Request.Form["aname"] != null)
            {
                string aname = Request.Form["aname"];
                string adesc = Request.Form["adesc"];
                string price = Request.Form["aprice"];
                int aprice = Convert.ToInt32(price);
                string apicture = Request.Form["apicture"];
                string mcat = Request.Form["amcat"];
                int amcat = Convert.ToInt32(mcat);
                string scat = Request.Form["ascat"];
                int ascat = Convert.ToInt32(scat);
                SqlCommand cmd2 = new SqlCommand("insert into Items (Name,[Desc],Price,Picture,[Main Category],[Sub Category],Views) values('" + aname + "','" + adesc + "'," + aprice + ",'" + apicture + "'," + amcat + "," + ascat + ",0)", con);
                int num2=cmd2.ExecuteNonQuery();
            }
            if (add2 == 1)
            {
                Response.Write("<form action='itemsmanage.aspx' method='post'>");
                Response.Write("<table>");
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("Name:");
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<input type='text' name='aname'/><br>");
                Response.Write("</td>");
                Response.Write("</tr>");
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("Description:<br>");
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<textarea rows='10' cols='30' name='adesc'></textarea>");
                Response.Write("</td>");
                Response.Write("</tr>");


                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("Price:");
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<input type='text' name='aprice'/>");
                Response.Write("</td>");
                Response.Write("</tr>");

                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("Picture:");
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<input type='text' name='apicture'/>");
                Response.Write("</td>");
                Response.Write("</tr>");

                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("Main Category:");
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<select name='amcat'>");
                Response.Write("<option value='1'>Computers</option>");
                Response.Write("<option value='2'>Computer Parts</option>");
                Response.Write("<option value='3'>Video Games</option>");
                Response.Write("</select>");
                Response.Write("</td>");
                Response.Write("</tr>");

                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write("Sub Category:");
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<select name='ascat'>");
                Response.Write("<option value='1'>Laptops</option>");
                Response.Write("<option value='2'>Ultrabooks</option>");
                Response.Write("<option value='3'>Servers</option>");
                Response.Write("<option value='4'>Desktops</option>");
                Response.Write("<option value='1'>Video Cards</option>");
                Response.Write("<option value='2'>Hard Drives</option>");
                Response.Write("<option value='6'>CPUs</option>");
                Response.Write("<option value='7'>Memory</option>");
                Response.Write("<option value='8'>Motherboards</option>");
                Response.Write("<option value='1'>XBOX 360</option>");
                Response.Write("<option value='2'>Playstation 3</option>");
                Response.Write("<option value='3'>Wii</option>");
                Response.Write("<option value='4'>PC</option>");
                Response.Write("</select>");
                Response.Write("</td>");
                Response.Write("</tr>");
                Response.Write("</table>");
                Response.Write("<input type='submit' value='Submit' />");
                Response.Write("</form>");
            }
            else if (del2 > 0)
            {
                SqlCommand cmd3 = new SqlCommand("delete from Items where ID="+del2, con);
                int num2=cmd3.ExecuteNonQuery();
                Response.Write("<a href='itemsmanage.aspx?add=1' class='btn btn-success'>Add New Record</a>");
                Response.Redirect("itemsmanage.aspx");
            }
            else
            {
                Response.Write("<a href='itemsmanage.aspx?add=1' class='btn btn-success'>Add New Record</a>");
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
                        Response.Write("Name");
                    Response.Write("</th>");
                    Response.Write("<th>");
                        Response.Write("Description");
                    Response.Write("</th>");
                    Response.Write("<th>");
                        Response.Write("Price");
                    Response.Write("</th>");
                    Response.Write("<th>");
                        Response.Write("Picture");
                    Response.Write("</th>");
                    Response.Write("<th>");
                        Response.Write("Main Category");
                    Response.Write("</th>");
                    Response.Write("<th>");
                        Response.Write("Sub Category");
                    Response.Write("</th>");
                    Response.Write("<th>");
                    Response.Write("Action");
                    Response.Write("</th>");
                Response.Write("<tr>");
            }
            //for (int i = 0; i < num; i++)
            while(rdr.Read())
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
                        Response.Write((decimal)rdr[3]);
                    Response.Write("</td>");
                    Response.Write("<td>");
                        Response.Write((string)rdr[4]);
                    Response.Write("</td>");
                    Response.Write("<td>");
                        Response.Write((int)rdr[5]);
                    Response.Write("</td>");
                    Response.Write("<td>");
                        Response.Write((int)rdr[6]);
                    Response.Write("</td>");
                    Response.Write("<td>");
                    int id4 = (int)rdr[0];
                    Response.Write("<a href='itemsmanage.aspx?del=" + id4 + "' class='btn btn-danger'>Delete</a>");
                    Response.Write("</td>");
                Response.Write("</tr>");
            }
            con.Close();
            Response.Write("</table>");
        }
    }
}