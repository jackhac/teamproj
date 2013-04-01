using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace teamproj2
{
    
    public partial class cart : System.Web.UI.Page
    {
        int del2=0;
        int upd2 = 0;
        int min2 = 0;

        string conn = "";
        string del = "";
        string upd = "";
        string min = "";

        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);

            del = Request.QueryString["del"];
            del2 = Convert.ToInt32(del);

            upd = Request.QueryString["upd"];
            upd2 = Convert.ToInt32(upd);

            min = Request.QueryString["min"];
            min2 = Convert.ToInt32(min);
        }

        protected void LoadCart()
        {
            ArrayList cartItems = (ArrayList)Session["cartItem"];

            if (Session["cartItem"] == null)
            {
                Response.Write("No items currently on the cart!");
            }
            else if(cartItems.Count == 0)
            {
               cartItems = new ArrayList();
               Response.Write("No items currently on the cart!");
            }
            else
            {
                int numCartItems =cartItems.Count;
                decimal alltotal = 0;
                decimal price=0;
                decimal total = 0;
                int id2=0;
                int quant = 0;
                string name = "";
                string desc = "";
                string picture = "";

                Response.Write("<table class='table'>");
                Response.Write("<tr><th>Picture</th><th>Name</th><th>Quantity</th><th>Price</th><th>Compatibility</th><th>Action</th></tr>");

                for (int i = 0; i < numCartItems; i++)
                {
                    Item item=(Item)cartItems[i];

                    id2 = item.Id;
                    quant = item.Quant;
                    name = item.Name;
                    desc = item.Desc;
                    picture = item.Picture;
                    price = item.Price;
                    total = item.Total;
                    alltotal += (total*quant);

                    if (del2 == id2)
                    {
                        cartItems.Remove(item);
                        
                        Response.Redirect("cart.aspx");
                    }
                    if (upd2 == id2)
                    {
                        item.Quant += 1;

                        Response.Redirect("cart.aspx");
                    }
                    if (min2 == id2)
                    {
                        if (item.Quant > 1)
                        {
                            item.Quant -= 1;
                        } 

                        Response.Redirect("cart.aspx");
                    }

                    Response.Write("<tr><td><img src='" + picture + "'width='100px'/></td><td><a href='item.aspx?pid=" + id2 + "'>" + name + "</a></td><td align='center'><input class='span3' type='text' value='" + quant + "'><a href='cart.aspx?upd=" + id2 + "' class='btn btn-success'>+</a><a href='cart.aspx?min=" + id2 + "' class='btn btn-warning'>-</a></td><td>" + String.Format("{0:C}", price) + "</td><td>TEST</td><td><a href='cart.aspx?del=" + id2 + "' class='btn btn-danger'>Delete</a></td></tr>");
                }

                Response.Write("</table>");
                Response.Write("<b>Total:</b> " + String.Format("{0:C}", alltotal));
                Response.Write("<br />");
                Response.Write("<br />");
                Response.Write("<a href='checkout.aspx' class='btn btn-primary'>CHECKOUT</a>");
            }
        }
    }
}