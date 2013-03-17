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
        protected void Page_Load(object sender, EventArgs e)
        {

           // string value = Request.QueryString["pid"];
            string pid=Request.QueryString["pid"];
            int pid2 = Convert.ToInt32(pid);
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
                Item item1 = new Item(pid2);
                
                cartItems.Add(item1);
                

                Session["cartItem"] = cartItems;
            }
        }
        protected void add_cart(object sender, EventArgs e)
        {
            // some logic
            Response.Redirect("item.aspx?pid=1&addcart=1");
        }
    }
}