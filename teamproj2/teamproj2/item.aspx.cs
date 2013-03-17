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
    public partial class item : System.Web.UI.Page
    {
        Item item1;
        int pid2;
        protected void Page_Load(object sender, EventArgs e)
        {

           // string value = Request.QueryString["pid"];
            string pid=Request.QueryString["pid"];
            pid2 = Convert.ToInt32(pid);
            string addcart = Request.QueryString["addcart"];
            
            if (pid==null)
            {
                Response.Redirect("item.aspx?pid=1");
            }
            if (addcart == "1")
            {
                ArrayList cartItems = new ArrayList();

                if ((ArrayList)Session["cartItem"] != null)
                {
                    cartItems = (ArrayList)Session["cartItem"];
                }
                item1 = new Item(pid2);
                
                cartItems.Add(item1);
                

                Session["cartItem"] = cartItems;
            }
        }
        protected void add_cart(object sender, EventArgs e)
        {
            // some logic
            Response.Redirect("item.aspx?pid=1&addcart=1");
        }
        protected void displayDesc()
        {
            Item item3 = new Item(pid2);
            Response.Write(item3.Desc);
        }
        protected void displayName()
        {
            Item item3 = new Item(pid2);
            Response.Write(item3.Name);
        }
        protected void displayPrice()
        {
            Item item3 = new Item(pid2);
            Response.Write(String.Format("{0:C}", item3.Price));
        }
        protected void displayPicture()
        {
            Item item3 = new Item(pid2);
            Response.Write(item3.Picture);
        }
        protected void displayMCategory()
        {
            Item item3 = new Item(pid2);
            Response.Write(item3.MCategory2);
        }
        protected void displaySCategory()
        {
            Item item3 = new Item(pid2);
            Response.Write(item3.SCategory2);
        }
    }
}