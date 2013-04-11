using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teamproj2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        string usertxt;
        string lr;
        string al;
        protected void Page_Load(object sender, EventArgs e)
        {
            int state=getState();
            if (state == 1)
            {
                usertxt = (string)Session["ausername"]+" [Admin]";
                lr = "<a href='cart.aspx'>Shopping Cart</a>&nbsp;&nbsp;   <a href='admin.aspx'>Admin</a>&nbsp;&nbsp;<a href='adminlogout.aspx'>Admin Logout</a>&nbsp;&nbsp;<br></p>";
                
            }
            else if (state == 2)
            {
                usertxt = (string)Session["username"]+" [User]";
                lr = "<a href='cart.aspx'>Shopping Cart</a>&nbsp;&nbsp;<a href='adminlogin.aspx'>Admin Login</a>&nbsp;&nbsp;   <a href='logout.aspx'>Logout</a>&nbsp;&nbsp;</p>";
            }
            else
            {
                usertxt = "Guest";
                lr = "<a href='cart.aspx'>Shopping Cart</a>&nbsp;&nbsp;   <a href='adminlogin.aspx'>Admin Login</a>&nbsp;&nbsp;<a href='login.aspx'>Login</a>&nbsp;&nbsp; <a href='register.aspx'>Register</a></p>";
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Page.Header.DataBind();
        }
        protected int getState()
        {
            //return 0;
            if (Session["ausername"] != null)
            {
                return 1;
            }
            else if (Session["username"] != null)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        protected string getUser()
        {
            return usertxt;
        }

        protected string getLR()
        {
            return lr;
        }
    }
}