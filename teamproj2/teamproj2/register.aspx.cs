using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teamproj2
{
    public partial class register : System.Web.UI.Page
    {
        bool isR = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void submit(Object sender, EventArgs e)
        {
            Register r2 = new Register(username.Text, password.Text);
            r2.EnterIntoDB();
            isR = true;
        }
        protected void isRegistered()
        {
            if (isR == true)
            {
                Response.Write("You are now Registered! <a href='login.aspx'>Login Here</a><br><br>");
            }
            else
            {
                Response.Write("Please Register below.<br><br>");
            }
        }
    }
}