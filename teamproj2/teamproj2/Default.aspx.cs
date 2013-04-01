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
    public partial class Default : System.Web.UI.Page
    {
       // Item item1;
        //int pid2;
        protected void Page_Load(object sender, EventArgs e)
        {
            // string value = Request.QueryString["pid"];
            //string pid = Request.QueryString["pid"];
            //pid2 = Convert.ToInt32(pid);
            //string addcart = Request.QueryString["addcart"];
        }
        protected void displayId(int pid2)
        {
            Item item3 = new Item(pid2);
            Response.Write(item3.Id);
        }
        protected void displayName(int pid2)
        {
            Item item3 = new Item(pid2);
            Response.Write(item3.Name);
        }

        protected void displayPrice(int pid2)
        {
            Item item3 = new Item(pid2);
            Response.Write(String.Format("{0:C}", item3.Price));
        }

        protected void displayPicture(int pid2)
        {
            Item item3 = new Item(pid2);
            Response.Write(item3.Picture);
        }

    }
}
