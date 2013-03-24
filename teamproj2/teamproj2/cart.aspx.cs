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
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = "data source=.\\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
        }

        protected void LoadCart()
        {
            if (Session["cartItem"] == null)
            {
                Response.Write("No items currently on the cart!");
            }
            else
            {
                ArrayList cartItems = (ArrayList)Session["cartItem"];

                int numCartItems =cartItems.Count;
                decimal alltotal = 0;
                decimal price=0;
                decimal total = 0;
                Response.Write("<table class='table'>");
                Response.Write("<tr><th>Picture</th><th>Name</th><th>Quantity</th><th>Price</th><th></th></tr>");

                for (int i = 0; i < numCartItems; i++)
                {
                    Item item=(Item)cartItems[i];
                    int id2 = item.Id;
                    int quant = item.Quant;
                    string name = item.Name;
                    string desc = item.Desc;
                    price = item.Price;
                    total = item.Total;
                    string picture = item.Picture;
                    alltotal += total;
                    Response.Write("<tr><td><img src='" + picture + "'width='100px'/></td><td><a href='item.aspx?pid=" + id2 + "'>" + name + "</a></td><td align='center'>" + quant + "</td><td>" + String.Format("{0:C}", price) + "</td></tr>");
                }
                Response.Write("<tr><td></td><td></td><td></td><td></td></tr>");
                Response.Write("</table>");
                Response.Write("<b>Total:</b> " + String.Format("{0:C}", alltotal));
                Response.Write("<br />");
                Response.Write("<br />");
                Response.Write("<a href='checkout.aspx' class='btn btn-primary'>CHECKOUT</a>");
            }
        }
    }
}