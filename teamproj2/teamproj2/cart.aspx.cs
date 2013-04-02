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
        int del2 = 0;
        int upd2 = 0;
        int min2 = 0;
        int main2 = 0;

        string conn = "";
        string del = "";
        string upd = "";
        string min = "";
        string main = "";

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

            main = Request.QueryString["main"];
            main2 = Convert.ToInt32(main);
        }

        protected void LoadCart()
        {
            ArrayList cartItems = (ArrayList)Session["cartItem"];
            decimal alltotal = 0;

            if (Session["cartItem"] == null)
            {
                Response.Write("No items currently on the cart!");
            }
            else if (cartItems.Count == 0)
            {
                cartItems = new ArrayList();
                Response.Write("No items currently on the cart!");
            }
            else
            {
                int numCartItems = cartItems.Count;

                decimal price = 0;
                decimal total = 0;
                int id2 = 0;
                int quant = 0;
                string name = "";
                string desc = "";
                string picture = "";
                int mm2 = 0;
                string isit = "";

                Response.Write("<table class='table'>");
                Response.Write("<tr><th>Picture</th><th>Name</th><th>Quantity</th><th>Price</th><th>Compatibility</th><th>Action</th><th>Connecting Item</th></tr>");

                for (int i = 0; i < numCartItems; i++)
                {
                    Item item = (Item)cartItems[i];

                    id2 = item.Id;
                    quant = item.Quant;
                    name = item.Name;
                    desc = item.Desc;
                    picture = item.Picture;
                    price = item.Price;
                    total = item.Total;
                    alltotal += (total * quant);

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

                    isit = "Not enough items";
                    //int m2=(int)Session["main"];


                    //isit = "Not enough items";
                    //int m3 = Convert.ToInt32(m2);
                    Compatibility c2 = new Compatibility(main2, id2);
                    isit = c2.htmlButton();
                    

                    Response.Write("<tr><td><img src='" + picture + "'width='100px'/></td><td><a href='item.aspx?pid=" + id2 + "'>" + name + "</a></td><td align='center'><input class='span3' type='text' value='" + quant + "'><a href='cart.aspx?upd=" + id2 + "' class='btn btn-success'>+</a><a href='cart.aspx?min=" + id2 + "' class='btn btn-warning'>-</a></td><td>" + String.Format("{0:C}", price) + "</td><td>" + isit + "</td><td><a href='cart.aspx?del=" + id2 + "' class='btn btn-danger'>Delete</a></td><td><a href='cart.aspx?main=" + id2 + "' class='btn btn-danger'>Select</a></td></tr>");
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

